using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calculator;
using System.Threading;

namespace SimpleCalculator
{
    public partial class EngView : SimpleCalculator.CalcUI
    {
        public EngView()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePow);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            CalcEngine.CalcOperation(CalcEngine.Operator.eSqrt);
            string a = this.OutputDisplay.Text;
            object o = null ;
            EventArgs c= null;
            KeyZero_Click(o, c);
            this.OutputDisplay.Text = a;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eReverse);
            string a = this.OutputDisplay.Text;
            object o = null;
            EventArgs c = null;
            KeyZero_Click(o, c);
            this.OutputDisplay.Text = a;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSquare);
            string a = this.OutputDisplay.Text;
            object o = null;
            EventArgs c = null;
            KeyZero_Click(o, c);
            this.OutputDisplay.Text = a;
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void EngView_Load(object sender, EventArgs e)
        {
            
                ToolTip t = new ToolTip();
                t.SetToolTip(button1, "Возведение в степень");
                t.SetToolTip(button2, "Вычисление квадратного корня");
                t.SetToolTip(button3, "Вычисление обратного значения");
                t.SetToolTip(button4, "Вычисление квадрата числа");
                t.SetToolTip(button5, "Вычисление факториала");
                t.SetToolTip(button6, "Вычисление кубического корня");
                t.SetToolTip(button7, "Вычисление корней квадратного уравнения");
                t.SetToolTip(button8, "Вычисление факториала в параллельном потоке");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eFactorial);
            string a = this.OutputDisplay.Text;
            object o = null;
            EventArgs c = null;
            KeyZero_Click(o, c);
            this.OutputDisplay.Text = a;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eCuberoot);
            string a = this.OutputDisplay.Text;
            object o = null;
            EventArgs c = null;
            KeyZero_Click(o, c);
            this.OutputDisplay.Text = a;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dialog D1 = new Dialog();
            D1.textBox1.Text = Convert.ToString(0);
            D1.textBox2.Text = Convert.ToString(0);
            D1.textBox3.Text = Convert.ToString(0);
            D1.Show();
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            MessageBox.Show("Идут вычисления");
        }
        private int factorial2;
        public int Fac
        {
            get
            {
                return factorial2;
            }

            set
            {
                factorial2 = value;
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            //CalcEngine.CalcOperation(CalcEngine.Operator.eFactorial);
            //string a = this.OutputDisplay.Text;
            //object o = null;
            //EventArgs c = null;
            //KeyZero_Click(o, c);
            //this.OutputDisplay.Text = a;
            
            
            int n = Convert.ToInt32(OutputDisplay.Text);  // количество циклов в факториале

            factorial2 = 1;   // значение факториала

            for (int i = 2; i <= n; i++) // цикл начинаем с 2, т.к. нет смысла начинать с 1
            {
                factorial2 = factorial2 * i;
            }

            Thread.Sleep(5000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBox1.Text = Convert.ToString(Fac);

        }
    }
}
