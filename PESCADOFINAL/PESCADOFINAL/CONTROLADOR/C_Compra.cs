using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PESCADOFINAL.MODELO;
using System.Data;


namespace PESCADOFINAL.CONTROLADOR
{
    public class C_Compra
    {
        public static int autonumericoCom() => new M_Compra().autonumericoComModelo();
        public static int autonumericoDCom() => new M_Compra().autonumericoDComModelo();

        public static int registrarCompra(int codigo, int proCodigo)
            => new M_Compra().registrarCompraModelo(codigo, proCodigo);

        // prdCodigo = FK obligatoria de BDC_PRODUCTO en el detalle
        public static int registrarDetalle(int codigo, int comCodigo, int prdCodigo,
                                           int cantidad, decimal precioUnit)
            => new M_Compra().registrarDetalleModelo(codigo, comCodigo, prdCodigo, cantidad, precioUnit);

        public static DataTable listar() => new M_Compra().listarModelo();
    }

}
