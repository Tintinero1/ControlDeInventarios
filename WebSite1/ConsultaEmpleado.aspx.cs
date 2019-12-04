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
    }

    protected void btnConsultaEmpleado_Click(object sender, EventArgs e)
    {
        string matricula = txtMatricula.Text;
        string nombre = txtNombre.Text;
        string puesto = txtPuesto.Text;
        string direccion = txtDireccion.Text;
        string telefono = txtTelefono.Text;
        string estatus = DDLClientes.SelectedValue;
        if (DDLClientes.SelectedValue == "Inactivo")
        {
            estatus = "0";
        }
        else
            estatus = "1";

        gvEmpleados.DataSource = bl.ConsultaEmpleado(matricula, nombre, puesto, direccion, telefono, estatus);
        gvEmpleados.DataBind();
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