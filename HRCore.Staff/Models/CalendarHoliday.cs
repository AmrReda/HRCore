namespace HRCore.Staff.Models
{
    public class CalendarHoliday
    {
        public int CalendarHolidayId { get; set; }
        public string Name { get; set; }
        public System.DateTime Day { get; set; }
        public int CalendarId { get; set; }

        public virtual Calendar Calendar { get; set; }
    }
}
