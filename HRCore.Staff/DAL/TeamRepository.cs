using HRCore.Staff.DAL.Abstractions;
using HRCore.Staff.Models;

namespace HRCore.Staff.DAL
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        public TeamRepository(StaffContext context) : base(context)
        {
        }
    }
}
