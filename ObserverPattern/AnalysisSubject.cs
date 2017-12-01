using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class AnalysisSubject
    {
        public List<IAnalysisObserver> _observerList;

        public AnalysisSubject()
        {
            _observerList = new List<IAnalysisObserver>();
        }

        public void Attach(IAnalysisObserver item)
        {
            _observerList.Add(item);
        }

        public void Detach(IAnalysisObserver item)
        {
            _observerList.Remove(item);
        }

        public void Notify()
        {
            foreach (var item in _observerList)
            {
                item.AnalysisUpdate();
            }
        }
    }
}
