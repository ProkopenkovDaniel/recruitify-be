namespace Recrutify.Host.Configuration
{
    public class MongoSettings : IMongoSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }

    public interface IMongoSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
