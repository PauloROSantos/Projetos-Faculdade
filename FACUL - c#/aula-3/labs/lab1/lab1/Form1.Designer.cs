namespace lab1
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
            this.digiteUmNumeroLabel = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // digiteUmNumeroLabel
            // 
            this.digiteUmNumeroLabel.AutoSize = true;
            this.digiteUmNumeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digiteUmNumeroLabel.Location = new System.Drawing.Point(26, 32);
            this.digiteUmNumeroLabel.Name = "digiteUmNumeroLabel";
            this.digiteUmNumeroLabel.Size = new System.Drawing.Size(92, 13);
            this.digiteUmNumeroLabel.TabIndex = 0;
            this.digiteUmNumeroLabel.Text = "Digite um numero:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(29, 48);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(159, 20);
            this.numeroTextBox.TabIndex = 1;
            this.numeroTextBox.TextChanged += new System.EventHandler(this.numeroTextBox_TextChanged);
            // 
            // calcularButton
            // 
            this.calcularButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcularButton.Location = new System.Drawing.Point(196, 12);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(105, 57);
            this.calcularButton.TabIndex = 2;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultadoLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultadoLabel.Location = new System.Drawing.Point(26, 88);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(275, 164);
            this.resultadoLabel.TabIndex = 3;
            this.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultadoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab01Form
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.digiteUmNumeroLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "lab01Form";
            this.Text = "Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label digiteUmNumeroLabel;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label resultadoLabel;
    }
}

