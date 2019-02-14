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
using System.Linq;

namespace UchetMarket
{
    public partial class Form1 : Form
    {
      
        

        public Form1()
        {
            InitializeComponent();
        }

       
        /// кнопка Добавить новый товар
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(); //новый обьект для вызова и работы с новой формой
            newForm.Show(); // показать нов. форму
        }

        //Кнопка обновить таблицу
        private void SettingUpdateTabl_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; // очистка формы перед использованием
            // textBox1.Text = Mysql.UpdateTable(); // вывод данных из БД в текст боск

            
            List<string> info  = Mysql.UpdateTable((int)numericUpDown1.Value); //

            // перебор и запись в массив
            for(int i = 0; i < info.Count; i++)
            {
                string[] razdelitel = info[i].Split(','); // разбивка по сплиту перед записью в массив

                /// textBox1.Text += info[i]+ Environment.NewLine; // переход на новую строку
                 //textBox1.Text += razdelitel[i]+ Environment.NewLine;
            }


        }

        
    }
}
