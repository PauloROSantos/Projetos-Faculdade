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
            this.clienteLabel = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.valorLabel = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.freteLabel = new System.Windows.Forms.Label();
            this.valorFreteLabel = new System.Windows.Forms.Label();
            this.ufLabel = new System.Windows.Forms.Label();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(18, 22);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(42, 13);
            this.clienteLabel.TabIndex = 0;
            this.clienteLabel.Text = "Cliente:";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(66, 15);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(195, 20);
            this.clienteTextBox.TabIndex = 1;
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Location = new System.Drawing.Point(23, 52);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(33, 13);
            this.valorLabel.TabIndex = 2;
            this.valorLabel.Text = "valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(66, 52);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 3;
            // 
            // freteLabel
            // 
            this.freteLabel.AutoSize = true;
            this.freteLabel.Location = new System.Drawing.Point(18, 95);
            this.freteLabel.Name = "freteLabel";
            this.freteLabel.Size = new System.Drawing.Size(42, 13);
            this.freteLabel.TabIndex = 4;
            this.freteLabel.Text = "%Frete:";
            // 
            // valorFreteLabel
            // 
            this.valorFreteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorFreteLabel.Location = new System.Drawing.Point(66, 85);
            this.valorFreteLabel.Name = "valorFreteLabel";
            this.valorFreteLabel.Size = new System.Drawing.Size(195, 23);
            this.valorFreteLabel.TabIndex = 5;
            // 
            // ufLabel
            // 
            this.ufLabel.AutoSize = true;
            this.ufLabel.Location = new System.Drawing.Point(172, 55);
            this.ufLabel.Name = "ufLabel";
            this.ufLabel.Size = new System.Drawing.Size(24, 13);
            this.ufLabel.TabIndex = 6;
            this.ufLabel.Text = "UF:";
            // 
            // ufComboBox
            // 
            this.ufComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "RJ",
            "SP",
            "AM",
            "PB",
            "MO"});
            this.ufComboBox.Location = new System.Drawing.Point(202, 52);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(50, 21);
            this.ufComboBox.TabIndex = 7;
            this.ufComboBox.SelectedIndexChanged += new System.EventHandler(this.ufComboBox_SelectedIndexChanged);
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(26, 132);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(235, 41);
            this.calcularButton.TabIndex = 8;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoLabel.Location = new System.Drawing.Point(25, 188);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(236, 64);
            this.resultadoLabel.TabIndex = 9;
            this.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab02Form
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.ufComboBox);
            this.Controls.Add(this.ufLabel);
            this.Controls.Add(this.valorFreteLabel);
            this.Controls.Add(this.freteLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.clienteLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "lab02Form";
            this.Text = "Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label freteLabel;
        private System.Windows.Forms.Label valorFreteLabel;
        private System.Windows.Forms.Label ufLabel;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label resultadoLabel;
    }
}

