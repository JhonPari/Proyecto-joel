using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PESCADOFINAL.MODELO;
using System.Data;


namespace PESCADOFINAL.CONTROLADOR
{
    public class C_ProductoElaborado
    {
        public static int autonumerico() => new M_ProductoElaborado().autonumericoModelo();
        public static int existe(string nombre) => new M_ProductoElaborado().existeModelo(nombre);

        public static int registrar(int codigo, int prdCodigo, string nombre,
                                    string descripcion, decimal precioVenta, decimal cantidad)
            => new M_ProductoElaborado().registrarModelo(codigo, prdCodigo, nombre, descripcion, precioVenta, cantidad);

        public static int editar(int codigo, int prdCodigo, string nombre,
                                 string descripcion, decimal precioVenta, decimal cantidad)
            => new M_ProductoElaborado().editarModelo(codigo, prdCodigo, nombre, descripcion, precioVenta, cantidad);

        public static int eliminar(int codigo) => new M_ProductoElaborado().eliminarModelo(codigo);
        public static int aumentarStock(int codigo, decimal cantidad) => new M_ProductoElaborado().aumentarStockModelo(codigo, cantidad);
        public static DataTable listar() => new M_ProductoElaborado().listarModelo();
    }

}
