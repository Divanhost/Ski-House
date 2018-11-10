using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Models;

namespace WS.DAO
{
    public class LoginController
    {

        public  User user {get; set ;}

        private static LoginController instance;
        public static LoginController GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginController();
            }
            return instance;
        }
        private LoginController()
        {

        }
    }
}
