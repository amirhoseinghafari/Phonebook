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
            ad.Fill(ds, "T1");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "T1");
        }
    }
}
