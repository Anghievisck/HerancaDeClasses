namespace heranca_de_classes
{
    partial class frmHome
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
            this.btnCadastProf = new System.Windows.Forms.Button();
            this.btnCadastAluno = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastProf
            // 
            this.btnCadastProf.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastProf.Location = new System.Drawing.Point(143, 171);
            this.btnCadastProf.Name = "btnCadastProf";
            this.btnCadastProf.Size = new System.Drawing.Size(144, 33);
            this.btnCadastProf.TabIndex = 0;
            this.btnCadastProf.Text = "Cadastrar Professor";
            this.btnCadastProf.UseVisualStyleBackColor = true;
            this.btnCadastProf.Click += new System.EventHandler(this.btnCadastProf_Click);
            // 
            // btnCadastAluno
            // 
            this.btnCadastAluno.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastAluno.Location = new System.Drawing.Point(317, 171);
            this.btnCadastAluno.Name = "btnCadastAluno";
            this.btnCadastAluno.Size = new System.Drawing.Size(141, 33);
            this.btnCadastAluno.TabIndex = 1;
            this.btnCadastAluno.Text = "Cadastrar Aluno";
            this.btnCadastAluno.UseVisualStyleBackColor = true;
            this.btnCadastAluno.Click += new System.EventHandler(this.btnCadastAluno_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(480, 171);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(144, 33);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastAluno);
            this.Controls.Add(this.btnCadastProf);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastProf;
        private System.Windows.Forms.Button btnCadastAluno;
        private System.Windows.Forms.Button btnSair;
    }
}