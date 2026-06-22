using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PESCADOFINAL.MODELO;
using System.Data;

namespace PESCADOFINAL.CONTROLADOR
{
    public class C_Producto
    {
        public static int autonumerico() => new M_Producto().autonumericoModelo();
        public static int existe(string nombre, string tamano) => new M_Producto().existeModelo(nombre, tamano);

        public static int registrar(int codigo, int catCodigo, string nombre, string tamano, decimal precioCosto)
            => new M_Producto().registrarModelo(codigo, catCodigo, nombre, tamano, precioCosto);

        public static int editar(int codigo, int catCodigo, string nombre, string tamano, decimal precioCosto)
            => new M_Producto().editarModelo(codigo, catCodigo, nombre, tamano, precioCosto);

        public static int eliminar(int codigo) => new M_Producto().eliminarModelo(codigo);
        public static DataTable listar() => new M_Producto().listarModelo();

        public static int aumentarStock(int codigo, decimal cantidad) => new M_Producto().aumentarStockModelo(codigo, cantidad);
        public static int descontarStock(int codigo, decimal cantidad) => new M_Producto().descontarStockModelo(codigo, cantidad);

        public static DataTable stockCritico(decimal minimo) => new M_Producto().stockCriticoModelo(minimo);

        // Borrado logico
        public static int cambiarEstado(int codigo) => new M_Producto().cambiarEstadoModelo(codigo);
        public static DataTable listarActivos() => new M_Producto().listarActivosModelo();
    }

}
