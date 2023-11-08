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
            novaLinha(dataRow, "Não se aplica", "Em Tramitassão");

            //definindo o tamanho das colunas
            dgvEsocial.Columns[0].Width = 200;
            dgvEsocial.Columns[1].Width = 200;
            dgvEsocial.Columns[2].Width = 170;
            dgvEsocial.Columns[3].Width = 180;
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
    }
}
