using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lesson_04._03._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "Вкладка " + (tabControl1.TabCount + 1).ToString();
            TabPage page = new TabPage(title);
            tabControl1.TabPages.Add(page);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=_E6RbwNtIEI");
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Текстовый файл |*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter str_wr = new StreamWriter(save.FileName);
                str_wr.WriteLine(tbSurname.Text);
                str_wr.WriteLine(tbName.Text);
                str_wr.WriteLine(tbDescription.Text);
                str_wr.Close();
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
