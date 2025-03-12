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
    [RoutePrefix("api/Marcas")]
    public class MarcasController : ApiController
    {

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Marca> ConsultarTodos()
        {
            clsMarca Marca = new clsMarca();
            return Marca.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public Marca ConsultarXId(int IdMarca)
        {
            clsMarca Marca = new clsMarca();
            return Marca.Consultar(IdMarca);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Marca marca)
        {
            clsMarca Marca = new clsMarca();
            Marca.marca = marca;
            return Marca.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Marca marca)
        {
            clsMarca Marca = new clsMarca();
            Marca.marca = marca;
            return Marca.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Marca marca)
        {
            clsMarca Marca = new clsMarca();
            Marca.marca = marca;
            return Marca.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int IdMarca)
        {
            clsMarca Marca = new clsMarca();
            return Marca.EliminarXId(IdMarca);
        }
    }
}