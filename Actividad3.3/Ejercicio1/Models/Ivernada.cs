namespace Ejercicio1.Models;

public class Ivernada : Ganadera
{
    //kilos iniciales y finales contados sobre el total de los animales
    public int CantidadKilosCarneInicial { get; set; }
    public int CantidadKilosCarneFinal { get; set; }
    public double PrecioKilo { get; set; }

    public Ivernada(int periodo, string descripcion) : base(periodo, descripcion)
    {
    }

    //kilos ganados (finales menos iniciales) por el precio del kilo
    public override double CalcularProduccion()
    {
        return (CantidadKilosCarneFinal - CantidadKilosCarneInicial) * PrecioKilo;
    }

    //kilos ganados por cabeza
    public override double CalcularRendimiento()
    {
        if (CantidadCabezas > 0)
            return (double)(CantidadKilosCarneFinal - CantidadKilosCarneInicial) / CantidadCabezas;
        return 0;
    }
}
