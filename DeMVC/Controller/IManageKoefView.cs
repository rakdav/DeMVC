using DeMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMVC.Controller
{
    internal interface IManageKoefView
    {
        void SetController(ManageKoefController controller);
        void UpdateWorkCoef(Work worker);
        void SetSelectedWorkInGrid(Work work);
        void AddWorkToGrid(Work work);
        int Junior { get; set; }
        int Middle { get; set; }
        int Senior { get; set; }
        double CoefAnalize { get; set; }
        double CoefDeployment { get; set; }
        double CoefSupport { get; set; }
        double CoefTime { get; set; }
        int CoefCopmlex { get; set; }
        int CoefMoney { get; set; }
    }
}
