using Dapper;
using ProjetoConsultaVagas.Models;


namespace Projeto02.GestaoEventos.DataAccess
{
    public class VagaDao : Dao
    {
       
        public string conexao = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=inspiron12;Database=dbrecursoshumanos";
        public Vaga Buscar(int salario)
        {
            try
            {
                AbrirConexao();
                return Conn.QueryFirstOrDefault<Vaga>(
                    "SELECT * FROM tb_vaga WHERE id = @id ", new { salario});
            }
            finally
            {
                FecharConexao();
            }
        }

        public IEnumerable<Vaga> ListarVagas()
        {
            try
            {
                AbrirConexao();
                return Conn.Query<Vaga>("SELECT * FROM  tb_vaga ");
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
