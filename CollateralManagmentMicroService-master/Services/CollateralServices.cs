using CMService.Models;
using CMService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMService.Services
{
    public class CollateralServices: ICollateralServices
    {

        private readonly ICollateralRepository _collateralRepository;
        public CollateralServices(ICollateralRepository collateralRepository)
        {
            _collateralRepository = collateralRepository;
        }
        public CollateralLoanCashDeposit GetCollateralsCashDeposits(int loanId)
        {
            return _collateralRepository.GetCollateralsCashDeposits(loanId);
        }
        public CollateralLoanRealEstate GetCollateralsRealEstates(int loanId)
        {
            return _collateralRepository.GetCollateralsRealEstates(loanId);
        }
        public bool SaveCollaterals(CollateralLoanCashDeposit collateralLoanCashDeposit)
        {
            bool status = _collateralRepository.SaveCollaterals(collateralLoanCashDeposit);
            return status;
        }
        
        public bool SaveCollaterals(CollateralLoanRealEstate collateralLoanRealEstate)
        {
            bool status = _collateralRepository.SaveCollaterals(collateralLoanRealEstate);
            return status;
        }
    }
}
