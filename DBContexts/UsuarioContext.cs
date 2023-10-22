using Dapper;
using Espotei.DBContexts.Records;
using Espotei.Models;
using Microsoft.Data.SqlClient;

namespace Espotei.DBContexts
{
    public class UsuarioContext
    {
        #region Variáveis Privadas
        private string connectionString = "";
        #endregion

        #region Construtor
        public UsuarioContext() {
            this.connectionString = @"connection timeout=600; Persist Security Info=True;Initial Catalog=DBBaseTeste;Data Source=(LocalDb)\BaseTeste";
        }
        #endregion        

        #region Métodos
        public async Task<bool> CriarUsuario(Usuario usuario)
        {
            try
            {
                await using (var connection = new SqlConnection(this.connectionString))
                {
                    await connection.ExecuteAsync("INSERT INTO [Usuario](LOGIN, SENHA) VALUES(@login, @senha)",
                    new
                    {
                        login = usuario.Login,
                        senha = usuario.Senha,                        
                    });
                }
                return true;
            }
            catch (Exception e)
            {
                throw e; 
            }
        }

        public async Task<Models.Usuario> GetUsuario(string? id, string? login)
        {
            try
            {
                UsuarioDB usuarioDb;
                if (id != null)
                    await using (var connection = new SqlConnection(this.connectionString))
                        usuarioDb = await connection.QueryFirstOrDefaultAsync<UsuarioDB>("SELECT [Id], [Login], [Senha] FROM [Usuario] WHERE [Id]=@id", new { id = id });
                else
                    await using (var connection = new SqlConnection(this.connectionString))
                        usuarioDb = await connection.QueryFirstOrDefaultAsync<UsuarioDB>("SELECT [Id], [Login], [Senha] FROM [Usuario] WHERE [Login]=@login", new { login = login });

                Usuario usuario;
                usuario = usuarioDb == null ?
                    new Models.Usuario { Id = 0, Login = "", Senha = "", }
                    : new Models.Usuario { Id = usuarioDb.Id, Login = usuarioDb.login, Senha = usuarioDb.senha, };

                return usuario;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> EditarUsuario(Usuario usuario)
        {
            try
            {
                await using (var connection = new SqlConnection(this.connectionString))
                {
                    await connection.ExecuteAsync("UPDATE [Usuario] SET [Login]=@login, [Senha]=@senha, WHERE [Id]=@id",
                        new { id = usuario.Id, login = usuario.Login, senha = usuario.Senha });
                }

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> ExcluirUsuario(int idUsuario)
        {
            try
            {
                await using (var connection = new SqlConnection(this.connectionString))
                {
                    await connection.ExecuteAsync("DELETE FROM [Usuario] WHERE [Id]=@id",
                        new { id = idUsuario });
                }

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
    #endregion
}
