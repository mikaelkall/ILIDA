using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mono;
using Mono.Cecil;
using Mono.Cecil.Cil;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.Ast;
using ICSharpCode.NRefactory;
using System.Reflection;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Collections;
using HexEdit;

namespace ILIDA
{
    public partial class Form_MainWindow : Form
    {
        /* Placeholder for filename */
        public string selectedFilename = null;
        public Mono.Cecil.AssemblyDefinition LoadAssembly { get; set; }
        public bool status = false;

        /* Hexedit window */
        private HexEdit.HexEditBox m_edtHex;
        //private HexEdit.LinkedBox m_edtASCII;

        public Form_MainWindow()
        {
            InitializeComponent();
            tabControl_DefinitionWindow.SelectedIndexChanged += new EventHandler(tabControl_DefinitionWindow_SelectedIndexChanged);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_DefinitionWindow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedFilename != null)
            {
                /* If hex tab is selected */
                if (tabControl_DefinitionWindow.SelectedIndex == 2)
                {
                    try
                    {
                        byte[] m_abyData = System.IO.File.ReadAllBytes(selectedFilename);
                        m_edtHex.InitializeComponent();
                        //m_edtASCII.InitializeComponent();
                        //m_edtHex.LinkDisplay(m_edtASCII);
                        m_edtHex.LoadData(m_abyData);
                    }
                    catch
                    {
                        return;
                    }

                }
            }
        }

        /// <summary>
        /// Opens a file for the application to work width. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openAsm = new OpenFileDialog();
            openAsm.Filter = "Executable | *.exe";
            if (openAsm.ShowDialog() == DialogResult.OK)
            {
                selectedFilename = openAsm.FileName.ToString();
                LoadAsmOrigin();
                if (status == false)
                {
                    LoadAsmContents();
                }
            }
        }

        /// <summary>
        ///  Load assemblyname
        /// </summary>
        private void LoadAsmOrigin()
        {
            try
            {
                LoadAssembly = AssemblyDefinition.ReadAssembly(selectedFilename);

                richTextBox_AssemblyInfo.Clear();

                richTextBox_AssemblyInfo.AppendText(Environment.NewLine);
                richTextBox_AssemblyInfo.AppendText(Environment.NewLine);
                richTextBox_AssemblyInfo.AppendText("[Name]::" + LoadAssembly.MainModule.Name.ToString() + Environment.NewLine);
                richTextBox_AssemblyInfo.AppendText("[CLR Runtime]::" + LoadAssembly.MainModule.Runtime.ToString() + Environment.NewLine);
                richTextBox_AssemblyInfo.AppendText("[Full Name]::" + LoadAssembly.MainModule.FullyQualifiedName.ToString() + Environment.NewLine);
                richTextBox_AssemblyInfo.AppendText("[Metadata Token]::" + LoadAssembly.MainModule.MetadataToken.ToString() + Environment.NewLine);
                richTextBox_AssemblyInfo.AppendText("[Architecture]::" + LoadAssembly.MainModule.Architecture.ToString() + Environment.NewLine);
                richTextBox_AssemblyInfo.AppendText("[EntryPoint]::" + LoadAssembly.MainModule.EntryPoint.ToString() + Environment.NewLine);
                richTextBox_AssemblyInfo.AppendText("[Mvid]::" + LoadAssembly.MainModule.Mvid.ToString() + Environment.NewLine);
            }
            catch
            {
                //ResetData();
                MessageBox.Show("Couldn't Read Assembly, it is either Unmanaged or obfuscated");
                status = true;
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadAsmContents()
        {
            this.treeview_Definitions.Nodes.Clear();
            LoadAssembly = AssemblyDefinition.ReadAssembly(selectedFilename);
            TreeNode tn = null;
            IEnumerator enumerator = LoadAssembly.MainModule.Types.GetEnumerator();
            while (enumerator.MoveNext())
            {
                TypeDefinition td = (TypeDefinition)enumerator.Current;

                tn = this.treeview_Definitions.Nodes.Add(td.Name.ToString());
                IEnumerator enumerator2 = td.Methods.GetEnumerator();
                while (enumerator2.MoveNext())
                {
                    MethodDefinition method_definition = (MethodDefinition)enumerator2.Current;
                    if (method_definition.IsConstructor)
                    {
                        tn.Nodes.Add(method_definition.Name.ToString());
                    }
                    tn.Nodes.Add(method_definition.Name.ToString());
                }
            }
        }

        /// <summary>
        ///  Populate CsharpCode
        /// </summary>
        private void populateCsharpCode()
        {
            var assembly = AssemblyDefinition.ReadAssembly(selectedFilename);
            IEnumerator enumerator = assembly.MainModule.Types.GetEnumerator();

            while (enumerator.MoveNext())
            {
                TypeDefinition td = (TypeDefinition)enumerator.Current;
                IEnumerator enumerator2 = td.Methods.GetEnumerator();
                while (enumerator2.MoveNext())
                {
                    MethodDefinition method_definition = (MethodDefinition)enumerator2.Current;
                    AstBuilder ast_Builder = null;

                    foreach (var typeInAssembly in assembly.MainModule.Types)
                    {
                        ast_Builder = new AstBuilder(new ICSharpCode.Decompiler.DecompilerContext(assembly.MainModule) { CurrentType = typeInAssembly });
                        foreach (var method in typeInAssembly.Methods)
                        {

                            if (method.Name == treeview_Definitions.SelectedNode.Text)
                            {
                                richTextBox_codeView.Clear();
                                ast_Builder.AddMethod(method);
                                StringWriter output = new StringWriter();
                                ast_Builder.GenerateCode(new PlainTextOutput(output));
                                string result = output.ToString();
                                richTextBox_codeView.AppendText(result);
                                output.Dispose();
                            }
                        }
                    }
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void populateILCode()
        {
            richTextBox_Il_CodeView.Clear();
            var assembly = AssemblyDefinition.ReadAssembly(selectedFilename);
            IEnumerator enumerator = assembly.MainModule.Types.GetEnumerator();

            while (enumerator.MoveNext())
            {
                TypeDefinition td = (TypeDefinition)enumerator.Current;

                if (td.Name == treeview_Definitions.SelectedNode.Parent.Text)
                {
                    IEnumerator enumerator2 = td.Methods.GetEnumerator();
                    while (enumerator2.MoveNext())
                    {
                        MethodDefinition method_definition = (MethodDefinition)enumerator2.Current;
                        if (method_definition.Name == treeview_Definitions.SelectedNode.Text && !method_definition.IsSetter && !method_definition.IsGetter)
                        {
                            richTextBox_Il_CodeView.Clear();
                            ILProcessor cilProcess = method_definition.Body.GetILProcessor();
                            foreach (Instruction ins in cilProcess.Body.Instructions)
                            {
                                richTextBox_Il_CodeView.AppendText(ins + Environment.NewLine);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeview_Definitions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                populateCsharpCode();
                populateILCode();
            }
            catch
            {
                return;
            }
        }

    }
}
