using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Models.Regression.Linear;
using DTO;

namespace Buisnesslogic
{
    class Slope
    {
        private double _sum;
        private double _P1;
        private double _P2;
        private double _P3;


        public double CalculateP1(List<double> dataList)
        {
            foreach (var sample in dataList)
            {
                _sum =+ sample;
            }

            return _P1 = _sum / dataList.Count;
        }

        public double CalculateP2(List<double> dataList)
        {
            foreach (var sample in dataList)
            {
                _sum =+ sample;
            }

            return _P2 = _sum / dataList.Count;
        }

        public double CalculateP3(List<double> dataList)
        {
            foreach (var sample in dataList)
            {
                _sum =+ sample;
            }

            return _P3 = _sum / dataList.Count;
        }

        public double CalculateSlope(double ZPA)
        {
            double[] _expectet = {0, 10, 50, 100};

            double[] _measured = {ZPA, _P1, _P2, _P3};

            OrdinaryLeastSquares ols = new OrdinaryLeastSquares();

            SimpleLinearRegression regression = ols.Learn(_expectet, _measured);

            return regression.Slope;
        }




    }
}
