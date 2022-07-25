using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMService.Models
{
    public class CollateralLoanCashDepositList
    {
        public static List<CollateralLoanCashDeposit> CashDeposits = new List<CollateralLoanCashDeposit>()
        {
            new CollateralLoanCashDeposit{LoanId= 101, CollateralId= 1, PledgedDate= new DateTime(2020, 12, 31), CustomerID= 101, OwnerName= "Mr Brown", OwnerDetails= "Down Street,CA", CollateralType= "CashDeposit", CurrentValue= 5000000,BankName= "SBI", InterestRate= 16.5, DepositAmount= 80000, LockPeriod=12 },
            new CollateralLoanCashDeposit{LoanId= 102, CollateralId= 3, PledgedDate= new DateTime(2019, 02, 11), CustomerID= 102, OwnerName= "Ms Lily", OwnerDetails= "LA", CollateralType= "CashDeposit", CurrentValue= 5500000,BankName= "HDFC", InterestRate= 12.3, DepositAmount= 85000, LockPeriod=3 },
            new CollateralLoanCashDeposit{LoanId= 103, CollateralId= 2, PledgedDate= new DateTime(2018, 09, 03), CustomerID= 103, OwnerName= "Mr George", OwnerDetails= "SFC", CollateralType= "CashDeposit", CurrentValue= 8900000,BankName= "BOI", InterestRate= 8.6, DepositAmount= 6000, LockPeriod=11 },
            new CollateralLoanCashDeposit{LoanId= 104, CollateralId= 2, PledgedDate= new DateTime(2020, 11, 28), CustomerID= 104, OwnerName= "Mr Henry", OwnerDetails= "Chicago", CollateralType= "CashDeposit", CurrentValue= 7300000,BankName= "SBI", InterestRate= 6, DepositAmount= 42000, LockPeriod=6 }
        };
    }
}

      