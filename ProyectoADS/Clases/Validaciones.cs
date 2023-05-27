using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto
{
    class Validaciones
    {
        public DateTime ahora = DateTime.Today;
        public bool validar_texto(string texto)
        {
            texto = texto.Trim();
            if (texto.Length < 1)
            {
                return false;
            }
            return true;
        }

        public bool validar_texto2(string texto)
        {
            if (!validar_texto(texto))
            {
                return false;
            }
            Regex patron = new Regex("^\\s*[a-zA-Z,\\s]+\\s*$");
            if (!patron.IsMatch(texto))
            {
                return false;
            }
            return true;
        }

        public bool validar_usuario(string texto)
        {
            if (!validar_texto(texto))
            {
                return false;
            }
            Regex patron = new Regex("(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$");//Usuario de 6 a 15 caracteres
            if (!patron.IsMatch(texto))
            {
                return false;
            }
            return true;
        }

        public bool validar_password(string texto)
        {
            if (!validar_texto(texto))
            {
                return false;
            }
            Regex patron = new Regex("^(?=.*\\d).{4,8}$");//Contraseña de 4 a 8 caracteres incluidos numeros
            if (!patron.IsMatch(texto))
            {
                return false;
            }
            return true;
        }

        public bool ValidarFecha(DateTime fecha, string fechaCorta)
        {

            string hoy = ahora.ToString("dd/MM/yyyy");
            if (fecha < ahora || hoy == fechaCorta)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validar_Depa(string texto)
        {
            if (!validar_texto(texto))
            {
                return false;
            }
            Regex patron = new Regex("^Departamento de\\s*[a-zA-Z,\\s]+\\s*$");
            if (!patron.IsMatch(texto))
            {
                return false;
            }
            return true;
        }

    }
}
