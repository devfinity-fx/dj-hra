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
    public partial class Settings : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        private MetroColorGeneratorParameters[] metroThemes = MetroColorGeneratorParameters.GetAllPredefinedThemes();
        private StyleManager smgr;
        public Settings(StyleManager sMgr)
        {
            this.smgr = sMgr;
            InitializeComponent();

            

            foreach(var x in metroThemes)
            {
                comboBoxEx1.Items.Add(x.ThemeName);
            }
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            smgr.MetroColorParameters = metroThemes[comboBoxEx1.SelectedIndex];
        }
    }
}