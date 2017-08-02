namespace PowershellSalvador
{
    using System.Management.Automation;

    internal class PowershellMethods : Cmdlet, IPowershellMethods
    {
        public void PSWriteObject(object sendToPipeline)
        {
            WriteObject(sendToPipeline);
        }
    }
}
