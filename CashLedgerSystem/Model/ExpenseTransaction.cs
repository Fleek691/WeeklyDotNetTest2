namespace CashLedgerSystem.Model
{
    /// <summary>
    /// Child class for expenses derived from Transaction parent
    /// </summary>
    public class ExpenseTransacction : Transaction
    {
        public string Category{get;set;}
        /// <summary>
        /// Usage of contructore chaining
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="date">Date</param>
        /// <param name="amount">Amount</param>
        /// <param name="description">Description</param>
        /// <param name="category">Catgeory</param>
        public ExpenseTransacction(int id,DateTime date,decimal amount,string description,string category):base(id, date, amount, description)
        {
            this.Category=category;
        }

        /// <summary>
        /// Prints the details of Expense Type Transaction
        /// </summary>
        public override void GetSummary()
        {
            System.Console.WriteLine("<EXPENSE>");
            System.Console.WriteLine($"Amount: {Amount}");
            System.Console.WriteLine($"Category: {Category}");
            System.Console.WriteLine($"Description: {Description}");
            System.Console.WriteLine($"Date: {Date}");
        }
    }
}