﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite1;

public partial class AltaCliente : System.Web.UI.Page
{
    BL bl = new BL();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAltaCliente_Click(object sender, EventArgs e)
    {
        string Nombre = txtNombre.Text;
        string Direccion = txtDireccion.Text;
        string Telefono = txtTelefono.Text;

        bl.AltaCliente(Nombre, Direccion, Telefono, "root");

        
    }
}