using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCatchTask
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();

            if (sender is Button bt)
            {
                int randomX = random.Next(this.Width - 200);
                int randomY = random.Next(this.Height - 200);
                bt.Location = new Point(randomX, randomY);
            }
        }
    }
}