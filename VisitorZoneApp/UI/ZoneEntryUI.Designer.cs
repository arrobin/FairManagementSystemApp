namespace VisitorZoneApp.UI
{
    partial class ZoneEntryUi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zoneSaveButton = new System.Windows.Forms.Button();
            this.zoneTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zoneListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zoneSaveButton);
            this.groupBox1.Controls.Add(this.zoneTypeNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zone Type";
            // 
            // zoneSaveButton
            // 
            this.zoneSaveButton.Location = new System.Drawing.Point(231, 63);
            this.zoneSaveButton.Name = "zoneSaveButton";
            this.zoneSaveButton.Size = new System.Drawing.Size(92, 22);
            this.zoneSaveButton.TabIndex = 1;
            this.zoneSaveButton.Text = "Save";
            this.zoneSaveButton.UseVisualStyleBackColor = true;
            this.zoneSaveButton.Click += new System.EventHandler(this.zoneSaveButton_Click);
            // 
            // zoneTypeNameTextBox
            // 
            this.zoneTypeNameTextBox.Location = new System.Drawing.Point(150, 30);
            this.zoneTypeNameTextBox.Name = "zoneTypeNameTextBox";
            this.zoneTypeNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.zoneTypeNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            // 
            // zoneListView
            // 
            this.zoneListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.zoneListView.FullRowSelect = true;
            this.zoneListView.GridLines = true;
            this.zoneListView.Location = new System.Drawing.Point(46, 158);
            this.zoneListView.Name = "zoneListView";
            this.zoneListView.Size = new System.Drawing.Size(341, 119);
            this.zoneListView.TabIndex = 2;
            this.zoneListView.UseCompatibleStateImageBehavior = false;
            this.zoneListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No.";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zone Type";
            this.columnHeader2.Width = 273;
            // 
            // ZoneEntryUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 312);
            this.Controls.Add(this.zoneListView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZoneEntryUi";
            this.ShowIcon = false;
            this.Text = "Zone Type Entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zoneTypeNameTextBox;
        private System.Windows.Forms.Button zoneSaveButton;
        private System.Windows.Forms.ListView zoneListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}