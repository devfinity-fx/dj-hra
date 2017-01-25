using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Metro.ColorTables;

namespace Djallon.Assistant.Main
{
    public partial class MainForm : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Settings_Action(object sender, EventArgs e)
        {
            new Settings(styleManager1).ShowDialog();
        }

        private void metroTabItem3_Click(object sender, EventArgs e)
        {

        }

        private void ChangeTab_Action(object sender, EventArgs e)
        {
            if(metroShell1.SelectedTab==tabHome)
            {
                navHome.Select();
            }
            else if(metroShell1.SelectedTab==tabTimeReport)
            {
                navTimeRecord.Select();
            }
            else if(metroShell1.SelectedTab==tabHrConnect)
            {

            }
        }
    }
}