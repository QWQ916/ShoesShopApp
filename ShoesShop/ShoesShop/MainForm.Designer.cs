namespace ShoesShop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_role = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.but_exit = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.but_edit = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cb_prov = new System.Windows.Forms.ComboBox();
            this.tb_sort = new System.Windows.Forms.TextBox();
            this.but_reset = new System.Windows.Forms.Button();
            this.but_orders = new System.Windows.Forms.Button();
            this.pb_sort = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(552, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(293, 50);
            this.textBox1.TabIndex = 9;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Меню товаров";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_role
            // 
            this.tb_role.BackColor = System.Drawing.Color.White;
            this.tb_role.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_role.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_role.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_role.Location = new System.Drawing.Point(943, 12);
            this.tb_role.Name = "tb_role";
            this.tb_role.ReadOnly = true;
            this.tb_role.Size = new System.Drawing.Size(372, 25);
            this.tb_role.TabIndex = 18;
            this.tb_role.TabStop = false;
            this.tb_role.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.White;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.ForeColor = System.Drawing.Color.Navy;
            this.tb_name.Location = new System.Drawing.Point(943, 37);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(372, 25);
            this.tb_name.TabIndex = 19;
            this.tb_name.TabStop = false;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // but_exit
            // 
            this.but_exit.BackColor = System.Drawing.Color.Maroon;
            this.but_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_exit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_exit.ForeColor = System.Drawing.Color.White;
            this.but_exit.Location = new System.Drawing.Point(13, 118);
            this.but_exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(117, 46);
            this.but_exit.TabIndex = 20;
            this.but_exit.Text = "Выйти";
            this.but_exit.UseVisualStyleBackColor = false;
            this.but_exit.Click += new System.EventHandler(this.but_enter_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(157, 156);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(1118, 622);
            this.dg.TabIndex = 21;
            this.dg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellDoubleClick);
            // 
            // but_edit
            // 
            this.but_edit.BackColor = System.Drawing.Color.Chartreuse;
            this.but_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_edit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_edit.ForeColor = System.Drawing.Color.Black;
            this.but_edit.Location = new System.Drawing.Point(157, 784);
            this.but_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(184, 46);
            this.but_edit.TabIndex = 22;
            this.but_edit.TabStop = false;
            this.but_edit.Text = "Добавить";
            this.but_edit.UseVisualStyleBackColor = false;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_search.Location = new System.Drawing.Point(552, 68);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(293, 29);
            this.tb_search.TabIndex = 24;
            this.tb_search.TabStop = false;
            this.tb_search.Text = "Поиск...";
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            this.tb_search.Enter += new System.EventHandler(this.tb_search_Enter);
            // 
            // cb_prov
            // 
            this.cb_prov.BackColor = System.Drawing.SystemColors.Info;
            this.cb_prov.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_prov.FormattingEnabled = true;
            this.cb_prov.Items.AddRange(new object[] {
            "Все поставщики..."});
            this.cb_prov.Location = new System.Drawing.Point(1033, 120);
            this.cb_prov.Name = "cb_prov";
            this.cb_prov.Size = new System.Drawing.Size(242, 30);
            this.cb_prov.TabIndex = 25;
            this.cb_prov.TabStop = false;
            this.cb_prov.Text = "Все поставщики...";
            this.cb_prov.SelectedIndexChanged += new System.EventHandler(this.cb_prov_SelectedIndexChanged);
            // 
            // tb_sort
            // 
            this.tb_sort.BackColor = System.Drawing.Color.White;
            this.tb_sort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_sort.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_sort.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_sort.Location = new System.Drawing.Point(242, 93);
            this.tb_sort.Multiline = true;
            this.tb_sort.Name = "tb_sort";
            this.tb_sort.ReadOnly = true;
            this.tb_sort.Size = new System.Drawing.Size(188, 46);
            this.tb_sort.TabIndex = 27;
            this.tb_sort.TabStop = false;
            this.tb_sort.Text = "Сортировка по\r\nКоличеству на складе";
            this.tb_sort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // but_reset
            // 
            this.but_reset.BackColor = System.Drawing.Color.Brown;
            this.but_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_reset.ForeColor = System.Drawing.Color.White;
            this.but_reset.Location = new System.Drawing.Point(619, 103);
            this.but_reset.Name = "but_reset";
            this.but_reset.Size = new System.Drawing.Size(161, 32);
            this.but_reset.TabIndex = 28;
            this.but_reset.Text = "Сбросить фильтры";
            this.but_reset.UseVisualStyleBackColor = false;
            this.but_reset.Click += new System.EventHandler(this.but_reset_Click);
            // 
            // but_orders
            // 
            this.but_orders.BackColor = System.Drawing.Color.DarkSlateGray;
            this.but_orders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_orders.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_orders.ForeColor = System.Drawing.Color.White;
            this.but_orders.Location = new System.Drawing.Point(1059, 784);
            this.but_orders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_orders.Name = "but_orders";
            this.but_orders.Size = new System.Drawing.Size(216, 46);
            this.but_orders.TabIndex = 29;
            this.but_orders.TabStop = false;
            this.but_orders.Text = "Страница заказов";
            this.but_orders.UseVisualStyleBackColor = false;
            this.but_orders.Click += new System.EventHandler(this.but_orders_Click);
            // 
            // pb_sort
            // 
            this.pb_sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pb_sort.Image = global::ShoesShop.Properties.Resources.cross;
            this.pb_sort.Location = new System.Drawing.Point(157, 80);
            this.pb_sort.Name = "pb_sort";
            this.pb_sort.Size = new System.Drawing.Size(79, 70);
            this.pb_sort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_sort.TabIndex = 26;
            this.pb_sort.TabStop = false;
            this.pb_sort.Click += new System.EventHandler(this.pb_sort_Click);
            this.pb_sort.DoubleClick += new System.EventHandler(this.pb_sort_DoubleClick);
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Image = global::ShoesShop.Properties.Resources.Icon;
            this.pb_logo.Location = new System.Drawing.Point(13, 12);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(117, 100);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 17;
            this.pb_logo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1293, 845);
            this.Controls.Add(this.but_orders);
            this.Controls.Add(this.but_reset);
            this.Controls.Add(this.tb_sort);
            this.Controls.Add(this.pb_sort);
            this.Controls.Add(this.cb_prov);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_role);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ООО \"Обувь\" - Товары";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.TextBox tb_role;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ComboBox cb_prov;
        private System.Windows.Forms.PictureBox pb_sort;
        private System.Windows.Forms.TextBox tb_sort;
        private System.Windows.Forms.Button but_reset;
        private System.Windows.Forms.Button but_orders;
    }
}