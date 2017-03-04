using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCore.Staff.Models
{
    public class Team
    {
        public Team()
        {
            this.Employees = new HashSet<Employee>();
        }

        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ManagerId { get; set; }
        public int OfficeId { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Office Office { get; set; }
    }
}
