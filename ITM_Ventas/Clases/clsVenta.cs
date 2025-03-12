using ITM_Ventas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ITM_Ventas.Clases
{
	public class clsVenta
	{

        private ITM_ventasEntities ITM_Ventas = new ITM_ventasEntities();

        public Venta venta { get; set; }

        public String Insertar()

        {

            try

            {

                ITM_Ventas.Ventas.Add(venta);

                ITM_Ventas.SaveChanges();

                return "venta registrada correctamente " + venta.IdVenta;

            }

            catch (Exception ex)

            {

                return "error al registrar la venta " + ex.Message;

            }

        }

        public List<Venta> ConsultarTodos()

        {

            return ITM_Ventas.Ventas

                .OrderBy(e => e.FechaVenta)

                .ToList();

        }

        public Venta Consultar(int IdVenta)

        {

            Venta venta = ITM_Ventas.Ventas.FirstOrDefault(e => e.IdVenta == IdVenta);

            return venta;

        }

        public String Actualizar()

        {

            Venta ven = Consultar(venta.IdVenta);

            if (ven == null)

            {

                return "la venta no existe";

            }

            ITM_Ventas.Ventas.AddOrUpdate(venta);

            ITM_Ventas.SaveChanges();

            return "se ha actualizado la venta correctamente";
        }



        public String Eliminar()

        {

            try

            {

                Venta ven = Consultar(venta.IdVenta);

                if (ven == null)

                {

                    return "la venta no existe";

                }

                ITM_Ventas.Ventas.Remove(ven);

                ITM_Ventas.SaveChanges();

                return "se ha eliminado la venta correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }

        }

        public String EliminarXId(int IdVenta)

        {

            try

            {

                Venta ven = Consultar(IdVenta);

                if (ven == null)

                {

                    return "la venta no existe";

                }

                ITM_Ventas.Ventas.Remove(ven);

                ITM_Ventas.SaveChanges();

                return "se ha eliminado la venta correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }


        }
    }
}