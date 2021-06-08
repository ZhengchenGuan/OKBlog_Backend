using OKBLOGAPI.Domain;
using OKBLOGAPI.Domain.Entities;
using OKBLOGAPI.Repository.Interface;

namespace OKBLOGAPI.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(OKBLOGContext context) : base(context)
        {
        }
    }
}
