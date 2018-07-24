using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormNetTest
{
    public static class CheckNetFramework
    {
        public static void VerifyFrameworkLevel(int major, int minor, int build, int revision)
        {
            var netVersion = Environment.Version;
            
            // Check current .NET Framework equals or above version required
            if (netVersion.Major < major || netVersion.Minor < minor || netVersion.Build < build ||netVersion.Revision < revision)
            {
                NetFrameworkInstall netFrameworkInstall = new NetFrameworkInstall(major, minor, build, revision);
                netFrameworkInstall.ShowDialog();

                // Exit application
                System.Windows.Forms.Application.Exit();
                Environment.Exit(0);
            }
        }
        
    }
}
