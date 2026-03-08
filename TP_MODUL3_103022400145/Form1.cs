namespace TP_MODUL3_103022400145
{
    public partial class Form1 : Form
    {
        int totalHasil = 0;
        string layarKetik = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            layarKetik += "1";
            labelHasil.Text = layarKetik;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            layarKetik += "2";
            labelHasil.Text = layarKetik;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            layarKetik += "3";
            labelHasil.Text = layarKetik;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            layarKetik += "4";
            labelHasil.Text = layarKetik;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            layarKetik += "5";
            labelHasil.Text = layarKetik;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            layarKetik += "6";
            labelHasil.Text = layarKetik;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            layarKetik += "7";
            labelHasil.Text = layarKetik;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            layarKetik += "8";
            labelHasil.Text = layarKetik;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            layarKetik += "9";
            labelHasil.Text = layarKetik;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            layarKetik += "0";
            labelHasil.Text = layarKetik;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (layarKetik != "")
            {
                totalHasil += Convert.ToInt32(layarKetik);
                layarKetik = "";
                labelHasil.Text = "";
            }
        }

        private void buttonSamaDengan_Click(object sender, EventArgs e)
        {
            if (layarKetik != "")
            {
                totalHasil += Convert.ToInt32(layarKetik);
                labelHasil.Text = Convert.ToString(totalHasil);
                totalHasil = 0;
                layarKetik = "";
            }
        }
    }
}
