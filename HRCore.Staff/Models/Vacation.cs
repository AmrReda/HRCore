namespace HRCore.Staff.Models
{
    public class Vacation
    {
        public int VacationId { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public int NumDays { get; set; }
        public int Status { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime LastModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
