using Ejercicio1.Models;
using Ejercicio1.Vistas;
using Ejercicio1.Vistas.Adms;
using System.Configuration;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    Estancia estancia { get; set; }

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        //inicia el sistema pide los datos del establecimiento
        AltaEstancia();
    }

    private void administrarCamposToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AdministrarCampos();
    }

    private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        AdministrarActividades();
    }

    private void informesToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void cascoToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }


    #region administracion

    protected void AdministrarCampos()
    {
        FormCamposAdm fCamposAdm = new FormCamposAdm();

        #region mostrar el listado de campos del establecimiento
        for (int idx = 0; idx < estancia.CantidadCampos; idx++)
        {
            Campo campo = estancia.VerCampo(idx);
            fCamposAdm.lsbCampos.Items.Add(campo);
        }
        #endregion

        #region mostrando listado de campos
        fCamposAdm.ShowDialog();

        bool continua = fCamposAdm.DialogResult == DialogResult.Retry ||
                        fCamposAdm.DialogResult == DialogResult.TryAgain ||
                        fCamposAdm.DialogResult == DialogResult.Continue;

        while (continua)
        {
            #region mostrar el listado de campos del establecimiento
            if (fCamposAdm.DialogResult == DialogResult.Retry)
            {
                fCamposAdm.lsbCampos.Items.Clear();
                for (int idx = 0; idx < estancia.CantidadCampos; idx++)
                {
                    Campo campo = estancia.VerCampo(idx);
                    fCamposAdm.lsbCampos.Items.Add(campo);
                }
            }
            #endregion

            #region agregar un campo al establecimiento
            else if (fCamposAdm.DialogResult == DialogResult.TryAgain)
            {
                //el registro de este campo nace en el registro de propiedad
                //podria ser un webservice o restapi hacia el registro de la propiedad
                Campo nuevo = SolicitarDatosCampo();
                if (estancia.AgregarCampo(nuevo) != null)
                {
                    fCamposAdm.lsbCampos.Items.Add(nuevo);
                }
            }
            #endregion

            #region administrar un campo
            else if (fCamposAdm.DialogResult == DialogResult.Continue)
            {
                int idx = fCamposAdm.lsbCampos.SelectedIndex;
                AdministrarUnCampo(idx);
            }
            #endregion

            fCamposAdm.ShowDialog();

            continua = fCamposAdm.DialogResult == DialogResult.Retry ||
                       fCamposAdm.DialogResult == DialogResult.TryAgain ||
                       fCamposAdm.DialogResult == DialogResult.Continue;
        }
        #endregion
    }

    protected void AdministrarUnCampo(int idxCampo)
    {
        if (idxCampo >= 0)
        {
            FormUnCampoAdm fCampoAdm = new FormUnCampoAdm();

            Campo campoSeleccionado = estancia.VerCampo(idxCampo);

            #region datos generales del campo 
            fCampoAdm.lbIdentificador.Text = campoSeleccionado.Identificador;
            fCampoAdm.lbSuperficieTotal.Text = campoSeleccionado.SuperficieTotal.ToString("0.00");
            double libre = campoSeleccionado.SuperficieTotal - campoSeleccionado.SuperficieOcupada();
            fCampoAdm.lbSuperficieSinParcelar.Text = libre.ToString("0.00");
            #endregion

            #region mostrar parcelas del campo
            for (int idx = 0; idx < campoSeleccionado.CantidadParcelas; idx++)
            {
                fCampoAdm.lsbParcelas.Items.Add(campoSeleccionado.VerParcela(idx));
            }
            #endregion

            fCampoAdm.ShowDialog();

            bool enEdicion = fCampoAdm.DialogResult == DialogResult.Retry || fCampoAdm.DialogResult == DialogResult.TryAgain;
            while (enEdicion)
            {
                #region actualizar listado
                if (fCampoAdm.DialogResult == DialogResult.Retry)
                {
                    fCampoAdm.lsbParcelas.Items.Clear();
                    for (int idx = 0; idx < campoSeleccionado.CantidadParcelas; idx++)
                    {
                        fCampoAdm.lsbParcelas.Items.Add(campoSeleccionado.VerParcela(idx));
                    }
                }
                #endregion

                #region agregar parcela o particion
                if (fCampoAdm.DialogResult == DialogResult.TryAgain)
                {
                    Parcela parcela = SolicitarDatosParcela();
                    bool exito = campoSeleccionado.CrearParcela(parcela.Identificador, parcela.Superficie);
                    if (exito)
                    {
                        fCampoAdm.lsbParcelas.Items.Add(parcela);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar la partición.");
                    }
                }
                #endregion

                fCampoAdm.ShowDialog();

                enEdicion = fCampoAdm.DialogResult == DialogResult.Retry || fCampoAdm.DialogResult == DialogResult.TryAgain;
            }
        }
    }

    protected void AdministrarActividades()
    {
        FormActividadAdm fActividadAdm = new FormActividadAdm();

        #region mostrar el listado de actividades productivas
        for (int idx = 0; idx < estancia.CantidadActividades; idx++)
        {
            estancia.VerActividad(idx);
        }
        #endregion

        fActividadAdm.ShowDialog();

        bool continuar = fActividadAdm.DialogResult == DialogResult.Retry || 
                            fActividadAdm.DialogResult == DialogResult.TryAgain;

        while (continuar)
        {
            #region mostrar el listado de actividades
            if (fActividadAdm.DialogResult == DialogResult.Retry)
            {
                #region mostrar el listado de actividades productivas
                for (int idx = 0; idx < estancia.CantidadActividades; idx++)
                {
                    estancia.VerActividad(idx);
                }
                #endregion
            }
            #endregion

            #region agregar una actividad
            else if (fActividadAdm.DialogResult == DialogResult.TryAgain)
            {
                Actividad nuevo = SolicitarDatosActividad();
                if (nuevo != null)
                {
                    if (estancia.AgregarActividad(nuevo.Periodo, nuevo.Descripcion, 0) != null)//teminar!!
                    {
                        fActividadAdm.lsbActividades.Items.Add(nuevo);
                    }
                }
            }
            #endregion


            fActividadAdm.ShowDialog();

            continuar = fActividadAdm.DialogResult == DialogResult.Retry ||
                            fActividadAdm.DialogResult == DialogResult.TryAgain;
        }
    }

    #endregion

    #region datos
    protected Campo SolicitarDatosCampo()
    {
        FormCampoDatos formCampoDatos = new FormCampoDatos();

        //solicito los valores al usuario
        if (formCampoDatos.ShowDialog() == DialogResult.OK)
        {
            string identificadorCampo1 = formCampoDatos.tbIdentificadorCampo.Text;
            double superficieCampo1 = Convert.ToDouble(formCampoDatos.tbSuperficieCampo.Text);

            //el campo aquí es un modelo de datos, un objeto de transporte
            Campo campo = new Campo(identificadorCampo1, superficieCampo1);

            return campo;
        }

        return null;
    }

    protected void AltaEstancia()
    {
        FormEstanciaDatos formEstanciaDatos = new FormEstanciaDatos();
        Campo nuevoCampo = null;

        //tengo que evaluar como vuelvo del formulario
        //tomo la estrategia de salir desde el formulario principal
        //y en lo posible no abrir ventanas modales de formularios modales.

        //para esto necesito un bucle que evalue con result vuelvo desde el formulario principal

        formEstanciaDatos.ShowDialog();

        bool estaEditando = formEstanciaDatos.DialogResult == DialogResult.OK ||
            formEstanciaDatos.DialogResult == DialogResult.TryAgain;

        //sigo solicitando datos al usuario mientras esté en editando y no haya completado los datos de la estancia
        while (estaEditando && estancia == null)
        {
            //verifico si quiere! cargar los datos del campo, si "si", me guardo los datos
            //si quiere!, tengo que pedir los datos
            if (formEstanciaDatos.DialogResult == DialogResult.TryAgain)
            {
                nuevoCampo = SolicitarDatosCampo();

                if (nuevoCampo != null)
                {
                    formEstanciaDatos.lbDescripcionGeneral.Text = nuevoCampo.ToString();
                }

                formEstanciaDatos.ShowDialog();
            }

            //evaluo el caso de que finalice el formulario
            else if (formEstanciaDatos.DialogResult == DialogResult.OK)
            {
                //verifico si editó los datos del campo.
                if (nuevoCampo == null)
                {
                    formEstanciaDatos.lbDescripcionGeneral.Text = "Debe completar los datos del campo principal de la estancia.";

                    formEstanciaDatos.ShowDialog();
                }
                else
                {
                    //confirmación del alta del campo
                    string nombreEstancia = formEstanciaDatos.tbNombre.Text;
                    Campo campo=new Campo(nuevoCampo.Identificador, nuevoCampo.SuperficieTotal);
                    estancia = new Estancia(nombreEstancia, campo);
                }
            }

            estaEditando = formEstanciaDatos.DialogResult == DialogResult.OK ||
            formEstanciaDatos.DialogResult == DialogResult.TryAgain;
        }

        //verifico si cancelo la configuración de la estancia - 
        if (estancia == null)
            Close();
    }

    public Parcela SolicitarDatosParcela()
    {
        FormParcelaDatos formParcelaDatos = new FormParcelaDatos();

        if (formParcelaDatos.ShowDialog() == DialogResult.OK)
        {
            string id = formParcelaDatos.tbIdentificadorCampo.Text;
            double superficie = Convert.ToDouble(formParcelaDatos.tbSuperficieCampo.Text);

            Parcela parcela = new Parcela(id, superficie);
            return parcela;
        }
        return null;
    }

    protected Actividad SolicitarDatosActividad()
    {
        FormActividadDatos fActividadDatos = new FormActividadDatos();

        //solicito los valores al usuario
        if (fActividadDatos.ShowDialog() == DialogResult.OK)
        {
            int periodo = Convert.ToInt32(fActividadDatos.tbPeriodoActividad.Text);
            string descripcion = fActividadDatos.tbDescripcionActividad.Text;
            int tipo = fActividadDatos.cmbTipoActividad.SelectedIndex;

            //el campo aquí es un modelo de datos, un objeto de transporte
            Actividad actividad = null;
            switch (tipo)
            {
                case 0:
                    actividad = new Agricola(periodo,descripcion);
                    break;
            }

            return actividad;
        }

        return null;
    }
    #endregion

}
