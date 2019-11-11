using System;
using System.Collections.Generic;
using SQLite;

namespace TestForms
{
    public class Loan
    {
        public Loan() { }

        [PrimaryKey, AutoIncrement]
        public long id { get; set; }
        public String name { get; set; }
        public Decimal amount { get; set; }
        public Decimal interest { get; set; }
        public Decimal period { get; set; }

    }

}