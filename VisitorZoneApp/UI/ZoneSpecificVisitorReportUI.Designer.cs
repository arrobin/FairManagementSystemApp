namespace VisitorZoneApp.UI
{
    partial class ZoneSpecificVisitorReportUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.zoneComboBox = new System.Windows.Forms.ComboBox();
            this.showZoneSpecificVisitorReportDetailsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.exporttoExcelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Zone";
            // 
            // zoneComboBox
            // 
            this.zoneComboBox.FormattingEnabled = true;
            this.zoneComboBox.Location = new System.Drawing.Point(141, 44);
            this.zoneComboBox.Name = "zoneComboBox";
            this.zoneComboBox.Size = new System.Drawing.Size(314, 21);
            this.zoneComboBox.TabIndex = 0;
            // 
            // showZoneSpecificVisitorReportDetailsListView
            // 
            this.showZoneSpecificVisitorReportDetailsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.showZoneSpecificVisitorReportDetailsListView.FullRowSelect = true;
            this.showZoneSpecificVisitorReportDetailsListView.GridLines = true;
            this.showZoneSpecificVisitorReportDetailsListView.Location = new System.Drawing.Point(12, 107);
            this.showZoneSpecificVisitorReportDetailsListView.Name = "showZoneSpecificVisitorReportDetailsListView";
            this.showZoneSpecificVisitorReportDetailsListView.Size = new System.Drawing.Size(545, 181);
            this.showZoneSpecificVisitorReportDetailsListView.TabIndex = 2;
            this.showZoneSpecificVisitorReportDetailsListView.UseCompatibleStateImageBehavior = false;
            this.showZoneSpecificVisitorReportDetailsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Visitor Name";
            this.columnHeader1.Width = 168;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contact Number";
            this.columnHeader3.Width = 168;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(431, 301);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(126, 20);
            this.totalTextBox.TabIndex = 2;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(482, 44);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // exporttoExcelButton
            // 
            this.exporttoExcelButton.Location = new System.Drawing.Point(371, 355);
            this.exporttoExcelButton.Name = "exporttoExcelButton";
            this.exporttoExcelButton.Size = new System.Drawing.Size(186, 23);
            this.exporttoExcelButton.TabIndex = 3;
            this.exporttoExcelButton.Text = "Export to Excel";
            this.exporttoExcelButton.UseVisualStyleBackColor = true;
            this.exporttoExcelButton.Click += new System.EventHandler(this.exporttoExcelButton_Click);
            // 
            // ZoneSpecificVisitorReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 408);
            this.Controls.Add(this.exporttoExcelButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showZoneSpecificVisitorReportDetailsListView);
            this.Controls.Add(this.zoneComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ZoneSpecificVisitorReportUI";
            this.Text = "ZoneSpecificVisitorReportUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox zoneComboBox;
        private System.Windows.Forms.ListView showZoneSpecificVisitorReportDetailsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button exporttoExcelButton;
    }
}