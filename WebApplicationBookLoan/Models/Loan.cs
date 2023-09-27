namespace WebApplicationBookLoan.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public string LenderName { get; set; }
        public string BorrowedName { get; set; }
        public string BookName { get; set; }
        public DateTime LoanDate { get; set; } = DateTime.Now;
    }
}
