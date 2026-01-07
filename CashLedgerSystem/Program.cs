

using CashLedgerSystem.Ledger;
using CashLedgerSystem.Model;
namespace CashLedgerSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ledger<IncomeTransactions> incomeLedger=new Ledger<IncomeTransactions>();
            IncomeTransactions income=new IncomeTransactions(1,DateTime.Now,500m,"Replenishment","Main Cash");
            incomeLedger.AddEntry(income);

            Ledger<ExpenseTransacction> expenseLedger=new Ledger<ExpenseTransacction>();
            ExpenseTransacction expense=new ExpenseTransacction(1,DateTime.Now,20m,"Stationery for Project","Shopping");
            expenseLedger.AddEntry(expense);

            ExpenseTransacction expense1=new ExpenseTransacction(2,DateTime.Now,15m,"Snacks with friends","Food");
            expenseLedger.AddEntry(expense1);

            decimal TotalIncome=incomeLedger.CalculateTotal();
            System.Console.WriteLine($"Total income: {TotalIncome}");

            decimal TotalExpense=expenseLedger.CalculateTotal();
            System.Console.WriteLine($"Total expense: {TotalExpense}");

            decimal NetBalance=TotalIncome-TotalExpense;

            System.Console.WriteLine($"Net Balance: {NetBalance}");

            List<Transaction> allTransactions=new List<Transaction>();
            allTransactions.AddRange(incomeLedger.GetRecords());
            allTransactions.AddRange(expenseLedger.GetRecords());

            foreach(Transaction transaction in allTransactions)
            {
                transaction.GetSummary();
            }
            
        }
    }
}