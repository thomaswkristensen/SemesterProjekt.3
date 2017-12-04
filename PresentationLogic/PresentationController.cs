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
        private AnalysisContainer _analysisContainer;

        public PresentationController(IBusinessLogic BL, FilterContainer filterContainer, AnalysisContainer analysisContainer)
        {
            _BL = BL;
            _filterContainer = filterContainer;
            _analysisContainer = analysisContainer;
        }
        
        public void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            MessageBox.Show("Husk nulpunktsjustering");
            Application.Run(new HomeForm(_BL, _filterContainer,_analysisContainer));
        }
    }
}
