using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using VisitorZoneApp.BLL;
using VisitorZoneApp.DAL.DAO;

namespace VisitorZoneApp.UI
{
    public partial class VisitorEntryUi : Form
    {
        ZoneManager zoneManager = new ZoneManager();
        VisitorManager visitorManager = new VisitorManager();
        private List<Zone> zoneList;
        
        public VisitorEntryUi()
        {
            InitializeComponent();
            LoadCheckListBox();

        }

        private void LoadCheckListBox()
        {
            zoneList = zoneManager.GetAllZone();
            zoneTypeCheckedListBox.Items.Clear();
            foreach (var zone in zoneList)
            {
                var item = zoneTypeCheckedListBox.Items;
                item.Add(zone.Name, true);
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            Visitor aVisitor = new Visitor();
            aVisitor.VisitorName=nameTextBox.Text;
            aVisitor.VisitorEmail = emailTextBox.Text;
            aVisitor.VisitorPhone = contactNumberTextBox.Text;
            if (nameTextBox.Text!="" && emailTextBox.Text!="" && contactNumberTextBox.Text!="")
            {
                List<Zone> zoneListforSave = new List<Zone>();

                foreach (var zones in zoneList)
                {
                    foreach (string itemChecked in zoneTypeCheckedListBox.CheckedItems)
                    {
                        string name = itemChecked;
                        if (name == zones.Name)
                        {
                            zoneListforSave.Add(zones);
                            
                        }
                    }
                }

                string message = visitorManager.SaveVesitorWithZone(aVisitor, zoneListforSave);
                MessageBox.Show(message, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nameTextBox.Clear();
                emailTextBox.Clear();
                contactNumberTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please Fillup All TextBox!!!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadCheckListBox();


        }

        

   }
}
