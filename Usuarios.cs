using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudUsuarios
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Passwd { get; set; }
        public string Estado { get; set; }
        public string Tipo_usuario { get; set; }

        public Usuarios() { }

        public Usuarios(int Id, string Usuario, string Passwd, string Estado, string Tipo_Usuario)

        {
            this.Id = Id;
            this.Usuario = Usuario;
            this.Passwd = Passwd;
            this.Estado = Estado;
            this.Tipo_usuario = Tipo_usuario;
        }
    }
}
