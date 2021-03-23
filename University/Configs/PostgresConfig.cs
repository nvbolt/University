using Npgsql;

namespace University.API.Configs
{
    public class PostgresConfig
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Db { get; set; }

        public string ConnectionString
        {
            get
            {
                var builder = new NpgsqlConnectionStringBuilder
                {
                    Host = this.Host,
                    Database = this.Db,
                    Username = this.User,
                    Password = this.Password,
                    Port = this.Port
                };

                return builder.ConnectionString;
            }
        }
    }
}
