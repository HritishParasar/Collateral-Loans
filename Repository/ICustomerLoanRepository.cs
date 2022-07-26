using LoanManagementMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementMicroservice.Repository
{
    public interface ICustomerLoanRepository
    {
        public CustomerLoan GetLoanDetails(int loanId,int customerId);

    }
}
