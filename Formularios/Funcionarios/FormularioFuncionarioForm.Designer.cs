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
            components = new System.ComponentModel.Container();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            cargosComboBox1 = new CargosComboBox(components);
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
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(385, 171);
            maskedTextBox1.Mask = "000.000.000-000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(389, 31);
            maskedTextBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(12, 171);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(367, 31);
            dateTimePicker1.TabIndex = 9;
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
            // textBox2
            // 
            textBox2.Location = new Point(12, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(367, 31);
            textBox2.TabIndex = 10;
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
            // cargosComboBox1
            // 
            cargosComboBox1.FormattingEnabled = true;
            cargosComboBox1.Location = new Point(385, 250);
            cargosComboBox1.Name = "cargosComboBox1";
            cargosComboBox1.Size = new Size(389, 33);
            cargosComboBox1.TabIndex = 15;
            // 
            // FormularioFuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 378);
            Controls.Add(cargosComboBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(maskedTextBox1);
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
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Button btnCancelar;
        private Button btnSalvar;
        private CargosComboBox cargosComboBox1;
    }
}