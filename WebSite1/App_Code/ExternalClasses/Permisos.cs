﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UX1.Layers
{
    class Permisos
    {
        // Privileges int var for user 
        public static int permiso;

        // String for user name
        public static string usuario;

        // Sets privilege for user
        public void setPermiso(int dt)
        {
            permiso = dt;
            
        }

        // Sets user name
        public void setUsuario(string Usuario)
        {
            usuario = Usuario;

        }

    }
}