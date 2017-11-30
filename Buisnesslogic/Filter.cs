using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Buisnesslogic
{
    class Filter
    {
        private IFilter _filter;
        private Measurement_DTO _measurementDTO;
        private bool DigitalFilterUsed { get; set; }

        public Filter()
        {
            _filter = new RawFilter();
            DigitalFilterUsed = false;
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
