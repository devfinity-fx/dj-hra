namespace Djallon.Assistant.Main
{
    partial class Settings
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
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.w8 = new Telerik.WinControls.Themes.Windows8Theme();
            this.o13 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radDropDownList2 = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            this.SuspendLayout();
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Location = new System.Drawing.Point(57, 126);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(192, 20);
            this.radDropDownList1.TabIndex = 1;
            this.radDropDownList1.Text = "radDropDownList1";
            this.radDropDownList1.ThemeName = "Windows8";
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.SelectedIndexChangedEvent);
            // 
            // radDropDownList2
            // 
            this.radDropDownList2.Location = new System.Drawing.Point(57, 100);
            this.radDropDownList2.Name = "radDropDownList2";
            this.radDropDownList2.Size = new System.Drawing.Size(192, 20);
            this.radDropDownList2.TabIndex = 2;
            this.radDropDownList2.Text = "radDropDownList2";
            this.radDropDownList2.ThemeName = "Windows8";
            // 
            // Settings
            // 
            this.ClientSize = new System.Drawing.Size(323, 387);
            this.Controls.Add(this.radDropDownList2);
            this.Controls.Add(this.radDropDownList1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.Themes.Windows8Theme w8;
        private Telerik.WinControls.Themes.Office2013LightTheme o13;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList2;
    }
}