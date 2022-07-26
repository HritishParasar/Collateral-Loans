using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementMicroservice.Models
{
    public class Loan
    {
        public string LoanProduct { get; set; }
        public double MaxLoanEligible { get; set; }
        public double Interest { get; set; }
        public int Tenure { get; set; }
        public string TypeOfCollateral { get; set; }
    }
}
