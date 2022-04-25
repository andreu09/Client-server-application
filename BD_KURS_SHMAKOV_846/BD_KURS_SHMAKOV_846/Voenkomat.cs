using System.Collections.Generic;
using System.Data.SqlClient;

namespace BD_KURS_SHMAKOV_846
{
    /*
      Военкомат
    */
    class Voenkomat
    {
        public int kod;
        public string name;
        public string adress;
        public string phone;
        public static string TabName = "Военкомат";

        // Существующие военкоматы
        public static System.Collections.IList ShowAllVoenkomatKod()
        {
            List<string> VoenkomatKods = new List<string>();
            SqlCommand cmd = SqlCon.con.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + TabName;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
                VoenkomatKods.Add(reader["Код"].ToString());

            reader.Close();

            return VoenkomatKods;
        }
    }
}
