namespace MVCTP1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btEntrar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(140, 227);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(100, 23);
            this.btEntrar.TabIndex = 0;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click_1);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(137, 91);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(40, 16);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(140, 120);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 22);
            this.txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(140, 187);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 22);
            this.txtSenha.TabIndex = 4;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(137, 158);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 16);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Senha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 319);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btEntrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbEmail;
    }
}

