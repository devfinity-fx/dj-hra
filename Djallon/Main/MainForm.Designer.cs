namespace Djallon.Assistant.Main
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.metroTabPanel1 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.sideNav1 = new DevComponents.DotNetBar.Controls.SideNav();
            this.sideNavPanel4 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel1 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel5 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel2 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel3 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.separator1 = new DevComponents.DotNetBar.Separator();
            this.navHome = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.navInfo = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.navPayslip = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.navLeaves = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.navPlanner = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.metroTabPanel2 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.tabHome = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.tabTimeReport = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.sideNav2 = new DevComponents.DotNetBar.Controls.SideNav();
            this.sideNavPanel6 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel7 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.separator2 = new DevComponents.DotNetBar.Separator();
            this.navTimeRecord = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.navProjectInfo = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.tabHrConnect = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.metroTabPanel3 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.sideNavItem1 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNavItem7 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.metroShell1.SuspendLayout();
            this.metroTabPanel1.SuspendLayout();
            this.sideNav1.SuspendLayout();
            this.metroTabPanel2.SuspendLayout();
            this.sideNav2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CanCustomize = false;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Controls.Add(this.metroTabPanel1);
            this.metroShell1.Controls.Add(this.metroTabPanel2);
            this.metroShell1.Controls.Add(this.metroTabPanel3);
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = null;
            this.metroShell1.HelpButtonVisible = false;
            this.metroShell1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabHome,
            this.tabTimeReport,
            this.tabHrConnect});
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(1, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.metroShell1.SettingsButtonText = "  SETTINGS";
            this.metroShell1.Size = new System.Drawing.Size(771, 516);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 0;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.SelectedTabChanged += new System.EventHandler(this.ChangeTab_Action);
            this.metroShell1.SettingsButtonClick += new System.EventHandler(this.Settings_Action);
            // 
            // metroTabPanel1
            // 
            this.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel1.Controls.Add(this.sideNav1);
            this.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel1.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroTabPanel1.Name = "metroTabPanel1";
            this.metroTabPanel1.Size = new System.Drawing.Size(771, 465);
            // 
            // 
            // 
            this.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel1.TabIndex = 1;
            // 
            // sideNav1
            // 
            this.sideNav1.Controls.Add(this.sideNavPanel1);
            this.sideNav1.Controls.Add(this.sideNavPanel5);
            this.sideNav1.Controls.Add(this.sideNavPanel4);
            this.sideNav1.Controls.Add(this.sideNavPanel3);
            this.sideNav1.Controls.Add(this.sideNavPanel2);
            this.sideNav1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNav1.EnableClose = false;
            this.sideNav1.EnableMaximize = false;
            this.sideNav1.EnableSplitter = false;
            this.sideNav1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sideNavItem7,
            this.separator1,
            this.navHome,
            this.navInfo,
            this.navPayslip,
            this.navLeaves,
            this.navPlanner});
            this.sideNav1.Location = new System.Drawing.Point(0, 0);
            this.sideNav1.Margin = new System.Windows.Forms.Padding(0);
            this.sideNav1.Name = "sideNav1";
            this.sideNav1.Padding = new System.Windows.Forms.Padding(1);
            this.sideNav1.Size = new System.Drawing.Size(771, 465);
            this.sideNav1.TabIndex = 0;
            this.sideNav1.Text = "sideNav1";
            // 
            // sideNavPanel4
            // 
            this.sideNavPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel4.Location = new System.Drawing.Point(121, 31);
            this.sideNavPanel4.Name = "sideNavPanel4";
            this.sideNavPanel4.Size = new System.Drawing.Size(649, 433);
            this.sideNavPanel4.TabIndex = 14;
            this.sideNavPanel4.Visible = false;
            // 
            // sideNavPanel1
            // 
            this.sideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel1.Location = new System.Drawing.Point(121, 31);
            this.sideNavPanel1.Name = "sideNavPanel1";
            this.sideNavPanel1.Size = new System.Drawing.Size(649, 433);
            this.sideNavPanel1.TabIndex = 2;
            // 
            // sideNavPanel5
            // 
            this.sideNavPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel5.Location = new System.Drawing.Point(121, 31);
            this.sideNavPanel5.Name = "sideNavPanel5";
            this.sideNavPanel5.Size = new System.Drawing.Size(649, 433);
            this.sideNavPanel5.TabIndex = 18;
            this.sideNavPanel5.Visible = false;
            // 
            // sideNavPanel2
            // 
            this.sideNavPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel2.Location = new System.Drawing.Point(121, 31);
            this.sideNavPanel2.Name = "sideNavPanel2";
            this.sideNavPanel2.Size = new System.Drawing.Size(649, 433);
            this.sideNavPanel2.TabIndex = 6;
            this.sideNavPanel2.Visible = false;
            // 
            // sideNavPanel3
            // 
            this.sideNavPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel3.Location = new System.Drawing.Point(121, 31);
            this.sideNavPanel3.Name = "sideNavPanel3";
            this.sideNavPanel3.Size = new System.Drawing.Size(649, 433);
            this.sideNavPanel3.TabIndex = 10;
            this.sideNavPanel3.Visible = false;
            // 
            // separator1
            // 
            this.separator1.FixedSize = new System.Drawing.Size(3, 1);
            this.separator1.Name = "separator1";
            this.separator1.Padding.Bottom = 2;
            this.separator1.Padding.Left = 6;
            this.separator1.Padding.Right = 6;
            this.separator1.Padding.Top = 2;
            this.separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // navHome
            // 
            this.navHome.Checked = true;
            this.navHome.Name = "navHome";
            this.navHome.Panel = this.sideNavPanel1;
            this.navHome.Symbol = "";
            this.navHome.Text = "Home";
            // 
            // navInfo
            // 
            this.navInfo.Name = "navInfo";
            this.navInfo.Panel = this.sideNavPanel2;
            this.navInfo.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sideNavItem1});
            this.navInfo.Symbol = "58390";
            this.navInfo.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.navInfo.Text = "Information";
            // 
            // navPayslip
            // 
            this.navPayslip.Name = "navPayslip";
            this.navPayslip.Panel = this.sideNavPanel3;
            this.navPayslip.Symbol = "57416";
            this.navPayslip.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.navPayslip.Text = "Payslip";
            // 
            // navLeaves
            // 
            this.navLeaves.Name = "navLeaves";
            this.navLeaves.Panel = this.sideNavPanel4;
            this.navLeaves.Symbol = "58715";
            this.navLeaves.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.navLeaves.Text = "Leave Balances";
            // 
            // navPlanner
            // 
            this.navPlanner.Name = "navPlanner";
            this.navPlanner.Panel = this.sideNavPanel5;
            this.navPlanner.Symbol = "58902";
            this.navPlanner.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.navPlanner.Text = "Planner";
            // 
            // metroTabPanel2
            // 
            this.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel2.Controls.Add(this.sideNav2);
            this.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel2.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.metroTabPanel2.Name = "metroTabPanel2";
            this.metroTabPanel2.Size = new System.Drawing.Size(771, 465);
            // 
            // 
            // 
            this.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel2.TabIndex = 2;
            this.metroTabPanel2.Visible = false;
            // 
            // tabHome
            // 
            this.tabHome.Checked = true;
            this.tabHome.Name = "tabHome";
            this.tabHome.Panel = this.metroTabPanel1;
            this.tabHome.Text = "&HOME";
            // 
            // tabTimeReport
            // 
            this.tabTimeReport.Name = "tabTimeReport";
            this.tabTimeReport.Panel = this.metroTabPanel2;
            this.tabTimeReport.Text = "&TIME REPORT";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "DJallon Employee App";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.Black;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1});
            this.metroStatusBar1.Location = new System.Drawing.Point(1, 517);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(771, 21);
            this.metroStatusBar1.TabIndex = 1;
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "READY";
            // 
            // sideNav2
            // 
            this.sideNav2.Controls.Add(this.sideNavPanel6);
            this.sideNav2.Controls.Add(this.sideNavPanel7);
            this.sideNav2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNav2.EnableClose = false;
            this.sideNav2.EnableMaximize = false;
            this.sideNav2.EnableSplitter = false;
            this.sideNav2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.separator2,
            this.navTimeRecord,
            this.navProjectInfo});
            this.sideNav2.Location = new System.Drawing.Point(0, 0);
            this.sideNav2.Margin = new System.Windows.Forms.Padding(0);
            this.sideNav2.Name = "sideNav2";
            this.sideNav2.Size = new System.Drawing.Size(771, 465);
            this.sideNav2.TabIndex = 1;
            this.sideNav2.Text = "sideNav2";
            // 
            // sideNavPanel6
            // 
            this.sideNavPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel6.Location = new System.Drawing.Point(117, 30);
            this.sideNavPanel6.Name = "sideNavPanel6";
            this.sideNavPanel6.Size = new System.Drawing.Size(654, 435);
            this.sideNavPanel6.TabIndex = 2;
            // 
            // sideNavPanel7
            // 
            this.sideNavPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel7.Location = new System.Drawing.Point(117, 30);
            this.sideNavPanel7.Name = "sideNavPanel7";
            this.sideNavPanel7.Size = new System.Drawing.Size(654, 435);
            this.sideNavPanel7.TabIndex = 6;
            this.sideNavPanel7.Visible = false;
            // 
            // separator2
            // 
            this.separator2.FixedSize = new System.Drawing.Size(3, 1);
            this.separator2.Name = "separator2";
            this.separator2.Padding.Bottom = 2;
            this.separator2.Padding.Left = 6;
            this.separator2.Padding.Right = 6;
            this.separator2.Padding.Top = 2;
            this.separator2.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // navTimeRecord
            // 
            this.navTimeRecord.Checked = true;
            this.navTimeRecord.Name = "navTimeRecord";
            this.navTimeRecord.Panel = this.sideNavPanel6;
            this.navTimeRecord.Symbol = "";
            this.navTimeRecord.Text = "Time Record";
            // 
            // navProjectInfo
            // 
            this.navProjectInfo.Name = "navProjectInfo";
            this.navProjectInfo.Panel = this.sideNavPanel7;
            this.navProjectInfo.Symbol = "58390";
            this.navProjectInfo.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.navProjectInfo.Text = "Project Details";
            // 
            // tabHrConnect
            // 
            this.tabHrConnect.Name = "tabHrConnect";
            this.tabHrConnect.Panel = this.metroTabPanel3;
            this.tabHrConnect.Text = "HR &CONNECT";
            this.tabHrConnect.Click += new System.EventHandler(this.metroTabItem3_Click);
            // 
            // metroTabPanel3
            // 
            this.metroTabPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel3.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.metroTabPanel3.Name = "metroTabPanel3";
            this.metroTabPanel3.Size = new System.Drawing.Size(771, 465);
            // 
            // 
            // 
            this.metroTabPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel3.TabIndex = 3;
            this.metroTabPanel3.Visible = false;
            // 
            // sideNavItem1
            // 
            this.sideNavItem1.IsSystemMenu = true;
            this.sideNavItem1.Name = "sideNavItem1";
            this.sideNavItem1.Symbol = "";
            this.sideNavItem1.Text = "Menu";
            // 
            // sideNavItem7
            // 
            this.sideNavItem7.FontBold = true;
            this.sideNavItem7.IsSystemMenu = true;
            this.sideNavItem7.Name = "sideNavItem7";
            this.sideNavItem7.Symbol = "";
            this.sideNavItem7.Text = "Menu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 539);
            this.Controls.Add(this.metroShell1);
            this.Controls.Add(this.metroStatusBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.metroShell1.ResumeLayout(false);
            this.metroShell1.PerformLayout();
            this.metroTabPanel1.ResumeLayout(false);
            this.sideNav1.ResumeLayout(false);
            this.sideNav1.PerformLayout();
            this.metroTabPanel2.ResumeLayout(false);
            this.sideNav2.ResumeLayout(false);
            this.sideNav2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel2;
        private DevComponents.DotNetBar.Metro.MetroTabItem tabHome;
        private DevComponents.DotNetBar.Metro.MetroTabItem tabTimeReport;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.Controls.SideNav sideNav1;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel1;
        private DevComponents.DotNetBar.Separator separator1;
        private DevComponents.DotNetBar.Controls.SideNavItem navHome;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel5;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel4;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel3;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel2;
        private DevComponents.DotNetBar.Controls.SideNavItem navInfo;
        private DevComponents.DotNetBar.Controls.SideNavItem navPayslip;
        private DevComponents.DotNetBar.Controls.SideNavItem navLeaves;
        private DevComponents.DotNetBar.Controls.SideNavItem navPlanner;
        private DevComponents.DotNetBar.Controls.SideNav sideNav2;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel7;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel6;
        private DevComponents.DotNetBar.Separator separator2;
        private DevComponents.DotNetBar.Controls.SideNavItem navTimeRecord;
        private DevComponents.DotNetBar.Controls.SideNavItem navProjectInfo;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel3;
        private DevComponents.DotNetBar.Metro.MetroTabItem tabHrConnect;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem7;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem1;
    }
}

