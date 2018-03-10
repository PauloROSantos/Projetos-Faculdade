namespace lab02
{
    partial class lab02Form
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
            this.valorDaCompraLabel = new System.Windows.Forms.Label();
            this.valorDaCompraTextBox = new System.Windows.Forms.TextBox();
            this.valorPagoDinheiroLabel = new System.Windows.Forms.Label();
            this.valorPagoDinheiroTextBox = new System.Windows.Forms.TextBox();
            this.valorTrocoLabel = new System.Windows.Forms.Label();
            this.trocoLabel = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.moedasParaTrocoLabel = new System.Windows.Forms.Label();
            this.qtdMoedas1RealLabel = new System.Windows.Forms.Label();
            this.moedas1RealLabel = new System.Windows.Forms.Label();
            this.moedas50centsLabel = new System.Windows.Forms.Label();
            this.qtdMoedas50centsLabel = new System.Windows.Forms.Label();
            this.moedas25centsLabel = new System.Windows.Forms.Label();
            this.qtdMoedas25centsLabel = new System.Windows.Forms.Label();
            this.moedas10centsLabel = new System.Windows.Forms.Label();
            this.qtdMoedas10centsLabel = new System.Windows.Forms.Label();
            this.moedas5centsLabel = new System.Windows.Forms.Label();
            this.qtdMoedas5centsLabel = new System.Windows.Forms.Label();
            this.moedas1centsLabel = new System.Windows.Forms.Label();
            this.qtdMoedas1centsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valorDaCompraLabel
            // 
            this.valorDaCompraLabel.AutoSize = true;
            this.valorDaCompraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorDaCompraLabel.Location = new System.Drawing.Point(49, 22);
            this.valorDaCompraLabel.Name = "valorDaCompraLabel";
            this.valorDaCompraLabel.Size = new System.Drawing.Size(104, 13);
            this.valorDaCompraLabel.TabIndex = 0;
            this.valorDaCompraLabel.Text = "Valor da Compra:";
            // 
            // valorDaCompraTextBox
            // 
            this.valorDaCompraTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorDaCompraTextBox.Location = new System.Drawing.Point(159, 22);
            this.valorDaCompraTextBox.Name = "valorDaCompraTextBox";
            this.valorDaCompraTextBox.Size = new System.Drawing.Size(118, 20);
            this.valorDaCompraTextBox.TabIndex = 1;
            // 
            // valorPagoDinheiroLabel
            // 
            this.valorPagoDinheiroLabel.AutoSize = true;
            this.valorPagoDinheiroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorPagoDinheiroLabel.Location = new System.Drawing.Point(12, 56);
            this.valorPagoDinheiroLabel.Name = "valorPagoDinheiroLabel";
            this.valorPagoDinheiroLabel.Size = new System.Drawing.Size(141, 13);
            this.valorPagoDinheiroLabel.TabIndex = 2;
            this.valorPagoDinheiroLabel.Text = "Valor pago em dinheiro:";
            // 
            // valorPagoDinheiroTextBox
            // 
            this.valorPagoDinheiroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorPagoDinheiroTextBox.Location = new System.Drawing.Point(159, 53);
            this.valorPagoDinheiroTextBox.Name = "valorPagoDinheiroTextBox";
            this.valorPagoDinheiroTextBox.Size = new System.Drawing.Size(118, 20);
            this.valorPagoDinheiroTextBox.TabIndex = 3;
            // 
            // valorTrocoLabel
            // 
            this.valorTrocoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valorTrocoLabel.AutoSize = true;
            this.valorTrocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTrocoLabel.Location = new System.Drawing.Point(55, 87);
            this.valorTrocoLabel.Name = "valorTrocoLabel";
            this.valorTrocoLabel.Size = new System.Drawing.Size(95, 13);
            this.valorTrocoLabel.TabIndex = 4;
            this.valorTrocoLabel.Text = "Valor do Troco:";
            // 
            // trocoLabel
            // 
            this.trocoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trocoLabel.Location = new System.Drawing.Point(159, 83);
            this.trocoLabel.Name = "trocoLabel";
            this.trocoLabel.Size = new System.Drawing.Size(118, 21);
            this.trocoLabel.TabIndex = 5;
            this.trocoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(12, 107);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(265, 57);
            this.calcularButton.TabIndex = 6;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // moedasParaTrocoLabel
            // 
            this.moedasParaTrocoLabel.AutoSize = true;
            this.moedasParaTrocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moedasParaTrocoLabel.Location = new System.Drawing.Point(310, 9);
            this.moedasParaTrocoLabel.Name = "moedasParaTrocoLabel";
            this.moedasParaTrocoLabel.Size = new System.Drawing.Size(159, 20);
            this.moedasParaTrocoLabel.TabIndex = 7;
            this.moedasParaTrocoLabel.Text = "Moedas para troco";
            // 
            // qtdMoedas1RealLabel
            // 
            this.qtdMoedas1RealLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtdMoedas1RealLabel.Location = new System.Drawing.Point(314, 35);
            this.qtdMoedas1RealLabel.Name = "qtdMoedas1RealLabel";
            this.qtdMoedas1RealLabel.Size = new System.Drawing.Size(37, 14);
            this.qtdMoedas1RealLabel.TabIndex = 8;
            // 
            // moedas1RealLabel
            // 
            this.moedas1RealLabel.AutoSize = true;
            this.moedas1RealLabel.Location = new System.Drawing.Point(357, 36);
            this.moedas1RealLabel.Name = "moedas1RealLabel";
            this.moedas1RealLabel.Size = new System.Drawing.Size(98, 13);
            this.moedas1RealLabel.TabIndex = 9;
            this.moedas1RealLabel.Text = "Moedas de R$1.00";
            // 
            // moedas50centsLabel
            // 
            this.moedas50centsLabel.AutoSize = true;
            this.moedas50centsLabel.Location = new System.Drawing.Point(357, 60);
            this.moedas50centsLabel.Name = "moedas50centsLabel";
            this.moedas50centsLabel.Size = new System.Drawing.Size(98, 13);
            this.moedas50centsLabel.TabIndex = 11;
            this.moedas50centsLabel.Text = "Moedas de R$0,50";
            // 
            // qtdMoedas50centsLabel
            // 
            this.qtdMoedas50centsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtdMoedas50centsLabel.Location = new System.Drawing.Point(314, 59);
            this.qtdMoedas50centsLabel.Name = "qtdMoedas50centsLabel";
            this.qtdMoedas50centsLabel.Size = new System.Drawing.Size(37, 14);
            this.qtdMoedas50centsLabel.TabIndex = 10;
            // 
            // moedas25centsLabel
            // 
            this.moedas25centsLabel.AutoSize = true;
            this.moedas25centsLabel.Location = new System.Drawing.Point(357, 84);
            this.moedas25centsLabel.Name = "moedas25centsLabel";
            this.moedas25centsLabel.Size = new System.Drawing.Size(98, 13);
            this.moedas25centsLabel.TabIndex = 13;
            this.moedas25centsLabel.Text = "Moedas de R$0,25";
            // 
            // qtdMoedas25centsLabel
            // 
            this.qtdMoedas25centsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtdMoedas25centsLabel.Location = new System.Drawing.Point(314, 83);
            this.qtdMoedas25centsLabel.Name = "qtdMoedas25centsLabel";
            this.qtdMoedas25centsLabel.Size = new System.Drawing.Size(37, 14);
            this.qtdMoedas25centsLabel.TabIndex = 12;
            // 
            // moedas10centsLabel
            // 
            this.moedas10centsLabel.AutoSize = true;
            this.moedas10centsLabel.Location = new System.Drawing.Point(357, 108);
            this.moedas10centsLabel.Name = "moedas10centsLabel";
            this.moedas10centsLabel.Size = new System.Drawing.Size(98, 13);
            this.moedas10centsLabel.TabIndex = 15;
            this.moedas10centsLabel.Text = "Moedas de R$0,10";
            // 
            // qtdMoedas10centsLabel
            // 
            this.qtdMoedas10centsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtdMoedas10centsLabel.Location = new System.Drawing.Point(314, 107);
            this.qtdMoedas10centsLabel.Name = "qtdMoedas10centsLabel";
            this.qtdMoedas10centsLabel.Size = new System.Drawing.Size(37, 14);
            this.qtdMoedas10centsLabel.TabIndex = 14;
            // 
            // moedas5centsLabel
            // 
            this.moedas5centsLabel.AutoSize = true;
            this.moedas5centsLabel.Location = new System.Drawing.Point(357, 129);
            this.moedas5centsLabel.Name = "moedas5centsLabel";
            this.moedas5centsLabel.Size = new System.Drawing.Size(98, 13);
            this.moedas5centsLabel.TabIndex = 17;
            this.moedas5centsLabel.Text = "Moedas de R$0,05";
            // 
            // qtdMoedas5centsLabel
            // 
            this.qtdMoedas5centsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtdMoedas5centsLabel.Location = new System.Drawing.Point(314, 128);
            this.qtdMoedas5centsLabel.Name = "qtdMoedas5centsLabel";
            this.qtdMoedas5centsLabel.Size = new System.Drawing.Size(37, 14);
            this.qtdMoedas5centsLabel.TabIndex = 16;
            // 
            // moedas1centsLabel
            // 
            this.moedas1centsLabel.AutoSize = true;
            this.moedas1centsLabel.Location = new System.Drawing.Point(357, 151);
            this.moedas1centsLabel.Name = "moedas1centsLabel";
            this.moedas1centsLabel.Size = new System.Drawing.Size(98, 13);
            this.moedas1centsLabel.TabIndex = 19;
            this.moedas1centsLabel.Text = "Moedas de R$0,01";
            // 
            // qtdMoedas1centsLabel
            // 
            this.qtdMoedas1centsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtdMoedas1centsLabel.Location = new System.Drawing.Point(314, 150);
            this.qtdMoedas1centsLabel.Name = "qtdMoedas1centsLabel";
            this.qtdMoedas1centsLabel.Size = new System.Drawing.Size(37, 14);
            this.qtdMoedas1centsLabel.TabIndex = 18;
            // 
            // lab02Form
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 168);
            this.Controls.Add(this.moedas1centsLabel);
            this.Controls.Add(this.qtdMoedas1centsLabel);
            this.Controls.Add(this.moedas5centsLabel);
            this.Controls.Add(this.qtdMoedas5centsLabel);
            this.Controls.Add(this.moedas10centsLabel);
            this.Controls.Add(this.qtdMoedas10centsLabel);
            this.Controls.Add(this.moedas25centsLabel);
            this.Controls.Add(this.qtdMoedas25centsLabel);
            this.Controls.Add(this.moedas50centsLabel);
            this.Controls.Add(this.qtdMoedas50centsLabel);
            this.Controls.Add(this.moedas1RealLabel);
            this.Controls.Add(this.qtdMoedas1RealLabel);
            this.Controls.Add(this.moedasParaTrocoLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.trocoLabel);
            this.Controls.Add(this.valorTrocoLabel);
            this.Controls.Add(this.valorPagoDinheiroTextBox);
            this.Controls.Add(this.valorPagoDinheiroLabel);
            this.Controls.Add(this.valorDaCompraTextBox);
            this.Controls.Add(this.valorDaCompraLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "lab02Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valorDaCompraLabel;
        private System.Windows.Forms.TextBox valorDaCompraTextBox;
        private System.Windows.Forms.Label valorPagoDinheiroLabel;
        private System.Windows.Forms.TextBox valorPagoDinheiroTextBox;
        private System.Windows.Forms.Label valorTrocoLabel;
        private System.Windows.Forms.Label trocoLabel;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label moedasParaTrocoLabel;
        private System.Windows.Forms.Label qtdMoedas1RealLabel;
        private System.Windows.Forms.Label moedas1RealLabel;
        private System.Windows.Forms.Label moedas50centsLabel;
        private System.Windows.Forms.Label qtdMoedas50centsLabel;
        private System.Windows.Forms.Label moedas25centsLabel;
        private System.Windows.Forms.Label qtdMoedas25centsLabel;
        private System.Windows.Forms.Label moedas10centsLabel;
        private System.Windows.Forms.Label qtdMoedas10centsLabel;
        private System.Windows.Forms.Label moedas5centsLabel;
        private System.Windows.Forms.Label qtdMoedas5centsLabel;
        private System.Windows.Forms.Label moedas1centsLabel;
        private System.Windows.Forms.Label qtdMoedas1centsLabel;
    }
}

