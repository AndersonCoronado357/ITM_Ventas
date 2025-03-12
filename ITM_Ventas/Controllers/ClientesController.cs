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
    [RoutePrefix("api/Clientes")]
    public class ClientesController : ApiController
    {

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Cliente> ConsultarTodos()
        {
            clsCliente Cliente = new clsCliente();
            return Cliente.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public Cliente ConsultarXId(int IdCliente)
        {
            clsCliente Cliente = new clsCliente();
            return Cliente.Consultar(IdCliente);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Cliente cliente)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = cliente;
            return Cliente.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Cliente cliente)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = cliente;
            return Cliente.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Cliente cliente)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = cliente;
            return Cliente.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int IdCliente)
        {
            clsCliente Cliente = new clsCliente();
            return Cliente.EliminarXId(IdCliente);
        }

    }
}