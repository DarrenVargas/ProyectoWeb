using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Usuarios
{
    public class UsuarioExistente
    {
        public int IdUsuario { get; set; }

        public string NombreUsuario { get; set; }

        public string PasswordUsuario { get; set; }

        public int IdPersona { get; set; }

        public bool IsAdmin { get; set; }

    }
}
