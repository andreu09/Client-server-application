using System.Collections.Generic;
using System.Data.SqlClient;

namespace BD_KURS_SHMAKOV_846
{
    /*
    Медкомитет
    */
    class Medkomitet
    {
        public static string kod;
        public static string tabName = "Медкомитет";

        // Все существующие медкомитеты
        public static System.Collections.IList ShowAllMedkomitet()
        {
            List<string> medkomitets = new List<string>();
            SqlCommand cmd = SqlCon.con.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + tabName;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
                medkomitets.Add(reader["Код"].ToString());

            reader.Close();

            return medkomitets;
        }
    }
}
