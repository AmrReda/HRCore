using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCore.Staff.Models
{
    public class Office
    {
        public Office()
        {
            Employees = new HashSet<Employee>();
            Teams = new HashSet<Team>();
        }

        public int OfficeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public int CalendarId { get; set; }

        public virtual Calendar Calendar { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
