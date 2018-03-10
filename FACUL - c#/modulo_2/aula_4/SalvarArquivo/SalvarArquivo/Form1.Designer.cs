namespace SalvarArquivo
{
    partial class SalvarArquivoForm
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
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.produtosListBox = new System.Windows.Forms.ListBox();
            this.produtosLabel = new System.Windows.Forms.Label();
            this.produtosTextBox = new System.Windows.Forms.TextBox();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(40, 20);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(36, 13);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(82, 17);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(171, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(40, 48);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(34, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(82, 48);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(171, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // produtosListBox
            // 
            this.produtosListBox.FormattingEnabled = true;
            this.produtosListBox.Location = new System.Drawing.Point(43, 127);
            this.produtosListBox.Name = "produtosListBox";
            this.produtosListBox.Size = new System.Drawing.Size(209, 134);
            this.produtosListBox.TabIndex = 7;
            // 
            // produtosLabel
            // 
            this.produtosLabel.AutoSize = true;
            this.produtosLabel.Location = new System.Drawing.Point(41, 75);
            this.produtosLabel.Name = "produtosLabel";
            this.produtosLabel.Size = new System.Drawing.Size(51, 13);
            this.produtosLabel.TabIndex = 4;
            this.produtosLabel.Text = "produtos:";
            // 
            // produtosTextBox
            // 
            this.produtosTextBox.Location = new System.Drawing.Point(98, 72);
            this.produtosTextBox.Name = "produtosTextBox";
            this.produtosTextBox.Size = new System.Drawing.Size(154, 20);
            this.produtosTextBox.TabIndex = 5;
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(44, 98);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(209, 23);
            this.adicionarButton.TabIndex = 6;
            this.adicionarButton.Text = "Adicionar Produto";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(44, 267);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(208, 56);
            this.salvarButton.TabIndex = 8;
            this.salvarButton.Text = "salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // SalvarArquivoForm
            // 
            this.AcceptButton = this.adicionarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 356);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.produtosTextBox);
            this.Controls.Add(this.produtosLabel);
            this.Controls.Add(this.produtosListBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SalvarArquivoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ListBox produtosListBox;
        private System.Windows.Forms.Label produtosLabel;
        private System.Windows.Forms.TextBox produtosTextBox;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.Button salvarButton;
    }
}

