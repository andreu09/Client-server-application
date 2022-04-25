using System;
using System.Windows.Forms;

namespace BD_KURS_SHMAKOV_846

{
    /*
      Форма обновления отсрочки у призывника 
    */
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Загрузка формы
        private void Form2_Load(object sender, EventArgs e)
        {
            // Добавление типов отсрочек для выбора
            foreach (string otsr in Otsr.getOtsr())
                comboBox1.Items.Add(otsr);
        }
        
        // Кнопка обновления отсрочки призывнику
        private void button1_Click(object sender, EventArgs e)
        {
            OtsrPrizyvnika.prizyvnik = textBox1.Text;
            OtsrPrizyvnika.otsr = comboBox1.Text.ToString();
            OtsrPrizyvnika.data = textBox2.Text;

            MessageBox.Show(OtsrPrizyvnika.updateOtsr());
        }
    }
}

