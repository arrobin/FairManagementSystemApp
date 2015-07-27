using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using VisitorZoneApp.DAL.DAO;
using Zone = VisitorZoneApp.DAL.DAO.Zone;

namespace VisitorZoneApp.DAL.Gateway
{
    class ZoneGateway
    {
        private SqlConnection connectionObj;
        private SqlCommand commandObj;

        public ZoneGateway()
        {
           connectionObj = new SqlConnection(ConfigurationManager.ConnectionStrings["VisitorZoneDB"].ConnectionString);
           commandObj = new SqlCommand();
           commandObj.Connection = connectionObj;
        }


        public bool SaveZone(Zone aZone)
        {
            string insert = "INSERT INTO tbl_zone VALUES('" + aZone.Name + "')";
            connectionObj.Open();
            commandObj.CommandText = insert;
            int rowAffected = commandObj.ExecuteNonQuery();
            connectionObj.Close();
            if (rowAffected>0)
            {
                return true;
            }
            return false;
        }

        public bool HasThisZoneExists(Zone aZone)
        {
            string insert = "SELECT * FROM tbl_zone WHERE zoneName='" + aZone.Name + "'";
            connectionObj.Open();
            commandObj.CommandText = insert;
            SqlDataReader reader = commandObj.ExecuteReader();

            bool zoneStatus = reader.HasRows;
            reader.Close();
            connectionObj.Close();

            return zoneStatus;
        }

        public List<Zone> GetAllZoneName()
        {
            string select = "SELECT * FROM tbl_zone";
            connectionObj.Open();
            commandObj.CommandText = select;
            SqlDataReader reader = commandObj.ExecuteReader();
            List<Zone> zoneList = new List<Zone>();
            while (reader.Read())
            {
                Zone aZone = new Zone();
                aZone.Id = (int)reader["id"];
                aZone.Name = reader["zoneName"].ToString();
                zoneList.Add(aZone);
            }
            reader.Close();
            connectionObj.Close();
            return zoneList;
        }

        public List<JointVisitorZone> GetAllZoneWiseVisitor()
        {
            string select = "SELECT * FROM tbl_joint_visitor_zone";
            connectionObj.Open();
            commandObj.CommandText = select;
            SqlDataReader reader = commandObj.ExecuteReader();
            List<JointVisitorZone> zoneWiseVisitorList = new List<JointVisitorZone>();
            while (reader.Read())
            {
                JointVisitorZone aJointVisitorZone = new JointVisitorZone();
                aJointVisitorZone.Id = (int)reader[0];
                aJointVisitorZone.VisitorId = (int)reader[1];
                aJointVisitorZone.ZoneId = (int)reader[2];
                zoneWiseVisitorList.Add(aJointVisitorZone);
            }
            reader.Close();
            connectionObj.Close();
            return zoneWiseVisitorList;
        }

        public string GetZoneNamebyId(int zoneId)
        {
            string select = "SELECT * FROM tbl_zone WHERE id='" + zoneId + "'";
            connectionObj.Open();
            commandObj.CommandText = select;
            SqlDataReader reader = commandObj.ExecuteReader();
            string zoneName="";
            
            while (reader.Read())
            {
                zoneName = reader[1].ToString();
                
            }
            reader.Close();
            connectionObj.Close();
            return zoneName;
        }
    }
}
