using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.EntityModels.Productos
{
    public class Producto : Entity
    {
        public Producto(string nombreProducto, string descripcionProducto, string idCategoria, string precioProducto, string imagenProducto)
        {
            NombreProducto = nombreProducto;
            DescripcionProducto = descripcionProducto;
            IdCategoria = idCategoria;
            PrecioProducto = precioProducto;
            ImagenProducto = imagenProducto;

        }

        //public void SetAdditionalInfo(string nombreProducto, string descripcionProducto, string IdCategoria, string precioProducto, int idProveedor, string ImagenProducto) //Solucion a problema con Constructor de Producto. +"No suitable constructor was found for entity type 'Producto'.Cannot bind 'correoProducto', 'telefonoProducto' in 'Producto(string nombreProducto,....

        //{
        //    NombreProducto = nombreProducto;
        //    DescripcionProducto = descripcionProducto;
        //    DireccionProducto = direccion;
        //}

        [Key]
        public int IdProducto { get; private set; }

        public string NombreProducto { get; private set; }

        public string DescripcionProducto { get; private set; }

        public string IdCategoria { get; private set; }

        public string PrecioProducto { get; private set; }

        public string ImagenProducto { get; private set; }

        //public int? ParentId { get; private set; }

        //[ForeignKey("ParentId")]
        //public List<Producto> Companions { get; private set; }

        public void Update(string nombreProducto, string descripcionProducto, string idCategoria, string precioProducto, string imagenProducto)
        {
            NombreProducto = nombreProducto;
            DescripcionProducto = descripcionProducto;
            IdCategoria = idCategoria;
            PrecioProducto = precioProducto;
            ImagenProducto = imagenProducto;
        }

    }
}
