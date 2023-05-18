using ProjetoConsultaVagas.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoConsultaVagas.Models
{
    public class Vaga
    {
        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public string? EmpresaInfo { get; set; }
        public string? Titulo_Vaga { get; set; }
        public string? Descricao { get; set; }
        public string? Turno { get; set; }
        public string? Modalidade { get; set; }
        public string? Escolaridade { get; set; }
        public int Salario { get; set; }
       
    }
}

