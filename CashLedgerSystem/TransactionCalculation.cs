using CashLedgerSystem.Model;

namespace CashLedgerSystem
{
    /// <summary>
    /// Class fro calculations of trandsaction
    /// </summary>
    public static class TransactionCalculator
    {
        /// <summary>
        /// Calculating the total income
        /// </summary>
        public static decimal CalIncomeTotal(List<IncomeTransactions> incomes)
        {
            return incomes.Sum(i => i.Amount);
        }
        
        /// <summary>
        /// Calculating the total expense
        /// </summary>
        /// <param name="expenses"></param>
        /// <returns></returns>
        public static decimal CalExpenseTotal(List<ExpenseTransacction> expenses)
        {
            return expenses.Sum(e => e.Amount);
        }
        /// <summary>
        /// Calculating the Net Balance
        /// </summary>
        /// <param name="incomes"></param>
        /// <param name="expenses"></param>
        /// <returns></returns>
        public static decimal CalNetBalance(
           List<IncomeTransactions> incomes,
           List<ExpenseTransacction> expenses)
        {
            return CalIncomeTotal(incomes) - CalExpenseTotal(expenses);
        }
    }
}