

namespace Ejercicio1.Models;

abstract public class Ganadera:Actividad
{
    public int CantidadCabezas { get; set; }

    public Ganadera(int periodo, string descripcion, int cantidad) : base(periodo, descripcion)
    {
        CantidadCabezas = cantidad;
    }
}
