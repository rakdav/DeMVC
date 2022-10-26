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
        public AllTasks(Object obj)
        {
            InitializeComponent();
            if(obj is Worker)
            {
                buttonManageCoef.Visible =false;
            }
        }
    }
}
