using PESCADOFINAL.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESCADOFINAL.CONTROLADOR
{
    public class C_Proveedor
    {
        public static int autonumerico() => new M_Proveedor().autonumericoModelo();
        public static int existe(string nombre) => new M_Proveedor().existeModelo(nombre);

        public static int registrar(int codigo, string nombre, string telefono, string direccion)
            => new M_Proveedor().registrarModelo(codigo, nombre, telefono, direccion);

        public static int editar(int codigo, string nombre, string telefono, string direccion)
            => new M_Proveedor().editarModelo(codigo, nombre, telefono, direccion);

        public static int eliminar(int codigo) => new M_Proveedor().eliminarModelo(codigo);
        public static DataTable listar() => new M_Proveedor().listarModelo();
    }

}
