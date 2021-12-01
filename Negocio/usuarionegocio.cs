using Data;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class usuarionegocio
    {
        usuarioData Usuario = new();

        public void InsertarUsuario(usuario usuario)
        {
            Usuario.insertarUsuario(usuario);
        }
    }
}
