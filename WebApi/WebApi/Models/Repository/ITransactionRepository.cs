using WebApi.Models.Repository;
using WebApi.Data;
using System.Collections.Generic;

namespace WebApi.Models.Repository
{
    public interface ITransactionRepository : IRepositoryBase<Transaction>
    {
        IEnumerable<Transaction> GetAllTransaction();
        IEnumerable<Transaction> GetTransactionByAccountNumber(int AccountNumber);
    }
}
