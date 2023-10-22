using Espotei.DBContexts;
using Espotei.Models;

namespace Espotei.Repositories
{
    public class UsuarioRepositorie
    {
        #region Variáveis Privadas
        private int id;
        private string login;
        private string senha;
        #endregion

        #region Construtor
        public UsuarioRepositorie()
        {
            id = -1;
            login = "";
            senha = "";
        }
        #endregion        

        #region Propriedades
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Login
        {
            get { return this.login; }
            set { this.login = value; }
        }
        public string Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }
        #endregion

        #region Métodos
        public async Task<Usuario> CriarUsuarioAsync(Usuario usuarioASerCriado)
        {
            if (usuarioASerCriado != null)
                ValidarUsuario(usuarioASerCriado);

            UsuarioContext contexto = new UsuarioContext();
            await contexto.CriarUsuario(usuarioASerCriado);
            Usuario usuarioEditado = contexto.GetUsuario(null, usuarioASerCriado.Login).Result;

            return usuarioASerCriado;
        }

        public async Task<Usuario> EditarUsuarioAsync(Usuario usuarioASerEditado)
        {
            if (usuarioASerEditado != null)
                ValidarUsuario(usuarioASerEditado);

            UsuarioContext contexto = new UsuarioContext();
            await contexto.EditarUsuario(usuarioASerEditado);
            Usuario usuarioEditado = contexto.GetUsuario(null, usuarioASerEditado.Login).Result;

            return usuarioEditado;
        }

        public async Task<bool> ExcluirUsuarioAsync(Usuario usuarioASerExcluido)
        {
            try
            {
                if (usuarioASerExcluido != null)
                {
                    UsuarioContext contexto = new UsuarioContext();
                    await contexto.ExcluirUsuario(usuarioASerExcluido.Id);
                    Usuario usuarioEditado = contexto.GetUsuario(null, usuarioASerExcluido.Login).Result;

                    return true;
                }

                return true;
            }
            catch (Exception e)
            {
                throw e;                
            }                     
        }

        private static void ValidarUsuario(Usuario usuarioASerCriado)
        {
            // Validações de login
            if (usuarioASerCriado.Login.Length < 5)
                throw new Exception("O login deve conter mais de 5 caracteres.");

            var contemNumeros = false;
            char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (char caractereSenha in usuarioASerCriado.Login)
                foreach (char numeroStr in numeros)
                    if (caractereSenha == numeroStr)
                        contemNumeros = true;

            //if (!contemNumeros)
            //    throw new Exception("O login deve conter pelo menos um número.");

            // Validações de senha
            if (usuarioASerCriado.Senha.Length < 5)
                throw new Exception("A senha deve conter mais de 5 caracteres.");

            int temCaractere = -1;
            if (int.TryParse(usuarioASerCriado.Senha, System.Globalization.NumberStyles.Number, null, out temCaractere))
                if (temCaractere > 0)
                    throw new Exception("A senha deve conter pelo menos um caractere.");
        }
        #endregion
    }
}
