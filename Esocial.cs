using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFPPRAJ
{
    public partial class Esocial : Form
    {
        DataTable dataTable = new DataTable();
        public Esocial(string processo, string tipo)
        {
            InitializeComponent();

            vPsocial.Text = processo;
            vTsocial.Text = tipo;
        }

        private void Esocial_Load(object sender, EventArgs e)
        {

            //criando colunas

            dataTable.Columns.Add("Número do Processo");
            dataTable.Columns.Add("Tipo de Processo");
            dataTable.Columns.Add("Operação");
            dataTable.Columns.Add("Situação do Envio");
            dataTable.Columns.Add("Data");
            dgvEsocial.DataSource = dataTable;

            //adicionando dados pre cadastrados
            DataRow dataRow = dataTable.NewRow();
            novaLinha(dataRow, "Não se aplica", "Pendente de Transmissão no Top");

            //definindo o tamanho das colunas
            dgvEsocial.Columns[0].Width = 177;
            dgvEsocial.Columns[1].Width = 165;
            dgvEsocial.Columns[2].Width = 140;
            dgvEsocial.Columns[3].Width = 270;
            dgvEsocial.Columns[4].Width = 120;

        }

        public void novaLinha(DataRow row, string operacao, string situacao)
        {
            DateOnly date = DateOnly.FromDateTime(DateTime.Now);

            row[0] = vPsocial.Text;
            row[1] = vTsocial.Text;
            row[2] = operacao;
            row[3] = situacao;
            row[4] = date;
            dataTable.Rows.Add(row);
            dgvEsocial.DataSource = dataTable;
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = dgvEsocial.Rows[0];
            linha.Cells[3].Value = "Registro Inativado pelo Usuário";
            MessageBox.Show("Processo inativado");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = dgvEsocial.Rows[0];
            linha.Cells[2].Value = "Original";
            linha.Cells[3].Value = "Em transmissão";
            MessageBox.Show("Processo enviado");
        }
    }
}
