
using System.Collections;

namespace Ejercicio1.Models;

public class Estancia
{
    public string Nombre { get; set; }

    #region Creación de la estancia
    //(1)
    //public Estancia(string nombre, string idCampo1, double supCampo1)
    public Estancia(string nombre, Campo campo)
    {
        Nombre = nombre;
        //campos.Add(new Campo(idCampo1, supCampo1));
        campos.Add(campo);
        Casco = new Casco();
        Casco.Administrador = "No designado";
        AgregarPuesto("No designado");
    }
    #endregion

    #region Administración del casco y puestos
    public Casco Casco { get; set; }

    Puesto[] puestos = new Puesto[100];

    public void AgregarPuesto(string encargado)
    {
        Puesto puesto = new Puesto();
        puesto.Encargado = encargado;
        puestos[CantidadPuestos] = puesto;
        CantidadPuestos++;
    }

    public Puesto VerPuesto(int idx)
    {
        if (idx >= 0 && idx < CantidadPuestos)
            return puestos[idx];
        return null;
    }

    public int CantidadPuestos { get; private set; } = 0;
    #endregion

    #region Administración de las actividades

    List<Actividad> actividades = new List<Actividad>();

    public Actividad AgregarActividad(int periodo, string descripcion, int tipo)
    {
        Actividad nueva = null;
        switch (tipo)
        {
            case 1:
                nueva = new Agricola(periodo, descripcion);
                break;
            case 2:
                nueva = new Cria(periodo, descripcion);
                break;
            case 3:
                nueva = new Ivernada(periodo, descripcion);
                break;
            case 4:
                nueva = new ReCria(periodo, descripcion);
                break;
        }

        if(nueva!=null)
            actividades.Add(nueva);

        return nueva;
    }

    public int CantidadActividades
    { 
        get { return actividades.Count; }
    }

    //una parcela puede ser lote de una sola actividad a la vez
    public bool EstaAsignada(Parcela parcela)
    {
        foreach (Actividad actividad in actividades)
        {
            if (actividad.TieneLote(parcela))
                return true;
        }
        return false;
    }
    public Actividad VerActividad(int idx)
    {
        /*
        if (idx >= 0 && idx < actividades.Count)
        {
            return actividades[idx] as Actividad;
        }
        */

        if (idx < 0 || idx >= actividades.Count) return null;        
        return actividades[idx] as Actividad;        
    }

    #endregion

    #region Administración de los campos
    ArrayList campos = new ArrayList();

    public Campo AgregarCampo(Campo campo)
    {
        //el identificador tiene que ser único dentro de la estancia
        //y la superficie no puede ser cero
        if (campo == null || campo.SuperficieTotal <= 0 || BuscarCampo(campo.Identificador) != null)
            return null;

        campos.Add(campo);  
        return campo;
    }

    public Campo BuscarCampo(string identificador)
    {
        foreach (Campo campo in campos)
        {
            if (campo.Identificador == identificador)
                return campo;
        }
        return null;
    }

    public int CantidadCampos
    {
        get
        {
            return campos.Count;
        }
    }

    public Campo VerCampo(int idx)
    {
        if (idx >= 0 && idx < campos.Count)
        {
            return campos[idx] as Campo;
        }
        return null;
    }
    #endregion

    #region informes

    //producción total de la estancia: la suma de lo que produce cada actividad
    public double CalcularProduccionTotal()
    {
        double total = 0;
        foreach (Actividad actividad in actividades)
        {
            //cada actividad sabe calcular lo suyo (polimorfismo)
            total += actividad.CalcularProduccion();
        }
        return total;
    }

    //productividad general: porcentaje de la superficie de los campos
    //que está ocupada por lotes asignados a alguna actividad
    public double CalcularProductividadGeneral()
    {
        double ocupada = 0;
        foreach (Actividad actividad in actividades)
        {
            ocupada += actividad.CalcularSuperficieOcupada();
        }

        double total = 0;
        for (int idx = 0; idx < CantidadCampos; idx++)
        {
            total += VerCampo(idx).SuperficieTotal;
        }

        if (total > 0)
            return ocupada / total * 100;
        return 0;
    }

    #endregion

}
