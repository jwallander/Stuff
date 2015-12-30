using Stuff.DataContracts;
using Stuff.Model;
using System.Data.Entity;

namespace Stuff.Data
{
    public class TagRepository : EFRepository<Tag>, ITagRepository
    {
        public TagRepository(DbContext context) : base(context) { }
    }
}
