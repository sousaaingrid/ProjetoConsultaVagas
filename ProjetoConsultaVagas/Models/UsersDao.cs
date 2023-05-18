using Dapper;
using ProjetoConsultaVagas.Models;

namespace Projeto02.GestaoEventos.DataAccess
{
    public class UsersDao : Dao
    {
        
        public Usuario Validar(string nome, string senha)
        {
            try
            {
                AbrirConexao();
                string sql = "SELECT * FROM tb_usuarios WHERE nome=@nome AND senha=@senha";
                var entidade = Conn.QueryFirstOrDefault<Usuario>(sql, new { nome, senha });

                return entidade;
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}