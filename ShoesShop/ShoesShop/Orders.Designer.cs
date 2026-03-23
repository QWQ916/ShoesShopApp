namespace ShoesShop
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.but_exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.but_edit = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // but_exit
            // 
            this.but_exit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.but_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_exit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_exit.ForeColor = System.Drawing.Color.White;
            this.but_exit.Location = new System.Drawing.Point(13, 118);
            this.but_exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(117, 46);
            this.but_exit.TabIndex = 22;
            this.but_exit.Text = "Назад";
            this.but_exit.UseVisualStyleBackColor = false;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(420, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(293, 50);
            this.textBox1.TabIndex = 23;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Заказы";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(156, 118);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(861, 719);
            this.dg.TabIndex = 24;
            this.dg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellDoubleClick);
            // 
            // but_edit
            // 
            this.but_edit.BackColor = System.Drawing.Color.Chartreuse;
            this.but_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_edit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_edit.ForeColor = System.Drawing.Color.Black;
            this.but_edit.Location = new System.Drawing.Point(156, 843);
            this.but_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(184, 46);
            this.but_edit.TabIndex = 25;
            this.but_edit.TabStop = false;
            this.but_edit.Text = "Добавить";
            this.but_edit.UseVisualStyleBackColor = false;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
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
            this.pb_logo.TabIndex = 21;
            this.pb_logo.TabStop = false;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 968);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.pb_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orders";
            this.Text = "ООО \"Обувь\"  - Страница заказов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Orders_FormClosed);
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button but_edit;
    }
}