using LoanManagementMicroservice.DBHelper;
using LoanManagementMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementMicroservice.Repository
{
    public class CustomerLoanRepository : ICustomerLoanRepository
    {
        private List<CustomerLoan> customerLoansDetails;
        public CustomerLoanRepository()
        {
            customerLoansDetails = DBHelperLoan.customerLoans;
        }
        public CustomerLoan GetLoanDetails(int loanId,int customerId)
        {
            foreach(var customerLoanDetail in customerLoansDetails)
            {
                if(customerLoanDetail.LoanID == loanId && customerLoanDetail.CustomerID == customerId)
                {
                    return customerLoanDetail;
                }
            }
            return null;
        }
    }
}
