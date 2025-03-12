using ITM_Ventas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ITM_Ventas.Clases
{
	public class clsCliente
	{

        private ITM_ventasEntities ITM_Ventas = new ITM_ventasEntities();

        public Cliente cliente { get; set; }

        public String Insertar()

        {

            try

            {

                ITM_Ventas.Clientes.Add(cliente);

                ITM_Ventas.SaveChanges();

                return "Cliente ingresado correctamente " + cliente.Nombre;

            }

            catch (Exception ex)

            {

                return "error al ingresar el cliente " + ex.Message;

            }

        }

        public List<Cliente> ConsultarTodos()

        {

            return ITM_Ventas.Clientes

                .OrderBy(e => e.Nombre)

                .ToList();

        }

        public Cliente Consultar(int IdCliente)

        {

            Cliente cliente = ITM_Ventas.Clientes.FirstOrDefault(e => e.IdCliente == IdCliente);

            return cliente;

        }

        public String Actualizar()

        {

            Cliente cli = Consultar(cliente.IdCliente);

            if (cli == null)

            {

                return "El cliente no existe";

            }

            ITM_Ventas.Clientes.AddOrUpdate(cliente);

            ITM_Ventas.SaveChanges();

            return "se ha actualizado el cliente correctamente";
        }



        public String Eliminar()

        {

            try

            {

                Cliente cli = Consultar(cliente.IdCliente);

                if (cli == null)

                {

                    return "El cliente no existe";

                }

                ITM_Ventas.Clientes.Remove(cliente);

                ITM_Ventas.SaveChanges();

                return "se ha actualizado el cliente correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }

        }

        public String EliminarXId(int IdCliente)

        {

            try

            {

                Cliente cli = Consultar(IdCliente);

                if (cli == null)

                {

                    return "El cliente no existe";

                }

                ITM_Ventas.Clientes.Remove(cli);

                ITM_Ventas.SaveChanges();

                return "se ha eliminado el cliente correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }


        }
    }
}