using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorZoneApp.DAL.DAO;
using VisitorZoneApp.DAL.Gateway;

namespace VisitorZoneApp.BLL
{
    class VisitorManager
    {
        VisitorGateway aVisitorGateway = new VisitorGateway();
        public string SaveVesitorWithZone(Visitor aVisitor, List<Zone> zoneListforSave)
        {
            if (aVisitorGateway.IsThisEmailAlreadyinSystem(aVisitor.VisitorEmail))
            {
                return "This Email's User Already Registerd";
            }
            else
            {
                if (aVisitorGateway.SaveVesitorWithZone(aVisitor, zoneListforSave))
                {
                    return "Save Successfull";
                }
                else
                {
                    return "Faild";
                }
            }
            
        }

        public List<Visitor> GetVisitorbyZoneId(int zoneId)
        {
            return aVisitorGateway.GetVisitorbyZoneId(zoneId);
        }
    }
}
