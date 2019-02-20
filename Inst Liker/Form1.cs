using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inst_Liker
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// проверочная булевская переменная
        /// </summary>
        bool Start = false;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// вывод сообщения  в лог.
        /// </summary>
        /// <param name="Tekxt">Сообщение</param>
        void Send(string Tekxt)
        {
            richTextBox1.AppendText($"{Tekxt}");
        }

        /// <summary>
        /// Метод проверки заполненности полей
        /// </summary>
         void Chek()
        {
            if (textBox1.Text.Length == 0)
            {
                Send("Не заполнен логин");
            }
            else if (textBox2.Text.Length == 0)
            {
                Send("Не привильно введен пароль");
            }
            else
            {
                Start = true; // меняем проверочную булевскую переменную на true
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //кнопка авторизации
        private void button1_Click(object sender, EventArgs e)
        {
            Chek();
        }
    }
}
