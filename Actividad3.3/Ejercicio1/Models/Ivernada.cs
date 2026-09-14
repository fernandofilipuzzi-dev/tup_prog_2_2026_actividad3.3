namespace Ejercicio1.Models;

public class Ivernada : Ganadera
{
    public int CantidadKilosCarneInicial { get; set; }
    public int CantidadKilosCarneFinal { get; set; }
    public double PrecioKilo { get; set; }

    public Ivernada(int periodo, string descripcion) : base(periodo, descripcion)
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
