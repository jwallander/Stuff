using System.Collections.Generic;

namespace Stuff.Model
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
