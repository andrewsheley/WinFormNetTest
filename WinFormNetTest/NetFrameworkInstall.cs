using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNetTest
{
    public partial class NetFrameworkInstall : Form
    {
        public NetFrameworkInstall(int major, int minor, int build, int revision)
        {
            InitializeComponent();

            lblMsgText.Text = $"The current .NET Framework version needs to be upgraded to version: {major}.{minor}.{build}.{revision}.\r\n\r\nMOVRS will not be able to run on this PC until that .NET Framework ( or higher ) is installed.\r\n\r\nClick the install link bottom left to begin download.  Must be connected to the internet during install.\r\n\r\nAfter the install you must relaunch MOVRS.  For more help click on the help link bottom right.";
            lnkNETFramework.Text = $"Install .NET Framework {major}.{minor}.{build}.{revision}";
            
        }

        private void NetFrameworkInstall_Load(object sender, EventArgs e)
        {

        }

        private void lnkNETFramework_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Start installer
            //Process.Start(@"C:\some_location\myapplication.exe");


            // open browser to link
            ProcessStartInfo sInfo = new ProcessStartInfo("http://localhost/download/NDP471-KB4033344-Web.exe");
            Process.Start(sInfo);

            System.Windows.Forms.Application.Exit();
        }
    }
}
