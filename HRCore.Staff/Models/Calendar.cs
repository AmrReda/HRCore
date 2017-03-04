using System.Collections.Generic;

namespace HRCore.Staff.Models
{
    public class Calendar
    {
        public Calendar()
        {
            this.CalendarHolidays = new HashSet<CalendarHoliday>();
            this.Offices = new HashSet<Office>();
        }

        public int CalendarId { get; set; }
        public string Name { get; set; }
        public int Vacation { get; set; }

        public virtual ICollection<CalendarHoliday> CalendarHolidays { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
    }
}
