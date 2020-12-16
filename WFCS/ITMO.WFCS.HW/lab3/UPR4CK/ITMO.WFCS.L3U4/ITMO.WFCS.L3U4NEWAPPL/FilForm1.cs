using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WFCS.L3U4NEWAPPL
{
    public partial class FilForm1 : Form
    {
        public string FilSurname
        {
            get { return filControl1.FilTextBox1.Text; }
            set { filControl1.FilTextBox1.Text = value; }
        }
        public string FilName
        {
            get { return filControl1.FilTextBox2.Text; }
            set { filControl1.FilTextBox2.Text = value; }
        }

        public string FilMiddlename

        {
            get { return filControl1.FilTextBox3.Text; }
            set { filControl1.FilTextBox3.Text = value; }
        }

        public FilForm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void filControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

    
        private void richTextBox1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = FilSurname +" "+ FilName +" "+ FilMiddlename+"-Золотой ты наш человек!!!";
        }
    }

}
