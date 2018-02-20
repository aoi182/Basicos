using System;

namespace ConsoleAppSerializationDemo
{
    [Serializable]
    class Loan
    {
        public double LoanAmount { get; set; }
        public double InterestRate { get; set; }
        public int Term { get; set; }
        public string Customer { get; set; }
    }
}