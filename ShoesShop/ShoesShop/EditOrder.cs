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
    public partial class EditOrder : Form
    {
        public EditOrder(Orders F, int ID, string userLogin)
        {
            InitializeComponent();
            this.F = F;
            this.ID = ID;
            this.userLogin = userLogin;
        }

        Orders F; int ID; int k1; int k2;

        string art; DateTime dateOrder; DateTime dateShip; string[] address;

        int cb_stat_isel = -1; int cb_add_isel = -1; string userLogin;

        List<string> statuts = new List<string>(); List<string> addresses = new List<string>();

        private void EditOrder_Load(object sender, EventArgs e)
        {
            art = DataBase.GetDataFromDB($"SELECT Article FROM dbo.Orders WHERE ID = {ID}").Rows[0][0].ToString();
            tb_id.Text = ID.ToString();
            dateOrder = Convert.ToDateTime(DataBase.GetDataFromDB($"SELECT OrderDate FROM dbo.Orders WHERE ID = {ID}").Rows[0][0].ToString());
            dateShip = Convert.ToDateTime(DataBase.GetDataFromDB($"SELECT ShipDate FROM dbo.Orders WHERE ID = {ID}").Rows[0][0].ToString());

            DataTable dstat = DataBase.GetDataFromDB("SELECT DISTINCT Status FROM dbo.Orders");
            string statusID = DataBase.GetDataFromDB($"SELECT Status FROM dbo.Orders WHERE ID = {ID}").Rows[0][0].ToString();
            foreach (DataRow dr in dstat.Rows)
            {
                string s = dr["Status"].ToString();
                if (s == statusID) { cb_stat_isel = k2; }
                cb_status.Items.Add(s);
                statuts.Add(s);
                k2++;
            }
            cb_status.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable dadd = DataBase.GetDataFromDB($"SELECT STR(Postcode, 6) + ': ' + City + ', ' + Street + STR(Home, 3) AS Address, ID FROM dbo.Points");
            int addressID = Convert.ToInt32(DataBase.GetDataFromDB($"SELECT PointID FROM dbo.Orders WHERE ID = {ID}").Rows[0][0].ToString());
            foreach (DataRow dr in dadd.Rows)
            {
                int id = Convert.ToInt32(dr["ID"].ToString());
                if (id == addressID) { cb_add_isel = k1; }
                string s = dr["Address"].ToString();
                cb_address.Items.Add(s);
                addresses.Add(s);
                k1++;
            }
            cb_address.SelectedIndex = cb_add_isel;
            cb_status.SelectedIndex = cb_stat_isel;

            tb_art.Text = art;

            tb_order_d.Text = dateOrder.Day.ToString(); tb_ship_d.Text = dateShip.Day.ToString();
            tb_order_m.Text = dateOrder.Month.ToString(); tb_ship_m.Text = dateShip.Month.ToString();
            tb_order_y.Text = dateOrder.Year.ToString(); tb_ship_y.Text = dateShip.Year.ToString();

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
            if (cb_add_isel == -1 || cb_stat_isel == -1 || art == null || tb_dateship.Text == "" || tb_dateorder.Text == "")
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


        // Обработчик артикула
        private void tb_art_TextChanged(object sender, EventArgs e)
        {
            CheckStr(tb_art, tb_mess, out art); CheckAll();
        }



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



        private void EditOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            F.Enabled = true; F.RE();
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_stat_isel = cb_status.SelectedIndex; CheckAll(); cb_status.ForeColor = Color.Black;
        }

        private void cb_address_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_add_isel = cb_address.SelectedIndex; CheckAll(); address = null; if (cb_add_isel == -1) { tb_mess.Text = ""; }
            cb_address.ForeColor = Color.Black;
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


        // Кнопка изменения
        private void but_create_Click(object sender, EventArgs e)
        {
            int addressID;

            string dO = dateOrder.ToString("yyyy-MM-dd");
            string dS = dateShip.ToString("yyyy-MM-dd");

            string status = statuts[cb_stat_isel];
            int userID = Convert.ToInt32(DataBase.GetDataFromDB($"SELECT ID FROM dbo.Users WHERE Login = '{userLogin}'").Rows[0][0].ToString());
            int code = Convert.ToInt32(DataBase.GetDataFromDB("SELECT TOP 1 Code FROM dbo.Orders ORDER BY Code DESC").Rows[0][0].ToString()) + 1;
            if (address != null)
            {
                addressID = Convert.ToInt32(DataBase.GetDataFromDB("SELECT TOP 1 ID FROM dbo.Points ORDER BY ID DESC").Rows[0][0].ToString()) + 1;
                DataBase.EditDataFromDB($"INSERT INTO dbo.Points VALUES ({addressID}, {Convert.ToInt32(address[0])}, N'{address[1]}', N'{address[2]}', {Convert.ToInt32(address[3])})");

                DataBase.EditDataFromDB($"UPDATE dbo.Orders SET Article = '{art}', OrderDate = '{dO}', ShipDate = '{dS}', PointID = {addressID}, UserID = {userID}, Code = {code}, Status = N'{status}' WHERE ID = {ID}");
                MessageBox.Show($"Вы успешно изменили заказ №{ID}", "Успешное изменение"); F.RE(); Close();
            }
            else
            {
                DataTable dt = DataBase.GetDataFromDB("SELECT * FROM dbo.Points");
                addressID = Convert.ToInt32(dt.Rows[cb_add_isel]["ID"].ToString());

                DataBase.EditDataFromDB($"UPDATE dbo.Orders SET Article = '{art}', OrderDate = '{dO}', ShipDate = '{dS}', PointID = {addressID}, UserID = {userID}, Code = {code}, Status = N'{status}' WHERE ID = {ID}");
                MessageBox.Show($"Вы успешно изменили заказ №{ID}", "Успешное изменение"); F.RE(); Close();
            }
        }


        // Кнопка удаления заказа
        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(tb_id.Text);
            ModalWindowOrder M = new ModalWindowOrder(this, ID); this.Enabled = false;
            M.Show();
        }
    }
}
