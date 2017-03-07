using HRCore.Staff.DAL.Abstractions;
using HRCore.Staff.Models;

namespace HRCore.Staff.DAL
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(StaffContext context) 
            : base(context)
        {
        }
    }
}