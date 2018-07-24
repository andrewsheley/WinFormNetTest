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

            lblMsgText.Text = $"The current .NET Framework version needs to be upgraded to at least version: {major}.{minor}.{build}.{revision}.\r\n\r\nMOVRS will not be able to run on this PC until that .NET Framework ( or higher ) is installed.\r\n\r\nClick on the link below to begin the install.\r\n\r\nAfter the install you must relaunch MOVRS.";
            lnkNETFramework.Text = $"Install .NET Framework {major}.{minor}.{build}.{revision}";
            
        }

        private void NetFrameworkInstall_Load(object sender, EventArgs e)
        {

        }

        private void lnkNETFramework_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Start installer
            Process.Start(@"C:\some_location\myapplication.exe");


            // open browser to link
            ProcessStartInfo sInfo = new ProcessStartInfo("http://cjonline.com");
            Process.Start(sInfo);

            System.Windows.Forms.Application.Exit();
        }
    }
}
