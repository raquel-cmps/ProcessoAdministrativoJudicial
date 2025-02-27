using FFPPRAJ.Models;
using FFPPRAJ.Repositories;

namespace FFPPRAJ
{
    public partial class Cadastro : Form
    {
        private readonly DbContext _dbContext = new DbContext();
        public Cadastro()
        {
            InitializeComponent();

            btnAlterar.Visible = false;
            btnAlterar.Enabled = false;
        }

        Detalhe detalhe;

        public Cadastro(Detalhe d, string processo, string tipo, string vara, string indicativo, string autoria,
            string chapa, string uf, string municipio)
        {
            InitializeComponent();

            detalhe = d;
            txtProcesso.Text = processo;
            cbTipo.Text = tipo;
            txtVara.Text = vara;
            cbIndicativo.Text = indicativo;
            cbAutoria.Text = autoria;
            txtChapa.Text = chapa;
            cbUF.Text = uf;
            txtMunicipio.Text = municipio;

            btnSalvar.Visible = false;
            btnSalvar.Enabled = false;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            //consulta Tipo Processo
            string vqueryTipo = @"
                SELECT
                    id_tipo,
                    nome_processo
                FROM
                    TipoProcesso
                ORDER BY
                    id_tipo
            ";
            //populando Tipo do Processo
            cbTipo.Items.Clear();
            cbTipo.DataSource = _dbContext.Consulta(vqueryTipo);
            cbTipo.DisplayMember = "nome_processo";
            cbTipo.ValueMember = "id_tipo";


            //consutando Autoria
            string vqueryAutoria = @"
                SELECT
                    id_autoria,
                    nome_autoria
                FROM
                    Autoria
                ORDER BY
                    id_autoria
            ";
            //popular Autoria
            cbAutoria.Items.Clear();
            cbAutoria.DataSource = _dbContext.Consulta(vqueryAutoria);
            cbAutoria.DisplayMember = "nome_autoria";
            cbAutoria.ValueMember = "id_autoria";


            //consultando UF
            string vqueryUF = @"
                SELECT
                    id,
                    uf
                FROM
                    estado
                ORDER BY
                    uf
            ";
            //popular UF
            cbUF.Items.Clear();
            cbUF.DataSource = _dbContext.Consulta(vqueryUF);
            cbUF.DisplayMember = "uf";
            cbUF.ValueMember = "id";

            //consultando indicativo
            string vqueryIndicativo = @"
                SELECT
                    id,
                    nome 
                FROM
                    Indicativo
                ORDER BY
                    nome
            ";

            //populando indicativo
            cbIndicativo.Items.Clear();
            cbIndicativo.DataSource = _dbContext.Consulta(vqueryIndicativo);
            cbIndicativo.DisplayMember = "nome";
            cbIndicativo.ValueMember = "id";

            //carregando o municipio
        }

        //BOTOES CADASTRO
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var processo = new Processo
            {
                id_processo = Int32.Parse(txtProcesso.Text),
                tipo = cbTipo.Text,
                uf = cbUF.Text,
                municipio = txtMunicipio.Text,
                vara = Int32.Parse(txtVara.Text),
                autoria = cbAutoria.Text,
                chapa = Int32.Parse(txtChapa.Text),
                indicativo = cbIndicativo.Text
            };

            var cadRepository = new CadastroRepository();
            cadRepository.NovoCadastro(processo);

            Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        //BOTOES INDICATIVO
        private void btnIndiSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Indicativo salvo com sucesso", "Indicativo");
        }

        private void btnIndiCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //BOTAO DO MUNICIPIO

        public static int index { get; set; }

        private void btnMunicipio_Click(object sender, EventArgs e)
        {
            Municipio municipio = new Municipio(txtMunicipio.Text, this);
            index = cbUF.SelectedIndex;
            municipio.ShowDialog();
        }


        private void txtMunicipio_TextChanged(object sender, EventArgs e)
        {
        }

        private void limpar()
        {
            Control ctrl = default(Control);
            TextBox txt = default(TextBox);
            foreach (Control c in this.Controls)
            {
                if ((object.ReferenceEquals(c.GetType(), typeof(TextBox))))
                {
                    txt = (TextBox)c;
                    txt.Text = "";
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Processo processo = new Processo
            {
                id_processo = Int32.Parse(txtProcesso.Text),
                tipo = cbTipo.Text,
                uf = cbUF.Text,
                municipio = txtMunicipio.Text,
                vara = Int32.Parse(txtVara.Text),
                autoria = cbAutoria.Text,
                chapa = Int32.Parse(txtChapa.Text),
                indicativo = cbIndicativo.Text
            };

            var cadRepository = new CadastroRepository();
            cadRepository.AtualizarCadastro(processo);

            Close();
        }
    }
}