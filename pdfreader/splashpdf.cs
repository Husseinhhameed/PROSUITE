using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfreader
{
    public partial class splashpdf : Form
    {
        public splashpdf()
        {
            InitializeComponent();
        }
        public int timeLeft { get; set; }

        private void splashpdf_Load(object sender, EventArgs e)
        {
            timeLeft = 80;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;

            }
            else
            {
                timer1.Stop();
                new Form1().Show();
                this.Hide();

            }
        }
    }
}
