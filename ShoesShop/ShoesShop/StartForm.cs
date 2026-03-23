using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesShop
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        Guests g = new Guests("", "", ""); // Текущие вводимые данные

        private void StartForm_Load(object sender, EventArgs e)
        {

        }



        private void but_enter_Click(object sender, EventArgs e)
        {
            Users u1 = new Admin(t_admin, tb_message);
            Users u2 = new Manager(t_manager, tb_message);
            Users u3 = new Clients(t_client, tb_message);
            Users u4 = new Guests(tb_message);

            u1.LowerAccess(u2);
            u2.LowerAccess(u3);
            u3.LowerAccess(u4);

            g = new Guests("", tb_login.Text, tb_password.Text);
            u1.Enter(g);
        }





        // Показ-скрытие пароля
        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb.Checked)
            {
                tb_password.PasswordChar = '\0';
            }
            else
            {
                tb_password.PasswordChar = '•';
            }
        }



        // Таймеры запуска главной формы с соответствующей ролью и именем
        private void t_admin_Tick(object sender, EventArgs e)
        {
            t_admin.Enabled = false;
            Hide(); MainForm F = new MainForm(g.name, "Администратор", g.Login);
            F.Show();
        }

        private void t_manager_Tick(object sender, EventArgs e)
        {
            t_manager.Enabled = false;
            Hide(); MainForm F = new MainForm(g.name, "Менеджер", g.Login);
            F.Show();
        }

        private void t_client_Tick(object sender, EventArgs e)
        {
            t_client.Enabled = false;
            Hide(); MainForm F = new MainForm(g.name, "Клиент", g.Login);
            F.Show();
        }

        private void t_guest_Tick(object sender, EventArgs e)
        {
            t_guest.Enabled = false;
            Hide(); MainForm F = new MainForm(" - ", "Гость", g.Login); 
            F.Show();
        }


        // Кнопка гостевого режима
        private void b_guest_Click(object sender, EventArgs e)
        {
            tb_message.Text = "Переход в гостевой режим..."; tb_message.ForeColor = Color.Orange;
            t_guest.Enabled = true; but_enter.Enabled = false;
        }



        // При изменении сообщение скрывать
        private void tb_login_TextChanged(object sender, EventArgs e)
        {
            tb_message.Clear();
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            tb_message.Clear();
        }


        // Закрытие формы = остановка программы
        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
