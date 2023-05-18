using Dapper;
using ProjetoConsultaVagas.Models;

namespace Projeto02.GestaoEventos.DataAccess 
{ 
 public class EmpresaDao : Dao
{

    public string conexao = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=inspiron12;Database=dbrecursoshumanos";
    

    public IEnumerable<Empresa> ListarEmpresa()
    {
        try
        {
            AbrirConexao();
            return Conn.Query<Empresa>("SELECT * FROM  tb_empresa ");
        }
        finally
        {
            FecharConexao();
        }
    }

}
}