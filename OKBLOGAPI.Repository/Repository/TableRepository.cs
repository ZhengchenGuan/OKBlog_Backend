using OKBLOGAPI.Domain;
using OKBLOGAPI.Domain.Entities;

namespace OKBLOGAPI.Repository
{
    public class TableRepository : RepositoryBase<Table>
    {
        public TableRepository(OKBLOGContext context) : base(context)
        {
        }
    }
}