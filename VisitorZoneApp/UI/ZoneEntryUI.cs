using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorZoneApp.BLL;
using VisitorZoneApp.DAL.DAO;
using Zone = VisitorZoneApp.DAL.DAO.Zone;

namespace VisitorZoneApp.UI
{
    public partial class ZoneEntryUi : Form
    {
        ZoneManager zoneManager = new ZoneManager();
        public ZoneEntryUi()
        {
            InitializeComponent();
            LoadZoneName();
        }
        
        private void zoneSaveButton_Click(object sender, EventArgs e)
        {
            Zone aZone = new Zone();
            aZone.Name = zoneTypeNameTextBox.Text;
            if (zoneTypeNameTextBox.Text!="")
            {
                string message = zoneManager.SaveZone(aZone);
                MessageBox.Show(message,@"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                zoneTypeNameTextBox.Clear();
            }
            else
            {
                MessageBox.Show(@"Zone field empty",@"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            LoadZoneName();
        }

        public void LoadZoneName()
        {
            List<Zone> zoneList = zoneManager.GetAllZone();
            int serialNo = 1;
            zoneListView.Items.Clear();
            foreach (var zone in zoneList)
            {
                ListViewItem item  = new ListViewItem(serialNo.ToString());
                item.SubItems.Add(zone.Name);
                zoneListView.Items.Add(item);
                serialNo++;
            }
        }
    }
}
