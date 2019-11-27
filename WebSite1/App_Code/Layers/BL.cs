using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite1;
using System.Data;

/// <summary>
/// Descripción breve de BL
/// </summary>
public class BL
{
    DAL dl = new DAL();

    public DataTable getTable(string TableName)
    {
        DataTable dt = new DataTable();

        switch (TableName) 
        {
            case "cliente":
                {
                    TableName = "select * from cliente";
                    break;
                }
            default:
                {
                    TableName = "TABLE-NOT-FOUND";
                    break;
                }
        }
        if(TableName != "TABLE-NOT-FOUND")
            dt = dl.getTable(TableName);

        return dt;
    }
    public void AltaCliente(string nombre, string direccion, string telefono, string user)
    {
        Console.WriteLine("Enviando a DAL-AltaCliente");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        nombre = nombre.Trim();
        direccion = direccion.Trim();
        telefono = telefono.Trim();

        dl.AltaCliente(nombre, direccion, telefono, user);
        
    }

    public void BajaCliente(string nombre, string user)
    {
        Console.WriteLine("Enviando a DAL-BajaCliente");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        nombre = nombre.Trim();
        
        dl.BajaCliente(nombre, user);

    }

    public DataTable ConsultaCliente(string codigo, string nombre, string estatus)
    {
        DataTable dt = new DataTable();

        Console.WriteLine("Enviando a DAL-ConsultaCliente");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        codigo = codigo.Trim();
        nombre = nombre.Trim();
        estatus = estatus.Trim();

        dt = dl.ConsultaCliente(codigo, nombre, estatus);

        return dt;
    }

    public void ModificaCliente(string codigo, string nombre, string direccion, string telefono, string estatus, string user)
    {
        Console.WriteLine("Enviando a DAL-ModificaCliente");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        codigo = codigo.Trim();
        nombre = nombre.Trim();
        direccion = direccion.Trim();
        telefono = telefono.Trim();
        estatus = estatus.Trim();

        dl.ModificaCliente(codigo, nombre, direccion, telefono, estatus, user);

    }
}