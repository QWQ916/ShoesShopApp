using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesShop
{
    public class Guests : Users
    {
        public string name; string login; string password;

        TextBox info;

        public string Login { get { return login; } }
        public string Password { get { return password; } }


        public Guests(string name, string login, string password)
        {
            this.name = name; this.login = login; this.password = password;
        }

        // Конструктор для паттерна
        public Guests(TextBox info)
        {
            this.info = info;
        }

        public void Enter(Guests g)
        {
            info.Text = "Пользователь не найден, проверьте данные или зайдите в гостевой режим"; info.ForeColor = Color.Red;
        }

        public void LowerAccess(Users u)
        {

        }
    }
}
