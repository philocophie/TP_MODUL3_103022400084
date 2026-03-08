namespace TP_MODUL3_103022400084
{
    public partial class Form1 : Form
    {
        double angka1 = 0;
        string operasi = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void tombol(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            labelOutput.Text += btn.Text;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToDouble(labelOutput.Text);
            operasi = "+";
            labelOutput.Text = "";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            double angka2 = Convert.ToDouble(labelOutput.Text);

            if (operasi == "+")
            {
                double hasil = angka1 + angka2;
                labelOutput.Text = hasil.ToString();
            }
        }
    }
}
