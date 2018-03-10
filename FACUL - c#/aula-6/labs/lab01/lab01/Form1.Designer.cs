namespace lab01
{
    partial class lab01Form
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
            this.kmLabel = new System.Windows.Forms.Label();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            this.litrosTextBox = new System.Windows.Forms.TextBox();
            this.litrosLabel = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.rendimentoGasLabel = new System.Windows.Forms.Label();
            this.resultadoRendimentoLabel = new System.Windows.Forms.Label();
            this.resultadoConsumoLabel = new System.Windows.Forms.Label();
            this.consumoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kmLabel
            // 
            this.kmLabel.AutoSize = true;
            this.kmLabel.Location = new System.Drawing.Point(20, 23);
            this.kmLabel.Name = "kmLabel";
            this.kmLabel.Size = new System.Drawing.Size(24, 13);
            this.kmLabel.TabIndex = 0;
            this.kmLabel.Text = "&km:";
            // 
            // kmTextBox
            // 
            this.kmTextBox.Location = new System.Drawing.Point(50, 20);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(57, 20);
            this.kmTextBox.TabIndex = 1;
            // 
            // litrosTextBox
            // 
            this.litrosTextBox.Location = new System.Drawing.Point(50, 57);
            this.litrosTextBox.Name = "litrosTextBox";
            this.litrosTextBox.Size = new System.Drawing.Size(57, 20);
            this.litrosTextBox.TabIndex = 3;
            // 
            // litrosLabel
            // 
            this.litrosLabel.AutoSize = true;
            this.litrosLabel.Location = new System.Drawing.Point(9, 60);
            this.litrosLabel.Name = "litrosLabel";
            this.litrosLabel.Size = new System.Drawing.Size(35, 13);
            this.litrosLabel.TabIndex = 2;
            this.litrosLabel.Text = "&Litros:";
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(12, 88);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(212, 76);
            this.calcularButton.TabIndex = 4;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // rendimentoGasLabel
            // 
            this.rendimentoGasLabel.AutoSize = true;
            this.rendimentoGasLabel.Location = new System.Drawing.Point(124, 6);
            this.rendimentoGasLabel.Name = "rendimentoGasLabel";
            this.rendimentoGasLabel.Size = new System.Drawing.Size(88, 13);
            this.rendimentoGasLabel.TabIndex = 5;
            this.rendimentoGasLabel.Text = "Rendimento km/l";
            // 
            // resultadoRendimentoLabel
            // 
            this.resultadoRendimentoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultadoRendimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoRendimentoLabel.Location = new System.Drawing.Point(124, 20);
            this.resultadoRendimentoLabel.Name = "resultadoRendimentoLabel";
            this.resultadoRendimentoLabel.Size = new System.Drawing.Size(88, 20);
            this.resultadoRendimentoLabel.TabIndex = 6;
            this.resultadoRendimentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultadoConsumoLabel
            // 
            this.resultadoConsumoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultadoConsumoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoConsumoLabel.Location = new System.Drawing.Point(124, 57);
            this.resultadoConsumoLabel.Name = "resultadoConsumoLabel";
            this.resultadoConsumoLabel.Size = new System.Drawing.Size(88, 20);
            this.resultadoConsumoLabel.TabIndex = 8;
            this.resultadoConsumoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consumoLabel
            // 
            this.consumoLabel.AutoSize = true;
            this.consumoLabel.Location = new System.Drawing.Point(124, 43);
            this.consumoLabel.Name = "consumoLabel";
            this.consumoLabel.Size = new System.Drawing.Size(81, 13);
            this.consumoLabel.TabIndex = 7;
            this.consumoLabel.Text = "Consumo L/KM";
            // 
            // lab01Form
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 176);
            this.Controls.Add(this.resultadoConsumoLabel);
            this.Controls.Add(this.consumoLabel);
            this.Controls.Add(this.resultadoRendimentoLabel);
            this.Controls.Add(this.rendimentoGasLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.litrosTextBox);
            this.Controls.Add(this.litrosLabel);
            this.Controls.Add(this.kmTextBox);
            this.Controls.Add(this.kmLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "lab01Form";
            this.Text = "Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kmLabel;
        private System.Windows.Forms.TextBox kmTextBox;
        private System.Windows.Forms.TextBox litrosTextBox;
        private System.Windows.Forms.Label litrosLabel;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label rendimentoGasLabel;
        private System.Windows.Forms.Label resultadoRendimentoLabel;
        private System.Windows.Forms.Label resultadoConsumoLabel;
        private System.Windows.Forms.Label consumoLabel;
    }
}

