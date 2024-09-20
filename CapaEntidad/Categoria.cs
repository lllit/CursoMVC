using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{

    //CREATE TABLE CATEGORIA(
    //IdCategoria int primary key identity,
    //Descripcion varchar(100),
    //Activo bit default 1,
    //FechaRegistro datetime default getdate())
    //
    //GO

    public class Categoria
    {
        public int IdCategoria {  get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
