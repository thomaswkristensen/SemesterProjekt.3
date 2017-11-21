using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Buisnesslogic
{
    public class Converter
    {
        private List<double> _data;

        public List<double> Convert(double slope, double zpa, List<double> data)
        {
            foreach (var item in data)
            {
                _data.Add((item - zpa)*slope);
            }

            return _data;
        }
    }
}
