# Intro
Repo to demonstrate factory pattern by showing that we can isolate the WriteObject powershell cmdlet method to execute only when executing from powershell and writing to Console when not executing from powershell.

>Note that the `InPowershell` method may or may not work (was not tested in Powershell), and the code was simply copied from https://stackoverflow.com/questions/27022501/determine-whether-console-application-is-run-from-command-line-or-powershell

>Refinements can be made on that method to ensure that it works, but the purpose of this repo is only to demonstrate the factory pattern.

Notice that we created a **public** factory `PowershellMethodsFactory` which creates objects of **public** interface `IPowershellMethods`.
We also made all implementation of IPowershellMethods **private**.

In doing so, we force other consumers of this library to code against interfaces, instantiating IPowershellMethods objects exclusively via the factory. This will in turn make the code of those consumers testable.
