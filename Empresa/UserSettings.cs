﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public static class UserSettings
    {
        public static int rol { get; set; }
        public static String nombre { get; set; }
        public static String username { get; set; }
        public static bool estaLogeado { get; set; }
        public static int id { get; set; }
        public static void Login(int nuevoRol, int nuevoId, String nuevoUsername, String nuevoNombre)
        {
            rol = nuevoRol;
            username = nuevoUsername;
            estaLogeado = true;
            id = nuevoId;
            nombre = nuevoNombre;
        }

        public static void Logout()
        {
            id = 0;
            rol = 0;
            username = null;
            estaLogeado = false;
            nombre = null;
        }


    }
}
