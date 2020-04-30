using WebApi.Models.Repository;
using WebApi.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models.DataManager
{
    public class LoginRepository : RepositoryBase<Login>, ILoginRepository
    {
        public LoginRepository(webApiContext webApiContext)
            : base(webApiContext)
        {
        }


        public Login GetLogin(int CustomerID)
        {
            return FindByCondition(x => x.CustomerID.Equals(CustomerID)).FirstOrDefault();
        }



    }
}
