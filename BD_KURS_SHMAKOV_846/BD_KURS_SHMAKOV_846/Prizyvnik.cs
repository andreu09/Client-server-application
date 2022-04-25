using System;
using System.Data;
using System.Data.SqlClient;

namespace BD_KURS_SHMAKOV_846
{
    /*
       Призывник
   */
    class Prizyvnik
    {
        public static string numDela;
        public static string fio;
        public static string voenkomat;
        public static string profOtbor;
        public static string phone;
        public static string dataBirth;
        public static string adress;
        public static string medkomitet;
        public static string stepenGodnosti;
        public static string dataMedosmotra;

        // Добавлене призывника
        public static string AddPrizyvnik()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = SqlCon.con;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[Добавить Призывника]";

            command.Parameters.AddWithValue("@ЛичноеДело", numDela);
            command.Parameters.AddWithValue("@ФИО", fio);
            command.Parameters.AddWithValue("@Военкомат", voenkomat);
            command.Parameters.AddWithValue("@Профотбор", profOtbor);
            command.Parameters.AddWithValue("@Телефон", phone);
            command.Parameters.AddWithValue("@ГодРождения", dataBirth);
            command.Parameters.AddWithValue("@Адрес", adress);
            command.Parameters.AddWithValue("@Медкомитет", medkomitet);
            command.Parameters.AddWithValue("@СтепеньГодности", stepenGodnosti);
            command.Parameters.AddWithValue("@ДатаМедосмотра", dataMedosmotra);
            command.Parameters.Add("@Код", SqlDbType.Int);
            command.Parameters["@Код"].Direction = ParameterDirection.ReturnValue;

            SqlDataReader rdr = command.ExecuteReader();

            string Message;

            switch (Convert.ToInt32(command.Parameters["@Код"].Value))
            {
                case 0:
                    Message = "Призывник успешно добавлен";
                    break;
                case 1:
                    Message = "Военкомат не найден";
                    break;
                case 2:
                    Message = "Призывник с таким номером личного дела уже существует";
                    break;
                case 3:
                    Message = "Неправильный формат степени годности";
                    break;
                case 4:
                    Message = "Медкомитет не может быть пустым";
                    break;
                case 5:
                    Message = "Дата Медосмотра не может быть пустой";
                    break;
                case 6:
                    Message = "Гуппа профотбора не может быть пустой";
                    break;
                case 7:
                    Message = "ФИО не может быть пустым";
                    break;
                case 8:
                    Message = "Номер личного дела не может быть пустым";
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
