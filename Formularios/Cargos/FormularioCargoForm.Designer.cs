namespace ControlePonto.Formularios.Cargos
{
    partial class FormularioCargoForm
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
            txtDescricao = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numCargaHoraria = new NumericUpDown();
            btnSalvar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCargaHoraria).BeginInit();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 117);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(395, 103);
            txtDescricao.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 1;
            label1.Text = "Descrição";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(395, 31);
            txtNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 240);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 2;
            label3.Text = "Carga Horária";
            // 
            // numCargaHoraria
            // 
            numCargaHoraria.Location = new Point(12, 268);
            numCargaHoraria.Name = "numCargaHoraria";
            numCargaHoraria.Size = new Size(395, 31);
            numCargaHoraria.TabIndex = 3;
            numCargaHoraria.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(295, 337);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(177, 337);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormularioCargoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 383);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(numCargaHoraria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(txtDescricao);
            Name = "FormularioCargoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Cargo";
            ((System.ComponentModel.ISupportInitialize)numCargaHoraria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescricao;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private NumericUpDown numCargaHoraria;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}