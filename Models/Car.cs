using System.ComponentModel.DataAnnotations;

namespace Clase5.Models;


// creacion de clase (nuestro modelo)
public class Car {
    public int Id { get; set; }
    [Display(Name="Marca")]
    public string Make { get; set; }
     [Display(Name="Modelo")]
    public string Model { get; set; }
    [Display(Name="Año")]
    public int Year {get; set;}
    [Display(Name="Patente")]
    public string Plate { get; set; }
    [Display(Name="Color")]
    public string Color{ get; set; } // CASO HIPOTETICO EN CUANTO A AGREGAR EL COLOR // SE AGREGA UN NUEVO ATRIBUTO/PROPIEDAD DESPUES DE HABER HECHO LA PRIMERA MIGRACION.

}
