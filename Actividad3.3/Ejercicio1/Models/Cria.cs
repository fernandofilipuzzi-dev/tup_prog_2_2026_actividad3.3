namespace Ejercicio1.Models;

public class Cria : Ganadera
{
    public int CantidadVacasMadres { get; set; }
    public int CantidadTerneroDestete { get; set; }
    public double PrecioTernero { get; set; }

    public Cria(int periodo, string descripcion) : base(periodo, descripcion)
    {
    }

    //terneros destetados por cada cien vacas madres (porcentaje de destete)
    public override double CalcularRendimiento()
    {
        if (CantidadVacasMadres > 0)
            return CantidadTerneroDestete * 100.0 / CantidadVacasMadres;
        return 0;
    }

    //terneros destetados por el precio de venta de cada ternero
    public override double CalcularProduccion()
    {
        return CantidadTerneroDestete * PrecioTernero;
    }
}
