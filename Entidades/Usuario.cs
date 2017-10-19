using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private DateTime _UltimoIngreso;
        private string _Clave, _Email, _NombreUsuario;
        private int _TipoUsuario;

        public DateTime UltimoIngreso
        {
            get
            {
                return _UltimoIngreso;
            }

            set
            {
                _UltimoIngreso = value;
            }
        }

        public string Clave
        {
            get
            {
                return _Clave;
            }

            set
            {
                _Clave = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return _NombreUsuario;
            }

            set
            {
                _NombreUsuario = value;
            }
        }

        public int DiasUltimoIngreso
        {
            get
            {
                int difDias = UltimoIngreso.Day - DateTime.Today.Day;
                return difDias;
            }            
        }

        public int TipoUsuario
        {
            get
            {
                return _TipoUsuario;
            }

            set
            {
                _TipoUsuario = value;
            }
        }
    }
}
