using clubdeportivoV2.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubdeportivoV2.Datos
{
    internal class Cuotas
    {
        public string Abono_Socio(E_Cuota cuota)
        {
            string salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Abono_Socio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idClien", MySqlDbType.Int32).Value = cuota.IdCliente;
                comando.Parameters.Add("fechaC", MySqlDbType.Date).Value = cuota.Fecha.Date;
                comando.Parameters.Add("montoC", MySqlDbType.Float).Value = cuota.Monto;
                comando.Parameters.Add("formaP", MySqlDbType.VarChar).Value = cuota.FormaPago;
                comando.Parameters.Add("fechaV", MySqlDbType.Date).Value = cuota.FechaVencimiento.Date;
                comando.Parameters.Add("tieneP", MySqlDbType.VarChar).Value = cuota.TienePromo ? 1 : 0; // Chequeamos que se almacene como boolean en la bd.
                comando.Parameters.Add("detalles", MySqlDbType.VarChar).Value = cuota.Detalle;

                MySqlParameter parCodigo = new MySqlParameter();
                parCodigo.ParameterName = "rta";
                parCodigo.MySqlDbType = MySqlDbType.Int32;
                parCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(parCodigo.Value);
            }
            catch (Exception ex) {
                salida = ex.Message;
            }
            // proceso de cierre de conexión que ejecutamos al final
            finally {
                if (sqlCon.State == ConnectionState.Open) {
                    sqlCon.Close();
                }
            }
            return salida;
        }
    }
}
