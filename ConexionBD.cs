using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

using System.IO;
namespace H_P_II_Clase4
{
    public  class ConexionBD
    {
        private static ConexionBD instancia;
        private SQLiteConnection conexion;

        private ConexionBD()
        {
            try
            {
                // Asegurarse que la ruta sea correcta:
                string rutaDB = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.db");

                if (!File.Exists(rutaDB))
                    throw new FileNotFoundException("No se encontró el archivo de base de datos en: " + rutaDB);

                string cadenaConexion = $"Data Source={rutaDB};Version=3;";
                conexion = new SQLiteConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        public static ConexionBD Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ConexionBD();
                return instancia;
            }
        }

        public SQLiteConnection ObtenerConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    conexion.Open();
                }
                catch (Exception ex)
                {
                    throw new Exception("No se pudo abrir la conexión: " + ex.Message);
                }
            }
            return conexion;
        }
    }
}
