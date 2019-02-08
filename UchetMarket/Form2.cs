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
        public void works() //Записать данные о Товара в БД
        {
            // метод с фикстрованными данными
            //work.Mysql.addTover(11, "Шаурма", 2, "Вкусная шаурма", "Новая точки на Квартале  ");

          bool Chek =  work.Mysql.addTover((int)numericUpDown1.Value, AddToverText_textBox.Text, (int)numericUpDown2.Value, OpisanieTovar_textBox3.Text, Comment_textBox4.Text);

            // проверка на истиность. Если ошибок нет. То выходит сообщение о добавлении
            if (Chek == true)
            {
                MessageBox.Show("Добавлен товар!! \t\n "+ AddToverText_textBox.Text);
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
            //label1.Text = "";

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
       
        
        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            myClass(); // метод запуска таймера времени.
        }

        // обьект для работы с таймером
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public void TimerOnOff()
        {
            //включение таймера
            timer.Enabled = true;
        }
        /// <summary>
        /// метод настроек и запуска таймера 
        /// </summary>
        public void myClass()
        {
            timer.Enabled = true;
            
            this.timer.Interval = 1000;
            this.timer.Tick += new EventHandler(timer_Tick);
            this.timer.Enabled = true;
           
        }
        //Событие запускающие метод для обновления времени. из метода myClass()
        private void timer_Tick(object sender, EventArgs e)
        {
          
            label1.Text = Mysql.TekDateTime();
        }


    }
}
