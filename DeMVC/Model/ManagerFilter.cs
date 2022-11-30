using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMVC.Model
{
    internal class ManagerFilter
    {
        public Manager Manager { get; set; }
        public List<Filter> GetFilters()
        {
            List<Filter> filters = new List<Filter>();
            using (ModelDB db = new ModelDB())
            {
                var query = from task in db.Tasks
                            join status in db.Status on task.idStatus equals status.id
                            join worker in db.Worker on task.LoginWorker equals worker.login
                            join work in db.Work on worker.login equals work.loginWorker
                            join man in db.Manager on work.loginManager equals man.login
                            where man.login.Equals(Manager.login)
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
        public List<Filter> GetFilterByStatus(string s)
        {
            List<Filter> filters = new List<Filter>();
            using (ModelDB db = new ModelDB())
            {
                var query = from task in db.Tasks
                            join status in db.Status on task.idStatus equals status.id
                            join worker in db.Worker on task.LoginWorker equals worker.login
                            join work in db.Work on worker.login equals work.loginWorker
                            join man in db.Manager on work.loginManager equals man.login
                            where man.login.Equals(Manager.login) && status.name.Equals(s)
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
        public List<Filter> GetFilterByWorker(string s)
        {
            List<Filter> filters = new List<Filter>();
            using (ModelDB db = new ModelDB())
            {
                var query = from task in db.Tasks
                            join status in db.Status on task.idStatus equals status.id
                            join worker in db.Worker on task.LoginWorker equals worker.login
                            join work in db.Work on worker.login equals work.loginWorker
                            join man in db.Manager on work.loginManager equals man.login
                            where man.login.Equals(Manager.login) && worker.FirstName.Equals(s)
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
        public List<Filter> GetFilterByWorkerAndStatus(string w, string s)
        {
            List<Filter> filters = new List<Filter>();
            using (ModelDB db = new ModelDB())
            {
                var query = from task in db.Tasks
                            join status in db.Status on task.idStatus equals status.id
                            join worker in db.Worker on task.LoginWorker equals worker.login
                            join work in db.Work on worker.login equals work.loginWorker
                            join man in db.Manager on work.loginManager equals man.login
                            where man.login.Equals(Manager.login) && worker.FirstName.Equals(w)
                            &&status.name.Equals(s)
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
