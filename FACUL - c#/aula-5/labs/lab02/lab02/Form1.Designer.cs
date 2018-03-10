namespace lab02
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
            this.cpfLabel = new System.Windows.Forms.Label();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.validarButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfLabel.Location = new System.Drawing.Point(12, 19);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(34, 13);
            this.cpfLabel.TabIndex = 0;
            this.cpfLabel.Text = "CPF:";
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Location = new System.Drawing.Point(55, 16);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(195, 20);
            this.cpfTextBox.TabIndex = 1;
            // 
            // validarButton
            // 
            this.validarButton.Location = new System.Drawing.Point(15, 42);
            this.validarButton.Name = "validarButton";
            this.validarButton.Size = new System.Drawing.Size(235, 44);
            this.validarButton.TabIndex = 2;
            this.validarButton.Text = "Validar";
            this.validarButton.UseVisualStyleBackColor = true;
            this.validarButton.Click += new System.EventHandler(this.validarButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoLabel.Location = new System.Drawing.Point(12, 102);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(238, 149);
            this.resultadoLabel.TabIndex = 3;
            this.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab01Form
            // 
            this.AcceptButton = this.validarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 260);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.validarButton);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(this.cpfLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "lab01Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.Button validarButton;
        private System.Windows.Forms.Label resultadoLabel;
    }
}

