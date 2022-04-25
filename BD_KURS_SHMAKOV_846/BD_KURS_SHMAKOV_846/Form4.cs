using System;
using System.Windows.Forms;

namespace BD_KURS_SHMAKOV_846
{
    /*
    Форма удаление отсрочки у призывника
    */
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Кнопка удаления отсрочки у призывника
        private void button1_Click(object sender, EventArgs e)
        {
            OtsrPrizyvnika.prizyvnik = textBox1.Text;
            MessageBox.Show(OtsrPrizyvnika.DeleteOtsr());
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
