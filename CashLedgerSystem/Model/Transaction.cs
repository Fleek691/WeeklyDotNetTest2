namespace CashLedgerSystem.Model
{   
    /// <summary>
    /// Main core class using Interface for printing summary
    /// </summary>
    public abstract class Transaction : IReportable
    {
        public int Id{get;set;}
        public DateTime Date{get;set;}
        public decimal Amount{get;set;}
        public string? Description{get;set;}

        /// <summary>
        /// Constructore with paramters of the fields
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="date">Date</param>
        /// <param name="amount">Amount</param>
        /// <param name="description">Descirption</param>
        protected Transaction(int id,DateTime date,decimal amount,string description)
        {
            this.Id=id;
            this.Date=date;
            this.Amount=amount;
            this.Description=description;
        }

        /// <summary>
        /// Abstract so much be used by children to print details
        /// </summary>
        public abstract void GetSummary();
        
    }
}
