using System;
using System.Collections.Generic;
using System.Linq;
using ITM_Ventas.Models;
using System.Data.Entity.Migrations;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ITM_Ventas.Clases
{
    public class clsVehiculo
    {

        private ITM_ventasEntities ITM_Ventas = new ITM_ventasEntities();

        public Vehiculo vehiculo { get; set; }

        public String Insertar()

        {

            try

            {

                ITM_Ventas.Vehiculoes.Add(vehiculo);

                ITM_Ventas.SaveChanges();

                return "vehiculo ingresado correctamente " + vehiculo.IdVehiculo;

            }

            catch (Exception ex)

            {

                return "error al insertar el vehiculo " + ex.Message;

            }

        }

        public List<Vehiculo> ConsultarTodos()

        {

            return ITM_Ventas.Vehiculoes

                .OrderBy(e => e.IdVehiculo)

                .ToList();

        }

        public Vehiculo Consultar(int IdVehiculo)

        {

            Vehiculo veh = ITM_Ventas.Vehiculoes.FirstOrDefault(e => e.IdVehiculo == IdVehiculo);

            return veh;

        }

        public Vehiculo ConsultarXMarca(int IdMarca)

        {

            Vehiculo veh = ITM_Ventas.Vehiculoes.FirstOrDefault(e => e.IdMarca == IdMarca);

            return veh;

        }

        public String Actualizar()

        {

            Vehiculo veh = Consultar(vehiculo.IdVehiculo);

            if (veh == null)

            {

                return "el vehiculo no existe";

            }

            ITM_Ventas.Vehiculoes.AddOrUpdate(vehiculo);

            ITM_Ventas.SaveChanges();

            return "se ha actualizado el vehiculo correctamente";
        }



        public String Eliminar()

        {

            try

            {

                Vehiculo veh = Consultar(vehiculo.IdVehiculo);

                if (veh == null)

                {

                    return "el vehiculo no existe";

                }

                ITM_Ventas.Vehiculoes.Remove(veh);

                ITM_Ventas.SaveChanges();

                return "se ha eliminado el vehiculo correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }

        }

        public String EliminarXId(int IdVehiculo)

        {

            try

            {

                Vehiculo veh = Consultar(IdVehiculo);

                if (veh == null)

                {

                    return "el vehiculo no existe";

                }

                ITM_Ventas.Vehiculoes.Remove(veh);

                ITM_Ventas.SaveChanges();

                return "se ha eliminado el vehiculo correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }


        }

    }

}