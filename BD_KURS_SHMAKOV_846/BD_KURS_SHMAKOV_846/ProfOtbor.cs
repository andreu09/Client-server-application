using System.Collections.Generic;
using System.Data.SqlClient;

namespace BD_KURS_SHMAKOV_846
{

    /*
       Профессиональный отбор
    */
    class ProfOtbor
    {
        public static string group;
        public static string description;
        public static string TabName = "[Профессиональный отбор]";

        // Существующие проф. отборы
        public static System.Collections.IList ShowAllProfOtbor()
        {
            List<string> ProfOtbors = new List<string>();
            SqlCommand cmd = SqlCon.con.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + TabName;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
                ProfOtbors.Add(reader["Группа"].ToString());

            reader.Close();

            return ProfOtbors;
        }
    }
}
