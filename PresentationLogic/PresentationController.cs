using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using ObserverPattern;

namespace PresentationLogic
{
    public class PresentationController : IPresentationLogic
    {
        private IBusinessLogic _BL;
        private FilterContainer _filterContainer;

        public PresentationController(IBusinessLogic BL, FilterContainer filterContainer)
        {
            _BL = BL;
            _filterContainer = filterContainer;
        }
        
        public void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            MessageBox.Show("Husk nulpunktsjustering");
            Application.Run(new HomeForm(_BL, _filterContainer));
        }
    }
}
