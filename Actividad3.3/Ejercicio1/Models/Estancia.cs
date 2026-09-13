
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
        Casco.Encargado = "No designado";
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
            //otras actividades
        }

        if(nueva!=null)
            actividades.Add(nueva);
        return nueva;
    }

    public int CantidadActividades
    { 
        get { return actividades.Count; }
    }
    public Actividad VerActividad(int idx)
    {
        if (idx >= 0 && idx < actividades.Count)
        {
            return actividades[idx] as Actividad;
        }
        return null;
    }

    #endregion

    #region Administración de los campos
    ArrayList campos = new ArrayList();

    public Campo AgregarCampo(Campo campo)
    {
        campos.Add(campo);  
        return campo;
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

}
