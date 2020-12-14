using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           DemoUr2.Ur2.Gg(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), out DemoUr2.Ur2.x1, out DemoUr2.Ur2.x2);
            if (DemoUr2.Ur2.d < 0)
                textBox4.Text = "Корней нет";
            else
            {
                textBox4.Text = DemoUr2.Ur2.x1.ToString("0.00") +"/"+ DemoUr2.Ur2.x2.ToString("0.00");
            }


        }
    }
}
