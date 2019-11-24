using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite1;

/// <summary>
/// Descripción breve de BL
/// </summary>
public class BL
{
    DAL dl = new DAL();
    public void AltaCliente(string nombre, string direccion, string telefono, string user)
    {
        Console.WriteLine("Enviando a DAL-AltaCliente");
        dl.AltaCliente(nombre, direccion, telefono, user);
        
    }
}