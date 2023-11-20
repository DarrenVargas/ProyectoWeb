using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.EntityModels.Usuarios
{
    public class Usuario : Entity
    {
        public Usuario(string NombreUsuario, string PasswordUsuario, int? IdPersona, bool IsAdmin)
        {
            this.NombreUsuario = NombreUsuario;
            this.PasswordUsuario = PasswordUsuario;
            this.IdPersona = IdPersona;
            this.IsAdmin = IsAdmin;
        }

        [Key]
        public int IdUsuario { get; private set; }

        public string NombreUsuario { get; private set; }

        public string PasswordUsuario { get; private set; }

        public int? IdPersona { get; private set; }

        public bool IsAdmin { get; private set; }


        public void Update(string NombreUsuario, string PasswordUsuario, int? IdPersona, bool IsAdmin)
        {
            this.NombreUsuario = NombreUsuario;
            this.PasswordUsuario = PasswordUsuario;
            this.IdPersona = IdPersona;
            this.IsAdmin = IsAdmin;
        }
    }
}
