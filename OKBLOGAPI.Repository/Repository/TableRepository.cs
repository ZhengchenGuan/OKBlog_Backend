using OKBLOGAPI.Domain;
using OKBLOGAPI.Domain.Entities;
using OKBLOGAPI.Repository.Interface;

namespace OKBLOGAPI.Repository
{
    public class TableRepository : RepositoryBase<Table>, ITableRepository
    {
        public TableRepository(OKBLOGContext context) : base(context)
        {
        }
    }
}