using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMVC.Model
{
    internal class WorkerFilter
    {
        public Worker Worker { get; set; }
        public List<Filter> getWork()
        {
            List<Filter> filters = new List<Filter>();
            using (ModelDB db = new ModelDB())
            {
                var query = from task in db.Tasks
                            join status in db.Status on task.idStatus equals status.id
                            join worker in db.Worker on task.LoginWorker equals worker.login
                            join work in db.Work on worker.login equals work.loginWorker
                            join man in db.Manager on work.loginManager equals man.login
                            where task.LoginWorker.Equals(Worker.login)
                            select new Filter
                            {
                                Title = task.title,
                                Status = status.name,
                                FioWorker = worker.FirstName + " " + worker.MiddleName + " " + worker.LastName,
                                FioManager = man.FirstName + " " + man.MiddleName + " " + man.LastName
                            };
                filters = query.ToList();
            }
            return filters;
        }
        public List<Filter> getWork(string s)
        {
            List<Filter> filters = new List<Filter>();
            using (ModelDB db = new ModelDB())
            {
                var query = from task in db.Tasks
                            join status in db.Status on task.idStatus equals status.id
                            join worker in db.Worker on task.LoginWorker equals worker.login
                            join work in db.Work on worker.login equals work.loginWorker
                            join man in db.Manager on work.loginManager equals man.login
                            where task.LoginWorker.Equals(Worker.login) && status.name.Equals(s)
                            select new Filter
                            {
                                Title = task.title,
                                Status = status.name,
                                FioWorker = worker.FirstName + " " + worker.MiddleName + " " + worker.LastName,
                                FioManager = man.FirstName + " " + man.MiddleName + " " + man.LastName
                            };
                filters = query.ToList();
            }
            return filters;
        }
    }
}
