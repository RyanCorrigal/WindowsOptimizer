using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsOptimizerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var windowsOptimizerCore = new WindowsOptimizerCore.WindowsOptimizerCore();
            var registrySettings = new WindowsOptimizerCore.WindowsOptimizerCore().registrySettings;
        }
    }
}
