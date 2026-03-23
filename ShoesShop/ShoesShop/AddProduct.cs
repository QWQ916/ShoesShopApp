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

namespace ShoesShop
{
    public partial class AddProduct : Form
    {
        public AddProduct(MainForm F)
        {
            InitializeComponent();
            this.F = F;
        }

        MainForm F;
        Image newImage;
        string newImageName;

        int k = 0;

        int cb_man_iselected = -1;
        int cb_cat_iselected = -1;

        string name; string prov; string unit; string desc; string art;

        double price; int discount; int count;

        List<string> categories; List<string> manus;

        private void AddProduct_Load(object sender, EventArgs e)
        {
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
            CheckAll();
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
        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CheckD(tb_price, tb_mess, out price); CheckAll();
        }

        private void tb_discount_TextChanged(object sender, EventArgs e)
        {
            CheckInt(tb_discount, tb_mess, out discount); CheckAll();
        }

        private void tb_unit_TextChanged(object sender, EventArgs e)
        {
            CheckStr(tb_unit, tb_mess, out  unit); CheckAll();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            CheckInt(tb_count, tb_mess, out count); CheckAll();
        }

        private void tb_category_TextChanged(object sender, EventArgs e)
        {
            CheckStr(tb_desc, tb_mess, out desc); CheckAll();
        }

        private void tb_price_Leave(object sender, EventArgs e)
        {
            tb_price.Text = price.ToString(); CheckAll();
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_cat_iselected = cb_category.SelectedIndex;
            CheckAll();
        }

        private void cb_manu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_man_iselected = cb_manu.SelectedIndex;
            CheckAll();
        }

        private void tb_art_TextChanged(object sender, EventArgs e)
        {
            CheckStr(tb_art, tb_mess, out art); CheckAll();
        }


        // Кнопка применения
        private void but_create_Click(object sender, EventArgs e)
        {
            k++; this.Enabled = false; 
            int id = Convert.ToInt32(DataBase.GetDataFromDB("SELECT TOP 1 ID FROM dbo.Products ORDER BY ID DESC").Rows[0].ItemArray[0]) + 1;
            DataBase.EditDataFromDB($"INSERT INTO dbo.Products VALUES ({id}, '{art}', N'{name}', N'{unit}', {Convert.ToInt32(price)}, N'{prov}', N'{manus[cb_man_iselected]}', N'{categories[cb_cat_iselected]}', {discount}, {count}, N'{desc}', '{newImageName}', 1)");
            MessageBox.Show($"Вы добавили успешно товар '{name}'", "Успешное добавление"); Close();
        }

       
    }
}
