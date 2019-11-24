using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite1;

/// <summary>
/// DATA ACCES LAYER, en esta capa podemos realizar ajustes o validaciones previas a la
/// informacion que entra a la capa DbConn.
/// </summary>
public class DAL
{
    dbConn db = new dbConn();
    List<string> parametros = new List<string>();
    
    public void AltaCliente(string nombre, string direccion, string telefono, string user)
    {
        string querySP = "AltaCliente";
        parametros.Add(nombre);
        parametros.Add(direccion);
        parametros.Add(telefono);
        parametros.Add(user);
        //parametros.Add(" ");

        db.ExecSP(querySP, parametros);
        parametros.Clear();
        


    }
}

/// Nombre del programador: Albrand Aguirre Marc, Abel Efrain Pech Aguilar
/// Fecha de inicio: 18/11/2019
/// Ultima fecha trabajada: 18/11/2019