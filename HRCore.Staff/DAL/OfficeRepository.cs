using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRCore.Staff.DAL.Abstractions;
using HRCore.Staff.Models;

namespace HRCore.Staff.DAL
{
    public class OfficeRepository : GenericRepository<Office>, IOfficeRepository
    {
        public OfficeRepository(StaffContext context) : base(context)
        {
        }
    }
}
