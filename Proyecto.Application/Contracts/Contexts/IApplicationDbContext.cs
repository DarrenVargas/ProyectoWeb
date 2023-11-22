using Proyecto.Domain.EntityModels.Cliente;
using Proyecto.Domain.EntityModels.Colaboradores;
using Proyecto.Domain.EntityModels.Productos;
using Proyecto.Domain.EntityModels.Usuarios;
<<<<<<< HEAD
=======
using Proyecto.Domain.EntityModels.Categorias;
using Proyecto.Domain.EntityModels.Facturaciones;
using Proyecto.Domain.EntityModels.Proveedores;
>>>>>>> main
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Application.Contracts.Contexts
{
    public interface IApplicationDbContext
    {
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Colaborador> Colaboradores { get; set; }
<<<<<<< HEAD
=======
        DbSet<Categoria> Categorias { get; set; }
        DbSet<Facturacion> Facturaciones { get; set; }
        DbSet<Proveedor> Proveedores { get; set; }
>>>>>>> main
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Producto> Productos { get; set; }

        void Save();
    }
}
