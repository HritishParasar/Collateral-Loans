using CMService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMService.Repository
{
    public class CollateralRepository : ICollateralRepository
    {
        private List<CollateralLoanCashDeposit> collateralLoanCashDeposits;
        private List<CollateralLoanRealEstate> collateralLoanRealEstates;

        public CollateralRepository()
        {
            collateralLoanCashDeposits = CollateralLoanCashDepositList.CashDeposits;
            collateralLoanRealEstates = CollateralLoanRealEstateList.RealEstates;
        }

        public CollateralLoanCashDeposit GetCollateralsCashDeposits(int loanId)
        {
            foreach (var collateralLoanCashDeposit in collateralLoanCashDeposits)
            {
                if (collateralLoanCashDeposit.LoanId == loanId)
                {
                    return collateralLoanCashDeposit;
                }
            }
            return null;
        }
        public CollateralLoanRealEstate GetCollateralsRealEstates(int loanId)
        {
            foreach (var collateralLoanRealEstate in collateralLoanRealEstates)
            {
                if (collateralLoanRealEstate.LoanId == loanId)
                {
                    return collateralLoanRealEstate;
                }
            }
            return null;
        }
        public bool SaveCollaterals(CollateralLoanCashDeposit collateralLoanCashDeposit)
        {
            try
            {
                collateralLoanCashDeposits.Add(collateralLoanCashDeposit);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool SaveCollaterals(CollateralLoanRealEstate collateralLoanRealEstate)
        {
            try
            {
                collateralLoanRealEstates.Add(collateralLoanRealEstate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

}

