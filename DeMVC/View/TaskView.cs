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
    public partial class TaskView : Form
    {
        private Manager manager;
        private Worker workerIn;
        public TaskView(Object obj)
        {
            InitializeComponent();
            using (ModelDB db = new ModelDB())
            {
                var workers = from worker in db.Worker
                              select worker;

                foreach (var item in workers)
                {
                    comboBox1.Items.Add(item.FirstName);
                }
                var status=from stat in db.Status
                           select stat;
                foreach (var item in status)
                {
                    comboBox2.Items.Add(item.name);
                }
            }
                if (obj is Manager)
                {
                    manager = (Manager)obj;
                    Print();
                }
                else
                { 
                    workerIn = (Worker)obj;
                    label1.Visible = false;
                    comboBox1.Visible = false;
                    PrintWorker();
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(manager!=null) Print();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            Print();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (manager != null) Print();
            if (workerIn != null) PrintWorker();
        }
        private void PrintWorker()
        {
            if(comboBox2.Text.Length==0)
            {
                using (ModelDB db = new ModelDB())
                {
                    var query = from task in db.Tasks
                                join status in db.Status on task.idStatus equals status.id
                                join worker in db.Worker on task.LoginWorker equals worker.login
                                join work in db.Work on worker.login equals work.loginWorker
                                join man in db.Manager on work.loginManager equals man.login
                                where task.LoginWorker.Equals(workerIn.login)
                                select new
                                {
                                    Title = task.title,
                                    Status = status.name,
                                    fioWork = worker.FirstName + " " + worker.MiddleName + " " + worker.LastName,
                                    fioMan = man.FirstName + " " + man.MiddleName + " " + man.LastName
                                };
                    dataGridView1.DataSource = query.ToList();
                }
            }
            else
            {
                using (ModelDB db = new ModelDB())
                {
                    var query = from task in db.Tasks
                                join status in db.Status on task.idStatus equals status.id
                                join worker in db.Worker on task.LoginWorker equals worker.login
                                join work in db.Work on worker.login equals work.loginWorker
                                join man in db.Manager on work.loginManager equals man.login
                                where task.LoginWorker.Equals(workerIn.login)&&status.name.Equals(comboBox2.SelectedItem.ToString())
                                select new
                                {
                                    Title = task.title,
                                    Status = status.name,
                                    fioWork = worker.FirstName + " " + worker.MiddleName + " " + worker.LastName,
                                    fioMan = man.FirstName + " " + man.MiddleName + " " + man.LastName
                                };
                    dataGridView1.DataSource = query.ToList();
                }
            }
        }
        private void Print()
        {
            if (comboBox1.Text.Length != 0 &&
                comboBox2.Text.Length != 0)
            {
                string name = comboBox1.SelectedItem.ToString();
                string st = comboBox2.SelectedItem.ToString();
                using (ModelDB db = new ModelDB())
                {
                    var query = from task in db.Tasks
                                join status in db.Status on task.idStatus equals status.id
                                join worker in db.Worker on task.LoginWorker equals worker.login
                                join work in db.Work on worker.login equals work.loginWorker
                                join man in db.Manager on work.loginManager equals man.login
                                where man.login.Equals(manager.login) && worker.FirstName.Equals(name)
                                && status.name.Equals(st)
                                select new
                                {
                                    Title = task.title,
                                    Status = status.name,
                                    fioWork = worker.FirstName + " " + worker.MiddleName + " " + worker.LastName,
                                    fioMan = man.FirstName + " " + man.MiddleName + " " + man.LastName
                                };
                    dataGridView1.DataSource = query.ToList();
                }
            }
            else
            if (comboBox1.Text.Length != 0 &&
                comboBox2.Text.Length == 0)
            {
                string name = comboBox1.SelectedItem.ToString();
                using (ModelDB db = new ModelDB())
                {
                    var query = from task in db.Tasks
                                join status in db.Status on task.idStatus equals status.id
                                join worker in db.Worker on task.LoginWorker equals worker.login
                                join work in db.Work on worker.login equals work.loginWorker
                                join man in db.Manager on work.loginManager equals man.login
                                where man.login.Equals(manager.login) && worker.FirstName.Equals(name)
                                select new
                                {
                                    Title = task.title,
                                    Status = status.name,
                                    fioWork = worker.FirstName + " " + worker.MiddleName + " " + worker.LastName,
                                    fioMan = man.FirstName + " " + man.MiddleName + " " + man.LastName
                                };
                    dataGridView1.DataSource = query.ToList();
                }
            }
            else
            if (comboBox1.Text.Length == 0 &&
                comboBox2.Text.Length != 0)
            {
                string st = comboBox2.SelectedItem.ToString();
                using (ModelDB db = new ModelDB())
                {
                    var query = from task in db.Tasks
                                join status in db.Status on task.idStatus equals status.id
                                join worker in db.Worker on task.LoginWorker equals worker.login
                                join work in db.Work on worker.login equals work.loginWorker
                                join man in db.Manager on work.loginManager equals man.login
                                where man.login.Equals(manager.login) && status.name.Equals(st)
                                select new
                                {
                                    Title = task.title,
                                    Status = status.name,
                                    fioWork = worker.FirstName + " " + worker.MiddleName + " " + worker.LastName,
                                    fioMan = man.FirstName + " " + man.MiddleName + " " + man.LastName
                                };
                    dataGridView1.DataSource = query.ToList();
                }
            }
            else
            {
                using (ModelDB db = new ModelDB())
                {
                    var query = from task in db.Tasks
                                join status in db.Status on task.idStatus equals status.id
                                join worker in db.Worker on task.LoginWorker equals worker.login
                                join work in db.Work on worker.login equals work.loginWorker
                                join man in db.Manager on work.loginManager equals man.login
                                where man.login.Equals(manager.login)
                                select new
                                {
                                    Title = task.title,
                                    Status = status.name,
                                    fioWork = worker.FirstName + " " + worker.MiddleName + " " + worker.LastName,
                                    fioMan = man.FirstName + " " + man.MiddleName + " " + man.LastName
                                };
                    dataGridView1.DataSource = query.ToList();
                }
            }
        }


        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (manager != null) Print();
            if (workerIn != null) PrintWorker();
        }
    }
}
