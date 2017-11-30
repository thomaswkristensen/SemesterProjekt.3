using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ObserverPattern
{
    public class FilterContainer : FilterSubject 
    {
        public Measurement_DTO MeasurementDTO { get; set; }

        public void Done()
        {
            Notify();
        }
    }
}
