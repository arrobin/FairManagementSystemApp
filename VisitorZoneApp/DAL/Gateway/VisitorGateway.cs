using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorZoneApp.DAL.DAO;

namespace VisitorZoneApp.DAL.Gateway
{
    class VisitorGateway
    {
        private SqlConnection aConnection = new SqlConnection();
        
        public VisitorGateway()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["VisitorZoneDB"].ConnectionString;
            aConnection.ConnectionString = connectionString;
            
        }
        public bool SaveVesitorWithZone(Visitor aVisitor, List<Zone> zoneListforSave)
        {
            aConnection.Open();
            string query = string.Format("INSERT INTO tbl_visitor VALUES('{0}','{1}','{2}')", aVisitor.VisitorName, aVisitor.VisitorEmail, aVisitor.VisitorPhone);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (SaveVisitorandZoneinJointTable(aVisitor.VisitorEmail, zoneListforSave)&& total>0)
            {
                return true;
            }
           
            return false;
        }

        private bool SaveVisitorandZoneinJointTable(string visitorEmail, List<Zone> zoneListforSave)
        {
            int visitorId = GetVisitorId(visitorEmail);
            int total=0;
            foreach (var zones in zoneListforSave)
            {
                aConnection.Open();
                string query = string.Format("INSERT INTO tbl_joint_visitor_zone VALUES({0},{1})", visitorId, zones.Id);

                SqlCommand aCommand = new SqlCommand(query, aConnection);
                total =+ aCommand.ExecuteNonQuery();
                aConnection.Close();
                
            }
            if (total > 0)
                return true;
            return false;

        }

        private int GetVisitorId(string visitorEmail)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM tbl_visitor WHERE email='{0}'",visitorEmail);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            Visitor aVisitor = new Visitor();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                   aVisitor.VisitorId = (int)aReader[0];
                }
            }
            aReader.Close();
            aConnection.Close();
            return aVisitor.VisitorId;
        }

        public List<Visitor> GetVisitorbyZoneId(int zoneId)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM tbl_joint_visitor_zone WHERE zoneid={0}", zoneId);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<int> visitorIdList = new List<int>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    int id = (int)aReader["visitorid"];
                    visitorIdList.Add(id);
                }
            }
            aReader.Close();
            aConnection.Close();

            List<Visitor> visitorsList = GetVisitorList(visitorIdList);
            return visitorsList;
        }

        private List<Visitor> GetVisitorList(List<int> visitorIdList)
        {
            List<Visitor> visitorsList = new List<Visitor>();
            foreach (var visitorId in visitorIdList)
            {
                aConnection.Open();
                string query = string.Format("SELECT * FROM tbl_visitor WHERE id={0}", visitorId);
                SqlCommand aCommand = new SqlCommand(query, aConnection);
                SqlDataReader aReader = aCommand.ExecuteReader();
                
                if (aReader.HasRows)
                {
                    while (aReader.Read())
                    {
                        Visitor aVisitor = new Visitor();
                        aVisitor.VisitorId = (int)aReader[0];
                        aVisitor.VisitorName = aReader[1].ToString();
                        aVisitor.VisitorEmail = aReader[2].ToString();
                        aVisitor.VisitorPhone = aReader[3].ToString();

                        visitorsList.Add(aVisitor);
                    }
                }
                aReader.Close();
                aConnection.Close();
            }
            return visitorsList;

        }

        public bool IsThisEmailAlreadyinSystem(string visitorEmail)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM tbl_visitor WHERE email='{0}'", visitorEmail);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool msg = aReader.HasRows;
            aConnection.Close();
            return msg;
        }
    }
}
