namespace WindowsFormsApp1
{
    partial class Lab01Form
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
            this.cursoLabel = new System.Windows.Forms.Label();
            this.mensagemLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cursoComboBox = new System.Windows.Forms.ComboBox();
            this.exibirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(35, 33);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(43, 13);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "&Nome:";
            // 
            // cursoLabel
            // 
            this.cursoLabel.AutoSize = true;
            this.cursoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursoLabel.Location = new System.Drawing.Point(35, 83);
            this.cursoLabel.Name = "cursoLabel";
            this.cursoLabel.Size = new System.Drawing.Size(43, 13);
            this.cursoLabel.TabIndex = 2;
            this.cursoLabel.Text = "&Curso:";
            // 
            // mensagemLabel
            // 
            this.mensagemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mensagemLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mensagemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagemLabel.Location = new System.Drawing.Point(38, 168);
            this.mensagemLabel.Name = "mensagemLabel";
            this.mensagemLabel.Size = new System.Drawing.Size(354, 84);
            this.mensagemLabel.TabIndex = 5;
            this.mensagemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeTextBox.Location = new System.Drawing.Point(84, 30);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(308, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // cursoComboBox
            // 
            this.cursoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cursoComboBox.FormattingEnabled = true;
            this.cursoComboBox.Items.AddRange(new object[] {
            "C#",
            "Delphi",
            "Java",
            "VB NET"});
            this.cursoComboBox.Location = new System.Drawing.Point(84, 80);
            this.cursoComboBox.Name = "cursoComboBox";
            this.cursoComboBox.Size = new System.Drawing.Size(308, 21);
            this.cursoComboBox.Sorted = true;
            this.cursoComboBox.TabIndex = 3;
            // 
            // exibirButton
            // 
            this.exibirButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exibirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibirButton.Location = new System.Drawing.Point(38, 117);
            this.exibirButton.Name = "exibirButton";
            this.exibirButton.Size = new System.Drawing.Size(354, 35);
            this.exibirButton.TabIndex = 4;
            this.exibirButton.Text = "Exibir";
            this.exibirButton.UseVisualStyleBackColor = true;
            this.exibirButton.Click += new System.EventHandler(this.exibirButton_Click);
            // 
            // Lab01Form
            // 
            this.AcceptButton = this.exibirButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.exibirButton);
            this.Controls.Add(this.cursoComboBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.mensagemLabel);
            this.Controls.Add(this.cursoLabel);
            this.Controls.Add(this.nomeLabel);
            this.Name = "Lab01Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label cursoLabel;
        private System.Windows.Forms.Label mensagemLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ComboBox cursoComboBox;
        private System.Windows.Forms.Button exibirButton;
    }
}

