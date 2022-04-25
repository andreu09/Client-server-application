using System.Collections.Generic;
using System.Data.SqlClient;

namespace BD_KURS_SHMAKOV_846
{
    /*
       Отсрочка
   */
    class Otsr
    {
        public static string kod;
        public static string term;
        public static string desc;
        public static string tabName = "Отсрочка";

        // Все существующие отсрочки
        public static System.Collections.IList getOtsr()
        {
            List<string> otrs = new List<string>();
            SqlCommand cmd = SqlCon.con.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + tabName;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                otrs.Add(reader["Код"].ToString());
            }

            reader.Close();

            return otrs;
        }
    }

}
