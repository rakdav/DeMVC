using DeMVC.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeMVC
{
    public partial class AutorizationView : Form,IAutorizationView
    {
        AutorizationController controller;
        public AutorizationView()
        {
            InitializeComponent();
        }

        public string Login { get { return this.textBoxLogin.Text; }
            set { this.textBoxLogin.Text = value; }
        }
        public string Password
        {
            get { return this.textBoxPassword.Text; }
            set { this.textBoxPassword.Text = value; }
        }

        public void SetController(AutorizationController controller)
        {
            this.controller=controller;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.controller.EnterUser(Login, Password);
        }

        private void checkBoxSe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSe.Checked) textBoxPassword.UseSystemPasswordChar = false;
            else textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
