using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorZoneApp.DAL.DAO;
using VisitorZoneApp.DAL.Gateway;

namespace VisitorZoneApp.BLL
{
    class ZoneManager
    {
        ZoneGateway zoneGateway= new ZoneGateway();
        public string SaveZone(Zone aZone)
        {
            if (zoneGateway.HasThisZoneExists(aZone))
            {
                return "Zone already Exists!";
            }
            else
            {

                if (zoneGateway.SaveZone(aZone))
                {
                    return "Successfull";
                }
                else
                {
                    return "Faild";
                }
            }
        }

        public List<Zone> GetAllZone()
        {
            return zoneGateway.GetAllZoneName();
        }

        public List<JointVisitorZone> GetAllZoneWiseVisitor()
        {
            return zoneGateway.GetAllZoneWiseVisitor();
        }

        public string GetZoneNamebyId(int zoneId)
        {
            return zoneGateway.GetZoneNamebyId(zoneId);
        }
    }
}
