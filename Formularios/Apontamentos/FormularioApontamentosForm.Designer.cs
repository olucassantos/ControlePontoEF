namespace ControlePonto.Formularios.Apontamentos
{
    partial class FormularioApontamentosForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnCancela = new Button();
            btnAprova = new Button();
            lblNomeFuncionario = new Label();
            imageFunc = new PictureBox();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            txtMatricula = new TextBox();
            btnSete = new Button();
            btnOito = new Button();
            btnConfirma = new Button();
            btnNove = new Button();
            btnZero = new Button();
            btnQuatro = new Button();
            btnLimpa = new Button();
            btnCinco = new Button();
            btnTres = new Button();
            btnSeis = new Button();
            btnDois = new Button();
            btnUm = new Button();
            timer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageFunc).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76.66666F));
            tableLayoutPanel1.Size = new Size(800, 659);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancela);
            panel1.Controls.Add(btnAprova);
            panel1.Controls.Add(lblNomeFuncionario);
            panel1.Controls.Add(imageFunc);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(339, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 500);
            panel1.TabIndex = 2;
            // 
            // btnCancela
            // 
            btnCancela.Location = new Point(118, 354);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(105, 85);
            btnCancela.TabIndex = 2;
            btnCancela.Text = "Cancelar";
            btnCancela.UseVisualStyleBackColor = true;
            // 
            // btnAprova
            // 
            btnAprova.Location = new Point(236, 354);
            btnAprova.Name = "btnAprova";
            btnAprova.Size = new Size(105, 85);
            btnAprova.TabIndex = 2;
            btnAprova.Text = "Aprovar";
            btnAprova.UseVisualStyleBackColor = true;
            btnAprova.Click += btnAprova_Click;
            // 
            // lblNomeFuncionario
            // 
            lblNomeFuncionario.AutoSize = true;
            lblNomeFuncionario.Font = new Font("Segoe UI", 13F);
            lblNomeFuncionario.Location = new Point(116, 281);
            lblNomeFuncionario.Name = "lblNomeFuncionario";
            lblNomeFuncionario.Size = new Size(226, 36);
            lblNomeFuncionario.TabIndex = 1;
            lblNomeFuncionario.Text = "Nome Funcionario";
            lblNomeFuncionario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // imageFunc
            // 
            imageFunc.Location = new Point(118, 3);
            imageFunc.Name = "imageFunc";
            imageFunc.Size = new Size(223, 238);
            imageFunc.TabIndex = 0;
            imageFunc.TabStop = false;
            // 
            // panel3
            // 
            tableLayoutPanel1.SetColumnSpan(panel3, 2);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(794, 147);
            panel3.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 15F);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy H:mm:ss";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Segoe UI", 40F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(9, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.Size = new Size(776, 114);
            dateTimePicker1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtMatricula);
            panel2.Controls.Add(btnSete);
            panel2.Controls.Add(btnOito);
            panel2.Controls.Add(btnConfirma);
            panel2.Controls.Add(btnNove);
            panel2.Controls.Add(btnZero);
            panel2.Controls.Add(btnQuatro);
            panel2.Controls.Add(btnLimpa);
            panel2.Controls.Add(btnCinco);
            panel2.Controls.Add(btnTres);
            panel2.Controls.Add(btnSeis);
            panel2.Controls.Add(btnDois);
            panel2.Controls.Add(btnUm);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 500);
            panel2.TabIndex = 4;
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 15F);
            txtMatricula.Location = new Point(18, 21);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(294, 47);
            txtMatricula.TabIndex = 12;
            txtMatricula.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(18, 75);
            btnSete.Margin = new Padding(3, 4, 3, 4);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(94, 95);
            btnSete.TabIndex = 0;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(118, 75);
            btnOito.Margin = new Padding(3, 4, 3, 4);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(94, 95);
            btnOito.TabIndex = 1;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnConfirma
            // 
            btnConfirma.Location = new Point(218, 384);
            btnConfirma.Margin = new Padding(3, 4, 3, 4);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(94, 95);
            btnConfirma.TabIndex = 11;
            btnConfirma.Text = "OK";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(218, 75);
            btnNove.Margin = new Padding(3, 4, 3, 4);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(94, 95);
            btnNove.TabIndex = 2;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(118, 384);
            btnZero.Margin = new Padding(3, 4, 3, 4);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(94, 95);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(18, 178);
            btnQuatro.Margin = new Padding(3, 4, 3, 4);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(94, 95);
            btnQuatro.TabIndex = 3;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnLimpa
            // 
            btnLimpa.Location = new Point(18, 384);
            btnLimpa.Margin = new Padding(3, 4, 3, 4);
            btnLimpa.Name = "btnLimpa";
            btnLimpa.Size = new Size(94, 95);
            btnLimpa.TabIndex = 9;
            btnLimpa.Text = "C";
            btnLimpa.UseVisualStyleBackColor = true;
            btnLimpa.Click += btnLimpa_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(118, 178);
            btnCinco.Margin = new Padding(3, 4, 3, 4);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(94, 95);
            btnCinco.TabIndex = 4;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(218, 281);
            btnTres.Margin = new Padding(3, 4, 3, 4);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(94, 95);
            btnTres.TabIndex = 8;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(218, 178);
            btnSeis.Margin = new Padding(3, 4, 3, 4);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(94, 95);
            btnSeis.TabIndex = 5;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(118, 281);
            btnDois.Margin = new Padding(3, 4, 3, 4);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(94, 95);
            btnDois.TabIndex = 7;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(18, 281);
            btnUm.Margin = new Padding(3, 4, 3, 4);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(94, 95);
            btnUm.TabIndex = 6;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // FormularioApontamentosForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 659);
            Controls.Add(tableLayoutPanel1);
            Name = "FormularioApontamentosForm";
            Text = "Apontamentos";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageFunc).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnConfirma;
        private Panel panel1;
        private Panel panel3;
        private Button btnCancela;
        private Button btnAprova;
        private Label lblNomeFuncionario;
        private PictureBox imageFunc;
        private Panel panel2;
        private TextBox txtMatricula;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer;
    }
}