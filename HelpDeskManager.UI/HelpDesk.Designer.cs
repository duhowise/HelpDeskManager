using System.Windows.Forms;

namespace HelpDeskManager.UI
{
    partial class HelpDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpDesk));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.AllVisits = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.DepartureDate = new DevExpress.XtraEditors.DateEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.ArrivalDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Persontxt = new DevExpress.XtraEditors.TextEdit();
            this.Nametxt = new DevExpress.XtraEditors.TextEdit();
            this.Purposetxt = new DevExpress.XtraEditors.MemoEdit();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Arrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.searchbox = new DevExpress.XtraEditors.TextEdit();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.AllVisits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartureDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartureDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrivalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrivalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Persontxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nametxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Purposetxt.Properties)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchbox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.AllVisits);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.AllVisits,
            this.tabNavigationPage2,
            this.tabNavigationPage1,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(827, 399);
            this.tabPane1.SelectedPage = this.AllVisits;
            this.tabPane1.Size = new System.Drawing.Size(827, 399);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "Visits";
            // 
            // AllVisits
            // 
            this.AllVisits.Caption = "New Visit";
            this.AllVisits.Controls.Add(this.panelControl1);
            this.AllVisits.Name = "AllVisits";
            this.AllVisits.Size = new System.Drawing.Size(809, 354);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkEdit2);
            this.panelControl1.Controls.Add(this.DepartureDate);
            this.panelControl1.Controls.Add(this.checkEdit1);
            this.panelControl1.Controls.Add(this.ArrivalDate);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.Persontxt);
            this.panelControl1.Controls.Add(this.Nametxt);
            this.panelControl1.Controls.Add(this.Purposetxt);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(809, 354);
            this.panelControl1.TabIndex = 0;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(400, 256);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Now";
            this.checkEdit2.Size = new System.Drawing.Size(41, 19);
            this.checkEdit2.TabIndex = 15;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // DepartureDate
            // 
            this.DepartureDate.EditValue = null;
            this.DepartureDate.Location = new System.Drawing.Point(179, 226);
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartureDate.Properties.Appearance.Options.UseFont = true;
            this.DepartureDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DepartureDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DepartureDate.Size = new System.Drawing.Size(262, 24);
            this.DepartureDate.TabIndex = 14;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(400, 75);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Now";
            this.checkEdit1.Size = new System.Drawing.Size(41, 19);
            this.checkEdit1.TabIndex = 13;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.EditValue = null;
            this.ArrivalDate.Location = new System.Drawing.Point(179, 49);
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalDate.Properties.Appearance.Options.UseFont = true;
            this.ArrivalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ArrivalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ArrivalDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.ArrivalDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.ArrivalDate.Size = new System.Drawing.Size(262, 24);
            this.ArrivalDate.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(85, 52);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Arrival time";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(366, 293);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Save";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(64, 228);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Departure time";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(47, 199);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(115, 18);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Person of interest";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(63, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Purpose of visit";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(123, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 18);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Name";
            // 
            // Persontxt
            // 
            this.Persontxt.Location = new System.Drawing.Point(179, 196);
            this.Persontxt.Name = "Persontxt";
            this.Persontxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Persontxt.Properties.Appearance.Options.UseFont = true;
            this.Persontxt.Size = new System.Drawing.Size(262, 24);
            this.Persontxt.TabIndex = 2;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(179, 19);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nametxt.Properties.Appearance.Options.UseFont = true;
            this.Nametxt.Size = new System.Drawing.Size(262, 24);
            this.Nametxt.TabIndex = 0;
            // 
            // Purposetxt
            // 
            this.Purposetxt.Location = new System.Drawing.Point(179, 100);
            this.Purposetxt.Name = "Purposetxt";
            this.Purposetxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purposetxt.Properties.Appearance.Options.UseFont = true;
            this.Purposetxt.Size = new System.Drawing.Size(262, 90);
            this.Purposetxt.TabIndex = 1;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "All Visits";
            this.tabNavigationPage2.Controls.Add(this.panelControl2);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(809, 354);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.listView1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(809, 354);
            this.panelControl2.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Arrival,
            this.Departure});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(805, 350);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Name
            // 
            this.Name.Text = "Form1";
            this.Name.Width = 430;
            // 
            // Arrival
            // 
            this.Arrival.Text = "Arrival time";
            this.Arrival.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Arrival.Width = 185;
            // 
            // Departure
            // 
            this.Departure.Text = "Departure time";
            this.Departure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Departure.Width = 185;
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Search Visits";
            this.tabNavigationPage1.Controls.Add(this.panelControl3);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(809, 354);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.simpleButton1);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.searchbox);
            this.panelControl3.Controls.Add(this.listView2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(809, 354);
            this.panelControl3.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(337, 11);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 36);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(22, 21);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 18);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Search";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(83, 15);
            this.searchbox.Name = "searchbox";
            this.searchbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Properties.Appearance.Options.UseFont = true;
            this.searchbox.Size = new System.Drawing.Size(248, 24);
            this.searchbox.TabIndex = 3;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(2, 48);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(805, 307);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 430;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Arrival time";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Departure time";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 185;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "tabNavigationPage3";
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(809, 354);
            // 
            // HelpDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 399);
            this.Controls.Add(this.tabPane1);
            this.Text = "Visitation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.AllVisits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartureDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartureDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrivalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrivalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Persontxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nametxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Purposetxt.Properties)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchbox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage AllVisits;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.TextEdit Nametxt;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private ListView listView1;
        private ColumnHeader Name;
        private ColumnHeader Arrival;
        private ColumnHeader Departure;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit Persontxt;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit searchbox;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.DateEdit ArrivalDate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.DateEdit DepartureDate;
        private DevExpress.XtraEditors.MemoEdit Purposetxt;
    }
}

