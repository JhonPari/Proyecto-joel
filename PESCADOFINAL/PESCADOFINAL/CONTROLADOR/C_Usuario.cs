using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PESCADOFINAL.MODELO;
using System.Data;


namespace PESCADOFINAL.CONTROLADOR
{
    public class C_Usuario
    {
        public static int autonumerico() => new M_Usuario().autonumericoModelo();
        public static int existe(string usuario) => new M_Usuario().existeModelo(usuario);

        public static DataTable login(string usuario, string contrasena)
            => new M_Usuario().loginModelo(usuario, contrasena);

        public static int registrar(int codigo, string nombre, string usuario, string contrasena, string rol)
            => new M_Usuario().registrarModelo(codigo, nombre, usuario, contrasena, rol);

        public static int editar(int codigo, string nombre, string usuario, string contrasena, string rol)
            => new M_Usuario().editarModelo(codigo, nombre, usuario, contrasena, rol);

        public static int eliminar(int codigo) => new M_Usuario().eliminarModelo(codigo);
        public static DataTable listar() => new M_Usuario().listarModelo();
    }

}
