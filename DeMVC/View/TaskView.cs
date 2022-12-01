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
            Print();
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
            WorkerFilter workerFilter = new WorkerFilter();
            workerFilter.Worker = workerIn;
            if (comboBox2.Text.Length==0)
            {
                dataGridView1.DataSource = workerFilter.getWork();
            }
            else
            {
                dataGridView1.DataSource = workerFilter.getWork(comboBox2.SelectedItem.ToString());
            }
        }
        private void Print()
        {
            ManagerFilter manage = new ManagerFilter();
            manage.Manager = manager;
            if (comboBox1.Text.Length != 0 &&
                comboBox2.Text.Length != 0)
            {
                string name = comboBox1.SelectedItem.ToString();
                string st = comboBox2.SelectedItem.ToString();
                dataGridView1.DataSource = manage.GetFilterByWorkerAndStatus(name,st);
            }
            else
            if (comboBox1.Text.Length != 0 &&
                comboBox2.Text.Length == 0)
            {
                string name = comboBox1.SelectedItem.ToString();
                dataGridView1.DataSource = manage.GetFilterByWorker(name);
            }
            else
            if (comboBox1.Text.Length == 0 &&
                comboBox2.Text.Length != 0)
            {
                string st = comboBox2.SelectedItem.ToString();
                
                dataGridView1.DataSource = manage.GetFilterByStatus(st);
            }
            else
            { 
               dataGridView1.DataSource = manage.GetFilters();
                
            }
        }
        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (manager != null) Print();
            if (workerIn != null) PrintWorker();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Filter filter=new Filter();
            filter.Title=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            filter.Status=dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            filter.FioWorker = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            filter.FioManager = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TaskForm taskForm = new TaskForm();
        }
    }
}
