using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic
{
    class TestData :IData
    {
        private List<double> _data;


        public List<double> getData()
        {
            _data = new List<double>();
            Random test = new Random();
            for (int i = 0; i < 250; i++)
            {
                var test2 = test.Next(1, 5);
                _data.Add(test2);
            }
            return _data;
        }
    }
}
