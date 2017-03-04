using Microsoft.EntityFrameworkCore;

namespace HRCore.Staff.Models
{
    public class StaffContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StaffDb;Trusted_Connection=True;");
        }
        

        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<CalendarHoliday> CalendarHolidays { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<EmployeePicture> EmployeePicture { get; set; }

    }
}
