using Stuff.DataContracts;
using Stuff.Model;
using System.Data.Entity;

namespace Stuff.Data
{
    public class ItemRepository : EFRepository<Item>, IItemRepository
    {
        public ItemRepository(DbContext context) : base(context) { }
    }
}
