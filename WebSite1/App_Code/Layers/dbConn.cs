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
    public DataTable dtC = new DataTable();
    SqlConnection conexion;
    public dbConn()
    {
        // Obtiene el hostname de la computadora que utiliza el programa para adecuar la instancia
        // a la correcta de cada quien
        string host = Dns.GetHostName();

        //Se le asigna al objeto de SqlConnection la direccion de la instancia de la BD
        conexion = new SqlConnection("server =  " + host + "; database=ControlInv ; integrated security = true");
        
    }

    public DataTable ExecSP(string querySP, List<string> parametros)
    {
        DataTable dt = new DataTable();
        // SPResult es la variable que se encarga de guardar el mensaje resultante de un SP (StoredProcedure).
        string SPResult = "";
        // i es la variable cuyo unico objetivo es ser un contador para la lista parametros que recibimos.
        int i = 0;
        // Esta lista contiene los nombres de los parametros de cualquier SP que mandemos llamar.
        List<string> NombreParametros = new List<string>();

        // Iniciamos la variable cmd indicandole que sera un SP con el nombre de la variable "querySP"
        // y utilizara la conexion de la variable "conexion".
        SqlCommand cmd = new SqlCommand(querySP, conexion);
        cmd.CommandType = CommandType.StoredProcedure;

        // Se abre la conexion y se recopilan todos los parametros que se piden en el SP de la
        // variable "cmd". (ojo: este metodo te llena el espacio de los parametros de cmd.Parameters).
        conexion.Open();
        SqlCommandBuilder.DeriveParameters(cmd);

        // El siguiente ciclo guarda los parametros recopilados en una variable tipo lista<string>
        // para posteriormente poder tener acceso al nombre de todos los parametros utilizados
        // en el SP que mandamos llamar.
        foreach (SqlParameter p in cmd.Parameters)
        {
            // Nos saltamos el primer parametro con la condicion "i != 0" ya que el primer parametro
            // es el resultado obligatorio de cada query que se ejecuta, y ese no debemos sobreescribirlo
            // ni nos interesa guardarlo.
            if (i !=0)
            {
                System.Diagnostics.Debug.WriteLine("Parametro: " + p.ParameterName);
                NombreParametros.Add(p.ParameterName.ToString());
            }
            i++;
        }
        i = 0;

        // Limpiamos los parametros obtenidos en nuestro primer metodo para tener el espacio libre.
        cmd.Parameters.Clear();

        // Recorremos cada uno de los parametros que agregamos anteriormente para agregar los que
        // realmente necesitamos a cmd.Parameters.
        foreach (string p in NombreParametros)
        {

            // Para los parametros OUTPUT en los SP, se maneja un estandar. Todos los parametros OUTPUT
            // se llamaran @mensaje en los SP y contendran un mensaje de tipo varchar(150).
            // Asi esta condicion detecta si el parametro leido es de tipo OUTPUT y ejecuta un codigo
            // especial para el.
            if (p == "@mensaje")
            {
                cmd.Parameters.Add(p, SqlDbType.VarChar, 150);
                cmd.Parameters[p].Direction = ParameterDirection.Output;
                System.Diagnostics.Debug.WriteLine("Se agrega: " + p + ", " + "' '");
            }
            else
            {
                cmd.Parameters.AddWithValue(p.ToString(), parametros[i]);
                System.Diagnostics.Debug.WriteLine("Se agrega: " + p + ", " + parametros[i]);
            }
            i++;
        }
        
        // Ejecutamos el SP y cerramos la conexion.
        dt.Load(cmd.ExecuteReader());
        conexion.Close();

        // Cualquier mensaje establecido en el parametro @mensaje de tipo OUTPUT se guardara en la variable
        // SPResult y se desplegara por default en la consola.
        SPResult = cmd.Parameters["@mensaje"].Value.ToString();
        System.Diagnostics.Debug.WriteLine("BD respondio: " + SPResult);

        // Se limpian variables para uso posterior de la funcion.
        NombreParametros.Clear();
        i = 0;
        return dt;
    }

    public DataTable ReturnTable(string querySP)
    {
        DataTable dt = new DataTable();

        SqlCommand cmd = new SqlCommand(querySP, conexion);

        conexion.Open();
        dt.Load(cmd.ExecuteReader());
        conexion.Close();


        return dt;
    }

}

/// Nombre del programador: Albrand Aguirre Marc, Abel Efrain Pech Aguilar
/// Fecha de inicio: 18/11/2019
/// Ultima fecha trabajada: 24/11/2019