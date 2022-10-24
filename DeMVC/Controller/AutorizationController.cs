using DeMVC.Model;
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
            view.SetController(this);
        }
        public void EnterUser(String login,String password)
        {
            using (ModelDB db=new ModelDB())
            {
                Manager manager = db.Manager.Where(p => p.login.Equals(login) &&
                  p.password.Equals(password)).FirstOrDefault();
                if (manager != null)
                {

                    return;
                }
                Worker worker = db.Worker.Where(p => p.login.Equals(login) &&
                        p.password.Equals(password)).FirstOrDefault();
                if(worker!=null)
                {
                        return;
                }
            }
        }   

    }
}
