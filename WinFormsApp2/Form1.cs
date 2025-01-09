namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        static class GlobalVars
        {
            public static int islemTakip = 0;
            public static double tempNumber = 0;
            public static char tempislem;
            public static double sum = 0;
            public static int columnTemp = 0;
        }

        private void sifirla_number()
        {
            if (GlobalVars.islemTakip == 1)
            {
                textBox1.Text = "";
                GlobalVars.islemTakip = 0;
                GlobalVars.columnTemp = 0;
            }
        }

        private void sifirla_tam()
        {
            GlobalVars.islemTakip = 1;
            GlobalVars.tempislem = '\0';
            GlobalVars.tempNumber = 0;
            GlobalVars.sum = 0;
            GlobalVars.columnTemp = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifirla_number();
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifirla_number();
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sifirla_number();
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sifirla_number();
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sifirla_number();
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sifirla_number();
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sifirla_number();
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sifirla_number();
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sifirla_number();
            textBox1.Text += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            sifirla_number();
            textBox1.Text += 0;
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            sifirla_tam();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (GlobalVars.tempislem != '\0')
            {
                bool result_devam = Double.TryParse(textBox1.Text, out double value_devam);
                GlobalVars.sum = islem(GlobalVars.tempislem, GlobalVars.tempNumber, value_devam);
                textBox1.Text = GlobalVars.sum.ToString();
            }
            sifirla_tam();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (GlobalVars.tempislem != '\0')
            {
                bool result_devam = Double.TryParse(textBox1.Text, out double value_devam);
                GlobalVars.sum = islem(GlobalVars.tempislem, GlobalVars.tempNumber, value_devam);
                textBox1.Text = GlobalVars.sum.ToString();
            }
            GlobalVars.islemTakip = 1;
            GlobalVars.tempislem = '/';
            bool result = Double.TryParse(textBox1.Text, out double value);
            GlobalVars.tempNumber = value;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (GlobalVars.tempislem != '\0')
            {
                bool result_devam = Double.TryParse(textBox1.Text, out double value_devam);
                GlobalVars.sum = islem(GlobalVars.tempislem, GlobalVars.tempNumber, value_devam);
                textBox1.Text = GlobalVars.sum.ToString();
            }
            GlobalVars.islemTakip = 1;
            GlobalVars.tempislem = '*';
            bool result = Double.TryParse(textBox1.Text, out double value);
            GlobalVars.tempNumber = value;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (GlobalVars.tempislem != '\0')
            {
                bool result_devam = Double.TryParse(textBox1.Text, out double value_devam);
                GlobalVars.sum = islem(GlobalVars.tempislem, GlobalVars.tempNumber, value_devam);
                textBox1.Text = GlobalVars.sum.ToString();
            }
            GlobalVars.islemTakip = 1;
            GlobalVars.tempislem = '-';
            bool result = Double.TryParse(textBox1.Text, out double value);
            GlobalVars.tempNumber = value;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (GlobalVars.tempislem != '\0')
            {
                bool result_devam = Double.TryParse(textBox1.Text, out double value_devam);
                GlobalVars.sum = islem(GlobalVars.tempislem, GlobalVars.tempNumber, value_devam);
                textBox1.Text = GlobalVars.sum.ToString();
            }
            GlobalVars.islemTakip = 1;
            GlobalVars.tempislem = '+';
            bool result = Double.TryParse(textBox1.Text, out double value);
            GlobalVars.tempNumber = value;
        }

        private double islem(char islem, double num1, double num2)
        {
            double sum = 0;
            switch (islem)
            {
                case '+':
                    sum = num1 + num2;
                    break;
                case '-':
                    sum = num1 - num2;
                    break;
                case '*':
                    sum = num1 * num2;
                    break;
                case '/':
                    sum = num1 / num2;
                    break;
                default:
                    break;
            }
            return sum;
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            bool result = Double.TryParse(textBox1.Text, out double value);
            if (result)
            {
                textBox1.Text = Convert.ToString(value / 100);
            }
            GlobalVars.islemTakip = 1;
        }

        private void buttoncolumn_Click(object sender, EventArgs e)
        {
            sifirla_number();
            if (GlobalVars.columnTemp == 0)
            {
                GlobalVars.columnTemp = 1;
                textBox1.Text += ',';
            }
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1);
        }

        private void buttonsin_Click(object sender, EventArgs e)
        {
            bool result = float.TryParse(textBox1.Text, out float value);
            textBox1.Text = MathF.Sin(value).ToString();
            GlobalVars.islemTakip = 1;
        }

        private void buttoncos_Click(object sender, EventArgs e)
        {
            bool result = float.TryParse(textBox1.Text, out float value);
            textBox1.Text = MathF.Cos(value).ToString();
            GlobalVars.islemTakip = 1;
        }
    }
}
