using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WS.Models;

namespace WS.DAO
{
    public class UserDao
    {
        public static List<User> GetUsers()
        {
            var userList = new List<User>();
           /* string path = "resources\\users.csv";
            string pathFile = Path.Combine(
                Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location), @path);*/
            string pathFile = Application.StartupPath + "//resources//users.csv";
            string text = File.ReadAllText(pathFile);
            foreach (string row in text.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    var cells = row.Split(',');
                    User user = new User();
                    user.lastName = cells[0];
                    user.FirstNameAndPatronomic = cells[1];
                    user.login = cells[2];
                    user.password = cells[3];
                    user.role = cells[4];
                    user.photo = "Images\\" + user.login + ".jpg";
                    userList.Add(user);
                }
            }
            return userList;
        }

        public static Image GetImageFromFile(string inputPath)
        {
            string path = Path.Combine(Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location), 
                @inputPath);
            Image image = new Bitmap(path);
            return image;
        }

    }
}
