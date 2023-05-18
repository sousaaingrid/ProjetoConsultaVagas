using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto02.GestaoEventos.DataAccess;
using ProjetoConsultaVagas.Models;

namespace ProjetoConsultaVagas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UsersDao usersDao;

        public UserController()
        {
            usersDao = new UsersDao();
        }

        [HttpPost]
        public Usuario PostUsuario(Usuario usuario)
        {
            return usersDao.Validar(usuario.nome!, usuario.senha!);
        }
    }
}
