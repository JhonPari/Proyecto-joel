using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PESCADOFINAL.MODELO;
using System.Data;

namespace PESCADOFINAL.CONTROLADOR
{
    public class C_Categoria
    {
        public static int autonumerico() => new M_Categoria().autonumericoModelo();
        public static int existe(string nombre) => new M_Categoria().existeModelo(nombre);
        public static int registrar(int codigo, string nombre) => new M_Categoria().registrarModelo(codigo, nombre);
        public static int editar(int codigo, string nombre) => new M_Categoria().editarModelo(codigo, nombre);
        public static int eliminar(int codigo) => new M_Categoria().eliminarModelo(codigo);
        public static DataTable listar() => new M_Categoria().listarModelo();
    }
}
