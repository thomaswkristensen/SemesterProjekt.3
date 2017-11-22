using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnesslogic
{
    class Filter
    {
        private IFilter _filter;
        private bool DigitalFilterUsed { get; set; }

        public Filter()
        {
            _filter = new RawFilter();
            DigitalFilterUsed = false;
        }

        public List<double> FilterMethod(List<double> list)
        {
            if (DigitalFilterUsed)
            {
                _filter = new DigitalFilter();
            }
            else _filter = new RawFilter();
            return _filter.Filtering(list);
        }

        public void UseDigitalFilter(bool digitalFilter)
        {
            if (digitalFilter)
            {
                DigitalFilterUsed = true;
            }

            else DigitalFilterUsed = false;
        }
    }
}
