//using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DataAccess
{
    public class DataConnectionManager
    {
        public List<Tratamiento> GetTratamientos()
        {
            string cs = ConnectionInformation.ConnectionString;
            var con = new System.Data.SQLite.SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM Tratamiento";
            SQLiteCommand cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            List<Tratamiento> tratamientos = new List<Tratamiento>();
            while (rdr.Read())
            {
                Tratamiento tratamiento = new Tratamiento();
                tratamiento.Descripcion = rdr.GetString(0);
                tratamientos.Add(tratamiento);
            }
            return tratamientos;
        }

        public List<Despedida> GetDespedidas()
        {
            string cs = ConnectionInformation.ConnectionString;
            var con = new System.Data.SQLite.SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM Despedida";
            SQLiteCommand cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            List<Despedida> despedidas = new List<Despedida>();
            while (rdr.Read())
            {
                Despedida despedida = new Despedida();
                despedida.Descripcion = rdr.GetString(0);
                despedidas.Add(despedida);
            }
            return despedidas;
        }

        public List<Cargo> GetCargos()
        {
            string cs = ConnectionInformation.ConnectionString;
            var con = new System.Data.SQLite.SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM Cargo";
            SQLiteCommand cmd = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            List<Cargo> cargos = new List<Cargo>();
            while (rdr.Read())
            {
                Cargo cargo = new Cargo();
                cargo.Descripcion = rdr.GetString(0);
                cargos.Add(cargo);
            }
            return cargos;
        }
    }
}
