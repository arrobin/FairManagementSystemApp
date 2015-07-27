namespace VisitorZoneApp.UI
{
    partial class ZoneWiseVisitorNumberUI
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
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showZoneWiseVisitorListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(276, 261);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(122, 20);
            this.totalTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total";
            // 
            // showZoneWiseVisitorListView
            // 
            this.showZoneWiseVisitorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.showZoneWiseVisitorListView.FullRowSelect = true;
            this.showZoneWiseVisitorListView.GridLines = true;
            this.showZoneWiseVisitorListView.Location = new System.Drawing.Point(30, 22);
            this.showZoneWiseVisitorListView.Name = "showZoneWiseVisitorListView";
            this.showZoneWiseVisitorListView.Size = new System.Drawing.Size(367, 233);
            this.showZoneWiseVisitorListView.TabIndex = 0;
            this.showZoneWiseVisitorListView.UseCompatibleStateImageBehavior = false;
            this.showZoneWiseVisitorListView.View = System.Windows.Forms.View.Details;

            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zone";
            this.columnHeader2.Width = 209;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No of Visitors";
            this.columnHeader3.Width = 144;
            // 
            // ZoneWiseVisitorNumberUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 297);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showZoneWiseVisitorListView);
            this.Name = "ZoneWiseVisitorNumberUI";
            this.Text = "ZoneWiseVisitorNumberUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView showZoneWiseVisitorListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}