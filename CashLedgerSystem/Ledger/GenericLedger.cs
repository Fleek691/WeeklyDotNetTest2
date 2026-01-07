using CashLedgerSystem.Model;

namespace CashLedgerSystem.Ledger
{
    /// <summary>
    /// Generic class for type safety so that both types of transaction can be added to one parent transaction
    /// </summary>
    /// <typeparam name="T">where T is transaction</typeparam>
    public class Ledger<T> where T: Transaction
    {
        private List<T> record=new List<T>();
        /// <summary>
        /// Method for adding an entry in the record
        /// </summary>
        /// <param name="entry">adds the particular entry</param>
        public void AddEntry(T entry)
        {
            record.Add(entry);
        }
        /// <summary>
        /// List to store transactions by date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<T> GetTransactionsByDate(DateTime date)
        {
            List<T> result=new List<T>();
            for(int i = 0; i < record.Count; i++)
            {
                if (record[i].Date.Date == date.Date)
                {
                    result.Add(record[i]);
                }
            }
            return record;
        }
        /// <summary>
        /// Method to Calculate the total amount
        /// </summary>
        /// <returns>total amount</returns>
        public decimal CalculateTotal()
        {
            decimal total=0;
            for(int i = 0;i < record.Count; i++)
            {
                total=total+=record[i].Amount;
            }
            return total;
        }
        /// <summary>
        /// Method to Print All  the records present in the Ledger
        /// </summary>
        /// <returns>all the records</returns>
        public List<T> GetRecords()
        {
            return record;
        }
    }
}