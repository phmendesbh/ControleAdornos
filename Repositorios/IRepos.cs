using Microsoft.Data.Sqlite;

namespace ControleAdornos.Interface
{
    public interface IRepos
    {
        /// <summary>
        /// Se não existir o banco, cria ele e a tabela
        /// </summary>
        void VerificaBanco();

        SqliteConnectionStringBuilder CriaConexao();
    }
}
