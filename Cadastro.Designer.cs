namespace FFPPRAJ
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalvar = new Button();
            btnCancelar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtMunicipio = new TextBox();
            btnMunicipio = new Button();
            label14 = new Label();
            txtProcesso = new TextBox();
            cbIndicativo = new ComboBox();
            label8 = new Label();
            txtChapa = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtVara = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cbUF = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cbAutoria = new ComboBox();
            cbTipo = new ComboBox();
            tabPage2 = new TabPage();
            btnIndiCancelar = new Button();
            btnIndiSalvar = new Button();
            label13 = new Label();
            label11 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(751, 419);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 40);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(878, 419);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 40);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1016, 526);
            tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(txtMunicipio);
            tabPage1.Controls.Add(btnMunicipio);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(txtProcesso);
            tabPage1.Controls.Add(cbIndicativo);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtChapa);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtVara);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cbUF);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cbAutoria);
            tabPage1.Controls.Add(cbTipo);
            tabPage1.Controls.Add(btnSalvar);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1008, 493);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(533, 180);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.ReadOnly = true;
            txtMunicipio.Size = new Size(118, 27);
            txtMunicipio.TabIndex = 38;
            txtMunicipio.TabStop = false;
            txtMunicipio.TextChanged += txtMunicipio_TextChanged;
            // 
            // btnMunicipio
            // 
            btnMunicipio.Location = new Point(681, 173);
            btnMunicipio.Name = "btnMunicipio";
            btnMunicipio.Size = new Size(164, 40);
            btnMunicipio.TabIndex = 3;
            btnMunicipio.Text = "Selecionar Município";
            btnMunicipio.UseVisualStyleBackColor = true;
            btnMunicipio.Click += btnMunicipio_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(838, 22);
            label14.Name = "label14";
            label14.Size = new Size(132, 38);
            label14.TabIndex = 36;
            label14.Text = "Cadastro";
            // 
            // txtProcesso
            // 
            txtProcesso.Location = new Point(374, 40);
            txtProcesso.Name = "txtProcesso";
            txtProcesso.Size = new Size(200, 27);
            txtProcesso.TabIndex = 0;
            // 
            // cbIndicativo
            // 
            cbIndicativo.FormattingEnabled = true;
            cbIndicativo.Items.AddRange(new object[] { "teste" });
            cbIndicativo.Location = new Point(221, 431);
            cbIndicativo.Name = "cbIndicativo";
            cbIndicativo.Size = new Size(443, 28);
            cbIndicativo.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 419);
            label8.Name = "label8";
            label8.Size = new Size(194, 40);
            label8.TabIndex = 33;
            label8.Text = "Indicativo da Matéria do \r\nProcesso ou Alvará Judicial";
            // 
            // txtChapa
            // 
            txtChapa.Location = new Point(221, 374);
            txtChapa.Name = "txtChapa";
            txtChapa.Size = new Size(82, 27);
            txtChapa.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(163, 381);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 31;
            label7.Text = "Chapa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(449, 187);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 30;
            label6.Text = "Município";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(44, 314);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 29;
            label5.Text = "Autoria da Ação Judicial";
            // 
            // txtVara
            // 
            txtVara.Location = new Point(221, 243);
            txtVara.Name = "txtVara";
            txtVara.Size = new Size(82, 27);
            txtVara.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(66, 243);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 27;
            label4.Text = "Identificação da Vara";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(189, 187);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 25;
            label3.Text = "UF";
            // 
            // cbUF
            // 
            cbUF.FormattingEnabled = true;
            cbUF.Items.AddRange(new object[] { "1" });
            cbUF.Location = new Point(221, 179);
            cbUF.Name = "cbUF";
            cbUF.Size = new Size(118, 28);
            cbUF.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(93, 111);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 23;
            label2.Text = "Tipo de Processo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(221, 43);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 22;
            label1.Text = "Número do Processo";
            // 
            // cbAutoria
            // 
            cbAutoria.FormattingEnabled = true;
            cbAutoria.Location = new Point(221, 311);
            cbAutoria.Name = "cbAutoria";
            cbAutoria.Size = new Size(151, 28);
            cbAutoria.TabIndex = 5;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(221, 111);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(200, 28);
            cbTipo.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Controls.Add(btnIndiCancelar);
            tabPage2.Controls.Add(btnIndiSalvar);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(comboBox4);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1008, 493);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Indicativo";
            // 
            // btnIndiCancelar
            // 
            btnIndiCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIndiCancelar.Location = new Point(891, 416);
            btnIndiCancelar.Name = "btnIndiCancelar";
            btnIndiCancelar.Size = new Size(94, 40);
            btnIndiCancelar.TabIndex = 21;
            btnIndiCancelar.Text = "Cancelar";
            btnIndiCancelar.UseVisualStyleBackColor = true;
            btnIndiCancelar.Click += btnIndiCancelar_Click;
            // 
            // btnIndiSalvar
            // 
            btnIndiSalvar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIndiSalvar.Location = new Point(751, 416);
            btnIndiSalvar.Name = "btnIndiSalvar";
            btnIndiSalvar.Size = new Size(94, 40);
            btnIndiSalvar.TabIndex = 20;
            btnIndiSalvar.Text = "Salvar";
            btnIndiSalvar.UseVisualStyleBackColor = true;
            btnIndiSalvar.Click += btnIndiSalvar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(838, 22);
            label13.Name = "label13";
            label13.Size = new Size(147, 38);
            label13.TabIndex = 9;
            label13.Text = "Indicativo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(73, 292);
            label11.Name = "label11";
            label11.Size = new Size(316, 20);
            label11.TabIndex = 8;
            label11.Text = "Tributo/Contribuição abrangida pela Decisão";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(77, 220);
            label12.Name = "label12";
            label12.Size = new Size(312, 20);
            label12.TabIndex = 7;
            label12.Text = "Indicativo de Depósito do Montante Integral";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(77, 153);
            label10.Name = "label10";
            label10.Size = new Size(369, 20);
            label10.TabIndex = 5;
            label10.Text = "Data da decisão, setença ou despacho administrativo\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(77, 85);
            label9.Name = "label9";
            label9.Size = new Size(154, 20);
            label9.TabIndex = 4;
            label9.Text = "Indicativo da Decisão";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Não se aplica" });
            comboBox4.Location = new Point(392, 289);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(224, 28);
            comboBox4.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Não se aplica", "Não, o depósito não foi sobre o montante integral", "Sim, o depósito foi sobre o montante integral" });
            comboBox3.Location = new Point(392, 217);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(224, 28);
            comboBox3.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "22/10/2023", "01/11/2023", "05/04/2024" });
            comboBox2.Location = new Point(452, 150);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(164, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1° Inst. não transit em julgado c/efeito suspensivo", "Antecipação da Tutela", "Contestação Administrativa FAP" });
            comboBox1.Location = new Point(235, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(381, 28);
            comboBox1.TabIndex = 0;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 564);
            Controls.Add(tabControl1);
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtProcesso;
        private ComboBox cbTipo;
        public ComboBox cbUF;
        private Button btnMunicipio;
        public TextBox txtMunicipio;
        private TextBox txtVara;
        private ComboBox cbAutoria;
        private TextBox txtChapa;
        private ComboBox cbIndicativo;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label12;
        private Label label10;
        private Label label9;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label14;
        private Label label13;
        private Label label11;
        private Button btnIndiCancelar;
        private Button btnIndiSalvar;
    }
}