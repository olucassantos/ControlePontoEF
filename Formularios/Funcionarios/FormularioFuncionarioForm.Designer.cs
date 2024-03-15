using ControlePonto.Componentes;

namespace ControlePonto.Formularios.Funcionarios
{
    partial class FormularioFuncionarioForm
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
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtCPF = new MaskedTextBox();
            dateDataNascimento = new DateTimePicker();
            label4 = new Label();
            txtMatricula = new TextBox();
            label5 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            cmbCargos = new ComboBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 98);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(762, 31);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 143);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 5;
            label1.Text = "Data Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 143);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 7;
            label3.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(385, 171);
            txtCPF.Mask = "999.999.999-99";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(389, 31);
            txtCPF.TabIndex = 8;
            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // dateDataNascimento
            // 
            dateDataNascimento.Format = DateTimePickerFormat.Short;
            dateDataNascimento.Location = new Point(12, 171);
            dateDataNascimento.Name = "dateDataNascimento";
            dateDataNascimento.Size = new Size(367, 31);
            dateDataNascimento.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 222);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 11;
            label4.Text = "Cargo";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(12, 250);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(367, 31);
            txtMatricula.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 222);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 11;
            label5.Text = "Matricula";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(544, 332);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(662, 332);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cmbCargos
            // 
            cmbCargos.FormattingEnabled = true;
            cmbCargos.Location = new Point(385, 250);
            cmbCargos.Name = "cmbCargos";
            cmbCargos.Size = new Size(389, 33);
            cmbCargos.TabIndex = 15;
            // 
            // FormularioFuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 378);
            Controls.Add(cmbCargos);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label5);
            Controls.Add(txtMatricula);
            Controls.Add(label4);
            Controls.Add(dateDataNascimento);
            Controls.Add(txtCPF);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Name = "FormularioFuncionarioForm";
            Text = "Cadastro Funcionário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private Label label3;
        private MaskedTextBox txtCPF;
        private DateTimePicker dateDataNascimento;
        private Label label4;
        private TextBox txtMatricula;
        private Label label5;
        private Button btnCancelar;
        private Button btnSalvar;
        private ComboBox cmbCargos;
    }
}