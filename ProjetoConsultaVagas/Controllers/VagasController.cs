using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto02.GestaoEventos.DataAccess;
using Microsoft.AspNetCore.Cors;
using ProjetoConsultaVagas.Models;
using ProjetoConsultaVagas.ViewModels;

namespace Projeto03.ConceitosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagasController : ControllerBase
    {
        VagaDao vagaDao;
        EmpresaDao empresaDao;
        BeneficioDao beneficioDao;
        ResumoVagaDao resumoVagaDao;
        

        public VagasController()
        {
            vagaDao = new VagaDao();
            empresaDao = new EmpresaDao();
            beneficioDao = new BeneficioDao();
            resumoVagaDao = new ResumoVagaDao();

        }

        [HttpGet]
        public IEnumerable<ResumoVagaVM> GetResumoVagas()
        {
            return resumoVagaDao.Buscar();
        }

        [HttpGet("{salario}")]

        public Vaga GetVaga(int salario)
        {
            return vagaDao.Buscar(salario);
        }

        [HttpGet("id")]
        public IEnumerable<Empresa> GetEmpresa()
        {
            return empresaDao.ListarEmpresa();
        }

        [HttpGet("descricao")]
        public IEnumerable<Beneficio> GetBeneficio()
        {
            return beneficioDao.ListarBeneficio();
        }



    }
}
