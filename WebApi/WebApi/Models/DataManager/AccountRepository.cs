using WebApi.Models.Repository;
using WebApi.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models.DataManager
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(webApiContext webApiContext)
            : base(webApiContext)
        {
        }

        public IEnumerable<Account> GetAllAccount()
        {
            return FindAll()
                .OrderBy(ow => ow.CustomerID)
                .ToList();
        }

        public IEnumerable<Account> GetAccountByCustomerID(int CustomerID)
        {
            return FindByCondition(x => x.CustomerID.Equals(CustomerID)).ToList();
        }
    }
}
