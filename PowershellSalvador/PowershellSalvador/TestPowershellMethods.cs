using System;

namespace PowershellSalvador
{
    internal class TestPowershellMethods : IPowershellMethods
    {
        public void PSWriteObject(object sendToPipeline)
        {
            Console.WriteLine(sendToPipeline);
        }
    }
}
