using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
namespace Ejercicio1.Vistas;

public partial class FormLoteDatos : Form
{
    public FormLoteDatos()
    {
        InitializeComponent();
    }

    //el combo tiene los campos como objetos, al elegir uno
    //muestro sus parcelas en el listbox (también como objetos)
    private void cmbCampos_SelectedIndexChanged(object sender, EventArgs e)
    {
        lsbParcelas.Items.Clear();

        Campo campo = cmbCampos.SelectedItem as Campo;
        if (campo != null)
        {
            for (int idx = 0; idx < campo.CantidadParcelas; idx++)
            {
                lsbParcelas.Items.Add(campo.VerParcela(idx));
            }
        }
    }
}
