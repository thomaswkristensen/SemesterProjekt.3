using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class FilterSubject
    {
        private List<IFilterObserver> _observerList;

        public FilterSubject()
        {
            _observerList = new List<IFilterObserver>();
        }

        public void Attach(IFilterObserver item)
        {
            _observerList.Add(item);
        }

        public void Dettach(IFilterObserver item)
        {
            _observerList.Add(item);
        }

        public void Notify()
        {
            foreach (var item in _observerList)
            {
                item.Update();
            }
        }
    }
}
