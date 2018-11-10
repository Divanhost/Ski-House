using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WS.DAO;

namespace WS.Forms
{
    public partial class MainMenuForm : BaseForm
    {
        public string text { get; set; }
        public string login { get; set; }
        public MainMenuForm()
        {
            InitializeComponent();
            userName.Text = LoginController.GetInstance().user.login;
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            var listForm = new ListForm();
            showNextForm(listForm, false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tablesButton_Click(object sender, EventArgs e)
        {
            var tableForm = new TableForm();
            showNextForm(tableForm, false);
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Text Files|*.txt| All|*.*";
          //  string filename = Application.StartupPath + "//resources//users.csv";

           // string path = "resources//users.csv";
           // string pathfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @path);

            
            if (opd.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = opd.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            text = fileText;
            MessageBox.Show("Файл Успешно Открыт");
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt| All|*.*";
            if(sfd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = sfd.FileName;
            File.WriteAllText(filename,text);
        }

        private void showMB_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you happy now?",
                      "Mood Test", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes: break;
                case DialogResult.No: break;
            }
        }
    }
}
