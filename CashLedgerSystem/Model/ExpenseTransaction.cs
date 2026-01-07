namespace CashLedgerSystem.Model
{
    public class ExpenseTransacction : Transaction
    {
        public string Category{get;set;}

        public ExpenseTransacction(int id,DateTime date,decimal amount,string description,string category):base(id, date, amount, description)
        {
            this.Category=category;
        }
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