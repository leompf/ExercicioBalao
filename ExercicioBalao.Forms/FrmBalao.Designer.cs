namespace ExercicioBalao.Forms
{
    partial class FrmBalao
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
            lblMensagem = new Label();
            btnConstruir = new Button();
            lblCor = new Label();
            grpboxBalao = new GroupBox();
            lblDirecao = new Label();
            rbtnSul = new RadioButton();
            rbtnEste = new RadioButton();
            rbtnNorte = new RadioButton();
            rbtnOeste = new RadioButton();
            btnDescer = new Button();
            label2 = new Label();
            lblAltura = new Label();
            label1 = new Label();
            btnAumentaAltura = new Button();
            btnDiminuiAltura = new Button();
            btnMudarCor = new Button();
            cbbCor = new ComboBox();
            grpboxBalao.SuspendLayout();
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.Location = new Point(49, 90);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 17);
            lblMensagem.TabIndex = 0;
            // 
            // btnConstruir
            // 
            btnConstruir.Location = new Point(638, 374);
            btnConstruir.Name = "btnConstruir";
            btnConstruir.Size = new Size(122, 42);
            btnConstruir.TabIndex = 1;
            btnConstruir.Text = "Construir Balão";
            btnConstruir.UseVisualStyleBackColor = true;
            btnConstruir.Click += btnConstruir_Click;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCor.Location = new Point(49, 43);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(38, 20);
            lblCor.TabIndex = 2;
            lblCor.Text = "Cor:";
            // 
            // grpboxBalao
            // 
            grpboxBalao.Controls.Add(lblDirecao);
            grpboxBalao.Controls.Add(rbtnSul);
            grpboxBalao.Controls.Add(rbtnEste);
            grpboxBalao.Controls.Add(rbtnNorte);
            grpboxBalao.Controls.Add(rbtnOeste);
            grpboxBalao.Controls.Add(btnDescer);
            grpboxBalao.Controls.Add(label2);
            grpboxBalao.Controls.Add(lblAltura);
            grpboxBalao.Controls.Add(label1);
            grpboxBalao.Controls.Add(btnAumentaAltura);
            grpboxBalao.Controls.Add(btnDiminuiAltura);
            grpboxBalao.Enabled = false;
            grpboxBalao.Location = new Point(49, 143);
            grpboxBalao.Name = "grpboxBalao";
            grpboxBalao.Size = new Size(497, 148);
            grpboxBalao.TabIndex = 4;
            grpboxBalao.TabStop = false;
            grpboxBalao.Text = "Estado do Balão";
            // 
            // lblDirecao
            // 
            lblDirecao.AutoSize = true;
            lblDirecao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDirecao.Location = new Point(24, 118);
            lblDirecao.Name = "lblDirecao";
            lblDirecao.Size = new Size(0, 20);
            lblDirecao.TabIndex = 10;
            // 
            // rbtnSul
            // 
            rbtnSul.AutoSize = true;
            rbtnSul.Enabled = false;
            rbtnSul.Location = new Point(278, 86);
            rbtnSul.Name = "rbtnSul";
            rbtnSul.Size = new Size(41, 19);
            rbtnSul.TabIndex = 9;
            rbtnSul.TabStop = true;
            rbtnSul.Text = "Sul";
            rbtnSul.UseVisualStyleBackColor = true;
            rbtnSul.CheckedChanged += RadioButton_CheckedChanged;
            rbtnSul.EnabledChanged += RadioButton_EnabledChanged;
            // 
            // rbtnEste
            // 
            rbtnEste.AutoSize = true;
            rbtnEste.Enabled = false;
            rbtnEste.Location = new Point(226, 86);
            rbtnEste.Name = "rbtnEste";
            rbtnEste.Size = new Size(46, 19);
            rbtnEste.TabIndex = 8;
            rbtnEste.TabStop = true;
            rbtnEste.Text = "Este";
            rbtnEste.UseVisualStyleBackColor = true;
            rbtnEste.CheckedChanged += RadioButton_CheckedChanged;
            rbtnEste.EnabledChanged += RadioButton_EnabledChanged;
            // 
            // rbtnNorte
            // 
            rbtnNorte.AutoSize = true;
            rbtnNorte.Enabled = false;
            rbtnNorte.Location = new Point(164, 86);
            rbtnNorte.Name = "rbtnNorte";
            rbtnNorte.Size = new Size(55, 19);
            rbtnNorte.TabIndex = 7;
            rbtnNorte.TabStop = true;
            rbtnNorte.Text = "Norte";
            rbtnNorte.UseVisualStyleBackColor = true;
            rbtnNorte.CheckedChanged += RadioButton_CheckedChanged;
            rbtnNorte.EnabledChanged += RadioButton_EnabledChanged;
            // 
            // rbtnOeste
            // 
            rbtnOeste.AutoSize = true;
            rbtnOeste.Enabled = false;
            rbtnOeste.Location = new Point(104, 86);
            rbtnOeste.Name = "rbtnOeste";
            rbtnOeste.Size = new Size(55, 19);
            rbtnOeste.TabIndex = 6;
            rbtnOeste.TabStop = true;
            rbtnOeste.Text = "Oeste";
            rbtnOeste.UseVisualStyleBackColor = true;
            rbtnOeste.CheckedChanged += RadioButton_CheckedChanged;
            rbtnOeste.EnabledChanged += RadioButton_EnabledChanged;
            // 
            // btnDescer
            // 
            btnDescer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDescer.Location = new Point(287, 41);
            btnDescer.Name = "btnDescer";
            btnDescer.Size = new Size(119, 23);
            btnDescer.TabIndex = 5;
            btnDescer.Text = "Descer até ao solo";
            btnDescer.UseVisualStyleBackColor = true;
            btnDescer.Click += btnDescer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 83);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Direção: ";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAltura.Location = new Point(164, 45);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(13, 17);
            lblAltura.TabIndex = 3;
            lblAltura.Text = "-";
            lblAltura.TextChanged += lblAltura_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Altura:";
            // 
            // btnAumentaAltura
            // 
            btnAumentaAltura.BackColor = Color.WhiteSmoke;
            btnAumentaAltura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAumentaAltura.Location = new Point(206, 36);
            btnAumentaAltura.Name = "btnAumentaAltura";
            btnAumentaAltura.Size = new Size(54, 29);
            btnAumentaAltura.TabIndex = 1;
            btnAumentaAltura.Text = "+";
            btnAumentaAltura.UseVisualStyleBackColor = false;
            btnAumentaAltura.Click += btnAumentaAltura_Click;
            // 
            // btnDiminuiAltura
            // 
            btnDiminuiAltura.BackColor = Color.WhiteSmoke;
            btnDiminuiAltura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiminuiAltura.Location = new Point(87, 36);
            btnDiminuiAltura.Name = "btnDiminuiAltura";
            btnDiminuiAltura.Size = new Size(54, 29);
            btnDiminuiAltura.TabIndex = 0;
            btnDiminuiAltura.Text = "-";
            btnDiminuiAltura.UseVisualStyleBackColor = false;
            btnDiminuiAltura.Click += btnDiminuiAltura_Click;
            // 
            // btnMudarCor
            // 
            btnMudarCor.Enabled = false;
            btnMudarCor.Location = new Point(222, 44);
            btnMudarCor.Name = "btnMudarCor";
            btnMudarCor.Size = new Size(75, 23);
            btnMudarCor.TabIndex = 5;
            btnMudarCor.Text = "Mudar cor";
            btnMudarCor.UseVisualStyleBackColor = true;
            btnMudarCor.Click += btnMudarCor_Click;
            // 
            // cbbCor
            // 
            cbbCor.FormattingEnabled = true;
            cbbCor.Location = new Point(86, 44);
            cbbCor.Name = "cbbCor";
            cbbCor.Size = new Size(121, 23);
            cbbCor.TabIndex = 6;
            // 
            // FrmBalao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbbCor);
            Controls.Add(btnMudarCor);
            Controls.Add(grpboxBalao);
            Controls.Add(lblCor);
            Controls.Add(btnConstruir);
            Controls.Add(lblMensagem);
            Name = "FrmBalao";
            Text = "Balão";
            grpboxBalao.ResumeLayout(false);
            grpboxBalao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensagem;
        private Button btnConstruir;
        private Label lblCor;
        private GroupBox grpboxBalao;
        private Button btnDiminuiAltura;
        private Label lblAltura;
        private Label label1;
        private Button btnAumentaAltura;
        private Button btnMudarCor;
        private ComboBox cbbCor;
        private Button btnDescer;
        private Label label2;
        private Label lblDirecao;
        private RadioButton rbtnSul;
        private RadioButton rbtnEste;
        private RadioButton rbtnNorte;
        private RadioButton rbtnOeste;
    }
}
