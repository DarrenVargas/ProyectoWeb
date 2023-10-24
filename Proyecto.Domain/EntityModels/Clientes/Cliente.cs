using Proyecto.Domain.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.EntityModels.Cliente
{
    public class Cliente : Entity
    {
        //private Cliente()
        //{
        //    Companions = new List<Cliente>();
        //}

        public Cliente(string nombreCliente, string apellidoCliente, string cedulaCliente, string correoCliente, string telefonoCliente, string direccionCliente)
        {
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            CedulaCliente = cedulaCliente;
            CorreoElectronico = correoCliente;
            NumeroTelefono = telefonoCliente;
            DireccionCliente = direccionCliente;
        }

        public int Id { get; private set; }

        public string CedulaCliente { get; private set; }

        public string NombreCliente { get; private set; }

        public string ApellidoCliente { get; private set; }

        public string CorreoElectronico { get; private set; }

        public string NumeroTelefono { get; private set; }

        public string DireccionCliente { get; private set; }

        //public int? ParentId { get; private set; }

        //[ForeignKey("ParentId")]
        //public List<Cliente> Companions { get; private set; }

        public void Update(string nombreCliente, string apellidoCliente, string cedula, string correo, string telefono, string direccion)
        {
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            CedulaCliente = cedula;
            CorreoElectronico = correo;
            NumeroTelefono = telefono;
            DireccionCliente = direccion;
        }

    }
}
