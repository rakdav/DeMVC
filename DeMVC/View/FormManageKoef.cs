using DeMVC.Controller;
using DeMVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeMVC.View
{
    public partial class FormManageKoef : Form,IManageKoefView
    {
        ManageKoefController _controller;
        public FormManageKoef()
        {
            InitializeComponent();
        }

        public int Junior { get { return int.Parse(textBoxJunior.Text); }
            set { textBoxJunior.Text = value.ToString(); } }
        public int Middle { get { return int.Parse(textBoxMiddle.Text); }
            set { textBoxMiddle.Text = value.ToString(); } }
        public int Senior {
            get { return int.Parse(textBoxSenior.Text); }
            set { textBoxSenior.Text = value.ToString(); }
        }
        public double CoefAnalize {
            get { return double.Parse(textBoxAnaliz.Text); }
            set { textBoxAnaliz.Text = value.ToString(); }
        }
        public double CoefDeployment {
            get { return double.Parse(textBoxDeployment.Text); }
            set { textBoxDeployment.Text = value.ToString(); }
        }
        public double CoefSupport {
            get { return double.Parse(textBoxTO.Text); }
            set { textBoxTO.Text = value.ToString(); }
        }
        public double CoefTime {
            get { return double.Parse(textBoxTime.Text); }
            set { textBoxTime.Text = value.ToString(); }
        }
        public int CoefCopmlex {
            get { return int.Parse(textBoxComplex.Text); }
            set { textBoxComplex.Text = value.ToString(); }
        }
        public int CoefMoney {
            get { return int.Parse(textBoxMoney.Text); }
            set { textBoxMoney.Text = value.ToString(); }
        }

        public void AddWorkToGrid(Work work)
        {
            this.listBoxWorks.Items.Add(work.loginWorker);
        }

        public void SetController(ManageKoefController controller)
        {
            _controller = controller;
        }

        public void SetSelectedWorkInGrid()
        {
            listBoxWorks.SelectedIndex = 0;
        }

        

        private void listBoxWorks_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ModelDB db = new ModelDB())
            {
                string selectes = listBoxWorks.SelectedItem.ToString(); 
                Work work = db.Work.Where(x => x.loginWorker.Equals(selectes)).FirstOrDefault();
                _controller.updateViewDatailsValues(work);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (ModelDB db = new ModelDB())
            {
                string selectes = listBoxWorks.SelectedItem.ToString();
                Work work = db.Work.Where(x => x.loginWorker.Equals(selectes)).FirstOrDefault();
                _controller.UpdateWorkCoef(work);
            }
        }
    }
}
