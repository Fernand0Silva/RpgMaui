using AppRpgEtec.Services;
using System;

namespace AppRpgEtec.Models
{
    public class UsuarioService
    {
        private Request _request; // Declara a variável
        private string _token;

        public UsuarioService(string token)
        {
            _request = new Request(); // Inicializa no construtor
            _token = token;
        }
    }
}
