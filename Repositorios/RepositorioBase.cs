using Microsoft.Data.Sqlite;

namespace ControleAdornos.Repositorios
{
    public class RepositorioBase
    {
        public SqliteConnectionStringBuilder CriaConexao()
        {
            var conexao = new SqliteConnectionStringBuilder
            {
                DataSource = "./DB_Adornos.db"
            };

            return conexao;
        }
    }
}