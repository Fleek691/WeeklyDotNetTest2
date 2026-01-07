namespace CashLedgerSystem
{
    /// <summary>
    /// Interface that is to be implemented by all transactions
    /// </summary>
    public interface IReportable
    {
        public void GetSummary();
    }
}