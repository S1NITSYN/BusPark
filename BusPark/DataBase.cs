using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace BusPark
{
    internal static class DataBase
    {
        private static string connString = $"Data Source={Environment.MachineName}\\SQLEXPRESS;Database=BusPark;Trusted_Connection=True;";

        static SqlConnection connection = new SqlConnection(connString);

        public static void openCon()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        public static void closeCon()
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public static DataTable SELECT(string table_name)
           => SelectRequestExecute($"SELECT * FROM {table_name};");


        public static List<T> ConvertToList<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
        public static DataTable SelectRequestExecute(string request)
        {
            openCon();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(request, connection);

            using(SqlDataReader reader = command.ExecuteReader())
            {
                table.Load(reader);
            }
            closeCon();
            return table;
        }
        public static void NonQueryRequestExecute(string request)
        {
            openCon();
            //Все команды кроме селекта
            SqlCommand command = new SqlCommand(request, connection);
            command.ExecuteNonQuery();
            closeCon();
        }
        public static DataTable SelectFromUsersDB(string email, string Upassword)
           => SelectRequestExecute($"SELECT * FROM Users WHERE email = '{email}' AND UPassword = '{Upassword}';");
        public static DataTable SelectEmailFromUsersDB(string email)
           => SelectRequestExecute($"SELECT * FROM Users WHERE email = '{email}'");
        public static DataTable SelectFromUsersDB(string Ulogin)
            =>SelectRequestExecute($"SELECT * FROM Users WHERE ULogin = '{Ulogin}';");
        public static void InsertIntoUsersDB(string Ulogin, string Upassword, string email)
            =>NonQueryRequestExecute( $"INSERT INTO Users (ULogin, Upassword, email) VALUES ('{Ulogin}', '{Upassword}', '{email}');");
    }
}
