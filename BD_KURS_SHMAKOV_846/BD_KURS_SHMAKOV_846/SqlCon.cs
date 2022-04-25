using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.ConnectionUI;
using System.Data;
using System.Windows.Forms;

namespace BD_KURS_SHMAKOV_846
{
    /*
      Работа с базой данных
    */
    class SqlCon
    {
        // Строка подключения
        public static string strcon;
        // Объявление класса подключения к базе
        public static SqlConnection con = new SqlConnection();
        // Список таблиц
        public static List<string> TableNames = new List<string>();

        // Подключение к базе
        public static DialogResult ConnectDatabase() {

            DataConnectionDialog dlg = new DataConnectionDialog();
            DataSource.AddStandardDataSources(dlg);
            DataConnectionDialog.Show(dlg);

            strcon = dlg.ConnectionString;
            string[] parts = strcon.Split(';');
            strcon = parts[1] + ";" + parts[2] + ";" + parts[3] + ";" + parts[4] + ";";

            con.ConnectionString = strcon;
            con.ConnectionString = strcon;
            con.Open();

            DataTable schema = con.GetSchema("Tables");

            // Таблицы в базе
            foreach (DataRow row in schema.Rows)
                   TableNames.Add(row[2].ToString());

            return MessageBox.Show("Успешное подключение к базе данных!");
        }
    


  

        // Отключение от базы
        public static void DisconnectDatabase() {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
                MessageBox.Show("Соединение закрыто");
            }
            else
            {
                MessageBox.Show("Соединение не было открыто");
            }
        }

        // Показать таблицу
        public static DataTable ShowTable(string TabName) {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand com = con.CreateCommand();
            DataSet ds = new DataSet();

            com.CommandText = "select * from [" + TabName + "]";
            com.ExecuteNonQuery();
            da.SelectCommand = com;
            da.Fill(ds, TabName);

            return ds.Tables[0];
        }
    }
}
