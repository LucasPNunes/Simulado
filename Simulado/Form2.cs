namespace Simulado
{
    public partial class Form2 : Form
    {
        public List<Contato> contatos;
        public Contato selecionado;
        public Form2()
        {
            InitializeComponent();
            contatos = new List<Contato>();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contatos;
            dataGridView1.Refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void remover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                contatos.RemoveAt(selectedIndex);
                dataGridView1.DataSource = null
                dataGridView1.DataSource = contatos;
            }
            else
            {
                MessageBox.Show("Por favor, selecione um contato para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            selecionado = contatos[dataGridView1.SelectedRows[0].Index];
            Form1 form1 = new Form1(this, selecionado);
            form1.Show();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {   
            Form1 form1 = new Form1(this, null);
            form1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
        }
    }
}
