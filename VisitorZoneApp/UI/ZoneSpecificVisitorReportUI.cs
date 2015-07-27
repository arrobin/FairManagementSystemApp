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
    public partial class ZoneSpecificVisitorReportUI : Form
    {
        public ZoneSpecificVisitorReportUI()
        {
            InitializeComponent();
            populateZoneCombobox();
        }
        ZoneManager aZoneManager = new ZoneManager();
        VisitorManager aVisitorManager=new VisitorManager();
        private int totalVisitorNumberforExportExcel = 0;

        private void populateZoneCombobox()
        {
            zoneComboBox.DataSource = aZoneManager.GetAllZone();
            zoneComboBox.DisplayMember = "Name";
            zoneComboBox.ValueMember = "Id";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showZoneSpecificVisitorReportDetailsListView.Items.Clear();
            Zone zone = (Zone)zoneComboBox.SelectedItem;
            int zoneId = zone.Id;
            int totalVisitorNumber = 0;
            List<Visitor> visitors = aVisitorManager.GetVisitorbyZoneId(zoneId);
            foreach (var visitor in visitors)
            {
                ListViewItem item = new ListViewItem(visitor.VisitorName);
                item.SubItems.Add(visitor.VisitorEmail);
                item.SubItems.Add(visitor.VisitorPhone);

                showZoneSpecificVisitorReportDetailsListView.Items.Add(item);
                totalVisitorNumber++;
            }

            totalTextBox.Text = totalVisitorNumber.ToString();
            totalVisitorNumberforExportExcel = totalVisitorNumber;
        }

        private void exporttoExcelButton_Click(object sender, EventArgs e)
        {
            if (showZoneSpecificVisitorReportDetailsListView.Items.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excleObj = new Microsoft.Office.Interop.Excel.Application();

                excleObj.Visible = true;

                Microsoft.Office.Interop.Excel.Workbook workbook = excleObj.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excleObj.ActiveSheet;

                excleObj.Columns.ColumnWidth = 22;
                worksheet.Cells[1, 1] = "Visitor Name";
                worksheet.Cells[1, 2] = "Email";
                worksheet.Cells[1, 3] = "Contact Number";

                int row = 2;

                int coloum = 1;

                foreach (ListViewItem comp in showZoneSpecificVisitorReportDetailsListView.Items)
                {

                    worksheet.Cells[row, coloum] = comp.Text.ToString();


                    foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                    {

                        worksheet.Cells[row, coloum] = drv.Text.ToString();

                        coloum++;

                    }

                    coloum = 1;

                    row++;

                }
                worksheet.Cells[row + 1, 2] = "Total VisitorNumbers =";
                worksheet.Cells[row + 1, 3] = totalVisitorNumberforExportExcel;
            }
            else
            {
                MessageBox.Show("There is no Data", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
