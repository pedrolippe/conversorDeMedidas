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
            if (cbConversao.SelectedItem == null)
            {
                MessageBox.Show(
                    "Selecione uma conversão para continuar!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
