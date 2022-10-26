using DeMVC.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMVC.Controller
{
    public class ManageKoefController
    {
        IManageKoefView _view;
        IList<Work> _works;
        Work _selectedWork;

        public ManageKoefController(IManageKoefView view, IList<Work> workers)
        {
            _view = view;
            _works = workers;
            _view.SetController(this);
        }
        public IList<Work> Work
        {
            get { return _works; }
        }
        public void updateViewDatailsValues(Work work)
        {
            _view.Junior = work.junior;
            _view.Middle = work.middle;
            _view.Senior=work.senior;
            _view.CoefAnalize = work.coefAnalize;
            _view.CoefCopmlex = work.coefCompexity;
            _view.CoefDeployment= work.coefDeployment;
            _view.CoefMoney = work.coefManey;
            _view.CoefSupport = work.coefSupport;
            _view.CoefTime = work.coefTime;
        }
        public void UpdateWorkWithViewValues(Work work)
        {
            work.junior = _view.Junior;
            work.middle = _view.Middle;
            work.senior=_view.Senior;
            work.coefAnalize = _view.CoefAnalize;
            work.coefCompexity = _view.CoefCopmlex;
            work.coefDeployment = _view.CoefDeployment;
            work.coefManey = _view.CoefMoney;
            work.coefSupport = _view.CoefSupport;
            work.coefTime = _view.CoefTime;
        }
        public void LoadView()
        {
            foreach (Work work in _works)
                _view.AddWorkToGrid(work);

            //_view.SetSelectedWorkInGrid((Work)_works[0]);
        }
        public void SelectedWorkChanged(string selectedWork)
        {
            foreach (Work work in this._works)
            {
                if (work.loginWorker == selectedWork)
                {
                    _selectedWork = work;
                    updateViewDatailsValues(work);
                    //_view.SetSelectedWorkInGrid(work);
                    break;
                }
            }
        }
    }
}
