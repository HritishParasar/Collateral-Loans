using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementMicroservice.Models
{
    public class CustomerLoan
    {
        public int LoanProductID { get; set; }
        public int LoanID { get; set; }
        public int CustomerID { get; set; }
        public double LoanPrincipal { get; set; }
        public int Tenure { get; set; }
        public double Interest { get; set; }
        public double EMI { get; set; }
        public int CollateralID { get; set; }

    }
}
