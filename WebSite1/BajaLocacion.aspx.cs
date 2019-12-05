﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite1;

public partial class BajaCliente : System.Web.UI.Page
{
    BL bl = new BL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            RefreshTableData();
        }
        
    }

    public void RefreshTableData()
    {
        gvClientes.DataSource = bl.getTable("locacion");
        gvClientes.DataBind();
        /*ListViewClientes.DataSource = bl.getTable("cliente");
        ListViewClientes.DataBind();*/
        Repeater1.DataSource = bl.getTable("locacion");
        Repeater1.DataBind();
    }

    protected void btnBajaEmpleado_Click(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text.Trim();

        bl.BajaLocacion(nombre, "root");
        RefreshTableData();
        
    }
}