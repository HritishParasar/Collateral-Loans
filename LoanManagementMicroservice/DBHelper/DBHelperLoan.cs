using LoanManagementMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementMicroservice.DBHelper
{
    public static class DBHelperLoan
    {
        public static List<CustomerLoan> customerLoans = new List<CustomerLoan>()
        {
            new CustomerLoan()
            {
                LoanProductID = 1,
                LoanID = 101,
                CustomerID = 101,
                LoanPrincipal = 500000,
                Tenure = 6,
                Interest = 8.20,
                EMI = 6154,
                CollateralID = 301
            },
            new CustomerLoan()
            {
                LoanProductID = 2,
                LoanID = 102,
                CustomerID = 102,
                LoanPrincipal = 600000,
                Tenure = 8,
                Interest = 9.20,
                EMI = 8154,
                CollateralID = 302
            },
            new CustomerLoan()
            {
                LoanProductID = 3,
                LoanID = 103,
                CustomerID = 103,
                LoanPrincipal = 564000,
                Tenure = 7,
                Interest = 12.20,
                EMI = 7652,
                CollateralID = 303
            },
            new CustomerLoan()
            {
                LoanProductID = 3,
                LoanID = 201,
                CustomerID = 201,
                LoanPrincipal = 800000,
                Tenure = 8,
                Interest = 6.20,
                EMI = 9154,
                CollateralID = 304
            },
            new CustomerLoan()
            {
                LoanProductID = 1,
                LoanID = 202,
                CustomerID = 202,
                LoanPrincipal = 950000,
                Tenure = 3,
                Interest = 9.40,
                EMI = 3564,
                CollateralID = 305
            },
            new CustomerLoan()
            {
                LoanProductID = 2,
                LoanID = 203,
                CustomerID = 203,
                LoanPrincipal = 780000,
                Tenure = 7,
                Interest = 10.20,
                EMI = 9527,
                CollateralID = 306
            }
            };

     }
}
