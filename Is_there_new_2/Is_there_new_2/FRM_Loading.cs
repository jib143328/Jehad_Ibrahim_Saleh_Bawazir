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
    public partial class FRM_Loading : Form
    {
        public FRM_Loading()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

            Application.Exit();
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
                FRM_publisher publish = new FRM_publisher();
                this.Hide();
                publish.Show();

            }
        }

        private void FRM_Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("T");
        }
    }
}
