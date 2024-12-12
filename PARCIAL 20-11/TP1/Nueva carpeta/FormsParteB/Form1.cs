using System.Linq.Expressions;

namespace FormsParteB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 1;
            numericUpDown4.Minimum = 0;
            numericUpDown4.Maximum = 1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = (int)numericUpDown3.Value;
                int numero2 = (int)numericUpDown4.Value;
                int resultado = 0;

                if (numero1 != 0 && numero1 != 1)
                {
                    MessageBox.Show("El valor de N°1 debe ser 0 o 1 para opciones lógicas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (numero2 != 0 && numero2 != 1 && !radioButton7.Checked)
                {
                    MessageBox.Show("El valor de N°2 debe ser 0 o 1 para opciones lógicas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (radioButton5.Checked)
                {
                    resultado = numero1 & numero2;
                }
                else if (radioButton6.Checked)
                {
                    resultado = numero1 | numero2;
                }
                else if (radioButton7.Checked)
                {
                    resultado = numero1 == 0 ? 1 : 0;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una operación lógica.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("El resultado es: " + resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = (double)numericUpDown1.Value;
                double numero2 = (double)numericUpDown2.Value;
                double resultado = 0;


                if (radioButton1.Checked)
                {
                    resultado = numero1 + numero2;
                }
                else if (radioButton2.Checked)
                {
                    resultado = numero1 - numero2;
                }
                else if (radioButton3.Checked)
                {
                    resultado = numero1 * numero2;
                }
                else if (radioButton4.Checked)
                {
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una operación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                MessageBox.Show("El resultado es: " + resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


