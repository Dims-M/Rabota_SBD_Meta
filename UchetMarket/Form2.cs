using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UchetMarket.work;

namespace UchetMarket
{
    public partial class Form2 : Form
    {
        // для работы с подключением к БД
        Mysql MySql = new Mysql();



        // инициализатор форм
        public Form2()
        {
            InitializeComponent();

            

           //MyDatetIME();

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Добавить товар в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Будет добавлен товар");
            // метод с фикстрованными данными
            // work.Mysql.addTover(13, "Шаурма", 2,"Вкусная шаурма","новая точка Адоратского ");
            works();
        }

        /// <summary>
        /// Записать данные о Товара в БД
        /// </summary>
        public void works()
        {// метод с фикстрованными данными
            //work.Mysql.addTover(11, "Шаурма", 2, "Вкусная шаурма", "Новая точки на Квартале  ");
            work.Mysql.addTover((int)numericUpDown1.Value, AddToverText_textBox.Text, (int)numericUpDown2.Value, OpisanieTovar_textBox3.Text, Comment_textBox4.Text);
        }

        public async void MyDatetIME()
        {
            //string result = await Task.Factory.StartNew<string>(
             //() => Mysql.TekDateTime(),
             // TaskCreationOptions.LongRunning);

           // string result = await Task.Factory.StartNew<string>(
            // () => Mysql.TekDateTime());

            // string result = Mysql.TekDateTime();
            //label1.Text = Mysql.TekDateTime();

            this.label1.Text = Mysql.TekDateTime();

            // await Task.Run(() => Factorial());

            // while (true)
            // {
           
          //  this.label1.Text =  Mysql.TekDateTime();
            // this.label1.Text = await Task.Factory.StartNew<string>(
            // () => Mysql.TekDateTime(),
            // TaskCreationOptions.LongRunning); 

            //  }
            // Form2.label1.Text.Invoke(new Action(() => ));

            // }

        }

        public void TestData()
        {
            while (true)
            {
            this.label1.Text = Mysql.TekDateTime();
            }

        }

        // кнопка выход
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Кнопка очистить
        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            AddToverText_textBox.Text = "";
            numericUpDown2.Value = 0;
            OpisanieTovar_textBox3.Text = "";
            Comment_textBox4.Text = "";
            label1.Text = "";

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // запуск формы
        private void Form2_Load(object sender, EventArgs e)
        {
            // создаем новый поток
            Thread myThread = new Thread(new ThreadStart(TestData));
           // myThread.Start(); // запускаем поток

            // создаем новый поток
            // Thread myThread = new Thread(new ParameterizedThreadStart(MyDatetIME));
            // myThread.Start();
            this.label1.Text = Mysql.TekDateTime();
        }
    }
}
