using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesShop
{
    public interface Users
    {
        void Enter(Guests n);
        void LowerAccess(Users loweruser);
    }
}
