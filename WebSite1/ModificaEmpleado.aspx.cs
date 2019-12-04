using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite1;

public partial class ConsultaCliente : System.Web.UI.Page
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

    protected void btnModificaEmpleado_Click(object sender, EventArgs e)
    {
        string matricula = txtMatricula.Text;
        string nombre = txtNombre.Text;
        string puesto = txtPuesto.Text;
        string direccion = txtDireccion.Text;
        string telefono = txtTelefono.Text;
        string estatus = DDLClientes.SelectedValue;
        string user = "root";
        if (DDLClientes.SelectedValue == "Inactivo")
        {
            estatus = "0";
        }
        else
            estatus = "1";

        bl.ModificaEmpleado(matricula, nombre, puesto, direccion, telefono, estatus, user);
        RefreshTableData();
    }

    public void RefreshTableData()
    {
        gvEmpleados.DataSource = bl.ConsultaEmpleado(" "," ", " ", " ", " ", "0");
        gvEmpleados.DataBind();
        /*ListViewClientes.DataSource = bl.getTable("cliente");
        ListViewClientes.DataBind();
        Repeater1.DataSource = bl.getTable("cliente");
        Repeater1.DataBind();*/
    }
}