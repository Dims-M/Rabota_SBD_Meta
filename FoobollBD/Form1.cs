using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace FoobollBD
{
    public partial class Form1 : Form
    {
        //Обьект для работы с БД
        SoccerContext db;

        public Form1()
        {
            InitializeComponent();

            //Обьект для подклбчение в БД через класс SoccerContext
            db = new SoccerContext();

            //метод для отображение и закгрузки
            db.Players.Load();

           // привязку к элементу DataGridView и динамически отображать все изменения в случае добавления
            dataGridView1.DataSource = db.Players.Local.ToBindingList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Кнопка добавить
        private void button1_Click(object sender, EventArgs e)
        {
            PlayerForm plForm = new PlayerForm(); // Создание новой формы
            DialogResult result = plForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Player player = new Player(); // новый обьект для работы с БД.
            
            player.Age = (int)plForm.numericUpDown1.Value; // обьект для перечисление цифровых знач
            player.Name = plForm.textBox1.Text; // Хранится текст для записи имени

            player.Position = plForm.comboBox1.SelectedItem.ToString(); //выбор из перечисления нужное значение

            db.Players.Add(player); // записываем обьект класса() в нашу БД 
            db.SaveChanges(); // сохраняем изменения

            MessageBox.Show("Новый объект добавлен");
        }
    }
}
