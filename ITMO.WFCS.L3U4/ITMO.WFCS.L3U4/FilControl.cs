using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WFCS.L3U4
{
    public partial class FilControl : UserControl
    {
        public FilControl()
        {
            InitializeComponent();
        }


     
        private void FilTextBox1_Validating_1(object sender, CancelEventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(FilTextBox1.Text))
                {
                    e.Cancel = true;
                    FilTextBox1.Focus();
                    errorProvider1.SetError(FilTextBox1, "Поле не может быть пустым");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(FilTextBox1, "");
                }
            }
        }

        private void FilTextBox2_Validating(object sender, CancelEventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(FilTextBox2.Text))
                {
                    e.Cancel = true;
                    FilTextBox2.Focus();
                    errorProvider2.SetError(FilTextBox2, "Поле не может быть пустым");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider2.SetError(FilTextBox2, "");
                }
            }
        }

        private void FilTextBox3_Validating(object sender, CancelEventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(FilTextBox3.Text))
                {
                    e.Cancel = true;
                    FilTextBox3.Focus();
                    errorProvider3.SetError(FilTextBox3, "Поле не может быть пустым");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider3.SetError(FilTextBox3, "");
                }
            }
        }

       
    }


       
      
        
    
}
