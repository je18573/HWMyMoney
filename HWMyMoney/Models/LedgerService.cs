using System;
using System.Collections.Generic;
using HWMyMoney.Models.Enum;

namespace HWMyMoney.Models
{
    public class LedgerService
    {
      
        public IEnumerable<LedgerViewModel> LookupAllData()
        {
            var random   = new Random();

            for (var i = 1; i <= 50; i++)
            {
                var fakeData = new LedgerViewModel
                {
                    Category = random.Next(1, 100) % i == 0 ? CategoryType.Expenditure : CategoryType.Income,
                    Money    = random.Next(0, 100000),
                    Date     = DateTime.Now.AddDays(-random.Next(0, 100)).AddMinutes(random.Next(0, 60)),
                    Memo     = $"fake memo {i}"
                };
               yield return fakeData;
            }
        }
    }
}