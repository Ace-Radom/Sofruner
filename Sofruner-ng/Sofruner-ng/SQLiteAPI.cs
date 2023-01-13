using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Sofruner_ng
{
    internal class SQLiteAPI
    {
        /// <summary>
        /// create one sqlite database file with given path
        /// </summary>
        /// <param name="path"></param>
        public static void CreateDB(string path)
        {
            SQLiteConnection cn = new SQLiteConnection("data source=" + path);
            cn.Open();
            cn.Close();
        }

        /// <summary>
        /// delete one sqlite database file with given path
        /// </summary>
        /// <param name="path"></param>
        public static void DeleteDB(string path)
        {
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                // sqlite doesn't have a function to delete the database itself
                // but: sqlite database is only one file, therefore it only needs to delete it
            }
        }

        /// <summary>
        /// Create a list in given sqlite database
        /// </summary>
        /// <param name="path"></param>
        /// <param name="List_Name"></param>
        /// <param name="List_Data"></param>
        public static void CreateListInDB(string path, string List_Name, string List_Column)
        {
            SQLiteConnection cn = new SQLiteConnection("data source=" + path);
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText = 
                    "CREATE TABLE IF NOT EXISTS " + List_Name + " (" + List_Column + ")";
                cmd.ExecuteNonQuery();
            }
            cn.Close();
        }

        /// <summary>
        /// Drop a list in given sqlite database
        /// </summary>
        /// <param name="path"></param>
        /// <param name="List_Name"></param>
        public static void DropListInDB(string path, string List_Name)
        {
            SQLiteConnection cn = new SQLiteConnection("data source=" + path);
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                    "DROP TABLE IF EXISTS " + List_Name;
                cmd.ExecuteNonQuery();
            }
            cn.Close();
        }

        /// <summary>
        /// insert one data into a list in given sqlite database
        /// </summary>
        /// <param name="path"></param>
        /// <param name="List_Name"></param>
        /// <param name="Data"></param>
        public static void InsertIntoListInDB(string path, string List_Name, string Data)
        {
            SQLiteConnection cn = new SQLiteConnection("data source=" + path);
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                    "INSERT INTO " + List_Name + " VALUES (" + Data + ")";
                cmd.ExecuteNonQuery();
            }
            cn.Close();
        }

        /// <summary>
        /// update one data in a list in given sqlite database
        /// </summary>
        /// <param name="path"></param>
        /// <param name="List_Name"></param>
        /// <param name="Data"></param>
        public static void UpdateAllInListInDB(string path, string List_Name, string Data)
        {
            SQLiteConnection cn = new SQLiteConnection("data source=" + path);
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                    "UPDATE " + List_Name + " SET " + Data;
                cmd.ExecuteNonQuery();
            }
            cn.Close();
        }

        /// <summary>
        /// delete all data in a list in given sqlite database
        /// </summary>
        /// <param name="path"></param>
        /// <param name="List_Name"></param>
        public static void DeleteAllInListInDB(string path, string List_Name)
        {
            SQLiteConnection cn = new SQLiteConnection("data source=" + path);
            if (cn.State != System.Data.ConnectionState.Open)
            {
                cn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = cn;
                cmd.CommandText =
                    "DELETE FROM " + List_Name;
                cmd.ExecuteNonQuery();
            }
            cn.Close();
        }
    }
}
