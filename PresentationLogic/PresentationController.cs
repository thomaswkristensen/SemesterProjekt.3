using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;

namespace PresentationLogic
{
    public class PresentationController : IPresentationLogic
    {
        private IBusinessLogic _BL;

        public PresentationController(IBusinessLogic BL)
        {
            _BL = BL;
        }
        
        public void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            Application.Run(new HomeForm(_BL));
        }
    }
}
