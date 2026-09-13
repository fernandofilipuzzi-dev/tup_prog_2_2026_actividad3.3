
namespace Ejercicio1.Models;

public class Parcela:IComparable
{
    public string Identificador { get; set; }
    public double Superficie { get; set; }

    public Parcela(string identificador, double superficie)
    {
        Identificador = identificador;
        Superficie = superficie;
    }

    public int CompareTo(object obj)
    {
        Parcela otra=obj as Parcela;
        if (otra != null)
            return Identificador.CompareTo(otra.Identificador);
        return -1;
    }

    public override string ToString()
    {
        return $"{Identificador}({Superficie:f2})";
    }
}
