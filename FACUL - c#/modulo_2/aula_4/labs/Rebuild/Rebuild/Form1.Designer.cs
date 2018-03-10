namespace Rebuild
{
    partial class personagemForm
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
            this.proLabel = new System.Windows.Forms.Label();
            this.raçaLabel = new System.Windows.Forms.Label();
            this.classeLabel = new System.Windows.Forms.Label();
            this.profissaoComboBox = new System.Windows.Forms.ComboBox();
            this.raçaComboBox = new System.Windows.Forms.ComboBox();
            this.classeComboBox = new System.Windows.Forms.ComboBox();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.obsLabel = new System.Windows.Forms.Label();
            this.contagemLabel = new System.Windows.Forms.Label();
            this.salvarButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.strTextBox = new System.Windows.Forms.TextBox();
            this.dexTextBox = new System.Windows.Forms.TextBox();
            this.strLabel = new System.Windows.Forms.Label();
            this.vitLabel = new System.Windows.Forms.Label();
            this.intTextBox = new System.Windows.Forms.TextBox();
            this.vitTextBox = new System.Windows.Forms.TextBox();
            this.IntLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(119, 18);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(43, 13);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(163, 15);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // proLabel
            // 
            this.proLabel.AutoSize = true;
            this.proLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proLabel.Location = new System.Drawing.Point(176, 136);
            this.proLabel.Name = "proLabel";
            this.proLabel.Size = new System.Drawing.Size(67, 13);
            this.proLabel.TabIndex = 14;
            this.proLabel.Text = "Profissão :";
            // 
            // raçaLabel
            // 
            this.raçaLabel.AutoSize = true;
            this.raçaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raçaLabel.Location = new System.Drawing.Point(198, 71);
            this.raçaLabel.Name = "raçaLabel";
            this.raçaLabel.Size = new System.Drawing.Size(45, 13);
            this.raçaLabel.TabIndex = 10;
            this.raçaLabel.Text = "Raça :";
            // 
            // classeLabel
            // 
            this.classeLabel.AutoSize = true;
            this.classeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classeLabel.Location = new System.Drawing.Point(191, 101);
            this.classeLabel.Name = "classeLabel";
            this.classeLabel.Size = new System.Drawing.Size(52, 13);
            this.classeLabel.TabIndex = 12;
            this.classeLabel.Text = "Classe :";
            // 
            // profissaoComboBox
            // 
            this.profissaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profissaoComboBox.FormattingEnabled = true;
            this.profissaoComboBox.Location = new System.Drawing.Point(249, 132);
            this.profissaoComboBox.Name = "profissaoComboBox";
            this.profissaoComboBox.Size = new System.Drawing.Size(121, 21);
            this.profissaoComboBox.TabIndex = 15;
            // 
            // raçaComboBox
            // 
            this.raçaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raçaComboBox.FormattingEnabled = true;
            this.raçaComboBox.Location = new System.Drawing.Point(249, 68);
            this.raçaComboBox.Name = "raçaComboBox";
            this.raçaComboBox.Size = new System.Drawing.Size(121, 21);
            this.raçaComboBox.TabIndex = 11;
            // 
            // classeComboBox
            // 
            this.classeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classeComboBox.FormattingEnabled = true;
            this.classeComboBox.Location = new System.Drawing.Point(249, 98);
            this.classeComboBox.Name = "classeComboBox";
            this.classeComboBox.Size = new System.Drawing.Size(121, 21);
            this.classeComboBox.TabIndex = 13;
            // 
            // obsTextBox
            // 
            this.obsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obsTextBox.Location = new System.Drawing.Point(12, 211);
            this.obsTextBox.MaxLength = 300;
            this.obsTextBox.Multiline = true;
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(387, 94);
            this.obsTextBox.TabIndex = 18;
            this.obsTextBox.TextChanged += new System.EventHandler(this.obsTextBox_TextChanged);
            // 
            // obsLabel
            // 
            this.obsLabel.AutoSize = true;
            this.obsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obsLabel.Location = new System.Drawing.Point(12, 195);
            this.obsLabel.Name = "obsLabel";
            this.obsLabel.Size = new System.Drawing.Size(83, 13);
            this.obsLabel.TabIndex = 16;
            this.obsLabel.Text = "Observação :";
            // 
            // contagemLabel
            // 
            this.contagemLabel.AutoSize = true;
            this.contagemLabel.Location = new System.Drawing.Point(312, 195);
            this.contagemLabel.Name = "contagemLabel";
            this.contagemLabel.Size = new System.Drawing.Size(82, 13);
            this.contagemLabel.TabIndex = 17;
            this.contagemLabel.Text = "Restantes : 300";
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(12, 311);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(387, 50);
            this.salvarButton.TabIndex = 19;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultadoLabel.Location = new System.Drawing.Point(163, 364);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(76, 15);
            this.resultadoLabel.TabIndex = 20;
            this.resultadoLabel.Text = "Aguardando...";
            this.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dexLabel
            // 
            this.dexLabel.AutoSize = true;
            this.dexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexLabel.Location = new System.Drawing.Point(24, 123);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(40, 13);
            this.dexLabel.TabIndex = 6;
            this.dexLabel.Text = "DEX :";
            // 
            // strTextBox
            // 
            this.strTextBox.Location = new System.Drawing.Point(68, 94);
            this.strTextBox.Name = "strTextBox";
            this.strTextBox.Size = new System.Drawing.Size(100, 20);
            this.strTextBox.TabIndex = 5;
            // 
            // dexTextBox
            // 
            this.dexTextBox.Location = new System.Drawing.Point(68, 120);
            this.dexTextBox.Name = "dexTextBox";
            this.dexTextBox.Size = new System.Drawing.Size(100, 20);
            this.dexTextBox.TabIndex = 7;
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strLabel.Location = new System.Drawing.Point(24, 97);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(40, 13);
            this.strLabel.TabIndex = 4;
            this.strLabel.Text = "STR :";
            // 
            // vitLabel
            // 
            this.vitLabel.AutoSize = true;
            this.vitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vitLabel.Location = new System.Drawing.Point(24, 149);
            this.vitLabel.Name = "vitLabel";
            this.vitLabel.Size = new System.Drawing.Size(35, 13);
            this.vitLabel.TabIndex = 8;
            this.vitLabel.Text = "VIT :";
            // 
            // intTextBox
            // 
            this.intTextBox.Location = new System.Drawing.Point(68, 68);
            this.intTextBox.Name = "intTextBox";
            this.intTextBox.Size = new System.Drawing.Size(100, 20);
            this.intTextBox.TabIndex = 3;
            // 
            // vitTextBox
            // 
            this.vitTextBox.Location = new System.Drawing.Point(68, 146);
            this.vitTextBox.Name = "vitTextBox";
            this.vitTextBox.Size = new System.Drawing.Size(100, 20);
            this.vitTextBox.TabIndex = 9;
            // 
            // IntLabel
            // 
            this.IntLabel.AutoSize = true;
            this.IntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntLabel.Location = new System.Drawing.Point(24, 71);
            this.IntLabel.Name = "IntLabel";
            this.IntLabel.Size = new System.Drawing.Size(36, 13);
            this.IntLabel.TabIndex = 2;
            this.IntLabel.Text = "INT :";
            // 
            // personagemForm
            // 
            this.AcceptButton = this.salvarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(411, 474);
            this.Controls.Add(this.proLabel);
            this.Controls.Add(this.IntLabel);
            this.Controls.Add(this.raçaLabel);
            this.Controls.Add(this.classeLabel);
            this.Controls.Add(this.vitTextBox);
            this.Controls.Add(this.profissaoComboBox);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.raçaComboBox);
            this.Controls.Add(this.intTextBox);
            this.Controls.Add(this.classeComboBox);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.vitLabel);
            this.Controls.Add(this.contagemLabel);
            this.Controls.Add(this.strLabel);
            this.Controls.Add(this.obsLabel);
            this.Controls.Add(this.dexTextBox);
            this.Controls.Add(this.obsTextBox);
            this.Controls.Add(this.strTextBox);
            this.Controls.Add(this.dexLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "personagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personagem";
            this.Load += new System.EventHandler(this.personagemForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personagemForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ComboBox profissaoComboBox;
        private System.Windows.Forms.ComboBox raçaComboBox;
        private System.Windows.Forms.ComboBox classeComboBox;
        private System.Windows.Forms.Label proLabel;
        private System.Windows.Forms.Label raçaLabel;
        private System.Windows.Forms.Label classeLabel;
        private System.Windows.Forms.TextBox obsTextBox;
        private System.Windows.Forms.Label obsLabel;
        private System.Windows.Forms.Label contagemLabel;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.TextBox strTextBox;
        private System.Windows.Forms.TextBox dexTextBox;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label vitLabel;
        private System.Windows.Forms.TextBox intTextBox;
        private System.Windows.Forms.TextBox vitTextBox;
        private System.Windows.Forms.Label IntLabel;
    }
}

