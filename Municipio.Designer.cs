namespace FFPPRAJ
{
    partial class Municipio
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
            dgvMunicipio = new DataGridView();
            label1 = new Label();
            vMunicipio = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMunicipio).BeginInit();
            SuspendLayout();
            // 
            // dgvMunicipio
            // 
            dgvMunicipio.AllowUserToAddRows = false;
            dgvMunicipio.AllowUserToDeleteRows = false;
            dgvMunicipio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMunicipio.Location = new Point(12, 55);
            dgvMunicipio.MultiSelect = false;
            dgvMunicipio.Name = "dgvMunicipio";
            dgvMunicipio.ReadOnly = true;
            dgvMunicipio.RowHeadersVisible = false;
            dgvMunicipio.RowHeadersWidth = 51;
            dgvMunicipio.RowTemplate.Height = 29;
            dgvMunicipio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMunicipio.Size = new Size(455, 435);
            dgvMunicipio.StandardTab = true;
            dgvMunicipio.TabIndex = 3;
            dgvMunicipio.TabStop = false;
            dgvMunicipio.SelectionChanged += dgvMunicipio_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 23;
            label1.Text = "Município";
            // 
            // vMunicipio
            // 
            vMunicipio.Location = new Point(173, 13);
            vMunicipio.Name = "vMunicipio";
            vMunicipio.ReadOnly = true;
            vMunicipio.Size = new Size(181, 27);
            vMunicipio.TabIndex = 2;
            vMunicipio.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(106, 501);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 40);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(242, 501);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Municipio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 553);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(vMunicipio);
            Controls.Add(label1);
            Controls.Add(dgvMunicipio);
            Name = "Municipio";
            Text = "Municipio";
            Load += Municipio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMunicipio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMunicipio;
        private Label label1;
        private Button btnSalvar;
        private Button btnCancelar;
        public TextBox vMunicipio;
    }
}