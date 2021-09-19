using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HWProjectWindowsFormsClass;
using HackermeDB;


namespace HWProjectWindowsFormsClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           searchByLastNameDeleteButton actionWindow= new searchByLastNameDeleteButton();   
            actionWindow.Show(this);   
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
