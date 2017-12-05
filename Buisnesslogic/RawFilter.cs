using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Buisnesslogic
{
    class RawFilter : IFilter
    {
        private double total;
        public List<double> Filtering(List<double> list)
        {
            List<double> RawListe = new List<double>();

            for (int i = 0; i < list.Count-1; i+=10)
            {
                total = 0;   
                for (int j = 0; j < 9; j++)
                {
                    total += list[i + j];
                }
                total = total / 10;
                RawListe.Add(total);
            }

            return RawListe;
        }
    }
}
