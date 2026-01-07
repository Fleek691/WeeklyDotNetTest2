using CashLedgerSystem.Model;

namespace CashLedgerSystem.Ledger
{
    /// <summary>
    /// Generic class for 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Ledger<T> where T: Transaction
    {
        private List<T> record=new List<T>();
        public void AddEntry(T entry)
        {
            record.Add(entry);
        }
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
        public decimal CalculateTotal()
        {
            decimal total=0;
            for(int i = 0;i < record.Count; i++)
            {
                total=total+=record[i].Amount;
            }
            return total;
        }

        public List<T> GetRecords()
        {
            return record;
        }
    }
}