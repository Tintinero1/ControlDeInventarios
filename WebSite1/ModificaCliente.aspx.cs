using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite1;

public partial class ModificaCliente : System.Web.UI.Page
{
    BL bl = new BL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            RefreshTableData();
        }
        RefreshTableData();
    }
    public void RefreshTableData()
    {
        gvClientes.DataSource = bl.ConsultaCliente("0", " ", "1");
        gvClientes.DataBind();
        /*ListViewClientes.DataSource = bl.getTable("cliente");
        ListViewClientes.DataBind();
        Repeater1.DataSource = bl.getTable("cliente");
        Repeater1.DataBind();*/
    }

    protected void btnModificaCliente_Click(object sender, EventArgs e)
    {
        string idCliente = txtIdCliente.Text;
        string nombre = txtNombre.Text;
        string direccion = txtDireccion.Text;
        string telefono = txtTelefono.Text;
        string estatus;
        if (ddlEstatus.SelectedValue =="Activo")
        {
             estatus = "1";
        }
        else 
        {
            estatus = "0";
        }

        bl.ModificaCliente(idCliente, nombre, direccion, telefono, estatus, "root");
        RefreshTableData();
        
    }
}