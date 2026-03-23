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
    public partial class EditProduct : Form
    {
        public EditProduct(MainForm F, int id, DataGridView dg)
        {
            InitializeComponent(); 
            this.F = F; tb_id.Text = id.ToString(); this.dg = dg;
        }

        MainForm F;
        Image newImage;
        string newImageName;
        string oldImageName;
        DataGridView dg;

        int cb_man_iselected = -1;
        int cb_cat_iselected = -1;

        string name; 
        string prov; 
        string unit; 
        string desc; 
        string art;

        double price; 
        int discount; 
        int count;

        List<string> categories; List<string> manus;

        private void EditProduct_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(tb_id.Text);

            name = DataBase.GetDataFromDB($"SELECT Name FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString();
            tb_name.Text = name;

            prov = DataBase.GetDataFromDB($"SELECT Provider FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString();
            tb_prov.Text = prov;

            unit = DataBase.GetDataFromDB($"SELECT Unit FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString();
            tb_unit.Text = unit;

            desc = DataBase.GetDataFromDB($"SELECT Description FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString();
            tb_desc.Text = desc;

            art = DataBase.GetDataFromDB($"SELECT Article FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString();
            tb_art.Text = art;

            price = Convert.ToDouble(DataBase.GetDataFromDB($"SELECT Price FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString());
            tb_price.Text = price.ToString();

            discount = Convert.ToInt32(DataBase.GetDataFromDB($"SELECT Discount FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString());
            tb_discount.Text = discount.ToString();

            count = Convert.ToInt32(DataBase.GetDataFromDB($"SELECT Count FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString());
            tb_count.Text = count.ToString();

            string path = DataBase.GetDataFromDB($"SELECT Picture FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString();
            if (path == "") { path = "picture.png"; }
            pb_img.Image = CloneImg(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", path));

            string cat = DataBase.GetDataFromDB($"SELECT Category FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString();
            string man = DataBase.GetDataFromDB($"SELECT Manufacturer FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString();

            newImageName = path;
            if (newImageName == "") { newImageName = "picture.png"; }

            DataTable tc = DataBase.GetDataFromDB("SELECT DISTINCT Category FROM dbo.Products");
            categories = new List<string>();
            cb_category.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DataRow dr in tc.Rows)
            {
                categories.Add(dr["Category"].ToString());
                cb_category.Items.Add(dr["Category"].ToString());
            }

            DataTable tm = DataBase.GetDataFromDB("SELECT DISTINCT Manufacturer FROM dbo.Products");
            manus = new List<string>();
            cb_manu.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DataRow dr in tm.Rows)
            {
                manus.Add(dr["Manufacturer"].ToString());
                cb_manu.Items.Add(dr["Manufacturer"].ToString());
            }

            cb_category.SelectedIndex = categories.IndexOf(cat);
            cb_manu.SelectedIndex = manus.IndexOf(man);

            CheckAll();

            tb_name.ForeColor = Color.Blue;
            tb_art.ForeColor = Color.Blue;
            tb_prov.ForeColor = Color.Blue;
            tb_price.ForeColor = Color.Blue;
            tb_count.ForeColor = Color.Blue;
            tb_unit.ForeColor = Color.Blue;
            tb_discount.ForeColor = Color.Blue;
            cb_category.BackColor = Color.LightBlue;
            cb_manu.BackColor = Color.LightBlue;
            tb_desc.ForeColor = Color.Blue;
        }















        public void CheckInt(TextBox tb, TextBox ms, out int v)
        {
            int val; v = -1;
            try
            {
                val = Convert.ToInt32(tb.Text);
                if (val < 0)
                {
                    ms.Text = "Данное свойство не может быть отрицательным!"; tb.ForeColor = Color.DarkRed;
                }
                else
                {
                    ms.Text = "";
                    tb.ForeColor = Color.DarkGreen;
                    v = val;
                    But(false);
                }
            }
            catch
            {
                ms.Text = "Проверьте правильность введенных данных"; tb.ForeColor = Color.DarkRed;
            }
            CheckAll();
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

        public void CheckD(TextBox tb, TextBox ms, out double v)
        {
            double val; v = -1;
            try
            {
                val = Convert.ToDouble(tb.Text);
                if (val <= 0)
                {
                    ms.Text = "Данное свойство не может быть отрицательным!"; tb.ForeColor = Color.DarkRed;
                }
                else
                {
                    ms.Text = "";
                    tb.ForeColor = Color.DarkGreen;
                    v = Math.Round(val, 2);
                }
            }
            catch
            {
                ms.Text = "Проверьте правильность введенных данных!"; tb.ForeColor = Color.DarkRed;
            }
            CheckAll();
        }


        public void But(bool t)
        {
            but_create.Enabled = t; but_create.Visible = t;
        }


        public void CheckAll()
        {
            if (name == null || prov == null || desc == null || unit == null || price == -1 || discount == -1 || count == -1 || cb_cat_iselected == -1 || cb_man_iselected == -1 || art == null)
            {
                But(false);
            }
            else
            {
                But(true);
            }
        }












        // Заменить изображение
        private void pb_img_DoubleClick(object sender, EventArgs e)
        {
            dialog_file.ShowDialog();
        }


        private void dialog_file_FileOk(object sender, CancelEventArgs e)
        {
            string extension = Path.GetExtension(dialog_file.FileName).ToLower();
            string FileName = Path.GetFileName(dialog_file.FileName);
            string selectedFilePath = dialog_file.FileName;

            if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
            {
                string destinationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", FileName);

                if (!File.Exists(destinationPath) || destinationPath != selectedFilePath)
                {
                    try
                    {
                        FileName = GRS(10) + extension;
                        destinationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", $"{FileName}");
                        File.Copy(selectedFilePath, destinationPath);
                        Image img = CloneImg(destinationPath);
                        pb_img.Image = img;
                        newImage = img;
                        newImageName = FileName;
                        img.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при копировании файла: " + ex.Message);
                    }
                }
                else
                {
                    Image img = CloneImg(selectedFilePath);
                    pb_img.Image = img;
                    newImageName = FileName;
                }
            }
            else
            {
                MessageBox.Show("Допустимы только файлы JPG, JPEG и PNG", "Ошибка открытия изображения");
            }
        }


        public static string GRS(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[rnd.Next(chars.Length)]);
            }

            return result.ToString();
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


        // Закрытие формы
        private void EditProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            F.Mix(); F.Enabled = true;
        }



        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            CheckStr(tb_name, tb_mess, out name); CheckAll();
        }

        private void tb_prov_TextChanged(object sender, EventArgs e)
        {
            CheckStr(tb_prov, tb_mess, out prov); CheckAll();
        }

        private void tb_price_TextChanged(object sender, EventArgs e)
        {
            CheckD(tb_price, tb_mess, out price); CheckAll();
        }

        private void tb_discount_TextChanged(object sender, EventArgs e)
        {
            CheckInt(tb_discount, tb_mess, out discount); CheckAll();
        }

        private void tb_unit_TextChanged(object sender, EventArgs e)
        {
            CheckStr(tb_unit, tb_mess, out unit); CheckAll();
        }

        private void tb_count_TextChanged(object sender, EventArgs e)
        {
            CheckInt(tb_count, tb_mess, out count); CheckAll();
        }

        private void tb_desc_TextChanged(object sender, EventArgs e)
        {
            CheckStr(tb_desc, tb_mess, out desc); CheckAll();
        }

        private void tb_price_Leave(object sender, EventArgs e)
        {
            tb_price.Text = price.ToString(); CheckAll();
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_cat_iselected = cb_category.SelectedIndex; cb_category.BackColor = SystemColors.Info;
            CheckAll();
        }

        private void cb_manu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_man_iselected = cb_manu.SelectedIndex; cb_manu.BackColor = SystemColors.Info;
            CheckAll();
        }

        private void tb_art_TextChanged(object sender, EventArgs e)
        {
            CheckStr(tb_art, tb_mess, out art); CheckAll();
        }


        // Кнопка применения
        private void but_create_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            int ID = Convert.ToInt32(tb_id.Text);
            oldImageName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", DataBase.GetDataFromDB($"SELECT Picture FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString());
            DataBase.EditDataFromDB($"UPDATE dbo.Products SET Article = '{art}', Name = N'{name}', Unit = N'{unit}', Price = {Convert.ToInt32(price)}, Provider = N'{prov}', Manufacturer = N'{manus[cb_man_iselected]}', Category = N'{categories[cb_cat_iselected]}', Discount = {discount}, Count = {count}, Description = N'{desc}', Picture = '{newImageName}' WHERE ID = {ID}");
            MessageBox.Show($"Вы отредактировали успешно товар '{name}'", "Успешное изменение");
            Close();
        }

        // Удалить товар
        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(tb_id.Text);
            ModalWindow M = new ModalWindow(this, ID); this.Enabled = false;
            M.Show();
        }
    }
}
