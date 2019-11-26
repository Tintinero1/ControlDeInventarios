using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite1;
using System.Data;

/// <summary>
/// DATA ACCES LAYER, en esta capa podemos realizar ajustes o validaciones previas a la
/// informacion que entra a la capa DbConn.
/// </summary>
public class DAL
{
    dbConn db = new dbConn();
    List<string> parametros = new List<string>();

    public class CustomObject
    {
        public List<String> StringParameters  { get; set; }
        public List<int> IntParameters { get; set; }

        public CustomObject()
        {
        }

        public void CustomInt(int intValue)
        {

            IntParameters.Add(intValue);
        }

        public void CustomString(string stringValue)
        {

            StringParameters.Add(stringValue);
        }
    }

    public DataTable getTable(string query)
    {
        DataTable dt = new DataTable();
        try
        {
            dt = db.ReturnTable(query);
            parametros.Clear();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }

        return dt;
    }
    public void AltaCliente(string nombre, string direccion, string telefono, string user)
    {
        //List<CustomObject> Custo = new List<CustomObject>();
        string querySP = "AltaCliente";
        parametros.Add(nombre);
        parametros.Add(direccion);
        parametros.Add(telefono);
        parametros.Add(user);
        //parametros.Add(" ");

        
        db.ExecSP(querySP, parametros);
        parametros.Clear();

    }

    public void BajaCliente(string id_cliente, string user)
    {
        string querySP = "BajaCliente";
        parametros.Add(id_cliente);
        parametros.Add(user);

        try
        {
            db.ExecSP(querySP, parametros);
            parametros.Clear();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }
        
    }

    public void ConsultaCliente(string id_cliente, string nombre, string direccion, string telefono, string user)
    {
        string querySP = "ConsultaCliente";
        parametros.Add(id_cliente);
        parametros.Add(nombre);
        parametros.Add(direccion);
        parametros.Add(telefono);
        parametros.Add(user);

        try
        {
            db.ExecSP(querySP, parametros);
            parametros.Clear();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }

    }
}

/// Nombre del programador: Albrand Aguirre Marc, Abel Efrain Pech Aguilar
/// Fecha de inicio: 18/11/2019
/// Ultima fecha trabajada: 18/11/2019