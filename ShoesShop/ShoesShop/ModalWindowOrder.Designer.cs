namespace ShoesShop
{
    partial class ModalWindowOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalWindowOrder));
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_ok = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.but_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_cancel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_cancel.ForeColor = System.Drawing.Color.White;
            this.but_cancel.Location = new System.Drawing.Point(358, 230);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(93, 36);
            this.but_cancel.TabIndex = 7;
            this.but_cancel.Text = "Oтмена";
            this.but_cancel.UseVisualStyleBackColor = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_ok
            // 
            this.but_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_ok.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_ok.ForeColor = System.Drawing.Color.White;
            this.but_ok.Location = new System.Drawing.Point(10, 230);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(84, 36);
            this.but_ok.TabIndex = 6;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = false;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(95, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(255, 32);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Предупреждение!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_info
            // 
            this.tb_info.BackColor = System.Drawing.Color.White;
            this.tb_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_info.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_info.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_info.Location = new System.Drawing.Point(11, 67);
            this.tb_info.Multiline = true;
            this.tb_info.Name = "tb_info";
            this.tb_info.ReadOnly = true;
            this.tb_info.Size = new System.Drawing.Size(440, 143);
            this.tb_info.TabIndex = 5;
            this.tb_info.TabStop = false;
            this.tb_info.Text = "Вы пытаетесь выполнить неотвратимое действие: удалить заказ";
            this.tb_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModalWindowOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 284);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.tb_info);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModalWindowOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Обувь\" - Предупреждение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModalWindowOrder_FormClosed);
            this.Load += new System.EventHandler(this.ModalWindowOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_info;
    }
}