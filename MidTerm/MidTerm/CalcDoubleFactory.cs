using System;
namespace ProjectBasics
{
    public class CalcDoubleFactory : AbstractCalcFactory
    {
        public override AbstractCalc GetObject(string csvData)
        {
            return new CalcDouble(csvData);
        }

    }
}
