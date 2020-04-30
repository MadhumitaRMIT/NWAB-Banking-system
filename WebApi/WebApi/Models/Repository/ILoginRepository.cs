using System.Collections.Generic;
using WebApi.Models;
using WebApi.Models.Repository;

namespace WebApi.Models.Repository
{
    public interface ILoginRepository : IRepositoryBase<Login>
    {
        Login GetLogin(int CustomerID);

    }
}
