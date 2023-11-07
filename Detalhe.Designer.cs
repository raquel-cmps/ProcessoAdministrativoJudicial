namespace FFPPRAJ
{
    partial class Detalhe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvDetalhe = new DataGridView();
            label7 = new Label();
            vProcesso = new TextBox();
            Excluir = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            vMunicipio = new TextBox();
            vAutoria = new TextBox();
            vIndicativo = new TextBox();
            vUF = new TextBox();
            vVara = new TextBox();
            vTipo = new TextBox();
            btnNovoCadastro = new Button();
            vChapa = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalhe).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalhe
            // 
            dgvDetalhe.AllowUserToAddRows = false;
            dgvDetalhe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetalhe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalhe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalhe.EnableHeadersVisualStyles = false;
            dgvDetalhe.Location = new Point(12, 281);
            dgvDetalhe.MultiSelect = false;
            dgvDetalhe.Name = "dgvDetalhe";
            dgvDetalhe.ReadOnly = true;
            dgvDetalhe.RowHeadersVisible = false;
            dgvDetalhe.RowHeadersWidth = 51;
            dgvDetalhe.RowTemplate.Height = 29;
            dgvDetalhe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalhe.Size = new Size(1027, 280);
            dgvDetalhe.TabIndex = 2;
            dgvDetalhe.SelectionChanged += dgvDetalhe_SelectionChanged;
            dgvDetalhe.DoubleClick += dgvDetalhe_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(64, 9);
            label7.Name = "label7";
            label7.Size = new Size(152, 20);
            label7.TabIndex = 33;
            label7.Text = "Número do Processo";
            // 
            // vProcesso
            // 
            vProcesso.Location = new Point(64, 32);
            vProcesso.Name = "vProcesso";
            vProcesso.ReadOnly = true;
            vProcesso.Size = new Size(198, 27);
            vProcesso.TabIndex = 32;
            // 
            // Excluir
            // 
            Excluir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Excluir.Location = new Point(882, 160);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(123, 53);
            Excluir.TabIndex = 31;
            Excluir.Text = "Exluir \r\nCadastro";
            Excluir.UseVisualStyleBackColor = true;
            Excluir.Click += Excluir_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(472, 160);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 30;
            label6.Text = "Município";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(376, 82);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 29;
            label5.Text = "Autoria da Ação Judicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(376, 9);
            label4.Name = "label4";
            label4.Size = new Size(365, 20);
            label4.TabIndex = 28;
            label4.Text = "Indicativo da Matéria do Processo ou Alvará Judicial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(375, 160);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 27;
            label3.Text = "UF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 160);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 26;
            label2.Text = "Vara";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 82);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 25;
            label1.Text = "Tipo de Processo";
            // 
            // vMunicipio
            // 
            vMunicipio.Location = new Point(465, 183);
            vMunicipio.Name = "vMunicipio";
            vMunicipio.ReadOnly = true;
            vMunicipio.Size = new Size(142, 27);
            vMunicipio.TabIndex = 24;
            // 
            // vAutoria
            // 
            vAutoria.Location = new Point(376, 105);
            vAutoria.Name = "vAutoria";
            vAutoria.ReadOnly = true;
            vAutoria.Size = new Size(231, 27);
            vAutoria.TabIndex = 23;
            // 
            // vIndicativo
            // 
            vIndicativo.Location = new Point(376, 32);
            vIndicativo.Name = "vIndicativo";
            vIndicativo.ReadOnly = true;
            vIndicativo.Size = new Size(231, 27);
            vIndicativo.TabIndex = 22;
            // 
            // vUF
            // 
            vUF.Location = new Point(375, 183);
            vUF.Name = "vUF";
            vUF.ReadOnly = true;
            vUF.Size = new Size(68, 27);
            vUF.TabIndex = 21;
            // 
            // vVara
            // 
            vVara.Location = new Point(64, 183);
            vVara.Name = "vVara";
            vVara.ReadOnly = true;
            vVara.Size = new Size(65, 27);
            vVara.TabIndex = 20;
            // 
            // vTipo
            // 
            vTipo.Location = new Point(64, 105);
            vTipo.Name = "vTipo";
            vTipo.ReadOnly = true;
            vTipo.Size = new Size(198, 27);
            vTipo.TabIndex = 19;
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovoCadastro.Location = new Point(727, 160);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(123, 53);
            btnNovoCadastro.TabIndex = 18;
            btnNovoCadastro.Text = "Adicionar \r\nCadastro\r\n";
            btnNovoCadastro.UseVisualStyleBackColor = true;
            btnNovoCadastro.Click += btnNovoCadastro_Click_1;
            // 
            // vChapa
            // 
            vChapa.Location = new Point(197, 183);
            vChapa.Name = "vChapa";
            vChapa.ReadOnly = true;
            vChapa.Size = new Size(65, 27);
            vChapa.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(197, 160);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 35;
            label8.Text = "Chapa";
            // 
            // Detalhe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1051, 564);
            Controls.Add(label8);
            Controls.Add(vChapa);
            Controls.Add(label7);
            Controls.Add(vProcesso);
            Controls.Add(Excluir);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(vMunicipio);
            Controls.Add(vAutoria);
            Controls.Add(vIndicativo);
            Controls.Add(vUF);
            Controls.Add(vVara);
            Controls.Add(vTipo);
            Controls.Add(btnNovoCadastro);
            Controls.Add(dgvDetalhe);
            Name = "Detalhe";
            Text = "Detalhe";
            Load += Detalhe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalhe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvDetalhe;
        private Label label7;
        private Button Excluir;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox vMunicipio;
        private TextBox vAutoria;
        private TextBox vIndicativo;
        private TextBox vUF;
        private TextBox vVara;
        private TextBox vTipo;
        private Button btnNovoCadastro;
        public TextBox vProcesso;
        private TextBox vChapa;
        private Label label8;
    }
}