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
    public partial class AllTasks : Form
    {
        private Manager manager;
        private Object obj;
        public AllTasks(Object obj)
        {
            InitializeComponent();
            this.obj = obj;
            if(obj is Worker)
            {
                buttonManageCoef.Visible =false;   
                
            }
            else
            {
                manager = (Manager)obj;
            }
        }

        private void buttonManageCoef_Click(object sender, EventArgs e)
        {
            FormManageKoef view=new FormManageKoef();
            IList<Work> workerList=new List<Work>();
            using (ModelDB db = new ModelDB())
            {
                workerList = db.Work.Where(p => p.loginManager.
                 Equals(manager.login)).ToList();
                ManageKoefController controller =
                new ManageKoefController(view, workerList);
                controller.LoadView();
                view.ShowDialog();
            }
        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            TaskView taskView = new TaskView(obj);
            taskView.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkersForm workers = new WorkersForm();
            workers.Show();
        }
    }
}
