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
        private Converter _converter;

        public Filter(Converter converter, IFilter filter)
        {
            _converter = converter;
            _converter.Attach(this);
            _filter = filter;
        }

        public void Update()
        {
            
        }


    }
}
