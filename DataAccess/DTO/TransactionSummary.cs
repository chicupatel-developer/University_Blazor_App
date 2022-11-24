using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DTO
{
    public class TransactionSummary
    {
        public string GLACCTNO { get; set; }
        public decimal? TotalCreditAmount { get; set; }
        public decimal? TotalDebitAmount { get; set; }
        public decimal? EntryAmount { get; set; }
    }
}
