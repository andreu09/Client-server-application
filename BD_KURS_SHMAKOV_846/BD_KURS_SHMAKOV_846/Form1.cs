using System;
using System.Windows.Forms;

namespace BD_KURS_SHMAKOV_846
{
    /*
        Главная форма приложения
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Загрузка формы 1
        private void Form1_Load(object sender, EventArgs e)
        {  
            groupBoxTable.Enabled = false;
        }

        // Кнопка подлючения к БД
        private void ButtonConnection_Click(object sender, EventArgs e)
        {
            try {
                SqlCon.ConnectDatabase();

                foreach (string TableName in SqlCon.TableNames)
                    comboBox1.Items.Add(TableName);

                // Выбираем по умолчанию показ главного представления все о призывнике
                comboBox1.SelectedIndex = 14;
                // Удаление вспомогательного представления
                comboBox1.Items.RemoveAt(12);
                // Делаем доступынм для пользователя элементы управления
                groupBoxTable.Enabled = true;

            } catch {
                MessageBox.Show("Ошибка при подключении к базе данных, проверьте правильность введенных данных!");
            }
        }

        // Кнопка отключения от БД
        private void ButtonCloseConnection_Click(object sender, EventArgs e)
        {
            SqlCon.DisconnectDatabase();
            groupBoxTable.Enabled = false;
        }

        // Кнопка добавления отсрочки призывнику
        private void ButtonAddStr_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }

        // Кнопка описания приложения
        private void ButtonAboutApp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данное Клиент-Серверное приложение \n было разработано студентом группы 846 \n " +
                "Шмаковым Андреем Юрьевичем \n в рамках курса *Базы данных и  \n клиент-серверные приложения*");
        }

        // Кнопка закрытия приложения
        private void ButtonCloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Кнопка удаления отсрочки призывнику
        private void ButtonDelStr_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.ShowDialog();
        }

        // Кнопка обновления отсрочки призывнику
        private void ButtonUpStr_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
        }

        // Выбор таблицы и показ ее содержимого
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = SqlCon.ShowTable(comboBox1.SelectedItem.ToString()).DefaultView;
        }

        // Кнопка добавления отсрочки призывнику
        private void buttonAddOtsr_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.ShowDialog();
        }
    }
}

