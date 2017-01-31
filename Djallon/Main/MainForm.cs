using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.SuperGrid;

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
            if (metroShell1.SelectedTab==tabTimeReport)
            {
                navTimeRecord.Select();

                GridPanel panel = superGridControl1.PrimaryGrid;
                panel.NullString = null;
                panel.AllowEmptyCellSelection = true;
                panel.ShowRowGridIndex = true;
                panel.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.Select;
                panel.Rows.Clear();

                panel.Rows.Add(new GridRow());

            }
            if (metroShell1.SelectedTab==tabHrConnect)
            {

            }
        }

        private void HomeNav_Action(object sender, EventArgs e)
        {
            SideNavItem item = (SideNavItem)sender;
            if(item==navPlanner)
            {

            }
            if(item==navInfo)
            {

            }
        }

        private void CivilStatus_Changed(object sender, EventArgs e)
        {
            cmbTaxStatus.Items.Clear();
            cmbTaxStatus.Items.Add("Z - No TIN Number");

            switch (cmbCivilStatus.SelectedIndex)
            {
                case 0:
                    cmbTaxStatus.Items.AddRange(
                        new String[]{
                            "S - Single",
                            "S1 - Single with 1 Child",
                            "S2 - Single with 2 Children",
                            "S3 - Single with 3 Children",
                            "S4 - Single with 4 Children"
                        }
                    );
                    break;
                default:
                    cmbTaxStatus.Items.AddRange(
                        new String[]{
                            "ME - Married (no child)",
                            "ME1 - Married with 1 Child",
                            "ME2 - Married with 2 Children",
                            "ME3 - Married with 3 Children",
                            "ME4 - Married with 4 Children"
                        }
                    );
                    break;
            }
        }

        private void AddShit_Action(object sender, EventArgs e)
        {

        }

        private void Load_Event(object sender, EventArgs e)
        {
            MetroShell.SelectedTab = tabHome;
        }
        
    }
}