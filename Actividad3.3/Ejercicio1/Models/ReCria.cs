namespace Ejercicio1.Models;

public class ReCria : Ganadera
{
    //kilos de carne logrados en la etapa, contados sobre el total de los animales
    public int CantidadKilosCarneFinal { get; set; }
    public double PrecioKilo { get; set; }

    public ReCria(int periodo, string descripcion) : base(periodo, descripcion)
    {
    }

    //kilos de carne logrados por el precio del kilo
    public override double CalcularProduccion()
    {
        return CantidadKilosCarneFinal * PrecioKilo;
    }

    //kilos de carne logrados por cabeza
    public override double CalcularRendimiento()
    {
        if (CantidadCabezas > 0)
            return (double)CantidadKilosCarneFinal / CantidadCabezas;
        return 0;
    }
}
