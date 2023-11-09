using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Drawing.Text;
using System.Reflection.Metadata;
using DevExpress.Data.Filtering.Helpers;
using System.Security.Cryptography.X509Certificates;
using DevExpress.Xpo.Helpers;

namespace FFPPRAJ
{
    public partial class Cadastro : Form
    {

        public Cadastro()
        {
            InitializeComponent();
            
            btnAlterar.Visible = false;
            btnAlterar.Enabled = false;

        }
        Detalhe detalhe;
        public Cadastro(Detalhe d, string processo, string tipo, string vara, string indicativo, string autoria, string chapa, string uf, string municipio)
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
            cbTipo.DataSource = Banco.Consulta(vqueryTipo);
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
            cbAutoria.DataSource = Banco.Consulta(vqueryAutoria);
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
            cbUF.DataSource = Banco.Consulta(vqueryUF);
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
            cbIndicativo.DataSource = Banco.Consulta(vqueryIndicativo);
            cbIndicativo.DisplayMember = "nome";
            cbIndicativo.ValueMember = "id";

            //carregando o municipio

        }

        //BOTOES CADASTRO
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Processo processo = new Processo();

            processo.id_processo = Int32.Parse(txtProcesso.Text);
            processo.tipo = cbTipo.Text;
            processo.uf = cbUF.Text;
            processo.municipio = txtMunicipio.Text;
            processo.vara = Int32.Parse(txtVara.Text);
            processo.autoria = cbAutoria.Text;
            processo.chapa = Int32.Parse(txtChapa.Text);
            processo.indicativo = cbIndicativo.Text;

            Banco.NovoCadastro(processo);

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
            Processo processo = new Processo();

            processo.id_processo = Int32.Parse(txtProcesso.Text);
            processo.tipo = cbTipo.Text;
            processo.uf = cbUF.Text;
            processo.municipio = txtMunicipio.Text;
            processo.vara = Int32.Parse(txtVara.Text);
            processo.autoria = cbAutoria.Text;
            processo.chapa = Int32.Parse(txtChapa.Text);
            processo.indicativo = cbIndicativo.Text;

            Banco.AtualizarCadastro(processo);

            Close();

        }
    }
}
