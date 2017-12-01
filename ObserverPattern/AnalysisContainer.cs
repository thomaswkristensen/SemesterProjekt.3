using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ObserverPattern
{
    public class AnalysisContainer : AnalysisSubject
    {
        private HealthValues_DTO _hvDTO;

        public AnalysisContainer()
        {
            
        }
        public void SetHealthValues(HealthValues_DTO hvDto)
        {;
            _hvDTO = hvDto;
            Notify();
        }

        public HealthValues_DTO GetHealthValues()
        {
            return _hvDTO;
        }
    }
}
