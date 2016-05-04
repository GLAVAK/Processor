using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;

namespace MyProcessorIDE
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if ((string)Properties.Settings.Default["assemblerFilename"] != "")
            {
                try
                {
                    StreamReader reader = new StreamReader(File.OpenRead((string)Properties.Settings.Default["assemblerFilename"]));
                    textBoxAssembler.Text = reader.ReadToEnd();
                    reader.Close();

                    assemblerFilename = (string)Properties.Settings.Default["assemblerFilename"];
                    toolStripLabelAssemblerFilename.Text = assemblerFilename;
                }
                catch (Exception) { }
            }

            if ((string)Properties.Settings.Default["outputFilename"] != "")
            {
                try
                {
                    StreamReader reader = new StreamReader(File.OpenRead((string)Properties.Settings.Default["outputFilename"]));
                    textBoxOutput.Text = reader.ReadToEnd();
                    reader.Close();

                    outputFilename = (string)Properties.Settings.Default["outputFilename"];
                    toolStripLabelOutputSave.Text = outputFilename;
                }
                catch (Exception) { }
            }
        }

        private void toolStripButtonAssemble_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOutput.Text = Assembler.Assemble(textBoxAssembler.Text);
            }
            catch (CompilerErrorException ex)
            {
                MessageBox.Show(
                    String.Format("There was an assembling error: \"{0}\", Line {1}, Column {2}", ex.Text, ex.Line, ex.Column),
                    "Assembling error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOutput.Clear();
            }
        }

        private void toolStripButtonAssemblerNew_Click(object sender, EventArgs e)
        {
            assemblerFilename = "";
            Properties.Settings.Default["assemblerFilename"] = assemblerFilename;
            toolStripLabelAssemblerFilename.Text = "untitled";
            textBoxAssembler.Clear();
        }

        String assemblerFilename = "";
        private void toolStripButtonAssemblerSave_Click(object sender, EventArgs e)
        {
            if (assemblerFilename == "")
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.AddExtension = true;
                dialog.Filter = ".asm files|*.asm";

                if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                assemblerFilename = dialog.FileName;
                Properties.Settings.Default["assemblerFilename"] = assemblerFilename;
                Properties.Settings.Default.Save();
            }

            toolStripLabelAssemblerFilename.Text = assemblerFilename;
            StreamWriter writer = new StreamWriter(File.OpenWrite(assemblerFilename));
            writer.Write(textBoxAssembler.Text);
            writer.Close();
        }

        String outputFilename = "";
        private void toolStripButtonOutputSave_Click(object sender, EventArgs e)
        {
            if (outputFilename == "")
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.AddExtension = true;
                dialog.Filter = ".mif files|*.mif";

                if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                outputFilename = dialog.FileName;
                Properties.Settings.Default["outputFilename"] = outputFilename;
                Properties.Settings.Default.Save();
            }

            toolStripLabelOutputSave.Text = outputFilename;
            StreamWriter writer = new StreamWriter(File.OpenWrite(outputFilename));
            writer.Write(textBoxOutput.Text);
            writer.Close();
        }

        private void toolStripButtonOutputSaveAs_Click(object sender, EventArgs e)
        {
            string oldFilename = outputFilename;
            outputFilename = "";

            toolStripButtonOutputSave_Click(sender, e);

            if (outputFilename == "") outputFilename = oldFilename;
        }

        private void toolStripButtonAssemblerOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    StreamReader reader = new StreamReader(File.OpenRead(dialog.FileName));
                    textBoxAssembler.Text = reader.ReadToEnd();
                    reader.Close();

                    assemblerFilename = dialog.FileName;
                    toolStripLabelAssemblerFilename.Text = assemblerFilename;
                    Properties.Settings.Default["assemblerFilename"] = assemblerFilename;
                    Properties.Settings.Default.Save();
                }
                catch (Exception) { }
            }
        }

        Style CommandStyle = new TextStyle(Brushes.BurlyWood, null, FontStyle.Regular);
        Style ArgumentStyle = new TextStyle(Brushes.PaleGreen, null, FontStyle.Regular);
        Style DirectiveStyle = new TextStyle(Brushes.CornflowerBlue, null, FontStyle.Regular);
        Style ConstantStyle = new TextStyle(Brushes.Khaki, null, FontStyle.Regular);
        Style CommentStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);
        private void textBoxAssembler_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (assemblerFilename != "")
            {
                toolStripLabelAssemblerFilename.Text = assemblerFilename + " *";
            }

            e.ChangedRange.ClearStyle(CommandStyle);
            e.ChangedRange.ClearStyle(ArgumentStyle);
            e.ChangedRange.ClearStyle(DirectiveStyle);
            e.ChangedRange.ClearStyle(ConstantStyle);
            e.ChangedRange.ClearStyle(CommentStyle);

            // Commands:
            e.ChangedRange.SetStyle(CommandStyle, @"\b(add|sub|mul|div|and|or|xor|not|load|save|goto|print)", RegexOptions.IgnoreCase);
            // Args:
            e.ChangedRange.SetStyle(ArgumentStyle, @"\b(add|sub|mul|div|and|or|xor|not|load|save|goto)\s+(?<range>\d+?)\b", RegexOptions.IgnoreCase);

            e.ChangedRange.SetStyle(DirectiveStyle, @"\b(const)", RegexOptions.IgnoreCase);
            e.ChangedRange.SetStyle(ConstantStyle, @"\b(const)\s+(?<range>\d+?)\b", RegexOptions.IgnoreCase);

            e.ChangedRange.SetStyle(CommentStyle, @"%.*", RegexOptions.None);
        }


        Style BackStyle = new TextStyle(Brushes.DimGray, null, FontStyle.Regular);
        Style MemoryBlockStyle = new TextStyle(Brushes.PapayaWhip, null, FontStyle.Regular);
        private void textBoxOutput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (outputFilename != "")
            {
                toolStripLabelOutputSave.Text = outputFilename + " *";
            }

            e.ChangedRange.ClearStyle(BackStyle);
            e.ChangedRange.ClearStyle(MemoryBlockStyle);

            // Commands:
            e.ChangedRange.SetStyle(BackStyle, @"\b(CONTENT\sBEGIN|END|(DATA_RADIX\s=\s.*)|(ADDRESS_RADIX\s=\s.*)|(WIDTH\s=\s\d+)|(DEPTH\s=\s\d+))\b", RegexOptions.IgnoreCase);
            // Args:
            e.ChangedRange.SetStyle(MemoryBlockStyle, @"\d", RegexOptions.IgnoreCase);
        }
    }
}
