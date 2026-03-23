using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesShop
{
    public partial class Orders : Form
    {
        public Orders(MainForm F, string Role, string userLogin)
        {
            InitializeComponent();
            this.F = F; this.Role = Role; this.userLogin = userLogin;
        }

        MainForm F; string Role; string userLogin;

        private void Orders_Load(object sender, EventArgs e)
        {
            if (Role != "Администратор")
            {
                but_edit.Enabled = false; but_edit.Visible = false;
            }
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Информация";
            col1.Width = 500;
            col1.Name = "Info";

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Дата поставки";
            col2.Width = 300;
            col2.Name = "DateShip";


            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            headerStyle.BackColor = Color.FromArgb(127, 255, 0);
            headerStyle.ForeColor = Color.DarkGreen;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.EnableHeadersVisualStyles = false;
            dg.ColumnHeadersDefaultCellStyle = headerStyle;


            dg.Columns.Add(col1);
            dg.Columns.Add(col2);


            DataGridViewCellStyle cellsStyle2 = new DataGridViewCellStyle();
            cellsStyle2.Font = new Font("Times New Roman", 26F, FontStyle.Bold);
            cellsStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[1].DefaultCellStyle = cellsStyle2;

            DataGridViewCellStyle cellsStyle1 = new DataGridViewCellStyle();
            cellsStyle1.Font = new Font("Times New Roman", 16F);
            cellsStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellsStyle1.Padding = new Padding(10);
            dg.Columns[0].DefaultCellStyle = cellsStyle1;


            dg.RowTemplate.Height = 150;
            dg.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.AllowUserToAddRows = false;
            dg.ReadOnly = true;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dg.ClearSelection();
            dg.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            RE();
        }


        // Обновление таблицы заказов
        public void RE()
        {
            dg.Rows.Clear(); FillTable(DataBase.GetDataFromDB("SELECT * FROM dbo.Orders"));
        }


        public void FillTable(DataTable dt)
        {
            int id; string article; string status; string address; DateTime dateOrder; DateTime dateShip; int k = 0;
            foreach (DataRow r in dt.Rows)
            {
                id = Convert.ToInt32(r["PointID"]);
                address = DataBase.GetDataFromDB($"SELECT STR(Postcode, 6) + ': ' + City + ', ' + Street + N' д. ' + STR(Home, 3) AS Address FROM dbo.Points WHERE ID = {id}").Rows[0][0].ToString();
                article = r["Article"].ToString(); status = r["Status"].ToString(); dateOrder = Convert.ToDateTime(r["OrderDate"]); dateShip = Convert.ToDateTime(r["ShipDate"]);
                dg.Rows.Add();
                dg.Rows[k].Cells["DateShip"].Value = dateShip.ToString("dd-MM-yyyy");

                string s = $"{article}\n{status}\n{address}\n{dateOrder.ToString("dd-MM-yyyy")}";
                dg.Rows[k].Cells["Info"].Value = s;
                if (status == "Завершен") { dg.Rows[k].Cells["DateShip"].Style.BackColor = Color.LightCoral; }
                k++;
            }
        }






        private void but_exit_Click(object sender, EventArgs e)
        {
            this.Close(); F.Show(); F.Mix();
        }

        private void Orders_FormClosed(object sender, FormClosedEventArgs e)
        {
            F.Show(); F.Mix();
        }


        // Кнопка добавления заказа
        private void but_edit_Click(object sender, EventArgs e)
        {
            Enabled = false; AddOrder F = new AddOrder(this, userLogin); F.Show();
        }


        // Редактирование товара
        private void dg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Role == "Администратор")
            {
                DataTable dt = DataBase.GetDataFromDB("SELECT * FROM dbo.Orders");
                int ID = Convert.ToInt32(dt.Rows[e.RowIndex]["ID"].ToString());
                Enabled = false; EditOrder F = new EditOrder(this, ID, userLogin); F.Show();
            }
        }
    }
}
