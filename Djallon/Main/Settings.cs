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
    public partial class Settings : DevComponents.DotNetBar.OfficeForm
    {
        private StyleManager sMgr;
        public Settings(StyleManager sMgr)
        {
            this.sMgr = sMgr;
            InitializeComponent();

            MetroColorGeneratorParameters[] metroThemes = MetroColorGeneratorParameters.GetAllPredefinedThemes();
            

            foreach(var x in metroThemes)
            {
                radDropDownList1.Items.Add(x.ThemeName);
            }
        }
        

        private void SelectedIndexChangedEvent(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            sMgr.MetroColorParameters = MetroColorGeneratorParameters.GetAllPredefinedThemes()[radDropDownList1.SelectedIndex];
        }
    }
}