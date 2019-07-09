using System;
namespace ProjectBasics
{
    public class CalcComplexFactory : AbstractCalcFactory
    {
        public override AbstractCalc GetObject(string csvData)
        {
            return new CalcComplex(csvData);
        }
    }
}
