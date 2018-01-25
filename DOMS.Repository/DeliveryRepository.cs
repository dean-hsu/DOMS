using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Repository.DbContext;

namespace DOMS.Repository
{
    public class DeliveryRepository : BaseRepository, IDeliveryRepository
    {
        public DeliveryRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
