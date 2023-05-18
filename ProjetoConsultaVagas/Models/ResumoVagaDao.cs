using Dapper;
using ProjetoConsultaVagas.Models;
using ProjetoConsultaVagas.ViewModels;

namespace Projeto02.GestaoEventos.DataAccess
{
    public class ResumoVagaDao : Dao
    {
        
        public IEnumerable<ResumoVagaVM> Buscar()
        {
            try
            {
                AbrirConexao();
                return Conn.Query<ResumoVagaVM>
                    ("SELECT v.id, v.titulo_vaga, e.nome AS nomeempresa, v.salario, v.data_limite_inscricao, en.cidade, en.uf FROM tb_vaga v, tb_empresa e, tb_endereco en WHERE en.id = e.idendereco AND e.id = v.idempresa;");
            }
            finally
            {
                FecharConexao();
            }
        }
        
        
    }
}
