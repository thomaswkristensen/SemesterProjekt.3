using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ObserverPattern;

namespace Buisnesslogic
{
    class Filter
    {
        private IFilter _filter;
        private Measurement_DTO _measurementDTO;
        private FilterContainer _filterContainer;
        private bool DigitalFilterUsed { get; set; }

        public Filter(FilterContainer filterContainer)
        {
            _filter = new RawFilter();
            DigitalFilterUsed = false;
            _filterContainer = filterContainer;
        }

        public void FilterMethod(Measurement_DTO data)
        {
            _measurementDTO = data;
            if (DigitalFilterUsed)
            {
                _filter = new DigitalFilter();
            }
            else _filter = new RawFilter();
            
            _measurementDTO.ConvertedData = _filter.Filtering(data.ConvertedData);

        }

        public void UseDigitalFilter()
        {
            if (!DigitalFilterUsed)
            {
                DigitalFilterUsed = true;
            }

            else DigitalFilterUsed = false;
        }
    }
}
