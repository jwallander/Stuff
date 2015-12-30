namespace Stuff.DataContracts
{
    public interface IStuffUow
    {
        // Save pending changes to the data store.
        void Commit();

        // Repositories
        IItemRepository Items { get; }

        ITagRepository Tags { get; }
    }
}
