namespace FFPPRAJ
{
    partial class Esocial
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
            label7 = new Label();
            vPsocial = new TextBox();
            label1 = new Label();
            vTsocial = new TextBox();
            comboBox1 = new ComboBox();
            btnInativar = new Button();
            btnEnviar = new Button();
            dgvEsocial = new DataGridView();
            label14 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvEsocial).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(158, 9);
            label7.Name = "label7";
            label7.Size = new Size(152, 20);
            label7.TabIndex = 37;
            label7.Text = "Número do Processo";
            // 
            // vPsocial
            // 
            vPsocial.Location = new Point(158, 32);
            vPsocial.Name = "vPsocial";
            vPsocial.ReadOnly = true;
            vPsocial.Size = new Size(198, 27);
            vPsocial.TabIndex = 36;
            vPsocial.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(480, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 35;
            label1.Text = "Tipo de Processo";
            // 
            // vTsocial
            // 
            vTsocial.Location = new Point(480, 32);
            vTsocial.Name = "vTsocial";
            vTsocial.ReadOnly = true;
            vTsocial.Size = new Size(198, 27);
            vTsocial.TabIndex = 34;
            vTsocial.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Em Tramitação", "Erro", "Evento Duplicado", "Pendente de Tramitação no REX", "Pendente de Tramitação no Top", "Registro Inativado pelo Usuário", "Registro Inativado pelo Usuário", "Tranmitida (com Recibo) " });
            comboBox1.Location = new Point(158, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 28);
            comboBox1.TabIndex = 1;
            // 
            // btnInativar
            // 
            btnInativar.Location = new Point(593, 135);
            btnInativar.Name = "btnInativar";
            btnInativar.Size = new Size(129, 50);
            btnInativar.TabIndex = 3;
            btnInativar.Text = "Inativar \r\nRegistro";
            btnInativar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(740, 135);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(129, 50);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar/Atualizar \r\nRegistro";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // dgvEsocial
            // 
            dgvEsocial.AllowUserToAddRows = false;
            dgvEsocial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEsocial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEsocial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEsocial.EnableHeadersVisualStyles = false;
            dgvEsocial.Location = new Point(3, 12);
            dgvEsocial.MultiSelect = false;
            dgvEsocial.Name = "dgvEsocial";
            dgvEsocial.ReadOnly = true;
            dgvEsocial.RowHeadersVisible = false;
            dgvEsocial.RowHeadersWidth = 51;
            dgvEsocial.RowTemplate.Height = 29;
            dgvEsocial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEsocial.Size = new Size(875, 211);
            dgvEsocial.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(762, 21);
            label14.Name = "label14";
            label14.Size = new Size(109, 38);
            label14.TabIndex = 42;
            label14.Text = "eSocial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 160);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 43;
            label2.Text = "Situação do Envio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(77, 113);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 45;
            label3.Text = "Operação";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Não se Aplica", "Alteração", "Exclusão", "Inclusão", "Original", "Retificação" });
            comboBox2.Location = new Point(158, 110);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 28);
            comboBox2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvEsocial);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(881, 226);
            panel1.TabIndex = 41;
            // 
            // Esocial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 447);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label14);
            Controls.Add(panel1);
            Controls.Add(btnEnviar);
            Controls.Add(btnInativar);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(vPsocial);
            Controls.Add(label1);
            Controls.Add(vTsocial);
            Name = "Esocial";
            Text = "eSocial";
            Load += Esocial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEsocial).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        public TextBox vPsocial;
        private Label label1;
        private TextBox vTsocial;
        private ComboBox comboBox1;
        private Button btnInativar;
        private Button btnEnviar;
        private Label label14;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private DataGridView dgvEsocial;
        private Panel panel1;
    }
}