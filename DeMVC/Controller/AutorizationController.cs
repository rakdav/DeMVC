using DeMVC.Model;
using DeMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMVC.Controller
{
    public class AutorizationController
    {
        IAutorizationView _view;

        public AutorizationController(IAutorizationView view)
        {
            _view = view;
            _view.SetController(this);
        }
        public void EnterUser(String login,String password)
        {
            using (ModelDB db=new ModelDB())
            {
                Manager manager = db.Manager.Where(p => p.login.Equals(login) &&
                  p.password.Equals(password)).FirstOrDefault();
                if (manager != null)
                {
                    AllTasks window = new AllTasks(manager);
                    _view.HideForm();
                    window.ShowDialog();
                }
                else
                {
                    Worker worker = db.Worker.Where(p => p.login.Equals(login) &&
                            p.password.Equals(password)).FirstOrDefault();
                    if (worker != null)
                    {
                        AllTasks window = new AllTasks(worker);
                        _view.HideForm();
                        window.ShowDialog();
                    }
                }
            }
        }   

    }
}
