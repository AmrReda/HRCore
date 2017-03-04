using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCore.Staff.Models
{
    public class Employee
    {
        public Employee()
        {
            this.Expenses = new HashSet<Expense>();
            this.Teams = new HashSet<Team>();
            this.Vacations = new HashSet<Vacation>();
            this.EmployeePicture = new HashSet<EmployeePicture>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public int BussinessPhone { get; set; }
        public int? HomePhone { get; set; }
        public string Email { get; set; }
        public int PostalCode { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? TeamId { get; set; }
        public int OfficeId { get; set; }
        public string BankAccount { get; set; }
        public string Comments { get; set; }
        public string PersonalId { get; set; }
        public System.DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Office Office { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Vacation> Vacations { get; set; }
        public virtual ICollection<EmployeePicture> EmployeePicture { get; set; }
    }
}
