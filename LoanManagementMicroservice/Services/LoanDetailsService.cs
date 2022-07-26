using LoanManagementMicroservice.Models;
using LoanManagementMicroservice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementMicroservice.Services
{
    public class LoanDetailsService : ILoanDetailsService
    {
        private readonly ICustomerLoanRepository _customerLoanRepository;

        public LoanDetailsService(ICustomerLoanRepository customerLoanRepository)
        {
            _customerLoanRepository = customerLoanRepository;
        }
        public CustomerLoan GetLoanDetails(int loanId,int customerId)
        {
            return _customerLoanRepository.GetLoanDetails(loanId, customerId);
        }
    }
}
