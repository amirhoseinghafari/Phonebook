namespace phonebook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbfield = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.Location = new System.Drawing.Point(126, 29);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(342, 28);
            this.txtname.TabIndex = 1;
            // 
            // txtfamily
            // 
            this.txtfamily.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtfamily.Location = new System.Drawing.Point(126, 84);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.ReadOnly = true;
            this.txtfamily.Size = new System.Drawing.Size(342, 28);
            this.txtfamily.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Family :";
            // 
            // txttell
            // 
            this.txttell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txttell.Location = new System.Drawing.Point(126, 142);
            this.txttell.Name = "txttell";
            this.txttell.ReadOnly = true;
            this.txttell.Size = new System.Drawing.Size(342, 28);
            this.txttell.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(25, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tell :";
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtaddress.Location = new System.Drawing.Point(126, 188);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(342, 103);
            this.txtaddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(25, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address :";
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnew.Location = new System.Drawing.Point(41, 331);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(100, 41);
            this.btnnew.TabIndex = 8;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndel.Location = new System.Drawing.Point(368, 331);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(100, 41);
            this.btndel.TabIndex = 9;
            this.btndel.Text = "Del";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnedit.Location = new System.Drawing.Point(256, 331);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 41);
            this.btnedit.TabIndex = 10;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsave.Location = new System.Drawing.Point(149, 331);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 41);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnext.Location = new System.Drawing.Point(149, 387);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(100, 41);
            this.btnnext.TabIndex = 15;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnpre
            // 
            this.btnpre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnpre.Location = new System.Drawing.Point(256, 387);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(100, 41);
            this.btnpre.TabIndex = 14;
            this.btnpre.Text = "Pre...";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnlast
            // 
            this.btnlast.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnlast.Location = new System.Drawing.Point(368, 387);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(100, 41);
            this.btnlast.TabIndex = 13;
            this.btnlast.Text = "Last";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnfirst.Location = new System.Drawing.Point(41, 387);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(100, 41);
            this.btnfirst.TabIndex = 12;
            this.btnfirst.Text = "First";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(710, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Search By :";
            // 
            // cmbfield
            // 
            this.cmbfield.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbfield.FormattingEnabled = true;
            this.cmbfield.Location = new System.Drawing.Point(829, 28);
            this.cmbfield.Name = "cmbfield";
            this.cmbfield.Size = new System.Drawing.Size(180, 29);
            this.cmbfield.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(710, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Search For :";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtsearch.Location = new System.Drawing.Point(829, 63);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(216, 28);
            this.txtsearch.TabIndex = 19;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsearch.Location = new System.Drawing.Point(770, 97);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(124, 41);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(494, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 280);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(474, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID :";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtID.Location = new System.Drawing.Point(525, 33);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(86, 28);
            this.txtID.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 440);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbfield);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnpre);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfamily);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbfield;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
    }
}

