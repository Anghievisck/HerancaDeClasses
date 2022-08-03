namespace heranca_de_classes
{
    partial class frmCadastrarAluno
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
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtIdadeAluno = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblIdadeAluno = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.btnExibirAluno = new System.Windows.Forms.Button();
            this.btnVoltarAluno = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(250, 98);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(268, 20);
            this.txtNomeAluno.TabIndex = 17;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(250, 203);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(268, 20);
            this.txtCurso.TabIndex = 16;
            // 
            // txtIdadeAluno
            // 
            this.txtIdadeAluno.Location = new System.Drawing.Point(250, 153);
            this.txtIdadeAluno.Name = "txtIdadeAluno";
            this.txtIdadeAluno.Size = new System.Drawing.Size(268, 20);
            this.txtIdadeAluno.TabIndex = 15;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(181, 206);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 14;
            this.lblCurso.Text = "Curso:";
            // 
            // lblIdadeAluno
            // 
            this.lblIdadeAluno.AutoSize = true;
            this.lblIdadeAluno.Location = new System.Drawing.Point(181, 156);
            this.lblIdadeAluno.Name = "lblIdadeAluno";
            this.lblIdadeAluno.Size = new System.Drawing.Size(37, 13);
            this.lblIdadeAluno.TabIndex = 13;
            this.lblIdadeAluno.Text = "Idade:";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(181, 101);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(38, 13);
            this.lblNomeAluno.TabIndex = 12;
            this.lblNomeAluno.Text = "Nome:";
            // 
            // btnExibirAluno
            // 
            this.btnExibirAluno.Location = new System.Drawing.Point(321, 330);
            this.btnExibirAluno.Name = "btnExibirAluno";
            this.btnExibirAluno.Size = new System.Drawing.Size(159, 23);
            this.btnExibirAluno.TabIndex = 11;
            this.btnExibirAluno.Text = "Exibir";
            this.btnExibirAluno.UseVisualStyleBackColor = true;
            // 
            // btnVoltarAluno
            // 
            this.btnVoltarAluno.Location = new System.Drawing.Point(510, 330);
            this.btnVoltarAluno.Name = "btnVoltarAluno";
            this.btnVoltarAluno.Size = new System.Drawing.Size(159, 23);
            this.btnVoltarAluno.TabIndex = 10;
            this.btnVoltarAluno.Text = "Voltar";
            this.btnVoltarAluno.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(132, 330);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(159, 23);
            this.btnCadastrarAluno.TabIndex = 9;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            // 
            // frmCadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtIdadeAluno);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblIdadeAluno);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.btnExibirAluno);
            this.Controls.Add(this.btnVoltarAluno);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Name = "frmCadastrarAluno";
            this.Text = "Cadastrar Aluno";
            this.Load += new System.EventHandler(this.frmCadastrarAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtIdadeAluno;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblIdadeAluno;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Button btnExibirAluno;
        private System.Windows.Forms.Button btnVoltarAluno;
        private System.Windows.Forms.Button btnCadastrarAluno;
    }
}