

namespace Ejercicio1.Models;

abstract public class Ganadera:Actividad
{
    public int CantidadCabezas { get; set; }

    //public Ganadera(int periodo, string descripcion, int cantidadCabezas) : base(periodo, descripcion)
    public Ganadera(int periodo, string descripcion) : base(periodo, descripcion)
    {
        //CantidadCabezas = cantidadCabezas;
    }
}
