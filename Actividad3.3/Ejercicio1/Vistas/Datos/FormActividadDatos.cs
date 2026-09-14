using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
namespace Ejercicio1.Vistas;

public partial class FormActividadDatos : Form
{
    public FormActividadDatos()
    {
        InitializeComponent();
    }

    private void cmbTipoActividad_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbCantidadCabezas.Enabled = cmbTipoActividad.SelectedIndex > 0;
    }
}
