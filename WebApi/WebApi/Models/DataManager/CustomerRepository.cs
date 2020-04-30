using WebApi.Models.Repository;
using WebApi.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models.DataManager
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomersRepository
    {
        public CustomerRepository(webApiContext webApiContext)
            : base(webApiContext)
        {
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return FindAll()
                .OrderBy(ow => ow.CustomerID)
                .ToList();
        }

        public Customer GetCustomer(int CustomerID)
        {
            return FindByCondition(x => x.CustomerID.Equals(CustomerID)).FirstOrDefault();
        }

        public Customer GetCustomerWithAccounts(int CustomerID)
        {
           Customer myCust = FindByCondition(x => x.CustomerID.Equals(CustomerID))
                .Include(cust => cust.Accounts)
                .FirstOrDefault();

            for (int i=0; i<myCust.Accounts.Count; i++)
            {

                Account acc = myCust.Accounts[i];

            }


            return myCust;

        }

    }
}
