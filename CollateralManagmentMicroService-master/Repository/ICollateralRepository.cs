using CMService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMService.Repository
{
    public interface ICollateralRepository
    {
        public CollateralLoanCashDeposit GetCollateralsCashDeposits(int loanId);
        public CollateralLoanRealEstate GetCollateralsRealEstates(int loanId);

        public bool SaveCollaterals(CollateralLoanCashDeposit collateralLoanCashDeposit);
        public bool SaveCollaterals(CollateralLoanRealEstate collateralLoanRealEstate);
    }
}
