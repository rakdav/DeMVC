using DeMVC.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeMVC
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutorizationView view = new AutorizationView();
            AutorizationController controller = new AutorizationController(view);
            view.ShowDialog();
        }
    }
}
