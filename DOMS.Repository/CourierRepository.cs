using System;
using System.Collections.Generic;
using System.Text;
using DOMS.Interface.Repository;
using DOMS.Repository.DbContext;

namespace DOMS.Repository
{
    public class CourierRepository : BaseRepository, ICourierRepository
    {
        public CourierRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
