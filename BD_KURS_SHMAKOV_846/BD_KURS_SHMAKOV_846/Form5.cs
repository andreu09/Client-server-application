using System;
using System.Windows.Forms;

namespace BD_KURS_SHMAKOV_846
{
    /*
    Форма добавления отсрочки призывнику
    */
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // Кнопка доавления отсрочки призывнику
        private void button1_Click(object sender, EventArgs e)
        {
            OtsrPrizyvnika.prizyvnik = textBox1.Text;
            OtsrPrizyvnika.otsr = comboBox1.Text.ToString();
            OtsrPrizyvnika.data = textBox2.Text;

            MessageBox.Show(OtsrPrizyvnika.AddOtsr());
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Добвление существующих типов отсрочек для выбора
            foreach (string otsr in Otsr.getOtsr())
                comboBox1.Items.Add(otsr);
        }
    }
}
