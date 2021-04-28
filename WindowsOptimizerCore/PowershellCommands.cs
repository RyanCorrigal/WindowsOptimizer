using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace WindowsOptimizerCore
{
    class PowershellCommands
    {
    void Powershell()
        {
            var powerShell = PowerShell.Create(RunspaceMode.CurrentRunspace);
            powerShell.AddCommand("Get-AppxPackage");
            powerShell.AddParameter("AllUsers");
            powerShell.AddParameter("Name", "Microsoft.YourPhone");
            powerShell.
            powerShell.
        }
    }
}
