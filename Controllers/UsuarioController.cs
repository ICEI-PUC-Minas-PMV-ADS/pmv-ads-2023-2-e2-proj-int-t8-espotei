using Espotei.Models;
using Espotei.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Espotei.Controllers
{
    [Route("espotei/usuario")]
    public class UsuarioController : Controller
    {
        [Route("criarConta")]
        public async Task<ActionResult> criarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                UsuarioRepositorie repo = new UsuarioRepositorie();
                Usuario usuarioCriado = await repo.CriarUsuarioAsync(usuario);

                return new ContentResult
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    ContentType = Azure.Core.ContentType.ApplicationJson.ToString(),
                    Content = System.Text.Json.JsonSerializer.Serialize(usuarioCriado),
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

        [Route("editarConta")]
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

        [Route("excluirConta")]
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
