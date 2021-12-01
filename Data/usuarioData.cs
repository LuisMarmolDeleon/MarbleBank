using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class usuarioData
    {
        BancoAPIEntities db = new();

        public void insertarUsuario(usuario usuario)
        {
            db.usuarios.Add(usuario);
            db.SaveChanges();

        }
    }
}
