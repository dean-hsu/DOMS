using System;
using System.Collections.Generic;
using System.Text;

namespace DOMS.Model.DbModels
{
    public class BaseModel
    {
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public DateTime DeletedTime { get; set; }
        public bool Deleted { get; set; }
    }
}
