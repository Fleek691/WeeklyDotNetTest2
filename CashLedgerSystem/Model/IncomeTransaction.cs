namespace CashLedgerSystem.Model
{
    public class IncomeTransactions : Transaction
    {
        public string Source{get;set;}
        public IncomeTransactions(int id, DateTime date, decimal amount, string description,string source) : base(id, date, amount, description)
        {
            this.Source=source;
        }
        public override void GetSummary()
        {
            System.Console.WriteLine("<INCOME>");
            System.Console.WriteLine($"Amount: {Amount}");
            System.Console.WriteLine($"Source: {Source}");
            System.Console.WriteLine($"Description: {Description}");
            System.Console.WriteLine($"Date: {Date}");
        }
    }
}