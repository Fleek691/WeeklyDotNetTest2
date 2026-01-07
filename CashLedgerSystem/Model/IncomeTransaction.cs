namespace CashLedgerSystem.Model
{
    public class IncomeTransactions : Transaction
    {
        /// <summary>
        /// Child class for income derived from Transaction parent
        /// </summary>
        public string Source{get;set;}
        /// <summary>
        /// Usage of constructor chaining
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="date">Date</param>
        /// <param name="amount">Amount</param>
        /// <param name="description">Description</param>
        /// <param name="source">Source</param>
        public IncomeTransactions(int id, DateTime date, decimal amount, string description,string source) : base(id, date, amount, description)
        {
            this.Source=source;
        }

        /// <summary>
        /// Prints the details of Expense Type Transaction
        /// </summary> 
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