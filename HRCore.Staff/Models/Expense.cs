namespace HRCore.Staff.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ExpenseType { get; set; }
        public double Amount { get; set; }
        public string RelatedProject { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public int Status { get; set; }
        public string Contact { get; set; }
        public byte[] Picture { get; set; }

        public virtual Employee Employee { get; set; }
    }
}