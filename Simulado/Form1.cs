namespace Simulado
{
    public partial class Form1 : Form
    {
        Form2 home;
        Contato contato;
        public Form1(Form2 home, Contato selecionado)
        {
            InitializeComponent();
            this.home = home;

            comboBox1.Items.Add(new TipoTelefone(1, "Profissional"));
            comboBox1.Items.Add(new TipoTelefone(2, "Pessoal"));
            comboBox1.Items.Add(new TipoTelefone(3, "Whatsapp"));
            comboBox1.Items.Add(new TipoTelefone(4, "Recado"));
            comboBox1.DisplayMember = "nome";

            this.contato = selecionado;

            if (contato != null)
            {
                NomeBox.Text = contato.nome;
                SobrenomeBox.Text = contato.sobrenome;
                TelefoneBox.Text = contato.telefone;

                foreach(TipoTelefone tipo in comboBox1.Items) 
                {
                    if(contato.tipo.id ==  tipo.id && tipo.nome == contato.tipo.nome)
                    {
                        comboBox1.SelectedItem = tipo;
                        break;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adicionar_Click(object sender, EventArgs e)
        {   
            if (this.contato == null) 
            {
                int id = home.contatos.Count() + 1;
                Contato contato = new Contato(
                id,
                NomeBox.Text,
                SobrenomeBox.Text,
                TelefoneBox.Text,
                (TipoTelefone)comboBox1.SelectedItem
                );
                home.contatos.Add(contato);
            }
            else
            {
                contato.nome = NomeBox.Text;
                contato.sobrenome = SobrenomeBox.Text;
                contato.telefone = TelefoneBox.Text;
                contato.tipo = (TipoTelefone)comboBox1.SelectedItem;

                home.contatos[contato.id - 1] = contato;
            }
                home.dataGridView1.DataSource = null;
                home.dataGridView1.DataSource = home.contatos;
                home.dataGridView1.Refresh();

            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SobrenomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelefoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
