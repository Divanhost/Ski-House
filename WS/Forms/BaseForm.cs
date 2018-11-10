using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected void showNextForm(BaseForm nextForm, bool isClose = true){

            this.Hide();
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.Location = this.Location;
            nextForm.ShowDialog();
            if (isClose)
            {
                this.Close();
            }
            else
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = nextForm.Location;
                this.Show();
            }
        }
    }
}
