using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Domain.DTOs.Clientes;
using Proyecto.Domain.InputModels.Cliente;

namespace Proyecto.Application.Contracts
{
    public interface IClienteService
    {
        Cliente Get(int id);

        List<Cliente> List();

        bool Insert(NuevoCliente newGuest);

        bool Update(ClienteExistente existingGuest);

        bool Delete(int id);
    }
}
