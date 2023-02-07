using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace phonebook
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd1 = new SqlCommand();
        SqlDataAdapter ad = new SqlDataAdapter();
        DataSet ds = new DataSet();
        CurrencyManager cr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //conection to database
            conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\MyProgramC#\Phonebook\phonebook\phonebook\Telbook.mdf; Integrated Security = True";
            conn.Open();
            fillgrid();
        }
        /// <summary>
        ///  Extracting information from the database save in RAM and displaying it in girdview
        ///  استخراج اطلاعات از دیتابیس ، ذخیره آن در رم و نمایش در دیتاگرید 
        /// </summary>
        /// <param name="s"></param>
        void fillgrid(string s = "select * from Tbltell")
        {
            cmd1.CommandText = s;
            cmd1.Connection = conn;
            ad.SelectCommand = cmd1;
            ds.Clear();
            ad.Fill(ds, "T1");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "T1");
            //For displaying information in textbox 
            //نمایش اطلاعات سطر انتخاب شده در جعبه متن ها
            txtname.DataBindings.Clear();
            txtname.DataBindings.Add("text",ds,"T1.Firstname");
            txtfamily.DataBindings.Clear();
            txtfamily.DataBindings.Add("text", ds, "T1.Lastname");
            txttell.DataBindings.Clear();
            txttell.DataBindings.Add("text", ds, "T1.Phoneno");
            txtaddress.DataBindings.Clear();
            txtaddress.DataBindings.Add("text", ds, "T1.address");
            //define CurrencyManager for manage data
            // تعریف کارنسی برای مدیریت داده ها داخل دیتابیس
            cr = (CurrencyManager)this.BindingContext[ds, "T1"];
        }
        //for go to next data
        //برای رفتن به اطلاعات سطر بعدی در دیتابیس
        private void btnnext_Click(object sender, EventArgs e)
        {
            cr.Position++;
        }
        //for go to first data
        //برای رفتن به اولین سطر در دیتابیس
        private void btnfirst_Click(object sender, EventArgs e)
        {
            cr.Position = 0;
        }
        //for go to per...
        //برای رفتن به اطلاعات سطر قبلی در دیتابیس
        private void btnpre_Click(object sender, EventArgs e)
        {
            cr.Position--;
        }
        //for go to last data
        //برای رفتن به سطر قبلی در دیتابیس 
        private void btnlast_Click(object sender, EventArgs e)
        {
            cr.Position = cr.Count - 1;
        }
        //for cleaning textbox and add new person
        private void btnnew_Click(object sender, EventArgs e)
        {
            txtname.ReadOnly = false;
            txtfamily.ReadOnly = false;
            txtaddress.ReadOnly = false;
            txttell.ReadOnly = false;
            txtname.Text = "";
            txtfamily.Text = "";
            txttell.Text = "";
            txtaddress.Text = "";
            btnnew.Enabled = false;
            btnsave.Enabled = true;
            txtname.Focus();
        }
        //for save textboxes and add to database whith command
        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "insert into Tbltell values (@P1,@P2,@P3,@P4)";
            c1.Parameters.AddWithValue("P1",txtname.Text);
            c1.Parameters.AddWithValue("P2", txtfamily.Text);
            c1.Parameters.AddWithValue("P3", txttell.Text);
            c1.Parameters.AddWithValue("P4", txtaddress.Text);
            c1.Connection = conn;
            c1.ExecuteNonQuery();
            btnsave.Enabled = false;
            btnnew.Enabled = true;
            txtname.ReadOnly = true;
            txtfamily.ReadOnly = true;
            txtaddress.ReadOnly = true;
            txttell.ReadOnly = true;
            fillgrid();
        }
        //if you click on one row program display in textbox 
        //زمانی که روی اطلاعات یک شخص کلیک میکنیم اطلاعات آن در جعبه متن نمایش داده شود
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cr.Position = e.RowIndex;
        }
    }
}
