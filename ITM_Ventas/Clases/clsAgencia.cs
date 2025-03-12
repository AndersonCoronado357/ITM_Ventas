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
    public class clsAgencia
    {

        private ITM_ventasEntities ITM_Ventas = new ITM_ventasEntities();
        public Agencia agencia { get; set; }

        public String Insertar()

        {

            try

            {

                ITM_Ventas.Agencias.Add(agencia);

                ITM_Ventas.SaveChanges();

                return "agencia ingresada correctamente " + agencia.Nombre;

            }

            catch (Exception ex)

            {

                return "error al insertar la agencia " + ex.Message;

            }

        }

        public List<Agencia> ConsultarTodos()

        {

            return ITM_Ventas.Agencias

                .OrderBy(e => e.Nombre)

                .ToList();

        }

        public Agencia Consultar(int IdAgencia)

        {

            Agencia agen = ITM_Ventas.Agencias.FirstOrDefault(e => e.IdAgencia == IdAgencia);

            return agen;

        }

        public String Actualizar()

        {

            Agencia agen = Consultar(agencia.IdAgencia);

            if (agen == null)

            {

                return "la agencia no existe";

            }

            ITM_Ventas.Agencias.AddOrUpdate(agencia);

            ITM_Ventas.SaveChanges();

            return "se ha actualizado la marca correctamente";
        }



        public String Eliminar()

        {

            try

            {

                Agencia agen = Consultar(agencia.IdAgencia);

                if (agen == null)

                {

                    return "la agencia no existe";

                }

                ITM_Ventas.Agencias.Remove(agen);

                ITM_Ventas.SaveChanges();

                return "se ha eliminado la agencia correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }

        }

        public String EliminarXId(int IdAgencia)

        {

            try

            {

                Agencia agen = Consultar(IdAgencia);

                if (agen == null)

                {

                    return "la agencia no existe";

                }

                ITM_Ventas.Agencias.Remove(agen);

                ITM_Ventas.SaveChanges();

                return "se ha eliminado la agencia correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }


        }

    }

}