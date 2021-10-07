using ParcialApp.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialApp.Acceso_a_datos
{
    interface IFacturaDAO
    {

        int ObtenerProximoNroPresupuesto();
        List<Producto> ListarProductos();
        bool Crear(Factura oFactura);
    }
}
