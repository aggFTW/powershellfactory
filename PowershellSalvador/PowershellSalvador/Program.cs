namespace PowershellSalvador
{
    class Program
    {
        static void Main(string[] args)
        {
            IPowershellMethods powershellMethods = PowershellMethodsFactory.CreatePowershellMethods();

            // This method will execute powershell via actual powershell WriteObject when ivoked from within powershell
            // and will just write the string to Console when not from powershell.
            powershellMethods.PSWriteObject("Hello Salvador");
        }
    }
}
