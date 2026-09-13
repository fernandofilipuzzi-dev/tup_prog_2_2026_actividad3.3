namespace Ejercicio1.Models;

public class Agricola : Actividad
{
    public Agricola(int periodo, string descripcion):base(periodo, descripcion)
    {
    }

    public override double CalcularProduccion()
    {
        return 0;
    }

    public override double CalcularRendimiento()
    {
        return 0;
    }
}