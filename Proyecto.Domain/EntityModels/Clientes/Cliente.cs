using Guests.Domain.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Domain.EntityModels.Clientes
{
    public class Cliente : Entity
    {
        //private Cliente()
        //{
        //    Companions = new List<Cliente>();
        //}

        public Cliente(string nombreCliente, string apellidoCliente)
        {
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
        }

        public int Id { get; private set; }

        public string cedulaCliente { get; private set; }

        public string NombreCliente { get; private set; }

        public string ApellidoCliente { get; private set; }

        public int? ParentId { get; private set; }

        //[ForeignKey("ParentId")]
        //public List<Cliente> Companions { get; private set; }

        public void Update(string nombreCliente, string apellidoCliente)
        {
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
        }
    }
}
