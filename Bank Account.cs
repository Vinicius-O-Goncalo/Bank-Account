namespace Bank_Account
{
    public partial class Form1 : Form
    {
        StreamWriter streamWriter = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            streamWriter = new StreamWriter("C:\\Users\\Aluno\\VisualStudioGoncalo\\bankaccount.txt");
            lbStatus.Text = "Arquivo aberto";

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                streamWriter.Write(txbName.Text + ";" +
                    txbDate.Text + ";" +
                    txbDesc.Text + ";");
                MessageBox.Show("Conta registrada!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            decimal debito = 0;
            decimal credito = 0;

            bool debitoValido = decimal.TryParse(txbDebito.Text, out debito);
            bool creditoValido = decimal.TryParse(txbCredito.Text, out credito);

            if (!debitoValido || !creditoValido)
            {
                MessageBox.Show("Por favor, digite valores válidos para débito e crédito.");
                return;
            }

            decimal saldo = credito - debito;

            MessageBox.Show($"Débito: {debito:C}\nCrédito: {credito:C}\nSaldo: {saldo:C}");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            streamWriter.Close();
            lbStatus.Text = "Arquivo fechado";
        }
    }
}
