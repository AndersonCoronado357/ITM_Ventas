using ITM_Ventas.Clases;
using ITM_Ventas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ITM_Ventas.Controllers
{

    [RoutePrefix("api/Ventas")]
    public class VentasController : ApiController
    {

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Venta> ConsultarTodos()
        {
            clsVenta Venta = new clsVenta();
            return Venta.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public Venta ConsultarXId(int IdVenta)
        {
            clsVenta Venta = new clsVenta();
            return Venta.Consultar(IdVenta);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Venta venta)
        {
            clsVenta Venta = new clsVenta();
            Venta.venta = venta;
            return Venta.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Venta venta)
        {
            clsVenta Venta = new clsVenta();
            Venta.venta = venta;
            return Venta.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Venta venta)
        {
            clsVenta Venta = new clsVenta();
            Venta.venta = venta;
            return Venta.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int IdVenta)
        {
            clsVenta Venta = new clsVenta();
            return Venta.EliminarXId(IdVenta);
        }
    }
}