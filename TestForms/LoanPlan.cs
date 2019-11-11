using System;
using SQLite;

namespace TestForms
{
    public class LoanPlan
    {

        public LoanPlan() { }

        [PrimaryKey, AutoIncrement]
        public long id { get; set; }

        public Decimal payment;
        public Decimal interest;
        public Decimal base_loan;
        public Decimal rest_loan;


    }
}
