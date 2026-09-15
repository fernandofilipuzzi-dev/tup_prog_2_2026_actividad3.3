
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
        //la superficie no puede ser cero y tiene que entrar en lo que queda sin parcelar,
        //y el identificador tiene que ser único dentro del campo
        if (superficie > 0 && (superficie +SuperficieOcupada())<= SuperficieTotal && BuscarParcela(identificador) < 0)
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

    //solo se modifica la superficie asignada, el identificador queda
    public bool ModificarParcela(int idx, double superficie)
    {
        Parcela parcela = VerParcela(idx);
        if (parcela != null)
        {
            //la superficie ocupada sin contar la parcela que estoy modificando
            double ocupada = SuperficieOcupada() - parcela.Superficie;
            if (superficie > 0 && (superficie + ocupada) <= SuperficieTotal)
            {
                parcela.Superficie = superficie;
                return true;
            }
        }
        return false;
    }

    public bool EliminarParcela(int idx)
    {
        Parcela parcela = VerParcela(idx);
        if (parcela != null)
        {
            parcelas.Remove(parcela);
            return true;
        }
        return false;
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
