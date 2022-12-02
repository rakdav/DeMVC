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
    public partial class WorkersForm : Form
    {
        public WorkersForm()
        {
            InitializeComponent();
            using (ModelDB db=new ModelDB())
            {
                var query = from worker in db.Worker
                            join work in db.Work on worker.login equals work.loginWorker
                            join graide in db.Graide on work.idGraide equals graide.id
                            join manag in db.Manager on work.loginManager equals manag.login
                            select new
                            {
                                FioWorker=worker.FirstName+" "+worker.MiddleName+" "+worker.LastName,   
                                Graide=graide.name,
                                Manager=manag.FirstName
                            };
                dataGridView1.DataSource=query.ToList();
            }
        }
    }
}
