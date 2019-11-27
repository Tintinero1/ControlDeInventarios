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

    protected void btnConsultaCliente_Click(object sender, EventArgs e)
    {
        string id_cliente = txtIdCliente.Text;
        string nombre = txtNombre.Text;
        string estatus = DDLClientes.SelectedValue;
        if (DDLClientes.SelectedValue == "Inactivo")
        {
            estatus = "0";
        }
        else
            estatus = "1";

        gvClientes.DataSource = bl.ConsultaCliente(id_cliente, nombre, estatus);
        gvClientes.DataBind();
    }

    public void RefreshTableData()
    {
        gvClientes.DataSource = bl.ConsultaCliente("0"," ", "1");
        gvClientes.DataBind();
        /*ListViewClientes.DataSource = bl.getTable("cliente");
        ListViewClientes.DataBind();
        Repeater1.DataSource = bl.getTable("cliente");
        Repeater1.DataBind();*/
    }
}