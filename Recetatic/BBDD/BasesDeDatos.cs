using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Recetatic.Clases
{
    public class BasesDeDatos
    {
        //static string cadenacon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Script\\source\\repos\\Recetatic\\Recetas.mdf;Integrated Security=True;Connect Timeout=30";
        static string cadenacon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Worome\\source\\repos\\Recetatic\\Recetatic\\Recetas.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection con = new SqlConnection(cadenacon);

        public static void Conexion()
        {
            try
            {
                con.Open();
            } catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Se ha producido el siguiente error al abrir la base de datos: " + 
                    ex.Message);
            }
            
            
        }

        public static void Desconexion()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Se ha producido el siguiente error al cerrar la base de datos: " +
                    ex.Message);
            }
        }

        //public DataTable insertarPeriodo(string codigo, string periodo)
        //{
        //    string cadenaInsertar = "INSERT INTO Perioricidad (Codigo, Descripcion) values ('" + codigo +
        //        "','" + periodo + "')";
        //    SqlCommand comandoInsercion = new SqlCommand(cadenaInsertar, BasesDeDatos.con);
        //    comandoInsercion.ExecuteNonQuery();
        //    return null;
        //}


        public static DataTable mostrarPeriodos(string consulta)
        {
            try
            {
                Conexion();
                SqlCommand comandoConsultaPeriodos = new SqlCommand(consulta, BasesDeDatos.con);
                SqlDataAdapter adaptadorPeriodos = new SqlDataAdapter(comandoConsultaPeriodos);
                DataTable datosPeriodos = new DataTable();
                adaptadorPeriodos.Fill(datosPeriodos);
                return datosPeriodos;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
                return null;

            }

          

        }

        //        public static void insertarPeriodo(string codigo, string periodo)
        //        {
        //            string cadenaInsertar = "INSERT INTO Perioricidad (Codigo, Descripcion) values ('" + codigo +
        //"','" + periodo + "')";
        //            try
        //            {
        //                SqlCommand comandoInsercion = new SqlCommand(cadenaInsertar, con);
        //                comandoInsercion.ExecuteNonQuery();
        //            }
        //            catch (Exception ex)
        //            {

        //                System.Windows.Forms.MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message);

        //            }
        //        }
        public static void insertarPeriodo(clPeriodos periodoRecibido)
        {
            string cadenaInsertar = "INSERT INTO Perioricidad (Codigo, Descripcion) values ('" + 
                periodoRecibido.Codigo + "','" + periodoRecibido.Periodo + "')";
            try
            {
                SqlCommand comandoInsercion = new SqlCommand(cadenaInsertar, con);
                comandoInsercion.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message);

            }
        }

    }
}