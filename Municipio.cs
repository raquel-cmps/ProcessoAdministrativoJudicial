using DevExpress.DirectX.NativeInterop.Direct2D.CCW;
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
    public partial class Municipio : Form
    {
        Cadastro cadastro;
        public Municipio(string v, Cadastro c)
        {
            InitializeComponent();

            cadastro = c;
            vMunicipio.Text = v;
        }

        private void Municipio_Load(object sender, EventArgs e)
        {

            int retornIndex = Cadastro.index + 1;

            //consultando cidades
            string vqueryMunicipio = @"
                select
                    cidade.ibge as 'Código Municipio',
	                estado.uf as 'Estado', 
	                cidade.nome as 'Cidade'
                from 
	                estado
                inner join
	                cidade on cidade.uf = estado.id
                where
	                estado.id = @retornIndex; 
            ";

            using (var connection = Banco.ConexaoBanco())
            {
                using (SqlCommand cmd = new SqlCommand(vqueryMunicipio, connection))
                {
                    // Adicione o parâmetro na consulta
                    cmd.Parameters.AddWithValue("@retornIndex", retornIndex);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //colocando valores no dgv
                    dgvMunicipio.DataSource = dt;
                    dgvMunicipio.Columns[0].Width = 150;
                    dgvMunicipio.Columns[1].Width = 80;
                    dgvMunicipio.Columns[2].Width = 200;
                }
            }

        }

        private void dgvMunicipio_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;

            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosMunicipio(vId);

                vMunicipio.Text = dt.Rows[0].Field<string>("nome").ToString();
            }

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cadastro.txtMunicipio.Text = vMunicipio.Text;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
