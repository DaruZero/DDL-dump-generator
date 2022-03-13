using System.Media;
using System.Text;

namespace DDL_dump_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textOutput.Clear();
            if (textLink.Text.Length > 0)
                Generate();
            else
                MessageBox.Show("Insert a link", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (textFileName.Text.Length > 0)
                Export();
            else
                MessageBox.Show("Insert a filename", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Generate()
        {
            int start = (int)numStart.Value;
            int finish = (int)numFinal.Value;
            string suffix = comboBoxSuffix.Text;
            string linkTrimmed;

            // Remove the suffix from the original link if present
            if (textLink.Text.EndsWith(suffix))
                linkTrimmed = textLink.Text.Remove(textLink.TextLength - suffix.Length, suffix.Length);
            else
                linkTrimmed = textLink.Text;

            string linkBase = linkTrimmed;
            int padding = 0;

            // Remove the numbering at the end of the trimmed link if present and count the padding
            for (int i = linkTrimmed.Length - 1; i >= 0; i--)
            {
                if (char.IsNumber(linkTrimmed[i]))
                {
                    padding++;
                    linkBase = linkBase.Remove(i);
                }
                else break;
            }
            // Creates the DDL with the same padding as the original link and the suffix selected
            for (int i = start; i <= finish; i++)
            {
                StringBuilder stringBuilder = new();
                stringBuilder.Append(linkBase);
                stringBuilder.Append(i.ToString().PadLeft(padding, '0'));
                stringBuilder.AppendLine(suffix);
                textOutput.AppendText(stringBuilder.ToString());
            }
        }

        private void Export()
        {
            string filename = textFileName.Text.EndsWith(".txt")? textFileName.Text : textFileName.Text + ".txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), filename);

            // If file does not exists create a new one, else asks to overwrite
            if (!File.Exists(path))
                File.WriteAllText(path, textOutput.Text);
            else
                if (MessageBox.Show("Files already existing.\nOverwrite?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                File.WriteAllText(path, textOutput.Text);
                else
                    return;
            SystemSounds.Beep.Play();
        }
    }
}