using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Net;

/// <summary>
/// Clase que se encarga de establecer y ejecutar la conexion con la BD (Base de Datos).
/// </summary>
public class dbConn
{
    SqlConnection conexion;
    public dbConn()
    {
        // Obtiene el hostname de la computadora que utiliza el programa para adecuar la instancia
        // a la correcta de cada quien
        string host = Dns.GetHostName();

        //Se le asigna al objeto de SqlConnection la direccion de la instancia de la BD
        conexion = new SqlConnection("server =  " + host + "; database=ControlInv ; integrated security = true");
        
    }
}

/// Nombre del programador: Albrand Aguirre Marc
/// Fecha de inicio: 18/11/2019
/// Ultima fecha trabajada: 18/11/2019