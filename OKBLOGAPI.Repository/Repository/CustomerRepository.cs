using OKBLOGAPI.Domain;
using OKBLOGAPI.Domain.Entities;

namespace OKBLOGAPI.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>
    {
        public CustomerRepository(OKBLOGContext context) : base(context)
        {
        }
    }
}
