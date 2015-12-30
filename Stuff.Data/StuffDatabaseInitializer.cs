using System;
using System.Data.Entity;
using System.Linq;

namespace Stuff.Data
{
    public class StuffDatabaseInitializer :
        //CreateDatabaseIfNotExists<CodeCamperDbContext>      // when model is stable
        DropCreateDatabaseIfModelChanges<StuffDbContext>      // when iterating
    {
        private const string ItemBmw = "BMW Alpina B3";
        private const string ItemNextCube = "NextCube";
        private const string TagComputer = "Computer";
        private const string TagCar = "Car";

        protected override void Seed(StuffDbContext context)
        {
            AddItems(context);
            AddTags(context);

            AddTaging(context);
        }

        private void AddTaging(StuffDbContext context)
        {
            var nextCubeItem = context.Items.FirstOrDefault(i => i.Name.Equals(ItemNextCube));
            var computerTag = context.Tags.FirstOrDefault(t => t.Name.Equals(TagComputer));
            nextCubeItem.Tags.Add(computerTag);

            var bmwItem = context.Items.FirstOrDefault(i => i.Name.Equals(ItemBmw));
            var carTag = context.Tags.FirstOrDefault(t => t.Name.Equals(TagComputer));
            bmwItem.Tags.Add(carTag);

            context.SaveChanges();
        }

        private void AddTags(StuffDbContext context)
        {
            context.Tags.Add(new Model.Tag { Name = TagComputer });
            context.Tags.Add(new Model.Tag { Name = TagCar });

            context.SaveChanges();
        }

        private void AddItems(StuffDbContext context)
        {
            context.Items.Add(new Model.Item { Name = ItemNextCube });
            context.Items.Add(new Model.Item { Name = ItemBmw });

            context.SaveChanges();
        }
    }
}