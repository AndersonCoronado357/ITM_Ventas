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
    [RoutePrefix("api/Vehiculos")]
    public class VehiculosController : ApiController
    {

        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Vehiculo> ConsultarTodos()
        {
            clsVehiculo Vehiculo = new clsVehiculo();
            return Vehiculo.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public Vehiculo ConsultarXId(int IdVehiculo)
        {
            clsVehiculo Vehiculo = new clsVehiculo();
            return Vehiculo.Consultar(IdVehiculo);
        }

        [HttpGet]
        [Route("ConsultarXMarca")]
        public Vehiculo ConsultarXMarca(int IdMarca)
        {
            clsVehiculo Vehiculo = new clsVehiculo();
            return Vehiculo.Consultar(IdMarca);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Vehiculo vehiculo)
        {
            clsVehiculo Vehiculo = new clsVehiculo();
            Vehiculo.vehiculo = vehiculo;
            return Vehiculo.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Vehiculo vehiculo)
        {
            clsVehiculo Vehiculo = new clsVehiculo();
            Vehiculo.vehiculo = vehiculo;
            return Vehiculo.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Vehiculo vehiculo)
        {
            clsVehiculo Vehiculo = new clsVehiculo();
            Vehiculo.vehiculo = vehiculo;
            return Vehiculo.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int IdVehiculo)
        {
            clsVehiculo Vehiculo = new clsVehiculo();
            return Vehiculo.EliminarXId(IdVehiculo);
        }
    }
}