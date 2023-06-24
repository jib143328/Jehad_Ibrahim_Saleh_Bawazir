namespace Is_there_new_2
{
    partial class FRM_New_Add
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_Product = new System.Windows.Forms.TextBox();
            this.txtbx_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_Desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_Id = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Janna LT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "اسم المنتج";
            // 
            // txtbx_Product
            // 
            this.txtbx_Product.Font = new System.Drawing.Font("Janna LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Product.Location = new System.Drawing.Point(37, 146);
            this.txtbx_Product.Name = "txtbx_Product";
            this.txtbx_Product.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_Product.Size = new System.Drawing.Size(197, 32);
            this.txtbx_Product.TabIndex = 11;
            // 
            // txtbx_Price
            // 
            this.txtbx_Price.Font = new System.Drawing.Font("Janna LT", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Price.ForeColor = System.Drawing.Color.DimGray;
            this.txtbx_Price.Location = new System.Drawing.Point(37, 188);
            this.txtbx_Price.Name = "txtbx_Price";
            this.txtbx_Price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbx_Price.Size = new System.Drawing.Size(197, 28);
            this.txtbx_Price.TabIndex = 11;
            this.txtbx_Price.Text = "يرجى كتابة السعر مع العملة مثل 4500 ر.ي";
            this.txtbx_Price.Click += new System.EventHandler(this.txtbx_Price_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Janna LT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "سعر المنتج";
            // 
            // txtbx_Desc
            // 
            this.txtbx_Desc.Font = new System.Drawing.Font("Janna LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Desc.Location = new System.Drawing.Point(38, 223);
            this.txtbx_Desc.Multiline = true;
            this.txtbx_Desc.Name = "txtbx_Desc";
            this.txtbx_Desc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_Desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_Desc.Size = new System.Drawing.Size(197, 95);
            this.txtbx_Desc.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Janna LT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "وصف المنتج";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "إضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Janna LT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "رقم الصنف";
            // 
            // txtbx_Id
            // 
            this.txtbx_Id.Location = new System.Drawing.Point(150, 107);
            this.txtbx_Id.Multiline = true;
            this.txtbx_Id.Name = "txtbx_Id";
            this.txtbx_Id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbx_Id.Size = new System.Drawing.Size(84, 36);
            this.txtbx_Id.TabIndex = 18;
            this.txtbx_Id.Text = "يجب أن لا يكون الرقم مكرر";
            this.txtbx_Id.Click += new System.EventHandler(this.txtbx_Id_Click);
            // 
            // btn_close
            // 
            this.btn_close.AllowDrop = true;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::Is_there_new_2.Properties.Resources.space;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_close.FlatAppearance.BorderSize = 3;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.ForeColor = System.Drawing.Color.Gray;
            this.btn_close.Location = new System.Drawing.Point(335, 138);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(10, 57);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "button1";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Is_there_new_2.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 514);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(240, 34);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(51, 13);
            this.lbl_time.TabIndex = 19;
            this.lbl_time.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_New_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 514);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.txtbx_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_Desc);
            this.Controls.Add(this.txtbx_Price);
            this.Controls.Add(this.txtbx_Product);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_New_Add";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_New_Add";
            this.Load += new System.EventHandler(this.FRM_New_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_Product;
        private System.Windows.Forms.TextBox txtbx_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_Desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_Id;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
    }
}