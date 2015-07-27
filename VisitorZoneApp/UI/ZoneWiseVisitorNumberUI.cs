using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorZoneApp.BLL;
using VisitorZoneApp.DAL.DAO;

namespace VisitorZoneApp.UI
{
    public partial class ZoneWiseVisitorNumberUI : Form
    {
        public ZoneWiseVisitorNumberUI()
        {
            InitializeComponent();
            LoadZoneWiseVisitorListView();
        }

        private void LoadZoneWiseVisitorListView()
        {
            showZoneWiseVisitorListView.Items.Clear();
            ZoneManager aZoneManager = new ZoneManager();
            VisitorManager aVisitorManager = new VisitorManager();
            int numberofVisitor = 0;
            double totalVisitor = 0;
            
            List<Zone> zoneList = aZoneManager.GetAllZone();
            
            foreach (var zone in zoneList)
            {
                List<Visitor> visitors = aVisitorManager.GetVisitorbyZoneId(zone.Id);
              
                foreach (var visitor in visitors)
                {
                    numberofVisitor++;
                }

                ListViewItem item = new ListViewItem(zone.Name);
                item.SubItems.Add(numberofVisitor.ToString());

                showZoneWiseVisitorListView.Items.Add(item);
                totalVisitor += numberofVisitor;

                numberofVisitor = 0;
            }
            totalTextBox.Text = totalVisitor.ToString();
        }
    }
}
