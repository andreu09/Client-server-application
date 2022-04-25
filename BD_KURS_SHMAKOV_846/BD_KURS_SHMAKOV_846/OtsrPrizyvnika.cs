using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_KURS_SHMAKOV_846
{
    /*
       Отсрочка призывника
    */
    class OtsrPrizyvnika
    {
        public static string prizyvnik;
        public static string otsr;
        public static string data;

        // Обновление отсрочки
        public static string updateOtsr()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = SqlCon.con;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[Обновить Призывнику Отсрочку]";

            command.Parameters.AddWithValue("@ЛичноеДело", prizyvnik);
            command.Parameters.AddWithValue("@Отсрочка", otsr);
            command.Parameters.AddWithValue("@ДатаВыдачи", data);

            command.Parameters.Add("@Код", SqlDbType.Int);
            command.Parameters["@Код"].Direction = ParameterDirection.ReturnValue;

            SqlDataReader rdr = command.ExecuteReader();

            string Message;

            switch (Convert.ToInt32(command.Parameters["@Код"].Value))
            {
                case 0:
                    Message = "Отсчрока успешно обновлена у призывника";
                    break;
                case 1:
                    Message = "Призывник не имеет отсрочки";
                    break;
                case 2:
                    Message = "Не найден тип отсрочки";
                    break;
                case 3:
                    Message = "Призывник не найден";
                    break;
                default:
                    Message = "Неизвестное сообщение";
                    break;
            }

            rdr.Close();
            return Message;

        }

        // Удаление отсрочки
        public static string DeleteOtsr()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = SqlCon.con;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[Удалить Призывнику Отсрочку]";

            command.Parameters.AddWithValue("@ЛичноеДело", prizyvnik);
            command.Parameters.Add("@Код", SqlDbType.Int);
            command.Parameters["@Код"].Direction = ParameterDirection.ReturnValue;

            SqlDataReader rdr = command.ExecuteReader();

            string Message;

            switch (Convert.ToInt32(command.Parameters["@Код"].Value))
            {
                case 0:
                    Message = "Отсрочка успешно удалена у призывника";
                    break;
                case 1:
                    Message = "Призывник не имеет отсрочки";
                    break;
                case 2:
                    Message = "Призывник не найден";
                    break;
                default:
                    Message = "Неизвестное сообщение";
                    break;
            }


            rdr.Close();
            return Message;
        }

        // Добавление отсрочки
        public static string AddOtsr()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = SqlCon.con;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[Добавить Призывнику Отсрочку]";

            command.Parameters.AddWithValue("@ЛичноеДело", prizyvnik);
            command.Parameters.AddWithValue("@Отсрочка", otsr);
            command.Parameters.AddWithValue("@ДатаВыдачи", data);

            command.Parameters.Add("@Код", SqlDbType.Int);
            command.Parameters["@Код"].Direction = ParameterDirection.ReturnValue;

            SqlDataReader rdr = command.ExecuteReader();

            string Message;

            switch (Convert.ToInt32(command.Parameters["@Код"].Value))
            {
                case 0:
                    Message = "Отсрочка успешно добавлена призывнику";
                    break;
                case 1:
                    Message = "Призывник уже имеет отсрочку";
                    break;
                case 2:
                    Message = "Не найден тип отсрочки";
                    break;
                case 3:
                    Message = "Призывник не найден";
                    break;
                default:
                    Message = "Неизвестное сообщение";
                    break;
            }

            rdr.Close();
            return Message;
        }
    }
}
