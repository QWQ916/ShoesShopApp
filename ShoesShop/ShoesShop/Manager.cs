using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesShop
{
    public class Manager : Users
    {
        Users loweruser; // Реализация паттерна ChainResponsibillity
        string name; string login; string password;

        Timer t;
        TextBox info;

        public Manager(string name, string login, string password)
        {
            this.name = name; this.login = login; this.password = password;
        }

        // Конструктор для паттерна
        public Manager(Timer t, TextBox info)
        {
            this.t = t; this.info = info;
        }

        public void Enter(Guests g)
        {
            DataTable dt = DataBase.GetDataFromDB($"SELECT * FROM dbo.Users WHERE Login = '{g.Login}' AND Password = '{g.Password}'");
            if (dt.Rows.Count != 0)
            {
                string name = dt.Rows[0]["FullName"].ToString();
                string role = dt.Rows[0]["Role"].ToString();
                if (role == "Менеджер")
                {
                    info.Text = $"Добро пожаловать Менеджер - {name}"; info.ForeColor = Color.Green;
                    g.name = name;
                    t.Enabled = true;
                }
                else
                {
                    loweruser.Enter(g);
                }
            }
            else
            {
                loweruser.Enter(g);
            }
        }

        public void LowerAccess(Users loweruser)
        {
            this.loweruser = loweruser;
        }
    }
}
