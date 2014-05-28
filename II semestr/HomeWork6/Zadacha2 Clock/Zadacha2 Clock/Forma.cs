using System;
using System.Windows.Forms;

namespace Zadacha2_Clock
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
            PrintTime();
        }

        /// <summary>
        /// Every 1 second do TimeNow.
        /// </summary>
        private void PrintTime()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimeNow);
            timer.Start();
        }

        /// <summary>
        /// Write time in text boxes.
        /// </summary>
        private void TimeNow(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 10)
            {
                this.hours.Text = "0" + DateTime.Now.Hour.ToString();
            }
            else
            {
                this.hours.Text = DateTime.Now.Hour.ToString();
            }
            if (DateTime.Now.Minute < 10)
            {
                this.minutes.Text = "0" + DateTime.Now.Minute.ToString();
            }
            else
            {
                this.minutes.Text = DateTime.Now.Minute.ToString();
            }
            if (DateTime.Now.Second < 10)
            {
                this.seconds.Text = "0" + DateTime.Now.Second.ToString();
            }
            else
            {
                this.seconds.Text = DateTime.Now.Second.ToString();
            }
        }

        /// <summary>
        /// Don't touch time!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void time_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
