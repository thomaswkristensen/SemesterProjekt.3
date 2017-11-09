using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Measurement_DTO
    {
        public List<double> RawData { get; set; }
        public List<double> ConvertedData { get; set; }
        public int Fsample { get; set; }
        public DateTime TimeOfMeasurement { get; set; }

    }
}
