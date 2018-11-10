using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WS.Models;

namespace WS.DAO
{
    class MyDataUserDAO
    {
       public static List<User1> GetMyDataUsers()
        {
            var users = new List<User1>();
            string path = "resources//mydata.csv";
            string pathfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @path);
            try
            {
                string text = File.ReadAllText(pathfile);

                foreach (string row in text.Split('\n'))
                {
                    var user = new User1();
                    var cells = row.Split(';');
                    user.FirstName = cells[0];
                    user.lastName = cells[1];
                    user.Pathronymic = cells[2];
                    user.login = cells[3];
                    user.password = cells[4];
                    user.role = cells[5];
                    user.photo = "Images\\" + user.login + ".jpg";
                    users.Add(user);
                }

            }
            catch
            {
                
            }
            return users;
        }
    }
}
