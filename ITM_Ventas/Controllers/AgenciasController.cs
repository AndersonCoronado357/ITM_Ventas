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
    [RoutePrefix("api/Agencias")]
    public class AgenciasController : ApiController
    {

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Agencia> ConsultarTodos()
        {
            clsAgencia Agencia = new clsAgencia();
            return Agencia.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public Agencia ConsultarXId(int IdAgencia)
        {
            clsAgencia Agencia = new clsAgencia();
            return Agencia.Consultar(IdAgencia);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Agencia agencia)
        {
            clsAgencia Agencia = new clsAgencia();
            Agencia.agencia = agencia;
            return Agencia.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Agencia agencia)
        {
            clsAgencia Agencia = new clsAgencia();
            Agencia.agencia = agencia;
            return Agencia.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Agencia agencia)
        {
            clsAgencia Agencia = new clsAgencia();
            Agencia.agencia = agencia;
            return Agencia.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int IdAgencia)
        {
            clsAgencia Agencia = new clsAgencia();
            return Agencia.EliminarXId(IdAgencia);
        }
    }
}