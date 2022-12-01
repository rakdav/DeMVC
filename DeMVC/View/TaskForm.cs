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
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
            using (ModelDB db=new ModelDB())
            {
                List<Status> statuses=db.Status.ToList();
                foreach (Status stat in statuses)
                {
                    comboBoxStatus.Items.Add(stat.name);
                }
                List<Compexity> compexities=db.Compexity.ToList();
                foreach (var item in compexities)
                {
                    comboBoxCharacter.Items.Add(item.name);
                }
                List<Worker> workers=db.Worker.ToList();
                foreach(var item in workers)
                {
                    comboBoxWorker.Items.Add(item.FirstName);
                }
            }
        }
        public string Title
        {
            get { return textBoxTiilte.Text; }
            set { textBoxTiilte.Text = value; }
        }
        public string Description
        {
            get { return textBoxDescription.Text; }
            set { textBoxDescription.Text = value; }
        }
        public DateTime Srok
        { 
            get { return dateTimePickerSrok.Value; }
            set { dateTimePickerSrok.Value = value; }
        }
        public DateTime Data
        {
            get { return dateTimePickerEnd.Value; }
            set { dateTimePickerEnd.Value = value; }
        }
        public int Hard
        {
            get { return int.Parse(numericUpDownComplex.Value.ToString());}
            set { numericUpDownComplex.Value = value; }
        }
        public int Period
        {
            get { return int.Parse(numericUpDownTime.Value.ToString()); }
            set { numericUpDownTime.Value = value; }
        }
        public string Ispolnitel
        {
            get 
            {
                Worker worker;
                using (ModelDB db = new ModelDB())
                {
                    worker = db.Worker.Where(p => p.FirstName.Equals(comboBoxWorker.SelectedItem.ToString())).FirstOrDefault();
                }
                    return worker.login; 
            }
            set 
            {
                using (ModelDB db=new ModelDB())
                {
                    Worker worker = db.Worker.Where(p=>p.login.Equals(value)).FirstOrDefault();
                    comboBoxWorker.SelectedItem = worker.FirstName;
                }
            }
        }
        public int? Status
        {
            get
            {
                Status status;
                using (ModelDB db = new ModelDB())
                {
                    status = db.Status.Where(p => p.name.Equals(comboBoxStatus.SelectedItem.ToString())).FirstOrDefault();
                }
                return status.id;
            }
            set 
            {
                using (ModelDB db = new ModelDB())
                {
                    Status status = db.Status.Where(p => p.id==value).FirstOrDefault();
                    comboBoxStatus.SelectedItem = status.name;
                }
            }
        }
        public int? Comp
        {
            get 
            {
                Compexity comp;
                using (ModelDB db = new ModelDB())
                {
                    comp = db.Compexity.Where(p => p.name.Equals(comboBoxCharacter.SelectedItem.ToString())).FirstOrDefault();
                }
                return comp.id;
            }
            set
            {
                using (ModelDB db = new ModelDB())
                {
                    Compexity compexity = db.Compexity.Where(p => p.id==value).FirstOrDefault();
                    comboBoxCharacter.SelectedItem = compexity.name;
                }
            }
        }
    }
}
