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

namespace FFPPRAJ
{
    public partial class Detalhe : Form
    {
        public Detalhe()
        {
            InitializeComponent();
        }


        private void Detalhe_Load(object sender, EventArgs e)
        {
            dgvDetalhe.DataSource = Banco.ObterCadastros();

        }

        //para cada linha selecionada mostrar o conteúdo nos txtbox 
        private void dgvDetalhe_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;

            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosCadastro(vId);

                vProcesso.Text = dt.Rows[0].Field<Int32>("Processo").ToString();
                vTipo.Text = dt.Rows[0].Field<string>("Tipo").ToString();
                vMunicipio.Text = dt.Rows[0].Field<string>("Municipio").ToString();
                vVara.Text = dt.Rows[0].Field<Int32>("Vara").ToString();
                vUF.Text = dt.Rows[0].Field<string>("UF").ToString();
                vIndicativo.Text = dt.Rows[0].Field<string>("Indicativo").ToString();
                vAutoria.Text = dt.Rows[0].Field<string>("Autoria").ToString();
                vChapa.Text = dt.Rows[0].Field<Int32>("Vara").ToString();
            }

        }

        private void btnNovoCadastro_Click_1(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
            dgvDetalhe.DataSource = Banco.ObterCadastros();
        }

        private void Excluir_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão do processo: " + vProcesso.Text + "?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.ExluirCadastro(vProcesso.Text);
                dgvDetalhe.Rows.Remove(dgvDetalhe.CurrentRow);
            }
        }

        private void dgvDetalhe_DoubleClick(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro(this, vProcesso.Text, vTipo.Text, vVara.Text, vIndicativo.Text, vAutoria.Text, vChapa.Text, vUF.Text, vMunicipio.Text);
            cadastro.ShowDialog();
            dgvDetalhe.DataSource = Banco.ObterCadastros();
        }
    }
}
