using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Lesson_04._03._22
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void offBut_CheckedChanged(object sender, EventArgs e)
        {
            offBut.Checked = true;
        }

        private void okBut_Click(object sender, EventArgs e)
        {
            if (offBut.Checked)
            {
                Form1 form1 = this.Owner as Form1;
                this.Close();
                form1.tbSurname.ReadOnly = false;
                form1.tbName.ReadOnly = false;
                form1.tbDescription.ReadOnly = false;
            }
        }

        private void cancBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
