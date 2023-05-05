using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Clase5.Models;

namespace Clase5.Data
{
    public class CarContext : DbContext // HERENCIA (SI TUVIERA MAS MODELOS) CAR CONTEXT HEREDA DE DBCONTEXT.
    {
        public CarContext (DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        public DbSet<Clase5.Models.Car> Car { get; set; } = default!; // PROPIEDAD PARA MANIPULAR EL OBJETO CAR QUE ES UNA TABLA // vinculo con la base de datos.
    }
        //  public DbSet<Clase5.Models.Marca> Marcas { get; set; } = default!; // db conext tambien manejaria la tabla marca, en caso de que hubiera mas propiedades.
}
