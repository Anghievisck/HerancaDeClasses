namespace heranca_de_classes
{
    partial class frmCadastroProfessor
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
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.txtTitulacao = new System.Windows.Forms.TextBox();
            this.txtIdadeProf = new System.Windows.Forms.TextBox();
            this.lblTitulacao = new System.Windows.Forms.Label();
            this.lblIdadeProf = new System.Windows.Forms.Label();
            this.lblNomeProf = new System.Windows.Forms.Label();
            this.btnExibirProf = new System.Windows.Forms.Button();
            this.btnVoltarProf = new System.Windows.Forms.Button();
            this.btnCadastrarProf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Location = new System.Drawing.Point(250, 98);
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.Size = new System.Drawing.Size(268, 20);
            this.txtNomeProf.TabIndex = 17;
            // 
            // txtTitulacao
            // 
            this.txtTitulacao.Location = new System.Drawing.Point(250, 203);
            this.txtTitulacao.Name = "txtTitulacao";
            this.txtTitulacao.Size = new System.Drawing.Size(268, 20);
            this.txtTitulacao.TabIndex = 16;
            // 
            // txtIdadeProf
            // 
            this.txtIdadeProf.Location = new System.Drawing.Point(250, 153);
            this.txtIdadeProf.Name = "txtIdadeProf";
            this.txtIdadeProf.Size = new System.Drawing.Size(268, 20);
            this.txtIdadeProf.TabIndex = 15;
            // 
            // lblTitulacao
            // 
            this.lblTitulacao.AutoSize = true;
            this.lblTitulacao.Location = new System.Drawing.Point(181, 206);
            this.lblTitulacao.Name = "lblTitulacao";
            this.lblTitulacao.Size = new System.Drawing.Size(54, 13);
            this.lblTitulacao.TabIndex = 14;
            this.lblTitulacao.Text = "Titulação:";
            // 
            // lblIdadeProf
            // 
            this.lblIdadeProf.AutoSize = true;
            this.lblIdadeProf.Location = new System.Drawing.Point(181, 156);
            this.lblIdadeProf.Name = "lblIdadeProf";
            this.lblIdadeProf.Size = new System.Drawing.Size(37, 13);
            this.lblIdadeProf.TabIndex = 13;
            this.lblIdadeProf.Text = "Idade:";
            // 
            // lblNomeProf
            // 
            this.lblNomeProf.AutoSize = true;
            this.lblNomeProf.Location = new System.Drawing.Point(181, 101);
            this.lblNomeProf.Name = "lblNomeProf";
            this.lblNomeProf.Size = new System.Drawing.Size(38, 13);
            this.lblNomeProf.TabIndex = 12;
            this.lblNomeProf.Text = "Nome:";
            // 
            // btnExibirProf
            // 
            this.btnExibirProf.Location = new System.Drawing.Point(321, 330);
            this.btnExibirProf.Name = "btnExibirProf";
            this.btnExibirProf.Size = new System.Drawing.Size(159, 23);
            this.btnExibirProf.TabIndex = 11;
            this.btnExibirProf.Text = "Exibir";
            this.btnExibirProf.UseVisualStyleBackColor = true;
            // 
            // btnVoltarProf
            // 
            this.btnVoltarProf.Location = new System.Drawing.Point(510, 330);
            this.btnVoltarProf.Name = "btnVoltarProf";
            this.btnVoltarProf.Size = new System.Drawing.Size(159, 23);
            this.btnVoltarProf.TabIndex = 10;
            this.btnVoltarProf.Text = "Voltar";
            this.btnVoltarProf.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarProf
            // 
            this.btnCadastrarProf.Location = new System.Drawing.Point(132, 330);
            this.btnCadastrarProf.Name = "btnCadastrarProf";
            this.btnCadastrarProf.Size = new System.Drawing.Size(159, 23);
            this.btnCadastrarProf.TabIndex = 9;
            this.btnCadastrarProf.Text = "Cadastrar";
            this.btnCadastrarProf.UseVisualStyleBackColor = true;
            // 
            // frmCadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomeProf);
            this.Controls.Add(this.txtTitulacao);
            this.Controls.Add(this.txtIdadeProf);
            this.Controls.Add(this.lblTitulacao);
            this.Controls.Add(this.lblIdadeProf);
            this.Controls.Add(this.lblNomeProf);
            this.Controls.Add(this.btnExibirProf);
            this.Controls.Add(this.btnVoltarProf);
            this.Controls.Add(this.btnCadastrarProf);
            this.Name = "frmCadastroProfessor";
            this.Text = "Cadastrar Professor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeProf;
        private System.Windows.Forms.TextBox txtTitulacao;
        private System.Windows.Forms.TextBox txtIdadeProf;
        private System.Windows.Forms.Label lblTitulacao;
        private System.Windows.Forms.Label lblIdadeProf;
        private System.Windows.Forms.Label lblNomeProf;
        private System.Windows.Forms.Button btnExibirProf;
        private System.Windows.Forms.Button btnVoltarProf;
        private System.Windows.Forms.Button btnCadastrarProf;
    }
}