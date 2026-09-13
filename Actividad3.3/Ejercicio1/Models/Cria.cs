namespace Ejercicio1.Models;

public class Cria : Ganadera
{
    public int CantidadVacasMadres { get; set; }
    public int CantidadTerneroDestete { get; set; }
    public double PrecioTernero { get; set; }

    public Cria(int periodo, string descripcion, int cantidad) : base(periodo, descripcion, cantidad)
    {
    }

    public override double CalcularRendimiento()
    {
        return 0;
    }

    public override double CalcularProduccion()
    {
        return 0; // Ejemplo de cálculo de egresos
    }
}
