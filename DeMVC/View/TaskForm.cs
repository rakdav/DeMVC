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
            get { return comboBoxWorker.SelectedItem.ToString(); }
            set { comboBoxWorker.SelectedItem = value; }
        }
        public int Status
        {
            get
            {
                return int.Parse(comboBoxStatus.SelectedItem.ToString());
            }
            set { comboBoxStatus.SelectedItem = value; }
        }
        public int Comp
        {
            get 
            {
                return int.Parse(comboBoxCharacter.SelectedItem.ToString());
            }
            set { comboBoxCharacter.SelectedItem = value; }
        }

    }
}
