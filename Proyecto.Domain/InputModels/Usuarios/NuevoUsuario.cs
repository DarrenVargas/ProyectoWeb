using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.InputModels.Usuarios
{
    public class NuevoUsuario
    {
        [Required]
        [DisplayName("Nombre de Usuario")]
        public string NombreUsuario { get; set; }

        [Required]
        [DisplayName("Contraseña")]
        public string PasswordUsuario { get; set; }

        [Required]
        [DisplayName("Nombre Persona")]
        public int IdPersona { get; set; }

        [Required]
        [DisplayName("Admin")]
        public bool IsAdmin { get; set; }
    }
}
