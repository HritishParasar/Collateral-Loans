using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMService.Models
{
    public class CollateralLoanRealEstateList
    {
        public static List<CollateralLoanRealEstate> RealEstates = new List<CollateralLoanRealEstate>()
        {
            new CollateralLoanRealEstate{LoanId= 200, CollateralId= 200, PledgedDate= new DateTime(2020, 12, 08), CustomerID= 200, OwnerName= "Mr White", OwnerDetails= "Hyderabad", CollateralType= "Real Estates", CurrentValue= 8000000, DateOfPurchase=new DateTime(2012, 12, 21), AddressOfProperty="Mumbai", RatePerSqFt=30000, DepreciationRate=4 },
            new CollateralLoanRealEstate{LoanId= 201, CollateralId= 201, PledgedDate= new DateTime(2020, 12, 21), CustomerID= 201, OwnerName= "Mr Black", OwnerDetails= "Mumbai", CollateralType= "Real Estates", CurrentValue= 6000000, DateOfPurchase=new DateTime(2012, 12, 21), AddressOfProperty="Mumbai", RatePerSqFt=20000, DepreciationRate=2 },
            new CollateralLoanRealEstate{LoanId= 202, CollateralId= 202, PledgedDate= new DateTime(2020, 12, 06), CustomerID= 202, OwnerName= "Mr Green", OwnerDetails= "Pune", CollateralType= "Real Estates", CurrentValue= 6050000, DateOfPurchase=new DateTime(2014, 12, 21), AddressOfProperty="Mumbai", RatePerSqFt=10000, DepreciationRate=3 },
            new CollateralLoanRealEstate{LoanId= 203, CollateralId= 203, PledgedDate= new DateTime(2019, 04, 03), CustomerID= 203, OwnerName= "Ms Pink", OwnerDetails= "Kolkata", CollateralType= "Real Estates", CurrentValue= 2400000, DateOfPurchase=new DateTime(2003, 12, 21), AddressOfProperty="Delhi", RatePerSqFt=3000, DepreciationRate=1 },
            new CollateralLoanRealEstate{LoanId= 204, CollateralId= 204, PledgedDate= new DateTime(2019, 07, 07), CustomerID= 204, OwnerName= "Ms Yellow", OwnerDetails= "Delhi", CollateralType= "Real Estates", CurrentValue= 21000000, DateOfPurchase=new DateTime(2004, 12, 21), AddressOfProperty="Mumbai", RatePerSqFt=7000, DepreciationRate=4 }
        };
     }
}


