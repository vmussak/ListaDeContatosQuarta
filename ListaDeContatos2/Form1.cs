namespace ListaDeContatos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Tipo = cbxTipo.Text,
            };

            //validar

            lblResultado.Text = contato.Mostrar();
        }
    }
}
