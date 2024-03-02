using Dapper;
using Npgsql;
namespace Infrastructure.DataContext;

public class DapperContext
{
    private readonly string _conectionString ="Host=localhost;Port=5432;Database=Intilekt;User Id=postgres;Password=832111;";
    public NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(_conectionString);
    }
}
