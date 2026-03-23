namespace ShoesShop
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.cb = new System.Windows.Forms.CheckBox();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.but_enter = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b_guest = new System.Windows.Forms.Button();
            this.t_admin = new System.Windows.Forms.Timer(this.components);
            this.t_manager = new System.Windows.Forms.Timer(this.components);
            this.t_client = new System.Windows.Forms.Timer(this.components);
            this.t_guest = new System.Windows.Forms.Timer(this.components);
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb.Location = new System.Drawing.Point(682, 251);
            this.cb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(95, 23);
            this.cb.TabIndex = 15;
            this.cb.Text = "Показать";
            this.cb.UseVisualStyleBackColor = true;
            this.cb.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.White;
            this.tb_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_message.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_message.ForeColor = System.Drawing.Color.Black;
            this.tb_message.Location = new System.Drawing.Point(138, 280);
            this.tb_message.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.ReadOnly = true;
            this.tb_message.Size = new System.Drawing.Size(658, 55);
            this.tb_message.TabIndex = 14;
            this.tb_message.TabStop = false;
            this.tb_message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // but_enter
            // 
            this.but_enter.BackColor = System.Drawing.Color.Teal;
            this.but_enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_enter.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_enter.ForeColor = System.Drawing.Color.White;
            this.but_enter.Location = new System.Drawing.Point(372, 345);
            this.but_enter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.but_enter.Name = "but_enter";
            this.but_enter.Size = new System.Drawing.Size(192, 48);
            this.but_enter.TabIndex = 13;
            this.but_enter.Text = "Войти";
            this.but_enter.UseVisualStyleBackColor = false;
            this.but_enter.Click += new System.EventHandler(this.but_enter_Click);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_password.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(314, 209);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(481, 39);
            this.tb_password.TabIndex = 12;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // tb_login
            // 
            this.tb_login.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_login.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(314, 155);
            this.tb_login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(481, 39);
            this.tb_login.TabIndex = 11;
            this.tb_login.TextChanged += new System.EventHandler(this.tb_login_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Teal;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(138, 209);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(154, 39);
            this.textBox3.TabIndex = 10;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Пароль";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Teal;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(138, 155);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(154, 39);
            this.textBox2.TabIndex = 9;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Логин";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(339, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(258, 47);
            this.textBox1.TabIndex = 8;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Авторизация";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_guest
            // 
            this.b_guest.BackColor = System.Drawing.Color.White;
            this.b_guest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b_guest.FlatAppearance.BorderSize = 0;
            this.b_guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_guest.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_guest.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b_guest.Location = new System.Drawing.Point(314, 431);
            this.b_guest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b_guest.Name = "b_guest";
            this.b_guest.Size = new System.Drawing.Size(328, 34);
            this.b_guest.TabIndex = 17;
            this.b_guest.Text = "Продолжить как гость";
            this.b_guest.UseVisualStyleBackColor = false;
            this.b_guest.Click += new System.EventHandler(this.b_guest_Click);
            // 
            // t_admin
            // 
            this.t_admin.Interval = 2000;
            this.t_admin.Tick += new System.EventHandler(this.t_admin_Tick);
            // 
            // t_manager
            // 
            this.t_manager.Interval = 2000;
            this.t_manager.Tick += new System.EventHandler(this.t_manager_Tick);
            // 
            // t_client
            // 
            this.t_client.Interval = 2000;
            this.t_client.Tick += new System.EventHandler(this.t_client_Tick);
            // 
            // t_guest
            // 
            this.t_guest.Interval = 2000;
            this.t_guest.Tick += new System.EventHandler(this.t_guest_Tick);
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Image = global::ShoesShop.Properties.Resources.Icon;
            this.pb_logo.Location = new System.Drawing.Point(15, 13);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(117, 100);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 16;
            this.pb_logo.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 477);
            this.Controls.Add(this.b_guest);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.but_enter);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StartForm";
            this.Text = "Авторизация - OOO \"Обувь\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Button but_enter;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button b_guest;
        private System.Windows.Forms.Timer t_admin;
        private System.Windows.Forms.Timer t_manager;
        private System.Windows.Forms.Timer t_client;
        private System.Windows.Forms.Timer t_guest;
    }
}

