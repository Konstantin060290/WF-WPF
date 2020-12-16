using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ITMO.WFCS.L7U5_Check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Text.StringBuilder resultText = new
                System.Text.StringBuilder();
        public void GoButt()
        { int maxValue = 0;
            
            if (int.TryParse(MaxValue.Text, out maxValue))
            { for (int trial = 2; trial <= maxValue; trial++)
                { bool isPrime = true;
                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    { if (trial % divisor == 0)
                        { isPrime = false; break;
                        }
                    }
                    if (isPrime)
                    { resultText.AppendFormat("{0} ", trial);
                    }
                }
            } else { resultText.Append("Unable to parse maximum value.");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            Thread.Sleep(5000);
            GoButt();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ResultLabel.Text = resultText.ToString();
        }
    }
}
