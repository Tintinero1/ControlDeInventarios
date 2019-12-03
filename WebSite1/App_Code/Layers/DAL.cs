﻿using System;
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

    public int LoginValidation(string user, string pass)
    {
        int result = 0;
        string querySP = "LoginValidation";
        parametros.Add(user);
        parametros.Add(pass);

        try
        {
            result = db.ExecSPReturnInt(querySP, parametros);
            parametros.Clear();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }
        return result;
    }

    #region Cliente /**/ Comienza codigo de cliente /**/
    public void AltaCliente(string nombre, string direccion, string telefono, string user)
    {
        //List<CustomObject> Custo = new List<CustomObject>();
        string querySP = "AltaCliente";
        parametros.Add(nombre);
        parametros.Add(direccion);
        parametros.Add(telefono);
        parametros.Add(user);
        //parametros.Add(" ");

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

    public DataTable ConsultaCliente(string id_cliente, string nombre, string estatus)
    {
        DataTable dt = new DataTable();

        string querySP = "ConsultaCliente";
        parametros.Add(id_cliente);
        parametros.Add(nombre);
        parametros.Add(estatus);

        try
        {
            dt = db.ExecSP(querySP, parametros);
            parametros.Clear();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }
        return dt;
    }

    public void ModificaCliente(string id_cliente, string nombre, string direccion, string telefono, string estatus, string user)
    {
        DataTable dt = new DataTable();

        string querySP = "ModificaCliente";
        parametros.Add(id_cliente);
        parametros.Add(nombre);
        parametros.Add(direccion);
        parametros.Add(telefono);
        parametros.Add(estatus);
        parametros.Add(user);

        try
        {
            dt = db.ExecSP(querySP, parametros);
            parametros.Clear();
        }
        catch (Exception ex)
        {
           System.Diagnostics.Debug.WriteLine(ex);
        }

    }
    #endregion //Termina Cliente //jj

    #region Empleado /**/ Comienza codigo de empleado /**/
    public void AltaEmpleado(string matricula, string nombre, string puesto, string direccion, string telefono, string estatus, string user)
    {
        //List<CustomObject> Custo = new List<CustomObject>();
        string querySP = "AltaEmpleado";
        parametros.Add(matricula);
        parametros.Add(nombre);
        parametros.Add(puesto);
        parametros.Add(direccion);
        parametros.Add(telefono);
        parametros.Add(estatus);
        parametros.Add(user);
        //parametros.Add(" ");

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

    public void BajaEmpleado(string matricula, string user)
    {
        string querySP = "BajaEmpleado";
        parametros.Add(matricula);
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

    public DataTable ConsultaEmpleado(string matricula, string nombre, string puesto, string direccion, string telefono, string estatus)
    {
        DataTable dt = new DataTable();

        string querySP = "ConsultaEmpleado";
        parametros.Add(matricula);
        parametros.Add(nombre);
        parametros.Add(puesto);
        parametros.Add(direccion);
        parametros.Add(telefono);
        parametros.Add(estatus);

        try
        {
            dt = db.ExecSP(querySP, parametros);
            parametros.Clear();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }
        return dt;
    }

    public void ModificaEmpleado(string matricula, string nombre, string puesto, string direccion, string telefono, string estatus, string user)
    {
        DataTable dt = new DataTable();

        string querySP = "ModificaEmpleado";
        parametros.Add(matricula);
        parametros.Add(nombre);
        parametros.Add(puesto);
        parametros.Add(direccion);
        parametros.Add(telefono);
        parametros.Add(estatus);
        parametros.Add(user);

        try
        {
            dt = db.ExecSP(querySP, parametros);
            parametros.Clear();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }

    }
    #endregion //Termina codigo de empleado

    #region Almacen /**/ Comienza codigo de Almacen /**/
    public void AltaAlmacen(string nombre, string estatus, string user)
    {
        string querySP = "AltaAlmacen";
        parametros.Add(nombre);
        parametros.Add(estatus);
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

    public void BajaAlmacen(string nombre, string user)
    {
        string querySP = "BajaAlmacen";
        parametros.Add(nombre);
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

    public DataTable ConsultaAlmacen(string nombre, string estatus)
    {
        DataTable dt = new DataTable();

        string querySP = "ConsultaAlmacen";
        parametros.Add(nombre);
        parametros.Add(estatus);

        try
        {
            dt = db.ExecSP(querySP, parametros);
            parametros.Clear();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }
        return dt;
    }

    public void ModificaAlmacen(string codigo, string nombre, string estatus, string user)
    {
        DataTable dt = new DataTable();

        string querySP = "ModificaAlmacen";
        parametros.Add(codigo);
        parametros.Add(nombre);
        parametros.Add(estatus);
        parametros.Add(user);

        try
        {
            dt = db.ExecSP(querySP, parametros);
            parametros.Clear();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }

    }
    #endregion //Termina codigo de almacen

    #region Locacion /**/ Comienza codigo de Locacion /**/
    public void AltaLocacion(string nombre, string estatus, string user)
    {
        string querySP = "AltaLocacion";
        parametros.Add(nombre);
        parametros.Add(estatus);
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

    public void BajaLocacion(string nombre, string user)
    {
        string querySP = "BajaLocacion";
        parametros.Add(nombre);
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

    public DataTable ConsultaLocacion(string nombre, string estatus)
    {
        DataTable dt = new DataTable();

        string querySP = "ConsultaLocacion";
        parametros.Add(nombre);
        parametros.Add(estatus);

        try
        {
            dt = db.ExecSP(querySP, parametros);
            parametros.Clear();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }
        return dt;
    }

    public void ModificaLocacion(string codigo, string nombre, string estatus, string user)
    {
        DataTable dt = new DataTable();

        string querySP = "ModificaLocacion";
        parametros.Add(codigo);
        parametros.Add(nombre);
        parametros.Add(estatus);
        parametros.Add(user);

        try
        {
            dt = db.ExecSP(querySP, parametros);
            parametros.Clear();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }

    }
    #endregion //Termina codigo de locacion
}

/// Nombre del programador: Albrand Aguirre Marc, Abel Efrain Pech Aguilar
/// Fecha de inicio: 18/11/2019
/// Ultima fecha trabajada: 18/11/2019