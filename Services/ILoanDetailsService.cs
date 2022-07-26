using LoanManagementMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementMicroservice.Services
{
    public interface ILoanDetailsService
    {
        public CustomerLoan GetLoanDetails(int loanId,int customerId);

    }
}
