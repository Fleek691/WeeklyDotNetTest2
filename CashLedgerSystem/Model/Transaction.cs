namespace CashLedgerSystem.Model
{
    public abstract class Transaction : IReportable
    {
        public int Id{get;set;}
        public DateTime Date{get;set;}
        public decimal Amount{get;set;}
        public string? Description{get;set;}

        protected Transaction(int id,DateTime date,decimal amount,string description)
        {
            this.Id=id;
            this.Date=date;
            this.Amount=amount;
            this.Description=description;
        }

        public abstract void GetSummary();
        
    }
}
