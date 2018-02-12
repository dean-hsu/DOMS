using System;
using DOMS.Model.DbModels;
using DOMS.Repository.DbContext;

namespace DOMS.Repository
{
    public class BaseRepository
    {
        protected readonly ApplicationDbContext _db;

        public BaseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        protected void AddCreateTime(BaseModel entity)
        {
            entity.CreatedTime = DateTime.Now;
            entity.UpdatedTime = DateTime.Now;
        }

        protected void ChangeUpdateTime(BaseModel entity)
        {
            entity.UpdatedTime = DateTime.Now;
        }
    }
}
