using PESCADOFINAL.MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESCADOFINAL.CONTROLADOR
{
    public class C_Venta
    {
        // ---- Autonumericos ----
        public static int autonumericoVen() => new M_Venta().autonumericoVenModelo();
        public static int autonumericoDVen() => new M_Venta().autonumericoDVenModelo();

        // ---- Registro ----
        public static int registrarVenta(int codigo, decimal total, decimal monto, decimal cambio,
                                         int usuCod, string cliente, string nit)
            => new M_Venta().registrarVentaModelo(codigo, total, monto, cambio, usuCod, cliente, nit);

        public static int registrarDetalle(int codigo, int venCod, int pelCod,
                                           int cantidad, decimal precio, decimal subtotal)
            => new M_Venta().registrarDetalleModelo(codigo, venCod, pelCod, cantidad, precio, subtotal);

        // ---- Comprobante ----
        public static DataTable comprobanteCabecera(int venCod) => new M_Venta().comprobanteCabeceraModelo(venCod);
        public static DataTable comprobanteDetalle(int venCod) => new M_Venta().comprobanteDetalleModelo(venCod);

        // ---- Reportes ----
        public static DataTable reportePeriodo(DateTime desde, DateTime hasta) => new M_Venta().reportePeriodoModelo(desde, hasta);
        public static DataTable reporteDia() => new M_Venta().reporteDiaModelo();
        public static DataTable reporteMes(int mes, int anio) => new M_Venta().reporteMesModelo(mes, anio);
        public static DataTable reporteCategoria(int catCodigo, DateTime desde, DateTime hasta)
            => new M_Venta().reporteCategoriaModelo(catCodigo, desde, hasta);

        // ---- Estadisticas (graficas) ----
        public static DataTable masVendidos() => new M_Venta().masVendidosModelo();
        public static DataTable ingresosCategoria() => new M_Venta().ingresosCategoriaModelo();
    }


}
