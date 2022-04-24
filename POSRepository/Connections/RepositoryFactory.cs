namespace POSRepository.Connections
{
    internal class RepositoryFactory
    {
        public IRepositoryProvider GetRepositoryProvider()
        {
            return new SQLServiceProvider();
        }
    }
}
