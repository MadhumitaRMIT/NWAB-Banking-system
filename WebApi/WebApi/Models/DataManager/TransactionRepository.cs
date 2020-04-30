using WebApi.Models.Repository;
using WebApi.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models.DataManager
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        public TransactionRepository(webApiContext webApiContext)
            : base(webApiContext)
        {
        }

        public IEnumerable<Transaction> GetAllTransaction()
        {
            return FindAll()
                .OrderBy(ow => ow.TransactionID)
                .ToList();
        }

        public IEnumerable<Transaction> GetTransactionByAccountNumber(int AccountNumber)
        {
            return FindByCondition(x => x.AccountNumber.Equals(AccountNumber)).ToList();
        }
    }
}
