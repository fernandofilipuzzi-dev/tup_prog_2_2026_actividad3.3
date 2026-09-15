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
        InformeProductividad();
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
                if (nuevo != null)
                {
                    if (estancia.AgregarCampo(nuevo) != null)
                    {
                        fCamposAdm.lsbCampos.Items.Add(nuevo);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el campo: el identificador ya existe o es nulo, o la superficie es cero.");
                    }
                }
            }
            #endregion

            #region administrar un campo
            else if (fCamposAdm.DialogResult == DialogResult.Continue)
            {
                int idx = fCamposAdm.lsbCampos.SelectedIndex;
                if (idx >= 0)
                    AdministrarUnCampo(idx);
                else
                    MessageBox.Show("Seleccione un campo de la lista.");
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

            bool enEdicion = fCampoAdm.DialogResult == DialogResult.Retry ||
                             fCampoAdm.DialogResult == DialogResult.TryAgain ||
                             fCampoAdm.DialogResult == DialogResult.Continue;
            while (enEdicion)
            {
                #region agregar parcela o particion
                if (fCampoAdm.DialogResult == DialogResult.TryAgain)
                {
                    Parcela parcela = SolicitarDatosParcela();
                    if (parcela != null)
                    {
                        bool exito = campoSeleccionado.CrearParcela(parcela.Identificador, parcela.Superficie);
                        if (!exito)
                        {
                            MessageBox.Show("No se pudo realizar la partición.");
                        }
                    }
                }
                #endregion

                #region modificar o eliminar una parcela
                else if (fCampoAdm.DialogResult == DialogResult.Continue)
                {
                    int idx = fCampoAdm.lsbParcelas.SelectedIndex;
                    if (idx >= 0)
                        ModificarParcela(campoSeleccionado, idx);
                    else
                        MessageBox.Show("Seleccione una parcela de la lista.");
                }
                #endregion

                #region actualizar listado
                //vuelvo a cargar el listado siempre, porque el campo reordena las parcelas
                //al buscar y el índice del listbox tiene que coincidir con el del campo
                fCampoAdm.lsbParcelas.Items.Clear();
                for (int idx = 0; idx < campoSeleccionado.CantidadParcelas; idx++)
                {
                    fCampoAdm.lsbParcelas.Items.Add(campoSeleccionado.VerParcela(idx));
                }
                libre = campoSeleccionado.SuperficieTotal - campoSeleccionado.SuperficieOcupada();
                fCampoAdm.lbSuperficieSinParcelar.Text = libre.ToString("0.00");
                #endregion

                fCampoAdm.ShowDialog();

                enEdicion = fCampoAdm.DialogResult == DialogResult.Retry ||
                            fCampoAdm.DialogResult == DialogResult.TryAgain ||
                            fCampoAdm.DialogResult == DialogResult.Continue;
            }
        }
    }

    protected void AdministrarActividades()
    {
        FormActividadAdm fActividadAdm = new FormActividadAdm();

        #region mostrar el listado de actividades productivas
        for (int idx = 0; idx < estancia.CantidadActividades; idx++)
        {
            fActividadAdm.lsbActividades.Items.Add(estancia.VerActividad(idx));
        }
        #endregion

        fActividadAdm.ShowDialog();

        bool continuar = fActividadAdm.DialogResult == DialogResult.Retry || 
                            fActividadAdm.DialogResult == DialogResult.TryAgain ||
                            fActividadAdm.DialogResult == DialogResult.Continue;

        while (continuar)
        {
            #region mostrar el listado de actividades
            if (fActividadAdm.DialogResult == DialogResult.Retry)
            {
                #region mostrar el listado de actividades productivas
                fActividadAdm.lsbActividades.Items.Clear();
                for (int idx = 0; idx < estancia.CantidadActividades; idx++)
                {
                    fActividadAdm.lsbActividades.Items.Add(estancia.VerActividad(idx));
                }
                #endregion
            }
            #endregion

            #region agregar una actividad
            else if (fActividadAdm.DialogResult == DialogResult.TryAgain)
            {
                
                FormActividadDatos fActividadDatos = new FormActividadDatos();

                //solicito los valores al usuario
                if (fActividadDatos.ShowDialog() == DialogResult.OK)
                {
                    #region Solicitar datos actividad
                    int periodo = Convert.ToInt32(fActividadDatos.tbPeriodoActividad.Text);
                    string descripcion = fActividadDatos.tbDescripcionActividad.Text;
                    int tipo = fActividadDatos.cmbTipoActividad.SelectedIndex+1;

                    int cantidadCabezas = 0;
                    if (!string.IsNullOrEmpty(fActividadDatos.tbCantidadCabezas.Text))
                    {
                        cantidadCabezas = Convert.ToInt32(fActividadDatos.tbCantidadCabezas.Text);
                    }
                    #endregion

                    Actividad nueva = estancia.AgregarActividad(periodo, descripcion, tipo);

                    /*
                     if(tipo==0)
                     {
                        Actividad nueva = estancia.AgregarActividad(periodo, descripcion, tipo);
                     }
                     else if(tipo==0)
                     {
                        Actividad nueva = estancia.AgregarActividad(periodo, descripcion, tipo, cantidadCabezas);
                     }
                     */

                    if (nueva!=null)
                    {
                        if(nueva is Ganadera)
                        {
                            ((Ganadera)nueva).CantidadCabezas = cantidadCabezas;
                        }
                        fActividadAdm.lsbActividades.Items.Add(nueva);
                    }
                }
            }
            #endregion


            #region administrar una actividad
            else if (fActividadAdm.DialogResult == DialogResult.Continue)
            {
                int idx = fActividadAdm.lsbActividades.SelectedIndex;
                if (idx >= 0)
                    AdministrarUnaActividad(idx);
                else
                    MessageBox.Show("Seleccione una actividad de la lista.");
            }
            #endregion

            fActividadAdm.ShowDialog();

            continuar = fActividadAdm.DialogResult == DialogResult.Retry ||
                            fActividadAdm.DialogResult == DialogResult.TryAgain ||
                            fActividadAdm.DialogResult == DialogResult.Continue;
        }
    }

    protected void AdministrarUnaActividad(int idxActividad)
    {
        Actividad actividadSeleccionada = estancia.VerActividad(idxActividad);
        if (actividadSeleccionada != null)
        {
            FormUnaActividadAdm fActividadAdm = new FormUnaActividadAdm();

            #region datos generales de la actividad
            //el tipo lo saco del nombre de la clase con que se instanció
            fActividadAdm.lbTipo.Text = actividadSeleccionada.GetType().Name;
            fActividadAdm.lbPeriodo.Text = actividadSeleccionada.Periodo.ToString();
            fActividadAdm.lbDescripcion.Text = actividadSeleccionada.Descripcion;
            fActividadAdm.lbSuperficieOcupada.Text = actividadSeleccionada.CalcularSuperficieOcupada().ToString("0.00");
            fActividadAdm.lbEstado.Text = actividadSeleccionada.Cerrada ? "Cerrada" : "En curso";
            #endregion

            #region mostrar lotes asignados
            for (int idx = 0; idx < actividadSeleccionada.CantidadLotes; idx++)
            {
                fActividadAdm.lsbLotes.Items.Add(actividadSeleccionada.VerLote(idx));
            }
            #endregion

            fActividadAdm.ShowDialog();

            bool enEdicion = fActividadAdm.DialogResult == DialogResult.Retry ||
                             fActividadAdm.DialogResult == DialogResult.TryAgain ||
                             fActividadAdm.DialogResult == DialogResult.Continue;
            while (enEdicion)
            {
                #region asignar un lote
                if (fActividadAdm.DialogResult == DialogResult.TryAgain)
                {
                    Parcela lote = SolicitarLote();
                    if (lote != null)
                    {
                        //una parcela puede ser lote de una sola actividad
                        if (estancia.EstaAsignada(lote))
                        {
                            MessageBox.Show("El lote ya está asignado a una actividad.");
                        }
                        else if (!actividadSeleccionada.AsignarLote(lote))
                        {
                            MessageBox.Show("No se pudo asignar el lote.");
                        }
                    }
                }
                #endregion

                #region cerrar la actividad con los datos productivos
                else if (fActividadAdm.DialogResult == DialogResult.Continue)
                {
                    CerrarActividad(actividadSeleccionada);
                }
                #endregion

                #region actualizar listado y estado
                fActividadAdm.lsbLotes.Items.Clear();
                for (int idx = 0; idx < actividadSeleccionada.CantidadLotes; idx++)
                {
                    fActividadAdm.lsbLotes.Items.Add(actividadSeleccionada.VerLote(idx));
                }
                fActividadAdm.lbSuperficieOcupada.Text = actividadSeleccionada.CalcularSuperficieOcupada().ToString("0.00");
                fActividadAdm.lbEstado.Text = actividadSeleccionada.Cerrada ? "Cerrada" : "En curso";
                #endregion

                fActividadAdm.ShowDialog();

                enEdicion = fActividadAdm.DialogResult == DialogResult.Retry ||
                            fActividadAdm.DialogResult == DialogResult.TryAgain ||
                            fActividadAdm.DialogResult == DialogResult.Continue;
            }
        }
    }

    protected void CerrarActividad(Actividad actividad)
    {
        //la regla del cierre la tiene la actividad: al menos un lote asignado
        if (actividad.CantidadLotes == 0)
        {
            MessageBox.Show("La actividad no tiene ningún lote asignado y no se puede cerrar.");
            return;
        }

        FormActividadCierreDatos fCierre = new FormActividadCierreDatos();
        fCierre.lbActividad.Text = actividad.ToString();

        #region habilito solo el grupo del tipo que corresponde
        fCierre.gbAgricola.Enabled = actividad is Agricola;
        fCierre.gbCria.Enabled = actividad is Cria;
        fCierre.gbIvernada.Enabled = actividad is Ivernada;
        fCierre.gbReCria.Enabled = actividad is ReCria;
        #endregion

        if (fCierre.ShowDialog() == DialogResult.OK)
        {
            #region cargo los datos productivos según el tipo
            if (actividad is Agricola)
            {
                ((Agricola)actividad).CantidadToneladasCosechadas = Convert.ToInt32(fCierre.tbToneladas.Text);
                ((Agricola)actividad).PrecioTonelada = Convert.ToDouble(fCierre.tbPrecioTonelada.Text);
            }
            else if (actividad is Cria)
            {
                ((Cria)actividad).CantidadVacasMadres = Convert.ToInt32(fCierre.tbVacasMadres.Text);
                ((Cria)actividad).CantidadTerneroDestete = Convert.ToInt32(fCierre.tbTernerosDestete.Text);
                ((Cria)actividad).PrecioTernero = Convert.ToDouble(fCierre.tbPrecioTernero.Text);
            }
            else if (actividad is Ivernada)
            {
                ((Ivernada)actividad).CantidadKilosCarneInicial = Convert.ToInt32(fCierre.tbKilosIniciales.Text);
                ((Ivernada)actividad).CantidadKilosCarneFinal = Convert.ToInt32(fCierre.tbKilosFinales.Text);
                ((Ivernada)actividad).PrecioKilo = Convert.ToDouble(fCierre.tbPrecioKilo.Text);
            }
            else if (actividad is ReCria)
            {
                ((ReCria)actividad).CantidadKilosCarneFinal = Convert.ToInt32(fCierre.tbKilosLogrados.Text);
                ((ReCria)actividad).PrecioKilo = Convert.ToDouble(fCierre.tbPrecioKiloReCria.Text);
            }
            #endregion

            if (!actividad.Cerrar())
            {
                MessageBox.Show("No se pudo cerrar la actividad.");
            }
        }
    }

    #endregion

    #region informes

    protected void InformeProductividad()
    {
        FormInformeDatos fInforme = new FormInformeDatos();

        #region totales de la estancia
        fInforme.lbProduccionTotal.Text = estancia.CalcularProduccionTotal().ToString("0.00");
        fInforme.lbProductividad.Text = estancia.CalcularProductividadGeneral().ToString("0.00");
        #endregion

        #region detalle por actividad
        for (int idx = 0; idx < estancia.CantidadActividades; idx++)
        {
            Actividad actividad = estancia.VerActividad(idx);
            //cada actividad sabe calcular lo suyo, acá solo lo muestro
            string linea = $"{actividad} - Sup: {actividad.CalcularSuperficieOcupada():f2} ha" +
                           $" - Rend: {actividad.CalcularRendimiento():f2}" +
                           $" - Prod: $ {actividad.CalcularProduccion():f2}";
            fInforme.lsbActividades.Items.Add(linea);
        }
        #endregion

        fInforme.ShowDialog();
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

            //el primer campo de la estancia no pasa por AgregarCampo, así que
            //verifico acá lo mínimo: identificador y superficie
            if (string.IsNullOrEmpty(identificadorCampo1) || superficieCampo1 <= 0)
            {
                MessageBox.Show("Identificador o superficie incorrecta.");
                return null;
            }

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

    protected void ModificarParcela(Campo campo, int idxParcela)
    {
        Parcela seleccionada = campo.VerParcela(idxParcela);
        if (seleccionada != null)
        {
            //una parcela asignada como lote a una actividad no se toca
            if (estancia.EstaAsignada(seleccionada))
            {
                MessageBox.Show("La parcela está asignada como lote a una actividad y no se puede modificar ni eliminar.");
                return;
            }

            FormParcelaModificarDatos formParcela = new FormParcelaModificarDatos();

            //precargo el formulario con los datos actuales
            formParcela.lbIdentificador.Text = seleccionada.Identificador;
            formParcela.tbSuperficie.Text = seleccionada.Superficie.ToString("0.00");

            formParcela.ShowDialog();

            if (formParcela.DialogResult == DialogResult.OK)
            {
                double superficie = Convert.ToDouble(formParcela.tbSuperficie.Text);
                if (!campo.ModificarParcela(idxParcela, superficie))
                {
                    MessageBox.Show("No se pudo modificar la parcela.");
                }
            }
            else if (formParcela.DialogResult == DialogResult.Yes)
            {
                //el botón eliminar devuelve Yes
                if (!campo.EliminarParcela(idxParcela))
                {
                    MessageBox.Show("No se pudo eliminar la parcela.");
                }
            }
        }
    }

    protected Parcela SolicitarLote()
    {
        FormLoteDatos formLoteDatos = new FormLoteDatos();

        //cargo los campos como objetos en el combo, el formulario
        //muestra las parcelas del campo que se elija
        for (int idx = 0; idx < estancia.CantidadCampos; idx++)
        {
            formLoteDatos.cmbCampos.Items.Add(estancia.VerCampo(idx));
        }

        if (formLoteDatos.ShowDialog() == DialogResult.OK)
        {
            Parcela parcela = formLoteDatos.lsbParcelas.SelectedItem as Parcela;
            return parcela;
        }

        return null;
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

    #endregion

}
