using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Is_there_new_2
{
    public partial class FRM_Close : Form
    {
        public FRM_Close()
        {
            InitializeComponent();
        }
        int START = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            START += 1;
            progressBar1.Value = START;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                this.Hide();
                Application.Exit();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("T");
        }

        private void FRM_Close_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
    }
}
