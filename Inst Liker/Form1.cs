using Inst_Liker.work;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            string temlogPass = "";

            Chek();
            // проверка.
            if (Start == true)
            {
                // Send(inst.Auth("+79179037140", "d51215045"));
                Send(inst.Auth(textBox2.Text, textBox3.Text));
                // запись в лог
                temlogPass += textBox2.Text;
                temlogPass += "\t\n";
                temlogPass += textBox3.Text;

            }

            else // логин по деволту
            {
                string[] tempPassDefaut = OpenFail();
            }

            ZapisFaila(temlogPass);

        }
        /// <summary>
        /// чтение файла
        /// </summary>
        /// <returns></returns>
        static string[] OpenFail()
        {
            string[] data = File.ReadAllLines("Аcc.txt");

            return data;
        }

        /// <summary>
        /// запись текста в файл
        /// </summary>
        /// <param name="text"></param>
        static void ZapisFaila(string text)
        {
            string path = @"hta.txt";

            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
                sw.Write("\t\n");
            }
        }
    }
}
