using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Is_there_new_2
{
    public partial class FRM_New_Add : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=System;Password=jib");

        public FRM_New_Add()
        {
            InitializeComponent();
        }

        private void txtbx_Price_Click(object sender, EventArgs e)
        {
            txtbx_Price.Text = "";
            txtbx_Price.ForeColor = Color.Black;
            
        }

        public void Open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        public void ShutDown()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbx_Product.Text == "" || txtbx_Price.Text == "")
            {

                MessageBox.Show("خطأ في الإدخال", "يرجى التأكد من كتابة اسم وسعر المنتج", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    OleDbCommand cmd = new OleDbCommand("", con);                 
                    cmd.Connection = con;
                    cmd.CommandText = cmd.CommandText = "INSERT INTO BOOS.adds (ID_P,PRODUCT_NAME,PRICE,DESCRIBE_OF_PRODUCT) VALUES ('"+txtbx_Id.Text+"','" + txtbx_Product.Text + "','" + txtbx_Price.Text + "','" + txtbx_Desc.Text + "')";
                    Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمت الإضافة بنجاح");
                    ShutDown();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            this.Hide();
            FRM_publisher publisher = new FRM_publisher();
            publisher.Show();


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Close exit = new FRM_Close();
            exit.Show();
        }

        private void txtbx_Id_Click(object sender, EventArgs e)
        {
            txtbx_Id.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("T");
        }

        private void FRM_New_Add_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
