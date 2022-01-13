namespace MaquinaCaféVirtuall
{
    public partial class Form1 : Form
    {
        double saldo;
        double troco;
        bool cafe;

        public Form1()
        {
            InitializeComponent();
            labelStatus.Text = "Selecione uma bebida.";
            buttonRetirar.Enabled = false;
            buttonAdd.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                labelStatus.Text = "Insira suas moedas.";
                buttonAdd.Enabled = true;
                comboBox1.Enabled = true;
            }
            else if (checkBox1.Checked == false & checkBox2.Checked == false & checkBox3.Checked == false)
            {
                labelStatus.Text = "Selecione uma bebida.";
                buttonAdd.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                labelStatus.Text = "Insira suas moedas.";
                buttonAdd.Enabled = true;
                comboBox1.Enabled = true;
            }
            else if (checkBox1.Checked == false & checkBox2.Checked == false & checkBox3.Checked == false)
            {
                labelStatus.Text = "Selecione uma bebida.";
                buttonAdd.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                labelStatus.Text = "Insira suas moedas.";
                buttonAdd.Enabled = true;
                comboBox1.Enabled = true;
            }
            else if (checkBox1.Checked == false & checkBox2.Checked == false & checkBox3.Checked == false)
            {
                labelStatus.Text = "Selecione uma bebida.";
                buttonAdd.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "R$ 00,01")
            {
                troco += 1;
                labelTroco.Text = troco.ToString("C2");
                labelStatus.Text = "Moedas de 1 centavo não são aceitas.";
            }
            else if (comboBox1.Text == "R$ 00,05")
            {
                troco += 0.05f;
                labelTroco.Text = troco.ToString("C2");
                labelStatus.Text = "Moedas de 5 centavos não são aceitas.";
            }
            else if (comboBox1.Text == "R$ 00,10")
            {
                saldo += 0.10f;
                labelSaldo.Text = saldo.ToString("C2");
            }
            else if (comboBox1.Text == "R$ 00,25")
            {
                saldo += 0.25f;
                labelSaldo.Text = saldo.ToString("C2");
            }
            else if (comboBox1.Text == "R$ 00,50")
            {
                saldo = saldo + 0.50f;
                labelSaldo.Text = saldo.ToString("C2");
            }
            else if (comboBox1.Text == "R$ 01,00")
            {
                saldo = saldo + 1;
                labelSaldo.Text = saldo.ToString("C2");
            }
            if (checkBox1.Checked == true)
            {
                if (saldo >= 3)
                {
                    labelStatus.Text = "Saldo suficiente, clique em iniciar preparo.";
                }
            }
            if (checkBox2.Checked == true)
            {
                if (saldo >= 3.5f)
                {
                    labelStatus.Text = "Saldo suficiente, clique em iniciar preparo.";
                }
            }
            if (checkBox3.Checked == true)
            {
                if (saldo >= 4)
                {
                    labelStatus.Text = "Saldo suficiente, clique em iniciar preparo.";
                }
            }
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e) // Retirar Café
        {
            if (cafe == true)
            {
                labelStatus.Text = "Café Retirado, bom apetite :)";
                cafe = false;
                buttonRetirar.Enabled = false;

                if (checkBox1.Checked == true)
                {
                    MessageBox.Show("Café com Leite");
                }
                else if (checkBox2.Checked == true)
                {
                    MessageBox.Show("Cappuccino");
                }
                else if (checkBox3.Checked == true)
                {
                    MessageBox.Show("Mocha");
                }

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e) // Iniciar Preparo
        {
            if (checkBox1.Checked == true)
            {
                if (saldo >= 3)
                {
                    saldo -= 3;
                    troco = saldo;
                    saldo = 0;
                    cafe = true;
                    labelSaldo.Text = "R$ 00,00";
                    labelTroco.Text = troco.ToString();
                    labelStatus.Text = "Preparando...";
                    labelStatus.Update();
                    System.Threading.Thread.Sleep(3000);
                    labelStatus.Text = "Café Pronto.";
                    buttonRetirar.Enabled = true;
                }
                else
                {
                    labelStatus.Text = "Saldo Insuficiente.";
                }
            }
            else if (checkBox2.Checked == true)
            {
                if (saldo >= 3.5f)
                {
                    saldo -= 3.5f;
                    troco = saldo;
                    saldo = 0;
                    cafe = true;
                    labelSaldo.Text = "R$ 00,00";
                    labelTroco.Text = troco.ToString("C2");
                    labelStatus.Text = "Bebida Pronta.";
                    buttonRetirar.Enabled = true;
                }
                else
                {
                    labelStatus.Text = "Saldo Insuficiente.";
                }
            }
            else if (checkBox3.Checked == true)
            {
                if (saldo >= 4)
                {
                    saldo -= 4;
                    troco = saldo;
                    saldo = 0;
                    cafe = true;
                    labelSaldo.Text = "R$ 00,00";
                    labelTroco.Text = troco.ToString("C2");
                    labelStatus.Text = "Bebida Pronta.";
                    buttonRetirar.Enabled = true;
                }
                else
                {
                    labelStatus.Text = "Saldo Insuficiente.";
                }
            }
        }

        private void buttonSaldo_Click(object sender, EventArgs e)
        {
            if (saldo > 0)
            {
                saldo = 0;
                labelSaldo.Text = "R$ 00,00";
                labelStatus.Text = "Saldo Retirado.";
            }
        }

        private void buttonTroco_Click(object sender, EventArgs e)
        {
            if (troco > 0) 
            {
                troco = 0;
                labelTroco.Text = "R$ 00,00";
                labelStatus.Text = "Troco Retirado.";
            }
            }

        private void buttonCima_Click(object sender, EventArgs e)
        {
            saldo += troco;
            troco = 0;
            labelSaldo.Text = saldo.ToString("C2");
            labelTroco.Text = "R$ 00,00";
        }
    }
}