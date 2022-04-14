using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerService.Service
{
    // Service checks account balance, Account fraud, Account Expenditure rate, Customer Commission rate 
    public class AccountService
    {
        public readonly string AccountRespository _respository;
        public AccountService()
        {

        }
        // Check Account balance every 5 mins interval
        public async void CheckAccountBalance()
        {
            var result = ""; 
        }

        public void CheckAccountFraud()
        {

        }
    }
}
