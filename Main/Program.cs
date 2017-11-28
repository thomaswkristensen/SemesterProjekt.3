using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLogic;
using Buisnesslogic;
using PresentationLogic;
using Interfaces;

namespace Main
{
    class Program
    {
        private DataAccesController DAC;
        private PresentationController PC;
        private BusinessController BC;
        static void Main(string[] args)
        {
            
        }

        public Program()
        {
            DAC = new DataAccesController();
            BC = new BusinessController(DAC);
            PC = new PresentationController(BC);

            PC.Start();
        }
    }
}
