using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ShoesShop
{
    public partial class AddOrder : Form
    {
        public AddOrder(Orders F, string userLogin)
        {
            InitializeComponent(); this.F = F; this.userLogin = userLogin;
        }

        Orders F; string userLogin;

        string art; DateTime dateOrder; DateTime dateShip; string[] address;

        int cb_stat_isel = -1; int cb_add_isel = -1;

        List<string> statuts = new List<string>(); List<string> addresses = new List<string>();

        private void AddOrder_Load(object sender, EventArgs e)
        {
            DataTable dstat = DataBase.GetDataFromDB("SELECT DISTINCT Status FROM dbo.Orders");
            foreach (DataRow dr in dstat.Rows)
            {
                string s = dr["Status"].ToString();
                cb_status.Items.Add(s);
                statuts.Add(s);
            }
            cb_status.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable dadd = DataBase.GetDataFromDB($"SELECT STR(Postcode, 6) + ': ' + City + ', ' + Street + STR(Home, 3) AS Address FROM dbo.Points");
            foreach (DataRow dr in dadd.Rows)
            {
                string s = dr["Address"].ToString();
                cb_address.Items.Add(s);
                addresses.Add(s);
            }

            CheckAll();
        }


        public void CheckDateOrder()
        {
            try
            {
                int d = Convert.ToInt32(tb_order_d.Text);
                int m = Convert.ToInt32(tb_order_m.Text);
                int y = Convert.ToInt32(tb_order_y.Text);

                dateOrder = new DateTime(y, m, d);
                tb_dateorder.Text = dateOrder.ToString();
                tb_order_d.BackColor = Color.FromArgb(192, 255, 192); tb_order_m.BackColor = Color.FromArgb(192, 255, 192); tb_order_y.BackColor = Color.FromArgb(192, 255, 192);
                tb_mess.Text = "";
            }
            catch
            {
                tb_mess.Text = "Неправильный формат даты заказа или дозаполните поле!";
                tb_dateorder.Text = "";
                tb_order_d.BackColor = Color.FromArgb(255, 192, 192); tb_order_m.BackColor = Color.FromArgb(255, 192, 192); tb_order_y.BackColor = Color.FromArgb(255, 192, 192);
            }
        }

        public void CheckDateShip()
        {
            try
            {
                int d = Convert.ToInt32(tb_ship_d.Text);
                int m = Convert.ToInt32(tb_ship_m.Text);
                int y = Convert.ToInt32(tb_ship_y.Text);

                dateShip = new DateTime(y, m, d);
                tb_dateship.Text = dateShip.ToString();
                tb_ship_d.BackColor = Color.FromArgb(192, 255, 192); tb_ship_m.BackColor = Color.FromArgb(192, 255, 192); tb_ship_y.BackColor = Color.FromArgb(192, 255, 192);
                tb_mess.Text = "";
            }
            catch
            {
                tb_mess.Text = "Неправильный формат даты доставки или дозаполните поле!";
                tb_dateship.Text = "";
                tb_ship_d.BackColor = Color.FromArgb(255, 192, 192); tb_ship_m.BackColor = Color.FromArgb(255, 192, 192); tb_ship_y.BackColor = Color.FromArgb(255, 192, 192);
            }
        }





        public void CheckStr(TextBox tb, TextBox ms, out string v)
        {
            string val = tb.Text; v = null;
            if (val == "")
            {
                ms.Text = "Данное свойство не может быть пустым!"; tb.ForeColor = Color.DarkRed;
            }
            else
            {
                ms.Text = "";
                tb.ForeColor = Color.DarkGreen;
                v = val;
            }
            CheckAll();
        }


        public void CheckAll()
        {
            if ( cb_add_isel == -1 || cb_stat_isel == -1 || art == null || tb_dateship.Text == "" || tb_dateorder.Text == "")
            {
                But(false);
            }
            else
            {
                But(true);
            }
        }

        public void But(bool b)
        {
            but_create.Enabled = b; but_create.Visible = b;
        }


        // Обработчики даты
        private void tb_order_d_TextChanged(object sender, EventArgs e)
        {
            CheckDateOrder(); CheckAll();
        }

        private void tb_order_m_TextChanged(object sender, EventArgs e)
        {
            CheckDateOrder(); CheckAll();
        }

        private void tb_order_y_TextChanged(object sender, EventArgs e)
        {
            CheckDateOrder(); CheckAll();
        }

        private void tb_ship_d_TextChanged(object sender, EventArgs e)
        {
            CheckDateShip(); CheckAll();
        }

        private void tb_ship_m_TextChanged(object sender, EventArgs e)
        {
            CheckDateShip(); CheckAll();
        }

        private void tb_ship_y_TextChanged(object sender, EventArgs e)
        {
            CheckDateShip(); CheckAll();
        }



        // Обработчик артикула
        private void tb_art_TextChanged(object sender, EventArgs e)
        {
            CheckStr(tb_art, tb_mess, out art); CheckAll();
        }




        private void AddOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            F.Enabled = true;
        }

        private void cb_address_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_add_isel = cb_address.SelectedIndex; CheckAll(); address = null; if (cb_add_isel == -1) { tb_mess.Text = ""; }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_stat_isel = cb_status.SelectedIndex; CheckAll();
        }


        // Персональный адрес
        private void cb_address_TextUpdate(object sender, EventArgs e)
        {
            string[] s = cb_address.Text.Split(',');
            if (s.Length == 4)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    s[i] = s[i].Trim();
                }
                try
                {
                    int postcode = Convert.ToInt32(s[0]);
                    int house = Convert.ToInt32(s[3]);

                    address = s;
                    cb_add_isel = -2;
                    tb_mess.Text = "";
                    CheckAll();
                }
                catch
                {
                    tb_mess.Text = "Почтовый индекс и/или дом введены в неверном формате, должны быть в целочисленном значении!";
                    cb_add_isel = -1; CheckAll();
                }
            }
            else
            {
                cb_add_isel = -1;
                tb_mess.Text = "Неверный формат адреса, посмотрите формат в выпадающем вниз списке, или выберите адрес оттуда";
                CheckAll();
            }
        }





        // Кнопка создания
        private void but_create_Click(object sender, EventArgs e)
        {
            int addressID;
            string status = statuts[cb_stat_isel];

            string dO = dateOrder.ToString("yyyy-MM-dd");
            string dS = dateShip.ToString("yyyy-MM-dd");

            int userID = Convert.ToInt32(DataBase.GetDataFromDB($"SELECT ID FROM dbo.Users WHERE Login = '{userLogin}'").Rows[0][0].ToString());
            int newID = Convert.ToInt32(DataBase.GetDataFromDB("SELECT TOP 1 ID FROM dbo.Orders ORDER BY ID DESC").Rows[0][0].ToString()) + 1;
            int code = Convert.ToInt32(DataBase.GetDataFromDB("SELECT TOP 1 Code FROM dbo.Orders ORDER BY Code DESC").Rows[0][0].ToString()) + 1;
            if (address != null)
            {
                addressID = Convert.ToInt32(DataBase.GetDataFromDB("SELECT TOP 1 ID FROM dbo.Points ORDER BY ID DESC").Rows[0][0].ToString()) + 1;
                DataBase.EditDataFromDB($"INSERT INTO dbo.Points VALUES ({addressID}, {Convert.ToInt32(address[0])}, N'{address[1]}', N'{address[2]}', {Convert.ToInt32(address[3])})");

                DataBase.EditDataFromDB($"INSERT INTO dbo.Orders VALUES ({newID}, '{art}', '{dO}', '{dS}', {addressID}, {userID}, {code}, N'{status}')");
                MessageBox.Show($"Вы добавили успешно заказ №{newID}", "Успешное добавление"); F.RE(); Close();
            }
            else
            {
                DataTable dt = DataBase.GetDataFromDB("SELECT * FROM dbo.Points");
                addressID = Convert.ToInt32(dt.Rows[cb_add_isel]["ID"].ToString());

                DataBase.EditDataFromDB($"INSERT INTO dbo.Orders VALUES ({newID}, '{art}', '{dO}', '{dS}', {addressID}, {userID}, {code}, N'{status}')");
                MessageBox.Show($"Вы добавили успешно заказ №{newID}", "Успешное добавление"); F.RE(); Close();
            }
        }
    }
}
