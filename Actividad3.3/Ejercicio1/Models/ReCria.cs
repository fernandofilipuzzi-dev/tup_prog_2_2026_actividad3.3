namespace Ejercicio1.Models;

public class ReCria : Ganadera
{
    public int CantidadKilosCarneFinal { get; set; }

    public ReCria(int periodo, string descripcion) : base(periodo, descripcion)
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
