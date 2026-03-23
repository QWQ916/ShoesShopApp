using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShoesShop
{
    public partial class MainForm : Form
    {
        public MainForm(string name, string role, string userLogin)
        {
            InitializeComponent();
            Name = name; Role = role; this.userLogin = userLogin;
        }

        DataTable current;
        string Name;
        string Role;
        string userLogin;

        Image s0 = CloneImg(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "cross.png"));
        Image s1 = CloneImg(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "up.png"));
        Image s2 = CloneImg(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "down.png"));

        string Search = "";
        int Sorting = 0;
        List<string> provs = new List<string>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            switch (Role)
            {
                case "Администратор":
                    break;
                case "Менеджер":
                    ManagerAccess();
                    break;
                case "Клиент":
                    ClientAccess();
                    break;
                default:
                    GuestAccess();
                    break;
            }

            tb_name.Text = Name;
            tb_role.Text = $"Роль: {Role}";

            DataGridViewImageColumn col1 = new DataGridViewImageColumn();
            col1.HeaderText = "Фото";
            col1.Width = 300;
            col1.Name = "Photo";
            col1.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Информация";
            col2.Width = 500;
            col2.Name = "Info";

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Скидка, %";
            col3.Width = 250;
            col3.Name = "Discount";


            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            headerStyle.BackColor = Color.FromArgb(127, 255, 0);
            headerStyle.ForeColor = Color.DarkGreen;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.EnableHeadersVisualStyles = false;
            dg.ColumnHeadersDefaultCellStyle = headerStyle;


            dg.Columns.Add(col1);
            dg.Columns.Add(col2);
            dg.Columns.Add(col3);



            DataGridViewCellStyle cellsStyle2 = new DataGridViewCellStyle();
            cellsStyle2.Font = new Font("Times New Roman", 26F, FontStyle.Bold);
            cellsStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.Columns[2].DefaultCellStyle = cellsStyle2;

            DataGridViewCellStyle cellsStyle1 = new DataGridViewCellStyle();
            cellsStyle1.Font = new Font("Times New Roman", 12F);
            cellsStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellsStyle1.Padding = new Padding(10);
            dg.Columns[1].DefaultCellStyle = cellsStyle1;


            dg.RowTemplate.Height = 200;
            dg.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.AllowUserToAddRows = false;
            dg.ReadOnly = true;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dg.ClearSelection();
            dg.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            FillTable(DataBase.GetDataFromDB("SELECT * FROM dbo.Products"));

            DataTable p = DataBase.GetDataFromDB("SELECT DISTINCT Provider FROM dbo.Products");
            cb_prov.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DataRow row in p.Rows)
            {
                provs.Add(row["Provider"].ToString());
                cb_prov.Items.Add(row["Provider"].ToString());
            }
        }


        public void Mix()
        {
            dg.Rows.Clear();
            string q = "SELECT * FROM dbo.Products";
            string s; string f; string ss;
            if (Search != "")
            {
                s = $" WHERE (Article LIKE N'%{Search}%' OR Name LIKE N'%{Search}%' OR Unit LIKE N'%{Search}%' OR Provider LIKE N'%{Search}%' OR Manufacturer LIKE N'%{Search}%' OR Category LIKE N'%{Search}%' OR Description LIKE N'%{Search}%')";
            }
            else
            {
                s = " WHERE 1 = 1";
            }
            if (cb_prov.SelectedIndex != 0)
            {
                f = $" AND Provider = N'{provs[cb_prov.SelectedIndex - 1]}'";
            }
            else
            {
                f = " AND 1 = 1";
            }
            if (Sorting == 0)
            {
                ss = " ";
            }
            else if (Sorting == 1)
            {
                ss = " ORDER BY Count DESC";
            }
            else
            {
                ss = " ORDER BY Count ASC";
            }
            string query = q + s + f + ss;
            FillTable(DataBase.GetDataFromDB(query));
        }




        public void FillTable(DataTable dt)
        {
            string path; string name; string category; string desc; string manuf; string prov; int price; string unit; int count; int discount; int k = 0;
            foreach (DataRow r in dt.Rows)
            {
                current = dt;
                path = r["Picture"].ToString(); name = r["Name"].ToString(); category = r["Category"].ToString(); desc = r["Description"].ToString(); unit = r["Unit"].ToString();
                manuf = r["Manufacturer"].ToString(); prov = r["Provider"].ToString(); price = Convert.ToInt32(r["Price"].ToString()); count = Convert.ToInt32(r["Count"].ToString()); discount = Convert.ToInt32(r["Discount"].ToString());
                if (Convert.ToInt32(r["VFlag"].ToString()) == 1)
                {
                    dg.Rows.Add();
                    Image img;
                    try
                    {
                        string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", path); 
                        img = CloneImg(imagePath);
                    }
                    catch
                    {
                        string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "picture.png");
                        img = CloneImg(imagePath);
                    }
                    dg.Rows[k].Cells["Photo"].Value = img;

                    string s;
                    if (discount == 0)
                    {
                        s = $"{category} | {name} \nОписание товара: {desc} \nПроизводитель: {manuf} \nПоставщик: {prov} \nЦена: {price} ₽ \nЕдиница измерения: {unit} \nКоличество на складе: {count}";
                    }
                    else
                    {
                        s = $"{category} | {name} \nОписание товара: {desc} \nПроизводитель: {manuf} \nПоставщик: {prov} \nЦена: X({price}₽)X ===> {price * (1 - (Convert.ToDouble(discount) / 100))} ₽ \nЕдиница измерения: {unit} \nКоличество на складе: {count}";
                    }
                    dg.Rows[k].Cells["Info"].Value = s;


                    if (count == 0)
                    {
                        dg.Rows[k].DefaultCellStyle.BackColor = Color.LightBlue;
                    }

                    dg.Rows[k].Cells["Discount"].Value = discount;
                    if (discount > 15)
                    {
                        dg.Rows[k].DefaultCellStyle.BackColor = Color.FromArgb(46, 139, 87);
                    }
                    k++;
                }
            }
        }



        // Динамическая текст-заглушка
        private void tb_search_Enter(object sender, EventArgs e)
        {
            if (tb_search.Text == "Поиск...")
            {
                tb_search.Text = "";
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            pb_logo.Focus();
            if (tb_search.Text == "")
            {
                tb_search.Text = "Поиск...";
            }
        }


        // События для динамической фильтрации

        // Кнопка сортировки
        private void pb_sort_Click(object sender, EventArgs e)
        {
            if (Sorting == 0) { Sorting = 1; }
            if (Sorting == 1)
            {
                pb_sort.Image = s1;
                Sorting = 2;
                Mix();
            }
            else if (Sorting == 2)
            {
                pb_sort.Image = s2;
                Sorting = 1;
                Mix();
            }
        }

        private void pb_sort_DoubleClick(object sender, EventArgs e)
        {
            Sorting = 0; pb_sort.Image = s0;
            Mix();
        }

        // Строка поиска
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (!(tb_search.Text == "" || tb_search.Text == "Поиск..."))
            {
                Search = tb_search.Text; Mix();
            }
            else
            {
                Search = ""; Mix();
            }
        }

        // Фильтрация
        private void cb_prov_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mix();
        }



        // Функция клонирования изображения, чтобы не оставлять ее в памяти
        public static Image CloneImg(string filepath)
        {
            Image img;
            using (var temp = new Bitmap(filepath))
            {
                img = (Image)temp.Clone();
            }
            return img;
        }


        // Сброс всех фильтров
        private void but_reset_Click(object sender, EventArgs e)
        {
            Search = ""; cb_prov.SelectedIndex = 0; Sorting = 0; pb_sort.Image = s0; tb_search.Text = "Поиск..."; Mix();   
        }


        // Кнопка выхода из аккаунта
        private void but_enter_Click(object sender, EventArgs e)
        {
            Application.Exit(); Application.Restart();
        }

        // Закрытие формы = остановка программы
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        // Открытие добавления товара
        private void but_edit_Click(object sender, EventArgs e)
        {
            this.Enabled = false; AddProduct F1 = new AddProduct(this); F1.Show();
        }

        private void dg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Role == "Администратор")
            {
                int i = e.RowIndex;
                DataRow product = current.Rows[i];
                int id = Convert.ToInt32(product["ID"].ToString());
                this.Enabled = false; EditProduct F = new EditProduct(this, id, dg); F.Show();
            }
        }



        // Блокирование элементов для несоответсвующей роли
        public void ManagerAccess()
        {
            but_edit.Enabled = false; but_edit.Visible = false;
        }

        public void ClientAccess()
        {
            but_edit.Enabled = false; but_edit.Visible = false;

            tb_search.Visible = false; tb_search.Enabled = false;
            but_reset.Visible = false; but_reset.Enabled = false;
            
            tb_sort.Visible = false; tb_sort.Enabled = false;
            pb_sort.Enabled = false; pb_sort.Visible = false;

            cb_prov.Enabled = false; cb_prov.Visible = false;

            but_orders.Enabled = false; but_orders.Visible = false;
        }

        public void GuestAccess()
        {
            but_edit.Enabled = false; but_edit.Visible = false;

            tb_search.Visible = false; tb_search.Enabled = false;
            but_reset.Visible = false; but_reset.Enabled = false;

            tb_sort.Visible = false; tb_sort.Enabled = false;
            pb_sort.Enabled = false; pb_sort.Visible = false;

            cb_prov.Enabled = false; cb_prov.Visible = false;

            but_orders.Visible = false; but_orders.Enabled = false; 
        }



        // Страница заказов
        private void but_orders_Click(object sender, EventArgs e)
        {
            Orders F = new Orders(this, Role, userLogin); Hide(); F.Show();
        }
    }
}
