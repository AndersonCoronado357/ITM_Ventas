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
    public class clsMarca
    {

        private ITM_ventasEntities ITM_Ventas = new ITM_ventasEntities();

        public Marca marca { get; set; }

        public String Insertar()

        {

            try

            {

                ITM_Ventas.Marcas.Add(marca);

                ITM_Ventas.SaveChanges();

                return "marca ingresada correctamente " + marca.Nombre;

            }

            catch (Exception ex)

            {

                return "error al insertar la marca " + ex.Message;

            }

        }

        public List<Marca> ConsultarTodos()

        {

            return ITM_Ventas.Marcas

                .OrderBy(e => e.Nombre)

                .ToList();

        }

        public Marca Consultar(int idMarca)

        {

            Marca mar = ITM_Ventas.Marcas.FirstOrDefault(e => e.IdMarca == idMarca);

            return mar;

        }

        public String Actualizar()

        {

            Marca mar = Consultar(marca.IdMarca);

            if (mar == null)

            {

                return "la marca no existe";

            }

            ITM_Ventas.Marcas.AddOrUpdate(marca);

            ITM_Ventas.SaveChanges();

            return "se ha actualizado la marca correctamente";
        }



        public String Eliminar()

        {

            try

            {

                Marca mar = Consultar(marca.IdMarca);

                if (mar == null)

                {

                    return "la marca no existe";

                }

                ITM_Ventas.Marcas.Remove(mar);

                ITM_Ventas.SaveChanges();

                return "se ha eliminado la marca correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }

        }

        public String EliminarXId(int idMarca)

        {

            try

            {

                Marca mar = Consultar(idMarca);

                if (mar == null)

                {

                    return "la marca no existe";

                }

                ITM_Ventas.Marcas.Remove(mar);

                ITM_Ventas.SaveChanges();

                return "se ha eliminado la marca correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }


        }

    }

}
