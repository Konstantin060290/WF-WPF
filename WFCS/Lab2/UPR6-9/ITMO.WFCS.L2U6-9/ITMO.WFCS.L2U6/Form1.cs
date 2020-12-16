using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WFCS.L2U6
{
    
    public partial class Form1 : Form
    {
        List<Item> its = new List<Item>();

        //Свойства книг
        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text;}
            
            set { textBox2.Text = value; }
        }
        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }

            public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox3.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox2.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // Срок использования
        {
            get { return (int)numericUpDown5.Value; }

            set { numericUpDown4.Value = value; }
        }

        //Свойства журналов

        public string MTitle // Название
        {
            get { return textBox5.Text; }

            set { textBox5.Text = value; }
        }
        public string MVolume // Том
        {
            get { return textBox4.Text; }

            set { textBox4.Text = value; }
        }


        public int MNumber // Номер журнала
        {
            get { return (int)numericUpDown9.Value; }
            set { numericUpDown9.Value = value; }
        }

        public int MYear // Год выпуска
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }
        public int MInvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public int MPeriodUse // Срок использования
        {
            get { return (int)numericUpDown5.Value; }

            set { numericUpDown5.Value = value; }
        }

        public bool MSubs // Подписка
        {
            get { return checkBox7.Checked; }
            set { checkBox7.Checked = value; }
        }

        public bool MExistence // Наличие
        {
            get { return checkBox6.Checked; }
            set { checkBox6.Checked = value; }
        }
        public bool MSortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }
        public bool MReturnTime // Возвращение в срок
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }


      
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Book b = new Book(Author, Title, PublishHouse,
                Page, Year, InvNumber, Existence);

            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2000;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(MVolume, MNumber, MTitle, MYear, MInvNumber, MExistence, MSubs);

            if (ReturnTime)
            m.ReturnSrok();          
            its.Add(m);
            Title =  "";
            InvNumber = PeriodUse = 0;
            Year = 0;
            Existence = ReturnTime = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MSortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox2.Text = sb.ToString();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
