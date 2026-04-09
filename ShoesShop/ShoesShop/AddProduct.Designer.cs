namespace ShoesShop
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.dialog_file = new System.Windows.Forms.OpenFileDialog();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.tb_manu = new System.Windows.Forms.TextBox();
            this.cb_manu = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tb_unit = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.but_create = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tb_mess = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tb_art = new System.Windows.Forms.TextBox();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.cb_prov = new System.Windows.Forms.ComboBox();
            this.cb_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // dialog_file
            // 
            this.dialog_file.FileName = "Открытие изображения";
            this.dialog_file.InitialDirectory = "C:\\Users\\Bush\\source\\repos\\ShoesShop\\ShoesShop\\bin\\Debug\\img";
            this.dialog_file.FileOk += new System.ComponentModel.CancelEventHandler(this.dialog_file_FileOk);
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.Chartreuse;
            this.tb1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb1.Location = new System.Drawing.Point(275, 82);
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(117, 32);
            this.tb1.TabIndex = 1;
            this.tb1.TabStop = false;
            this.tb1.Text = "Название";
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 552);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(117, 32);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Описание";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_desc
            // 
            this.tb_desc.BackColor = System.Drawing.Color.White;
            this.tb_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_desc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_desc.Location = new System.Drawing.Point(11, 590);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(420, 94);
            this.tb_desc.TabIndex = 4;
            this.tb_desc.TabStop = false;
            this.tb_desc.TextChanged += new System.EventHandler(this.tb_category_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(11, 378);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(117, 32);
            this.textBox2.TabIndex = 5;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Категория";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_category
            // 
            this.cb_category.BackColor = System.Drawing.SystemColors.Info;
            this.cb_category.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(134, 378);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(420, 29);
            this.cb_category.TabIndex = 26;
            this.cb_category.TabStop = false;
            this.cb_category.Text = "<выбрать>";
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // tb_manu
            // 
            this.tb_manu.BackColor = System.Drawing.Color.Chartreuse;
            this.tb_manu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_manu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_manu.Location = new System.Drawing.Point(11, 434);
            this.tb_manu.Name = "tb_manu";
            this.tb_manu.ReadOnly = true;
            this.tb_manu.Size = new System.Drawing.Size(155, 32);
            this.tb_manu.TabIndex = 27;
            this.tb_manu.TabStop = false;
            this.tb_manu.Text = "Производитель";
            this.tb_manu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_manu
            // 
            this.cb_manu.BackColor = System.Drawing.SystemColors.Info;
            this.cb_manu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_manu.FormattingEnabled = true;
            this.cb_manu.Location = new System.Drawing.Point(172, 437);
            this.cb_manu.Name = "cb_manu";
            this.cb_manu.Size = new System.Drawing.Size(382, 29);
            this.cb_manu.TabIndex = 28;
            this.cb_manu.TabStop = false;
            this.cb_manu.Text = "<выбрать>";
            this.cb_manu.SelectedIndexChanged += new System.EventHandler(this.cb_manu_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(275, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(117, 32);
            this.textBox3.TabIndex = 29;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Поставщик";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(11, 499);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(208, 32);
            this.textBox4.TabIndex = 31;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Единица измерения";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_unit
            // 
            this.tb_unit.BackColor = System.Drawing.Color.White;
            this.tb_unit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_unit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_unit.Location = new System.Drawing.Point(225, 500);
            this.tb_unit.Name = "tb_unit";
            this.tb_unit.Size = new System.Drawing.Size(114, 32);
            this.tb_unit.TabIndex = 32;
            this.tb_unit.TabStop = false;
            this.tb_unit.TextChanged += new System.EventHandler(this.tb_unit_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(275, 241);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(117, 32);
            this.textBox5.TabIndex = 33;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Цена";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_price
            // 
            this.tb_price.BackColor = System.Drawing.Color.Snow;
            this.tb_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_price.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_price.Location = new System.Drawing.Point(398, 241);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(114, 32);
            this.tb_price.TabIndex = 34;
            this.tb_price.TabStop = false;
            this.tb_price.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.tb_price.Leave += new System.EventHandler(this.tb_price_Leave);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(275, 279);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(117, 32);
            this.textBox7.TabIndex = 35;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Скидка";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_discount
            // 
            this.tb_discount.BackColor = System.Drawing.Color.Snow;
            this.tb_discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_discount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_discount.Location = new System.Drawing.Point(398, 280);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.Size = new System.Drawing.Size(114, 32);
            this.tb_discount.TabIndex = 36;
            this.tb_discount.TabStop = false;
            this.tb_discount.TextChanged += new System.EventHandler(this.tb_discount_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(428, 500);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(207, 32);
            this.textBox8.TabIndex = 37;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Кол-во на складе";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_count
            // 
            this.tb_count.BackColor = System.Drawing.Color.Snow;
            this.tb_count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_count.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_count.Location = new System.Drawing.Point(641, 501);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(114, 32);
            this.tb_count.TabIndex = 38;
            this.tb_count.TabStop = false;
            this.tb_count.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // but_create
            // 
            this.but_create.BackColor = System.Drawing.Color.Maroon;
            this.but_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_create.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_create.ForeColor = System.Drawing.Color.White;
            this.but_create.Location = new System.Drawing.Point(641, 638);
            this.but_create.Name = "but_create";
            this.but_create.Size = new System.Drawing.Size(160, 46);
            this.but_create.TabIndex = 39;
            this.but_create.Text = "Создать";
            this.but_create.UseVisualStyleBackColor = false;
            this.but_create.Click += new System.EventHandler(this.but_create_Click);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox10.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox10.Location = new System.Drawing.Point(172, 12);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(428, 50);
            this.textBox10.TabIndex = 40;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Добавление товара";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mess
            // 
            this.tb_mess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_mess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_mess.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_mess.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_mess.ForeColor = System.Drawing.Color.DarkRed;
            this.tb_mess.Location = new System.Drawing.Point(11, 693);
            this.tb_mess.Name = "tb_mess";
            this.tb_mess.Size = new System.Drawing.Size(786, 25);
            this.tb_mess.TabIndex = 41;
            this.tb_mess.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(275, 129);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(117, 32);
            this.textBox6.TabIndex = 42;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Артикул";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_art
            // 
            this.tb_art.BackColor = System.Drawing.Color.White;
            this.tb_art.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_art.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_art.Location = new System.Drawing.Point(399, 129);
            this.tb_art.Name = "tb_art";
            this.tb_art.Size = new System.Drawing.Size(399, 32);
            this.tb_art.TabIndex = 43;
            this.tb_art.TabStop = false;
            this.tb_art.TextChanged += new System.EventHandler(this.tb_art_TextChanged);
            // 
            // pb_img
            // 
            this.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_img.Image = global::ShoesShop.Properties.Resources.picture;
            this.pb_img.Location = new System.Drawing.Point(12, 82);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(257, 229);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img.TabIndex = 0;
            this.pb_img.TabStop = false;
            this.pb_img.DoubleClick += new System.EventHandler(this.pb_img_DoubleClick);
            // 
            // cb_prov
            // 
            this.cb_prov.BackColor = System.Drawing.SystemColors.Info;
            this.cb_prov.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_prov.FormattingEnabled = true;
            this.cb_prov.Location = new System.Drawing.Point(398, 182);
            this.cb_prov.Name = "cb_prov";
            this.cb_prov.Size = new System.Drawing.Size(420, 29);
            this.cb_prov.TabIndex = 44;
            this.cb_prov.TabStop = false;
            this.cb_prov.Text = "<выбрать>";
            this.cb_prov.SelectedIndexChanged += new System.EventHandler(this.cb_prov_SelectedIndexChanged);
            // 
            // cb_name
            // 
            this.cb_name.BackColor = System.Drawing.SystemColors.Info;
            this.cb_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(398, 82);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(420, 29);
            this.cb_name.TabIndex = 46;
            this.cb_name.TabStop = false;
            this.cb_name.Text = "<выбрать>";
            this.cb_name.SelectedIndexChanged += new System.EventHandler(this.cb_name_SelectedIndexChanged);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(827, 737);
            this.Controls.Add(this.cb_name);
            this.Controls.Add(this.cb_prov);
            this.Controls.Add(this.tb_art);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.tb_mess);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.but_create);
            this.Controls.Add(this.tb_count);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.tb_discount);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tb_unit);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cb_manu);
            this.Controls.Add(this.tb_manu);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.pb_img);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.Text = "ООО \"Обувь\" - Добавление товара";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddProduct_FormClosed);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dialog_file;
        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.TextBox tb_manu;
        private System.Windows.Forms.ComboBox cb_manu;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tb_unit;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tb_discount;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.Button but_create;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox tb_mess;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tb_art;
        private System.Windows.Forms.ComboBox cb_prov;
        private System.Windows.Forms.ComboBox cb_name;
    }
}