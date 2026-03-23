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
    public partial class ModalWindow : Form
    {
        public ModalWindow(EditProduct p, int id)
        {
            InitializeComponent();
            P = p; ID = id;
        }
        EditProduct P; int ID;
        private void but_ok_Click(object sender, EventArgs e)
        {
            int k = 0;
            string art = DataBase.GetDataFromDB($"SELECT Article FROM dbo.Products WHERE ID = {ID}").Rows[0][0].ToString();
            DataTable dt = DataBase.GetDataFromDB($"SELECT Article FROM dbo.Orders WHERE Status = N'Новый'");
            foreach ( DataRow r in dt.Rows )
            {
                string input = r["Article"].ToString();
                string[] parts = input.Split('.');
                foreach (var item in parts)
                {
                    if (item.Trim() == art)
                    {
                        k++; break;
                    }
                }
                if (k > 0) { break; }
            }
            if (k > 0) { MessageBox.Show("Данный товар не может быть удален, так как он присутствует в одном из незавершенных заказов!", "Ошибка удаления!"); }
            else { DataBase.EditDataFromDB($"DELETE dbo.Products WHERE ID = {ID}"); MessageBox.Show("Вы успешно удалили товар!", "Успешное удаление!"); P.Close(); }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P.Enabled = true; Close();
        }

        private void ModalWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            P.Enabled = true;
        }

        private void ModalWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
