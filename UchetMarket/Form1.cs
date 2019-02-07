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
using Timer = System.Threading.Timer;

namespace UchetMarket
{
    public partial class Form1 : Form
    {
      
        

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// кнопка Добавить новый товар
        /// </summary>
      //  myClass mC = new myClass();

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(); //новый обьект для вызова и работы с новой формой
            newForm.Show(); // показать нов. форму

          //  mC.TimerOnOff(); // тест

            // создаем новый поток
            Thread myThread = new Thread(new ThreadStart(zapusk));
            //myThread.Start(); // запускаем поток

            //  inisalTimeForm2(); // Запуск асенронного метода для времени. НЕ раб!!! 

            // создаем новый поток
            // Thread myThread = new Thread(new ThreadStart(zapusk));
            // myThread.Start(); // запускаем поток

           

            TimerCallback tm = new TimerCallback(TestData);

            // создаем таймер
            Timer timer = new Timer(tm, null, 0, 5000);

        }

        public void TestData(object obj)
        {
            // while (true)
            // {
            //this.label1.Text = Mysql.TekDateTime();
           // this.label1.Text = DateTime.Now.ToString();
            //  }
            // string timme;
            // return timme = DateTime.Now.ToString();

        }


        //Кнопка обновить таблицу
        private void SettingUpdateTabl_Click(object sender, EventArgs e)
        {
            //Вызываем пробный тест
           // MessageBox.Show(work.Mysql.Test());
        }

        ///*******************
       private void zapusk()
        {
           // Form2 form3 = new Form2();
           // MyDatetIME();
        }

       
        ///*********************************

    }
}
