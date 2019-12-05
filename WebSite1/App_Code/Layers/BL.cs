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
            case "empleado":
                {
                    TableName = "select * from empleado";
                    break;
                }
            case "almacen":
                {
                    TableName = "select * from almacen";
                    break;
                }
            case "locacion":
                {
                    TableName = "select * from locacion";
                    break;
                }
            case "pedido":
                {
                    TableName = "select * from pedido";
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
    public int LoginValidation(string user, string pass)
    {
        Console.WriteLine("Enviando a DAL-LoginValidation");
        int result = 0;

        result = dl.LoginValidation(user, pass);
        return result;
    }

    /* Clientes */
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

    /* Empleados */

    public void AltaEmpleado(string matricula, string nombre, string puesto, string direccion, string telefono, string estatus, string user)
    {
        Console.WriteLine("Enviando a DAL-AltaEmpleado");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        matricula.Trim();
        nombre = nombre.Trim();
        puesto = puesto.Trim();
        direccion = direccion.Trim();
        telefono = telefono.Trim();
        estatus = estatus.Trim();

        dl.AltaEmpleado(matricula, nombre, puesto, direccion, telefono, estatus, user);

    }

    public void BajaEmpleado(string matricula, string user)
    {
        Console.WriteLine("Enviando a DAL-BajaEmpleado");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        matricula = matricula.Trim();

        dl.BajaEmpleado(matricula, user);

    }

    public DataTable ConsultaEmpleado(string matricula, string nombre, string puesto, string direccion, string telefono, string estatus)
    {
        DataTable dt = new DataTable();

        Console.WriteLine("Enviando a DAL-ConsultaEmpleado");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        matricula.Trim();
        nombre = nombre.Trim();
        puesto = puesto.Trim();
        direccion = direccion.Trim();
        telefono = telefono.Trim();
        estatus = estatus.Trim();

        dt = dl.ConsultaEmpleado(matricula, nombre, puesto, direccion, telefono, estatus);

        return dt;
    }

    public void ModificaEmpleado(string matricula, string nombre, string puesto, string direccion, string telefono, string estatus, string user)
    {
        Console.WriteLine("Enviando a DAL-ModificaEmpleado");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        matricula.Trim();
        nombre = nombre.Trim();
        puesto = puesto.Trim();
        direccion = direccion.Trim();
        telefono = telefono.Trim();
        estatus = estatus.Trim();

        dl.ModificaEmpleado(matricula, nombre, puesto, direccion, telefono, estatus, user);

    }

    /* Almacenes */

    #region Almacenes /**/ Inicia codigo de almacenes /**/
    public void AltaAlmacen(string nombre, string estatus, string user)
    {
        Console.WriteLine("Enviando a DAL-AltaAlmacen");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        nombre = nombre.Trim();
        estatus = estatus.Trim();

        dl.AltaAlmacen(nombre, estatus, user);

    }

    public void BajaAlmacen(string nombre, string user)
    {
        Console.WriteLine("Enviando a DAL-BajaAlmacen");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        nombre = nombre.Trim();

        dl.BajaAlmacen(nombre, user);

    }

    public DataTable ConsultaAlmacen(string nombre, string estatus)
    {
        DataTable dt = new DataTable();

        Console.WriteLine("Enviando a DAL-ConsultaAlmacen");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        nombre = nombre.Trim();
        estatus = estatus.Trim();

        dt = dl.ConsultaAlmacen(nombre, estatus);

        return dt;
    }

    public void ModificaAlmacen(string codigo, string nombre, string estatus, string user)
    {
        Console.WriteLine("Enviando a DAL-ModificaAlmacen");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        codigo = codigo.Trim();
        nombre = nombre.Trim();
        estatus = estatus.Trim();

        dl.ModificaAlmacen(codigo, nombre, estatus, user);

    }
    #endregion

    /* Locaciones */

    #region Locaciones /**/ Inicia codigo de locaciones /**/
    public void AltaLocacion(string nombre, string estatus, string user)
    {
        Console.WriteLine("Enviando a DAL-AltaLocacion");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        nombre = nombre.Trim();
        estatus = estatus.Trim();

        dl.AltaLocacion(nombre, estatus, user);

    }

    public void BajaLocacion(string nombre, string user)
    {
        Console.WriteLine("Enviando a DAL-BajaLocacion");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        nombre = nombre.Trim();

        dl.BajaLocacion(nombre, user);

    }

    public DataTable ConsultaLocacion(string nombre, string estatus)
    {
        DataTable dt = new DataTable();

        Console.WriteLine("Enviando a DAL-ConsultaLocacion");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        nombre = nombre.Trim();
        estatus = estatus.Trim();

        dt = dl.ConsultaLocacion(nombre, estatus);

        return dt;
    }

    public void ModificaLocacion(string codigo, string nombre, string estatus, string user)
    {
        Console.WriteLine("Enviando a DAL-ModificaLocacion");
        // Quita espacios no deseados a la izquierda y a la derecha de la variable
        codigo = codigo.Trim();
        nombre = nombre.Trim();
        estatus = estatus.Trim();

        dl.ModificaLocacion(codigo, nombre, estatus, user);

    }
    #endregion //Termina codigo de locaciones
}