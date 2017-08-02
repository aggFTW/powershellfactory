namespace PowershellSalvador
{
    using System.Diagnostics;

    internal class PowershellMethodsFactory
    {
        public static IPowershellMethods CreatePowershellMethods()
        {
            if (InPowershell())
            {
                return new PowershellMethods();
            }
            return new TestPowershellMethods();
        }

        private static bool InPowershell()
        {
            var launcher = Process.GetCurrentProcess().Parent();
            return launcher.ProcessName == "powershell";
        }
    }
}
