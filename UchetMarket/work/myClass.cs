using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetMarket.work
{
    class myClass
    {
        private Timer timer = null;
        public void TimerOnOff()
        {
            this.timer.Enabled = !this.timer.Enabled;
        }
        public myClass()
        {
            this.timer = new Timer();
            this.timer.Interval = 10000;
            this.timer.Tick += new EventHandler(timer_Tick);
            this.timer.Enabled = true;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Прошла секунда");
           // Form2.label1.Text = Mysql.TekDateTime();
        }
    }

}

