using WebApi.Models;
using WebApi.Models.Repository;
using System.Collections.Generic;

namespace WebApi.Models.Repository
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        IEnumerable<Account> GetAllAccount();
        IEnumerable<Account> GetAccountByCustomerID(int CustomerID);
    }
}
