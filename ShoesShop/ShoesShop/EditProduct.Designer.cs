namespace ShoesShop
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            this.tb_art = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tb_mess = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.but_create = new System.Windows.Forms.Button();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tb_unit = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cb_manu = new System.Windows.Forms.ComboBox();
            this.tb_manu = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.dialog_file = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.cb_prov = new System.Windows.Forms.ComboBox();
            this.cb_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_art
            // 
            this.tb_art.BackColor = System.Drawing.Color.White;
            this.tb_art.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_art.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_art.Location = new System.Drawing.Point(396, 152);
            this.tb_art.Name = "tb_art";
            this.tb_art.Size = new System.Drawing.Size(399, 32);
            this.tb_art.TabIndex = 67;
            this.tb_art.TabStop = false;
            this.tb_art.TextChanged += new System.EventHandler(this.tb_art_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(269, 152);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(117, 32);
            this.textBox6.TabIndex = 66;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Артикул";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mess
            // 
            this.tb_mess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_mess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_mess.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_mess.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_mess.ForeColor = System.Drawing.Color.DarkRed;
            this.tb_mess.Location = new System.Drawing.Point(5, 712);
            this.tb_mess.Name = "tb_mess";
            this.tb_mess.Size = new System.Drawing.Size(786, 25);
            this.tb_mess.TabIndex = 65;
            this.tb_mess.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox10.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox10.Location = new System.Drawing.Point(245, 7);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(542, 50);
            this.textBox10.TabIndex = 64;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Редактирование товара";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // but_create
            // 
            this.but_create.BackColor = System.Drawing.Color.Green;
            this.but_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_create.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_create.ForeColor = System.Drawing.Color.White;
            this.but_create.Location = new System.Drawing.Point(635, 657);
            this.but_create.Name = "but_create";
            this.but_create.Size = new System.Drawing.Size(160, 46);
            this.but_create.TabIndex = 63;
            this.but_create.Text = "Применить";
            this.but_create.UseVisualStyleBackColor = false;
            this.but_create.Click += new System.EventHandler(this.but_create_Click);
            // 
            // tb_count
            // 
            this.tb_count.BackColor = System.Drawing.Color.Snow;
            this.tb_count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_count.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_count.Location = new System.Drawing.Point(635, 520);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(114, 32);
            this.tb_count.TabIndex = 62;
            this.tb_count.TabStop = false;
            this.tb_count.TextChanged += new System.EventHandler(this.tb_count_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(422, 519);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(207, 32);
            this.textBox8.TabIndex = 61;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Кол-во на складе";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_discount
            // 
            this.tb_discount.BackColor = System.Drawing.Color.Snow;
            this.tb_discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_discount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_discount.Location = new System.Drawing.Point(392, 299);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.Size = new System.Drawing.Size(114, 32);
            this.tb_discount.TabIndex = 60;
            this.tb_discount.TabStop = false;
            this.tb_discount.TextChanged += new System.EventHandler(this.tb_discount_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(269, 298);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(117, 32);
            this.textBox7.TabIndex = 59;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Скидка";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_price
            // 
            this.tb_price.BackColor = System.Drawing.Color.Snow;
            this.tb_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_price.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_price.Location = new System.Drawing.Point(392, 260);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(114, 32);
            this.tb_price.TabIndex = 58;
            this.tb_price.TabStop = false;
            this.tb_price.TextChanged += new System.EventHandler(this.tb_price_TextChanged);
            this.tb_price.Leave += new System.EventHandler(this.tb_price_Leave);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(269, 260);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(117, 32);
            this.textBox5.TabIndex = 57;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Цена";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_unit
            // 
            this.tb_unit.BackColor = System.Drawing.Color.White;
            this.tb_unit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_unit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_unit.Location = new System.Drawing.Point(219, 519);
            this.tb_unit.Name = "tb_unit";
            this.tb_unit.Size = new System.Drawing.Size(114, 32);
            this.tb_unit.TabIndex = 56;
            this.tb_unit.TabStop = false;
            this.tb_unit.TextChanged += new System.EventHandler(this.tb_unit_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(5, 518);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(208, 32);
            this.textBox4.TabIndex = 55;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Единица измерения";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(269, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(117, 32);
            this.textBox3.TabIndex = 53;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Поставщик";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_manu
            // 
            this.cb_manu.BackColor = System.Drawing.SystemColors.Info;
            this.cb_manu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_manu.FormattingEnabled = true;
            this.cb_manu.Location = new System.Drawing.Point(166, 456);
            this.cb_manu.Name = "cb_manu";
            this.cb_manu.Size = new System.Drawing.Size(382, 29);
            this.cb_manu.TabIndex = 52;
            this.cb_manu.TabStop = false;
            this.cb_manu.Text = "<выбрать>";
            this.cb_manu.SelectedIndexChanged += new System.EventHandler(this.cb_manu_SelectedIndexChanged);
            // 
            // tb_manu
            // 
            this.tb_manu.BackColor = System.Drawing.Color.Chartreuse;
            this.tb_manu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_manu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_manu.Location = new System.Drawing.Point(5, 453);
            this.tb_manu.Name = "tb_manu";
            this.tb_manu.ReadOnly = true;
            this.tb_manu.Size = new System.Drawing.Size(155, 32);
            this.tb_manu.TabIndex = 51;
            this.tb_manu.TabStop = false;
            this.tb_manu.Text = "Производитель";
            this.tb_manu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_category
            // 
            this.cb_category.BackColor = System.Drawing.SystemColors.Info;
            this.cb_category.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(128, 397);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(420, 29);
            this.cb_category.TabIndex = 50;
            this.cb_category.TabStop = false;
            this.cb_category.Text = "<выбрать>";
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(5, 397);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(117, 32);
            this.textBox2.TabIndex = 49;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Категория";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_desc
            // 
            this.tb_desc.BackColor = System.Drawing.Color.White;
            this.tb_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_desc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_desc.Location = new System.Drawing.Point(5, 609);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(420, 94);
            this.tb_desc.TabIndex = 48;
            this.tb_desc.TabStop = false;
            this.tb_desc.TextChanged += new System.EventHandler(this.tb_desc_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(6, 571);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(117, 32);
            this.textBox1.TabIndex = 46;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Описание";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.Chartreuse;
            this.tb1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb1.Location = new System.Drawing.Point(269, 101);
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(117, 32);
            this.tb1.TabIndex = 45;
            this.tb1.TabStop = false;
            this.tb1.Text = "Название";
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(5, 63);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(77, 32);
            this.textBox9.TabIndex = 68;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "ID";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.Snow;
            this.tb_id.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_id.Location = new System.Drawing.Point(88, 63);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(77, 32);
            this.tb_id.TabIndex = 69;
            this.tb_id.TabStop = false;
            // 
            // dialog_file
            // 
            this.dialog_file.FileName = "Открытие изображения";
            this.dialog_file.InitialDirectory = "C:\\Users\\Bush\\source\\repos\\ShoesShop\\ShoesShop\\bin\\Debug\\img";
            this.dialog_file.FileOk += new System.ComponentModel.CancelEventHandler(this.dialog_file_FileOk);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(5, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 46);
            this.button1.TabIndex = 70;
            this.button1.Text = "Удалить товар";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_img
            // 
            this.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_img.Image = global::ShoesShop.Properties.Resources.picture;
            this.pb_img.Location = new System.Drawing.Point(6, 101);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(257, 229);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img.TabIndex = 44;
            this.pb_img.TabStop = false;
            this.pb_img.DoubleClick += new System.EventHandler(this.pb_img_DoubleClick);
            // 
            // cb_prov
            // 
            this.cb_prov.BackColor = System.Drawing.SystemColors.Info;
            this.cb_prov.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_prov.FormattingEnabled = true;
            this.cb_prov.Location = new System.Drawing.Point(392, 203);
            this.cb_prov.Name = "cb_prov";
            this.cb_prov.Size = new System.Drawing.Size(420, 29);
            this.cb_prov.TabIndex = 71;
            this.cb_prov.TabStop = false;
            this.cb_prov.Text = "<выбрать>";
            this.cb_prov.SelectedIndexChanged += new System.EventHandler(this.cb_prov_SelectedIndexChanged);
            // 
            // cb_name
            // 
            this.cb_name.BackColor = System.Drawing.SystemColors.Info;
            this.cb_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(392, 101);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(420, 29);
            this.cb_name.TabIndex = 72;
            this.cb_name.TabStop = false;
            this.cb_name.Text = "<выбрать>";
            this.cb_name.SelectedIndexChanged += new System.EventHandler(this.cb_name_SelectedIndexChanged);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(823, 745);
            this.Controls.Add(this.cb_name);
            this.Controls.Add(this.cb_prov);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.textBox9);
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
            this.Name = "EditProduct";
            this.Text = "ООО \"Обувь\" - Редактирование товара";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditProduct_FormClosed);
            this.Load += new System.EventHandler(this.EditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_art;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tb_mess;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button but_create;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox tb_discount;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tb_unit;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cb_manu;
        private System.Windows.Forms.TextBox tb_manu;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.OpenFileDialog dialog_file;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_prov;
        private System.Windows.Forms.ComboBox cb_name;
    }
}