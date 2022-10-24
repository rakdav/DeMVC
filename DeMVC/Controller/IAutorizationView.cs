using DeMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMVC.Controller
{
    public interface IAutorizationView
    {
        void SetController(AutorizationController controller);
        string Login { get; set; }
        string Password { get; set; }
    }
}
