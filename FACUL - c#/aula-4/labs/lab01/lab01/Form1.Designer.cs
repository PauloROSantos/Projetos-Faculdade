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
            this.valor1Label = new System.Windows.Forms.Label();
            this.valor1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valor2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valor2Label = new System.Windows.Forms.Label();
            this.valor3NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valor3Label = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valor1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor2NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor3NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // valor1Label
            // 
            this.valor1Label.AutoSize = true;
            this.valor1Label.Location = new System.Drawing.Point(23, 21);
            this.valor1Label.Name = "valor1Label";
            this.valor1Label.Size = new System.Drawing.Size(43, 13);
            this.valor1Label.TabIndex = 0;
            this.valor1Label.Text = "Valor 1:";
            // 
            // valor1NumericUpDown
            // 
            this.valor1NumericUpDown.Location = new System.Drawing.Point(73, 21);
            this.valor1NumericUpDown.Name = "valor1NumericUpDown";
            this.valor1NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valor1NumericUpDown.TabIndex = 1;
            // 
            // valor2NumericUpDown
            // 
            this.valor2NumericUpDown.Location = new System.Drawing.Point(73, 52);
            this.valor2NumericUpDown.Name = "valor2NumericUpDown";
            this.valor2NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valor2NumericUpDown.TabIndex = 3;
            // 
            // valor2Label
            // 
            this.valor2Label.AutoSize = true;
            this.valor2Label.Location = new System.Drawing.Point(23, 52);
            this.valor2Label.Name = "valor2Label";
            this.valor2Label.Size = new System.Drawing.Size(43, 13);
            this.valor2Label.TabIndex = 2;
            this.valor2Label.Text = "Valor 2:";
            // 
            // valor3NumericUpDown
            // 
            this.valor3NumericUpDown.Location = new System.Drawing.Point(73, 83);
            this.valor3NumericUpDown.Name = "valor3NumericUpDown";
            this.valor3NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valor3NumericUpDown.TabIndex = 5;
            // 
            // valor3Label
            // 
            this.valor3Label.AutoSize = true;
            this.valor3Label.Location = new System.Drawing.Point(23, 83);
            this.valor3Label.Name = "valor3Label";
            this.valor3Label.Size = new System.Drawing.Size(43, 13);
            this.valor3Label.TabIndex = 4;
            this.valor3Label.Text = "Valor 3:";
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(26, 109);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(167, 61);
            this.calcularButton.TabIndex = 6;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultadoLabel.Location = new System.Drawing.Point(23, 185);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(170, 78);
            this.resultadoLabel.TabIndex = 7;
            this.resultadoLabel.Click += new System.EventHandler(this.resultadoLabel_Click);
            // 
            // lab01Form
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 272);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.valor3NumericUpDown);
            this.Controls.Add(this.valor3Label);
            this.Controls.Add(this.valor2NumericUpDown);
            this.Controls.Add(this.valor2Label);
            this.Controls.Add(this.valor1NumericUpDown);
            this.Controls.Add(this.valor1Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "lab01Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valor1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor2NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor3NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valor1Label;
        private System.Windows.Forms.NumericUpDown valor1NumericUpDown;
        private System.Windows.Forms.NumericUpDown valor2NumericUpDown;
        private System.Windows.Forms.Label valor2Label;
        private System.Windows.Forms.NumericUpDown valor3NumericUpDown;
        private System.Windows.Forms.Label valor3Label;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label resultadoLabel;
    }
}

