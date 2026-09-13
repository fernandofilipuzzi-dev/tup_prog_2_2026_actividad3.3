
namespace Ejercicio1.Models;

abstract public class Actividad
{
    public int Periodo { get; set; }
    public string Descripcion { get; set; } 

    List<Parcela> lotesAsignados = new List<Parcela>();

    public Actividad(int periodo, string descripcion)
    {
        Periodo = periodo;
        Descripcion = descripcion;
    }

    abstract public double CalcularRendimiento();

    abstract public double CalcularProduccion();


    public override string ToString()
    {
        return $"Periodo: {Periodo}, Descripcion: {Descripcion}";
    }
}
