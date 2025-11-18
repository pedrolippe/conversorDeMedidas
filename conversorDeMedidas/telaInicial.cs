namespace conversorDeMedidas
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void telaInicial_Load(object sender, EventArgs e)
        {

        }

        private void cbConversao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            // Se não tiver nenhum item selecionado, aparece uma mensagem
            if (cbConversao.SelectedItem == null)
            {
                MessageBox.Show(
                    "Selecione uma conversão para continuar!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return; // Para a execução do método
            }
            // Se a caixa de texto estiver vazia, aparece uma mensagem
            else if (string.IsNullOrWhiteSpace(tbValor.Text))
            {
                MessageBox.Show(
                    "Insira um valor para continuar!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // Tenta converter o valor inserido para double e gera uma variável "valor"
            if (!double.TryParse(tbValor.Text, out double valor))
            {
                // Caso não consiga, mostra uma mensagem de erro
                MessageBox.Show("Informe um valor válido!"); 
                return;
            }

            // Define as variáveis necessárias para a conversão
            double resultado = 0;
            string opcaoConversao = cbConversao.SelectedItem?.ToString();

            // Realiza a conversão a partir da opção selecionada
            switch (opcaoConversao)
            {
                case "Quilômetros para Metros":
                    resultado = valor * 1000;
                    break; // Para o case

                case "Milhas para Quilômetros":
                    resultado = valor * 1.60934;
                    break;

                case "Quilômetros para Milhas":
                    resultado = valor / 1.60934;
                    break;

                case "Quilômetros para Centímetros":
                    resultado = valor * 100000;
                    break;

                case "Milhas para Metros":
                    resultado = valor * 1609.34;
                    break;

                case "Milhas para Centímetros":
                    resultado = valor * 160934;
                    break;

                case "Celsius para Fahrenheit":
                    resultado = (valor * 9 / 5) + 32;
                    break;

                case "Fahrenheit para Celsius":
                    resultado = (valor - 32) * 5 / 9;
                    break;

                case "Km/h para M/s":
                    resultado = valor / 3.6;
                    break;
            }

            // Exite o resultado na label e com apenas duas casas decimais
            lblResultado.Text = resultado.ToString("0.00");

        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void cbConversao_Click(object sender, EventArgs e)
        {
            cbConversao.DroppedDown = true;
        }

        private void tbValor_KeyDown(object sender, KeyEventArgs e)
        {
            // Se o usuário pressionar Enter, aciona o botão de converter
            if (e.KeyCode == Keys.Enter)
            {
                btnConverter.PerformClick(); // aciona o botão
            }
        }
    }
}
