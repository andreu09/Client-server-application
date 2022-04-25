using System;
using System.Windows.Forms;

namespace BD_KURS_SHMAKOV_846
{
    /*
     Форма добавления призывника
    */
    public partial class Form3 : Form
    {
        public static string tab_name;
        public Form3()
        {
            InitializeComponent();

            // Добавление существующих военкоматов для выбора
            foreach (string voenkomatKod in Voenkomat.ShowAllVoenkomatKod())
                comboBox1.Items.Add(voenkomatKod);

            // Добавление существующих проф. отборов для выбора
            foreach (string profOtbor in ProfOtbor.ShowAllProfOtbor())
                comboBox2.Items.Add(profOtbor);

            // Добавление существующих медкомитетов для выбора
            foreach (string medkomitet in Medkomitet.ShowAllMedkomitet())
                comboBox3.Items.Add(medkomitet);
        }
       
        // Кнопка добавления призывника
        private void button1_Click(object sender, EventArgs e)
        {
            Prizyvnik.numDela = textBox1.Text;
            Prizyvnik.fio = textBox2.Text;
            Prizyvnik.voenkomat = comboBox1.Text.ToString();
            Prizyvnik.profOtbor = comboBox2.Text.ToString();
            Prizyvnik.phone = textBox3.Text;
            Prizyvnik.dataBirth = textBox4.Text;
            Prizyvnik.adress = textBox5.Text;
            Prizyvnik.medkomitet = comboBox3.Text.ToString();
            Prizyvnik.stepenGodnosti = comboBox4.Text.ToString();
            Prizyvnik.dataMedosmotra = textBox6.Text;

            MessageBox.Show(Prizyvnik.AddPrizyvnik());
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}