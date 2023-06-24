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
    public partial class FRM_publisher : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=System;Password=jib");

        FRM_New_Add new_add = new FRM_New_Add();

        public FRM_publisher()
        {
            InitializeComponent();
            showpublishers();
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

        private void showpublishers()
        {

            Open();
            OleDbDataAdapter adepter = new OleDbDataAdapter("SELECT ID_PUB AS رقم_صاحب_الإعلان,USERNAME AS اسم_المستخدم,NAME_OF_STORE AS اسم_المتجر,PHONE AS رقم_الهاتف,ADDRESS AS العنوان FROM Boos.publisher", con);
            //ID_P AS رقم_الإعلان,PRODUCT_NAME AS اسم المنتج,PRICE AS السعر,DESCRIBE_OF_PRODUCT AS وصف المنتج,ID_PUB AS صاحب الإعلان  
            OleDbCommandBuilder com = new OleDbCommandBuilder(adepter);
            DataSet ds = new DataSet();
            adepter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            ShutDown();
        }

        private void txbx_Search_Click(object sender, EventArgs e)
        {
            txbx_Search.Text = "";
            txbx_Search.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new_add.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Close exit = new FRM_Close();
            exit.Show();
        }

        private void search_home()
        {
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT ID_P As رقم_الصنف ,PRODUCT_NAME AS اسم_المنتج,PRICE AS السعر, DESCRIBE_OF_PRODUCT AS وصف_المنتج FROM boos.adds WHERE   ID_P||PRODUCT_NAME||PRICE||DESCRIBE_OF_PRODUCT LIKE '%" + txbx_Search.Text + "%' ORDER BY ID_P";
            OleDbDataReader dr;
            Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            ShutDown();
           
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            search_home();
        }

        private void FRM_publisher_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT ID_P As رقم_الصنف ,PRODUCT_NAME AS اسم_المنتج,PRICE AS السعر, DESCRIBE_OF_PRODUCT AS وصف_المنتج FROM boos.adds ORDER BY ID_P";
            OleDbDataReader dr;
            Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            ShutDown();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("T");
        }

        
        }
    }

