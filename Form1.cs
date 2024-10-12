using PrjHelloWorld.Models;
using System.CodeDom;
using System.Linq.Expressions;
using System.Reflection;

namespace PrjGerenciadorDePessoas
{
    public partial class Form1 : Form
    {
        private Pessoa pessoa;// declarar

        private List<Pessoa> pessoas = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = String.Empty;
            try
            {
                string Nome = txtNome.Text;
                int Idade = Convert.ToInt32(txtIdade.Text);//pode lançar exception

                pessoa = new Pessoa(Nome, Idade);//atribuir
                lstPessoas.Items.Add(pessoa);//adicionando a pessoa criada na listbox
            }
            catch (FormatException)
            {
                MessageBox.Show("Apenas números podem ser utilizados no campo idade!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ResetForm();

            MessageBox.Show("Pessoa adicionada com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            this.pessoa = (Pessoa)lstPessoas.SelectedItem; //casting
            this.pessoa.Nome = txtNome.Text;
            this.pessoa.Idade = Convert.ToInt32(txtIdade.Text);
            lstPessoas.Items[lstPessoas.SelectedIndex] = this.pessoa;

            ResetForm();



            //lblMensagem.Text = $"{pessoa.Nome} - {pessoa.getIdadeFormatada()}";
            //lblMensagem.Text = pessoa.exibirDadosPessoa();
            //for (int contador = 0; contador < this.pessoas.Count; contador++)
            //{
            //    lblMensagem.Text = $"{lblMensagem.Text}{this.pessoas[contador].Nome}\n";
            //}
            //foreach (var pessoa in pessoas)
            //{
            //    lblMensagem.Text = $"{lblMensagem.Text}{pessoa.Nome}\n";
            //}

        }

        private void lstPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            btnDet.Enabled = true;
            btnCriar.Enabled = false;

            if (lstPessoas.SelectedItem != null)
            {
                Pessoa p = (Pessoa)lstPessoas.SelectedItem;//casting
                txtNome.Text = p.Nome;
                txtIdade.Text = p.Idade.ToString();
            }
            else
            {
                btnSalvar.Enabled = false;
                btnExcluir.Enabled = false;
                btnDet.Enabled = false;
                btnCriar.Enabled = true;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //if (lstPessoas.SelectedItem == null)
            //{
            //    MessageBox.Show("Não há itens selecionados na lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //else
            //{
            DialogResult ExcluirPessoa = MessageBox.Show($"Tem certeza que deseja excluir {lstPessoas.SelectedItem}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (ExcluirPessoa == DialogResult.Yes)
            {
                lstPessoas.Items.Remove(lstPessoas.SelectedItem);

                ResetForm();
            }
            //}
        }

        private void btnDet_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Dados sobre a pessoa\n\n" +
                $"Nome: {pessoa.Nome}\n" +
                $"Idade: {pessoa.Idade.ToString()} anos", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ResetForm()
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtNome.Focus();
            lstPessoas.SelectedItem = null;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lstPessoas.SelectedItem != null)
            {
                try
                {
                    this.pessoa = (Pessoa)lstPessoas.SelectedItem;
                    this.pessoa.Nome = txtNome.Text;
                    this.pessoa.Idade = Convert.ToInt32(txtIdade.Text);
                    lstPessoas.Items[lstPessoas.SelectedIndex] = this.pessoa;

                    ResetForm();

                    MessageBox.Show("Dados da pessoa atualizados com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Apenas números podem ser utilizados no campo idade!!!", "Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluirTudo_Click(object sender, EventArgs e)
        {

            DialogResult apagarLista = MessageBox.Show("Tem certeza que deseja limpar a lista de Pessoas?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (apagarLista == DialogResult.Yes)
            {
                lstPessoas.Items.Clear();


                ResetForm();
            }
        }

        private void btnGerarDoc_Click(object sender, EventArgs e)
        {
            try
            {
                string conteudoArquivo =
                       $"Nome: {this.pessoa.Nome} -" +
                       $" Idade {this.pessoa.getIdadeFormatada()}";

                File.WriteAllText("C://Users//kailany.smoraes//source//repos//SlnGerenciadorDePessoas//PrjGerenciadorDePessoas//relatorio//relatorio.txt", 
                    conteudoArquivo);

                MessageBox.Show("Relatório gerado com sucesso!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Houve um erro na criação do relatório. Pasta não encontrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}