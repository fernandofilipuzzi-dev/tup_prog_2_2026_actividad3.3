
namespace Ejercicio1.Models;

public class Campo
{
    public string Identificador { get; set; }
    public double SuperficieTotal { get; set; }
    
    public Campo(string identificador, double superficieTotal)
    {
        Identificador = identificador;
        SuperficieTotal = superficieTotal;
    }

    #region manejo de parcelas

    List<Parcela> parcelas { get; set; } = new List<Parcela>();

    public bool CrearParcela(string identificador, double superficie)
    {
        if ((superficie +SuperficieOcupada())<= SuperficieTotal && BuscarParcela(identificador) < 0)
        {
            parcelas.Add(new Parcela(identificador, superficie));
            return true;
        }
        return false;
    }

    public int CantidadParcelas 
    {
        get 
        {
            return parcelas.Count;
        }
    }

    public Parcela VerParcela(int idx)
    {
        if (idx >= 0 && idx < parcelas.Count)
        {
            return parcelas[idx];
        }
        return null;
    }

    #endregion

    #region manejo de superficie
    public double SuperficieOcupada()
    {
        double superficieOcupada = 0;
        foreach (var parcela in parcelas)
        {
            superficieOcupada += parcela.Superficie;
        }
        return superficieOcupada;
    }
    
    public int BuscarParcela(string identificador)
    {
        parcelas.Sort();
        int idx=parcelas.BinarySearch(new Parcela(identificador, 0));
        return idx;
    }
    #endregion 

    public override string ToString()
    {
        return $"{Identificador}({SuperficieTotal:f2})";
    }
}
