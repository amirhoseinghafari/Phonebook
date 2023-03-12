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
using System.IO;


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
        Region x = new Region();
        int beforedit;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //conection to database
            conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename="+Application.StartupPath + @"\Telbook.mdf; Integrated Security = True";
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
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("text", ds, "T1.ID");
            pic1.DataBindings.Clear();
            pic1.DataBindings.Add("imagelocation", ds , "T1.picurl");
            //define CurrencyManager for manage data
            // تعریف کارنسی برای مدیریت داده ها داخل دیتابیس
            cr = (CurrencyManager)this.BindingContext[ds, "T1"];
        }
        //for go to next data
        //برای رفتن به اطلاعات سطر بعدی در دیتابیس
        private void btnnext_Click(object sender, EventArgs e)
        {
            //cr.Position++;
            setcurrentrec(cr.Position + 1);
        }
        //for go to first data
        //برای رفتن به اولین سطر در دیتابیس
        private void btnfirst_Click(object sender, EventArgs e)
        {
            // cr.Position = 0;
            setcurrentrec(0);
        }
        //for go to per...
        //برای رفتن به اطلاعات سطر قبلی در دیتابیس
        private void btnpre_Click(object sender, EventArgs e)
        {
            //cr.Position--;
            setcurrentrec(cr.Position - 1);
        }
        //for go to last data
        //برای رفتن به سطر قبلی در دیتابیس 
        private void btnlast_Click(object sender, EventArgs e)
        {
            //cr.Position = cr.Count - 1;
            setcurrentrec(cr.Count - 1);
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
            BtnBrowse.Enabled = true;
            txtname.Focus();
        }
        //for save textboxes and add to database whith command
        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "insert into Tbltell values (@P1,@P2,@P3,@P4,@P5)";
            c1.Parameters.AddWithValue("P1",txtname.Text);
            c1.Parameters.AddWithValue("P2", txtfamily.Text);
            c1.Parameters.AddWithValue("P3", txttell.Text);
            c1.Parameters.AddWithValue("P4", txtaddress.Text);
            c1.Parameters.AddWithValue("P5", Copypic(pic1.ImageLocation, txtID.Text+txttell.Text));
            c1.Connection = conn;
            c1.ExecuteNonQuery();
            btnsave.Enabled = false;
            BtnBrowse.Enabled = false;
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
        //This code is for Btn delete 
        //نوشتن کد دکمه پاک کردن 
        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Do you want to delete " + txtname.Text + " " +txtfamily.Text , "Delete...",MessageBoxButtons.YesNo);
            if (x == DialogResult.No)
                return;
            SqlCommand c2 = new SqlCommand();
            c2.CommandText = "delete from Tbltell where ID = @P1";
            c2.Parameters.AddWithValue("P1", txtID.Text);
            c2.Connection = conn;
            c2.ExecuteNonQuery();
            fillgrid();
        }
        /// <summary>
        /// This Event is for Btn Edit
        /// این کد برای دکمه ویرایش میباشد که برای ذخیره تغییرات از خود دکمه استفاده کردیم
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnedit_Click(object sender, EventArgs e)
        {
            if (btnedit.Text=="Edit")
            {
                txtname.ReadOnly = false;
                txtfamily.ReadOnly = false;
                txtaddress.ReadOnly = false;
                txttell.ReadOnly = false;
                BtnBrowse.Enabled = true;
                btnedit.Text = "Apply";
                txtname.Focus();
                beforedit = cr.Position;
            }
            else
            {
                SqlCommand c3 = new SqlCommand();
                c3.CommandText = "Update Tbltell set firstname = @p1 , lastname = @p2 , phoneno = @p3 , address = @p4 , picurl = @p6  where ID = @p5";
                c3.Parameters.AddWithValue("p1", txtname.Text);
                c3.Parameters.AddWithValue("p2", txtfamily.Text);
                c3.Parameters.AddWithValue("p3", txttell.Text);
                c3.Parameters.AddWithValue("p4", txtaddress.Text);
                c3.Parameters.AddWithValue("p5", txtID.Text);
                c3.Parameters.AddWithValue("p6", Copypic(pic1.ImageLocation, txtID.Text + txttell.Text));
                c3.Connection = conn;
                c3.ExecuteNonQuery();
                fillgrid();
                setcurrentrec(beforedit);
                txtname.ReadOnly = true;
                txtfamily.ReadOnly = true;
                txtaddress.ReadOnly = true;
                txttell.ReadOnly = true;
                BtnBrowse.Enabled = false;
                btnedit.Text = "Edit";
            }
        }
        /// <summary>
        /// This Code is for Btn Search and use Method fillgird
        /// این کد برای دکمه سرچ میباشد که از متد Fillgrid در آن استفاده شده
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string a;
            a = "select * from Tbltell where " + cmbfield.Text + " like '" + txtsearch.Text + "%'";
            fillgrid(a);
        }
        //This code is for dynamics search 
        //این کد برای پویایی در سرچ میباشد که هر دفعه لازم نباشد دکمه سرچ را بزنند
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(null, null);
        }
        //In this Event, we want to specify the current record and also specify the row in the grid
        //در این زیربرنامه میخواهیم رکورد جاری را مشخص کنیم وهمچنین در گرید سطر را مشخص کنیم
        void setcurrentrec(int currec)
        {
            if (currec < 0 || currec >= cr.Count)
                return;
            cr.Position = currec;
            dataGridView1.CurrentCell = dataGridView1.Rows[currec].Cells[dataGridView1.CurrentCell.ColumnIndex];
        }
        //For work Btn up & down in keyword 
        //برای کار کردن دگمه های بالا و پایین و نمایش درست اطلاعات در جعبه متن ها 
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            setcurrentrec(dataGridView1.CurrentCell.RowIndex);
        }
        //For choose Picture and display that
        //برای انتخاب کردن و نمایش دادن تصویر مورد نظر 
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult p;
            p =openFileDialog1.ShowDialog();
            if (p == DialogResult.Cancel)
                return;
            pic1.ImageLocation = openFileDialog1.FileName;
        }
        //For copy the picture you choose in a directory for keep it
        //برای ذخیره کردن تصویر در یک مسیر و نگه داری آن 
         string Copypic(string sourcefile , string key)
        {
            if (sourcefile == "") 
            return "";
            string curpath;
            string newpath;
            curpath = Application.StartupPath + @"\images\";
            if (Directory.Exists(curpath) == false)
                Directory.CreateDirectory(curpath);
            newpath = curpath + key + sourcefile.Substring(sourcefile.LastIndexOf("."));
            if (File.Exists(newpath) == true)
                File.Delete(newpath);
            File.Copy(sourcefile, newpath);
            return newpath;
        }
        //For click in picture and change size of picture 
        //برای کلیک روی عکس و تغییر سایز عکس 

        private void pic1_Click(object sender, EventArgs e)
        {
            if (pic1.SizeMode == PictureBoxSizeMode.StretchImage)
            {
                x = pic1.Region;
                pic1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else
            {
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                pic1.Region = x;

            }
            
        }

        private void pic1_MouseLeave(object sender, EventArgs e)
        {
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.Region = x;
        }
    }
}
