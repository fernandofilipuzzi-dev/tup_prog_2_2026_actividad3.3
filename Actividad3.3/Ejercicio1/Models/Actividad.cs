
namespace Ejercicio1.Models;

abstract public class Actividad
{
    public int Periodo { get; set; }
    public string Descripcion { get; set; } 

    public Actividad(int periodo, string descripcion)
    {
        Periodo = periodo;
        Descripcion = descripcion;
    }

    #region manejo de lotes

    //los lotes son parcelas que ya existen en algún campo de la estancia,
    //acá solo guardo la referencia (agregación)
    List<Parcela> lotesAsignados = new List<Parcela>();

    public bool AsignarLote(Parcela lote)
    {
        //un lote no se puede asignar dos veces a la misma actividad
        //y una actividad cerrada ya no admite más lotes
        if (lote != null && !Cerrada && !lotesAsignados.Contains(lote))
        {
            lotesAsignados.Add(lote);
            return true;
        }
        return false;
    }

    public int CantidadLotes
    {
        get { return lotesAsignados.Count; }
    }

    public Parcela VerLote(int idx)
    {
        if (idx >= 0 && idx < lotesAsignados.Count)
            return lotesAsignados[idx];
        return null;
    }

    public bool TieneLote(Parcela parcela)
    {
        return lotesAsignados.Contains(parcela);
    }

    public double CalcularSuperficieOcupada()
    {
        double superficie = 0;
        foreach (Parcela lote in lotesAsignados)
        {
            superficie += lote.Superficie;
        }
        return superficie;
    }

    #endregion

    #region cierre de la actividad

    public bool Cerrada { get; private set; } = false;

    //los datos productivos los carga cada tipo por sus propiedades,
    //acá solo verifico la regla: al menos un lote asignado
    public bool Cerrar()
    {
        if (CantidadLotes > 0)
        {
            Cerrada = true;
            return true;
        }
        return false;
    }

    #endregion

    #region indicadores productivos

    //cada tipo de actividad sabe calcular lo suyo (polimorfismo)

    //rendimiento en la unidad propia de cada tipo
    abstract public double CalcularRendimiento();

    //producción valorizada en dinero
    abstract public double CalcularProduccion();

    #endregion

    public override string ToString()
    {
        return $"Periodo: {Periodo}, Descripcion: {Descripcion}";
    }
}
