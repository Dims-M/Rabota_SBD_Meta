using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(); //новый обьект для вызова и работы с новой формой
            newForm.Show(); // показать нов. форму

           
        }

        //Кнопка обновить таблицу
        private void SettingUpdateTabl_Click(object sender, EventArgs e)
        {
            //Вызываем пробный тест
            MessageBox.Show(work.Mysql.Test());
        }
    }
}
