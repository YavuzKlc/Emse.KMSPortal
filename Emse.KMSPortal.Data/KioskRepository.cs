using Emse.Framework;
using Emse.KMSPortal.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emse.KMSPortal.Data
{
    public class KioskRepository : Repository<Kiosk>//IRepository<Kiosk>
    {
        public void Create(Kiosk entity)
        {
            KMSPortalDBEntities
        }

        public void Delete(Kiosk entity)
        {
            throw new NotImplementedException();
        }

        public Kiosk GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Kiosk entity)
        {
            throw new NotImplementedException();
        }
    }
}
