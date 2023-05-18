using Dapper;
using ProjetoConsultaVagas.Models;

namespace Projeto02.GestaoEventos.DataAccess
{
    public class BeneficioDao : Dao
    {

        public string conexao = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=inspiron12;Database=dbrecursoshumanos";


        public IEnumerable<Beneficio> ListarBeneficio()
        {
            try
            {
                AbrirConexao();
                return Conn.Query<Beneficio>("SELECT * FROM  tb_beneficio ");
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}