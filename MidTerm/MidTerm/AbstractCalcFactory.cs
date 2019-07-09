using System;
namespace ProjectBasics
{
    //public abstract class AbstractCalcFactory
    //{
    //    public AbstractCalcFactory()
    //    {
    //    }
    //    public abstract AbstractCalc GetObject(string csvData);
    //}
    public abstract class AbstractCalcFactory {
        public abstract AbstractCalc getObject(string csvData);
    }
}
