using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Models.Shared
{
    public class BaseEntity
    {
        public int Id { get; set; }//pk
        public int CreatedBy { get; set; }//user Id
        public DateTime CreatedOn { get; set; }
        public int LastModifaiedBy { get; set; }//userId
        public DateTime LastModifaiedOn { get; set; }
        public bool IsDeleted { get; set; } // soft delete
    }
}
