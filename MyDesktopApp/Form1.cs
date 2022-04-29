using Manina.Windows.Forms;
using System;
using System.IO;
using System.Text;

namespace MyDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Notepad";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            //this.FormClosing += Form1_FormClosing;
        }

        void button1_Click(object sender, EventArgs e)
        {
        }

        void label2_Click(object sender, EventArgs e)
        {

        }

        void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void saveAdToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void schemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tab1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_PageChanged(object sender, Manina.Windows.Forms.PageChangedEventArgs e)
        {
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Tab tabpage = new Tab();
            RichTextBox rch = new RichTextBox();

            rch.BorderStyle = BorderStyle.None;
            rch.BackColor = SystemColors.Window;

            tabpage.Text = "Untitled";

            tabpage.Controls.Add(rch);

            //tabControl1.Tabs.Add(tabpage);*/
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        /*private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult res =  MessageBox.Show(this, "Do you want to save your file?",
                                                    "Save file",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning,
                                                    MessageBoxDefaultButton.Button1);

                if (res == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }

                    string path = saveFileDialog1.FileName;
                    string file_name = System.IO.Path.GetFileName(saveFileDialog1.FileName);

                    userControl11.Parent.Controls.Owner.;
                }
            }

            else if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                return;
            }
        }*/
    }
}