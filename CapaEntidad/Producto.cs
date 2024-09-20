using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
//    CREATE TABLE PRODUCTO(
//IdProducto int primary key identity,
//Nombre varchar(500),
//Descripcion varchar(500),
//IdMarca int references Marca(IdMarca),
//IdCategoria int references Categoria(IdCategoria),
//Precio decimal (10,2) default 0,
//Stock int,
//RutaImagen varchar(100),
//NombreImagen varchar(100),
//Activo bit default 1,
//FechaRegistro datetime default getdate()
//)
    public class Producto
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca oMarca { get; set; }
        public Categoria oCategoria { get; set; }
        public decimal Precio { get; set; }

        public string PrecioTexto { get; set; }

        public int Stock { get; set; }
        public string RutaImagen { get; set; }
        public string NombreImagen { get; set; }
        public bool Activo { get; set; }

        public string Base64 { get; set; }

        public string Extension { get; set; }
    }
}
