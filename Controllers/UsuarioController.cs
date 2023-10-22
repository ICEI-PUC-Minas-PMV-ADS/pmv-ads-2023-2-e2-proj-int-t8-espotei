using Espotei.Models;
using Espotei.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net;

namespace Espotei.Controllers
{
    [Route("espotei/usuario")]
    public class UsuarioController : Controller
    {        
        [HttpGet("criarConta")]
        public async Task<ActionResult> CriarUsuarioAsync([FromBody]Usuario usuarioASerCriado)
        {
            try
            {               
                UsuarioRepositorie repo = new UsuarioRepositorie();
                var usuario = await repo.CriarUsuarioAsync(usuarioASerCriado);

                return new ContentResult
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    ContentType = Azure.Core.ContentType.ApplicationJson.ToString(),
                    Content = System.Text.Json.JsonSerializer.Serialize(usuario),
                };
            }
            catch (Exception e)
            {
                return new ContentResult
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                    ContentType = Azure.Core.ContentType.TextPlain.ToString(),
                    Content = e.Message,
                };
            }
        }

        [HttpPut("editarConta")]
        public async Task<ActionResult> editarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                UsuarioRepositorie repo = new UsuarioRepositorie();
                Usuario usuarioEditado = await repo.EditarUsuarioAsync(usuario);

                return new ContentResult
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    ContentType = Azure.Core.ContentType.ApplicationJson.ToString(),
                    Content = System.Text.Json.JsonSerializer.Serialize(usuarioEditado),
                };
            }
            catch (Exception e)
            {
                return new ContentResult
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                    ContentType = Azure.Core.ContentType.TextPlain.ToString(),
                    Content = e.Message,
                };
            }
        }

        [HttpDelete("excluirConta")]
        public async Task<ActionResult> excluirUsuario([FromBody] Usuario usuario)
        {
            try
            {
                UsuarioRepositorie repo = new UsuarioRepositorie();
                bool operacao = await repo.ExcluirUsuarioAsync(usuario);

                if (operacao)
                    return new ContentResult
                    {
                        StatusCode = (int)HttpStatusCode.OK,
                        ContentType = Azure.Core.ContentType.ApplicationJson.ToString(),
                        Content = "Exclusão realizada com sucesso. Você será redirecionado à página iniial.",
                    };
                else
                    return new ContentResult
                    {
                        StatusCode = (int)HttpStatusCode.NotAcceptable,
                        ContentType = Azure.Core.ContentType.ApplicationJson.ToString(),
                        Content = "Algum erro ocorreu durante a exclusão de conta. Tente novamente.",
                    };
            }
            catch (Exception e)
            {
                return new ContentResult
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                    ContentType = Azure.Core.ContentType.TextPlain.ToString(),
                    Content = e.Message,
                };
            }
        }
    }
}
