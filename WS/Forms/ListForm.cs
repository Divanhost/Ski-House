using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WS.DAO;
using WS.Models;
namespace WS.Forms
{
    public partial class ListForm : BaseForm
    {
        public ListForm()
        {
            InitializeComponent();
            var users = UserDao.GetUsers();
            comboBox1.DataSource = users;
            comboBox1.DisplayMember = "LastName";
            comboBox1.ValueMember = "Login";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            listBox1.DisplayMember = "Login";
            listBox1.ValueMember = "Role";
            var users2 = UserDao.GetUsers();
            listBox1.DataSource = users2;
            listBox1.SelectedIndexChanged +=listBox1_SelectedIndexChanged;
            listView1.Items.AddRange(users.Select(u =>
            {
                var item = new ListViewItem();
                item.Text = u.lastName;
                item.Tag = u;
                item.ImageKey = u.login;
                return item;
            }).ToArray());

            var avatars = new ImageList();
            foreach (User u in users)
            {
                avatars.Images.Add(u.login, UserDao.GetImageFromFile(u.photo));
            }

            avatars.ImageSize = new Size(64, 64);
            avatars.ColorDepth = ColorDepth.Depth32Bit;
            listView1.LargeImageList = avatars;


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLabel.Text = (comboBox1.SelectedValue as string);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBoxLabel.Text = (listBox1.SelectedItem as User).FirstNameAndPatronomic;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewLabel.Text = "";
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                listViewLabel.Text += (lvi.Tag as User).login + " ";       
            }
        }

    }
}
