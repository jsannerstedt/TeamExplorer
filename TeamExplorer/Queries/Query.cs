using Raven.Client;

namespace TeamExplorer.Queries
{
    public abstract class Query<T>
    {
        public IDocumentSession Session { get; set; }

        public abstract T Execute();
    }
}