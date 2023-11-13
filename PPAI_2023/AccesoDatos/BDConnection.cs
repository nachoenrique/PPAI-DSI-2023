using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace PPAI_2023.AccesoDatos
{
    // TODO que nombre no sea public por favor
    public class BDConnection
    {
        private static SQLiteConnection conn;
        public static SQLiteConnection CreateConnection()
        {
            // PONER EL PATH ABSOLUTO HACIA DONDE ESTA LA DB EN TU PC
            String path = "C:\\Users\\Franco\\Desktop\\tpiDSI\\AppRegIngRTMantCorrec\\WindowsFormsApp1\\BBDD\\PPAIDB.db";
            conn = new SQLiteConnection("Datasource=" + path + ";Version=3;New=True;Compress=True;");

            try
            {
                conn.Open();
                Console.WriteLine("HOLAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            }
            catch
            {
                Console.WriteLine("NO ENTROOO");
            }
            return conn;
        }
        public static void CreateTable(string consulta)
        {
            SQLiteCommand sQLiteCommand;
            String createSQL = consulta;
            sQLiteCommand = conn.CreateCommand();
            sQLiteCommand.CommandText = createSQL;
            sQLiteCommand.ExecuteNonQuery();
        }

        public static void InsertData(string consulta)
        {
            SQLiteCommand sQLiteCommand;
            sQLiteCommand = conn.CreateCommand();
            sQLiteCommand.CommandText = consulta;
            sQLiteCommand.ExecuteNonQuery();
        }

        public static void UpdateData(string consulta)
        {
            SQLiteCommand sQLiteCommand;
            sQLiteCommand = conn.CreateCommand();
            sQLiteCommand.CommandText = consulta;
            sQLiteCommand.ExecuteNonQuery();
        }

        public static DataTable ReadData(string consulta)
        {
            SQLiteDataReader sqliteReader;
            SQLiteCommand sqliteCommand;
            DataTable tabla = new DataTable();
            sqliteCommand = conn.CreateCommand();
            //sqliteCommand = new SQLiteCommand(consulta);
            sqliteCommand.CommandText = consulta;
            sqliteReader = sqliteCommand.ExecuteReader();
            tabla.Load(sqliteReader);
            //Console.WriteLine(sqliteReader["COL2"].ToString());

            return tabla;
        }
    }
}
