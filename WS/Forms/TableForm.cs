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
using WS.DAO;
using WS.Models;

namespace WS.Forms
{
    public partial class TableForm : BaseForm
    {
        public TableForm()
        {
            InitializeComponent();
         
            var users = UserDao.GetUsers().OrderBy(u=>u.lastName).ToList();
            //var users = UserDao.GetUsers().Where(u => u.lastName.Contains('Б')).ToList();
            //var users = UserDao.GetUsers().Select(u => u.lastName).ToList();
            //var users = UserDao.GetUsers().OrderBy(u => u.lastName).ToList();
           // var users = UserDao.GetUsers().OrderBy(u => u.lastName).ToList();
           // var users = UserDao.GetUsers().OrderBy(u => u.lastName).ToList();
           // var users = UserDao.GetUsers().OrderBy(u => u.lastName).ToList();*/

            dataGridView1.DataSource = users;

    
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           //string a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           // pictureBox1.Image = new Bitmap("Images//" + a + ".jpg");
            /*var avatars = new ImageList();
            avatars.Images.Add(dataGridView1.SelectedRows., UserDao.GetImageFromFile(u.photo));
            avatars.ImageSize = new Size(64, 64);
            avatars.ColorDepth = ColorDepth.Depth32Bit;
            dataGridView1.Columns.Add("Images", "Images");*/
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Bitmap t = new Bitmap("Images//" + a + ".jpg");
            //   t.Size = new Size(64, 64);dfsfsdfsdf
            t = new Bitmap(t, new Size(64, 64));
            pictureBox1.Image = t;
        }
    }
}
