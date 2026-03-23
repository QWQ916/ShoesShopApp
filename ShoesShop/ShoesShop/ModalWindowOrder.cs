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
    public partial class ModalWindowOrder : Form
    {
        public ModalWindowOrder(EditOrder F, int ID)
        {
            InitializeComponent(); this.F = F; this.ID = ID;
        }

        EditOrder F; int ID;

        private void but_ok_Click(object sender, EventArgs e)
        {
            DataBase.EditDataFromDB($"DELETE dbo.Orders WHERE ID = {ID}"); MessageBox.Show("Вы успешно удалили товар!", "Успешное удаление!"); Close(); F.Close();
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            F.Enabled = true; Close();
        }

        private void ModalWindowOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            F.Enabled = true;
        }
    }
}
