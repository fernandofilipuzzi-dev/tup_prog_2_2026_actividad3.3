namespace Ejercicio1.Models;

public class Agricola : Actividad
{
    //datos productivos que se cargan al cierre del ciclo
    public int CantidadToneladasCosechadas { get; set; }
    public double PrecioTonelada { get; set; }

    public Agricola(int periodo, string descripcion):base(periodo, descripcion)
    {
    }

    //toneladas cosechadas por el precio de la tonelada
    public override double CalcularProduccion()
    {
        return CantidadToneladasCosechadas * PrecioTonelada;
    }

    //toneladas por hectárea ocupada
    public override double CalcularRendimiento()
    {
        double superficie = CalcularSuperficieOcupada();
        if (superficie > 0)
            return CantidadToneladasCosechadas / superficie;
        return 0;
    }
}
