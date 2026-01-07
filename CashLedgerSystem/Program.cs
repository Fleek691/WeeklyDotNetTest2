using CashLedgerSystem.Ledger;
using CashLedgerSystem.Model;
namespace CashLedgerSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Creating Income Ledger and Adding income
            Ledger<IncomeTransactions> incomeLedger=new Ledger<IncomeTransactions>();
            IncomeTransactions income = new IncomeTransactions(1,DateTime.Now,500m,"Replenishment","Main Cash");
            incomeLedger.AddEntry(income);
            //Creating Expense Ledger and Adding expense
            Ledger<ExpenseTransacction> expenseLedger = new Ledger<ExpenseTransacction>();
            ExpenseTransacction expense=new ExpenseTransacction(1,DateTime.Now,20m,"Stationery for Project","Shopping");
            expenseLedger.AddEntry(expense);
            //Creating and Adding another expense
            ExpenseTransacction expense1=new ExpenseTransacction(2,DateTime.Now,15m,"Snacks with friends","Food");
            expenseLedger.AddEntry(expense1);
            //Calculating total income
            decimal TotalIncome=TransactionCalculator.CalIncomeTotal(incomeLedger.GetRecords());
            System.Console.WriteLine($"Total income: {TotalIncome}");
            //Calculating total epense
            decimal TotalExpense=TransactionCalculator.CalExpenseTotal(expenseLedger.GetRecords());
            System.Console.WriteLine($"Total expense: {TotalExpense}");
            //Calculating Net BAlance
            decimal NetBalance=TransactionCalculator.CalNetBalance(incomeLedger.GetRecords(),expenseLedger.GetRecords());

            System.Console.WriteLine($"Net Balance: {NetBalance}");
            List<Transaction> allTransactions=new List<Transaction>();//Created a Ledger of Transactions to add both income and expense ledger
            for(int i = 0; i < incomeLedger.GetRecords().Count(); i++)
            {
                allTransactions.Add(incomeLedger.GetRecords()[i]);
            }
            foreach (ExpenseTransacction expenses  in expenseLedger.GetRecords())
            {
                allTransactions.Add(expenses);
            }
            //Pinting Symmary of all elements of Transaction Ledger
            foreach(Transaction transaction in allTransactions)
            {
                transaction.GetSummary();
            }   
        }
    }
}