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
            this.endereçoLabel = new System.Windows.Forms.Label();
            this.endereçoBuscadoLabel = new System.Windows.Forms.Label();
            this.buscarButton = new System.Windows.Forms.Button();
            this.deLabel = new System.Windows.Forms.Label();
            this.deTextBox = new System.Windows.Forms.TextBox();
            this.paraLabel = new System.Windows.Forms.Label();
            this.paraTextBox = new System.Windows.Forms.TextBox();
            this.trocarButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // endereçoLabel
            // 
            this.endereçoLabel.AutoSize = true;
            this.endereçoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereçoLabel.Location = new System.Drawing.Point(12, 9);
            this.endereçoLabel.Name = "endereçoLabel";
            this.endereçoLabel.Size = new System.Drawing.Size(65, 13);
            this.endereçoLabel.TabIndex = 0;
            this.endereçoLabel.Text = "Endereço:";
            // 
            // endereçoBuscadoLabel
            // 
            this.endereçoBuscadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.endereçoBuscadoLabel.Location = new System.Drawing.Point(12, 32);
            this.endereçoBuscadoLabel.Name = "endereçoBuscadoLabel";
            this.endereçoBuscadoLabel.Size = new System.Drawing.Size(371, 23);
            this.endereçoBuscadoLabel.TabIndex = 1;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(389, 32);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buscarButton.Size = new System.Drawing.Size(45, 23);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.Text = "...";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // deLabel
            // 
            this.deLabel.AutoSize = true;
            this.deLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabel.Location = new System.Drawing.Point(12, 76);
            this.deLabel.Name = "deLabel";
            this.deLabel.Size = new System.Drawing.Size(27, 13);
            this.deLabel.TabIndex = 3;
            this.deLabel.Text = "De:";
            // 
            // deTextBox
            // 
            this.deTextBox.Location = new System.Drawing.Point(15, 92);
            this.deTextBox.Name = "deTextBox";
            this.deTextBox.Size = new System.Drawing.Size(311, 20);
            this.deTextBox.TabIndex = 4;
            // 
            // paraLabel
            // 
            this.paraLabel.AutoSize = true;
            this.paraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraLabel.Location = new System.Drawing.Point(12, 128);
            this.paraLabel.Name = "paraLabel";
            this.paraLabel.Size = new System.Drawing.Size(37, 13);
            this.paraLabel.TabIndex = 5;
            this.paraLabel.Text = "Para:";
            // 
            // paraTextBox
            // 
            this.paraTextBox.Location = new System.Drawing.Point(15, 144);
            this.paraTextBox.Name = "paraTextBox";
            this.paraTextBox.Size = new System.Drawing.Size(311, 20);
            this.paraTextBox.TabIndex = 6;
            // 
            // trocarButton
            // 
            this.trocarButton.Location = new System.Drawing.Point(332, 92);
            this.trocarButton.Name = "trocarButton";
            this.trocarButton.Size = new System.Drawing.Size(102, 72);
            this.trocarButton.TabIndex = 7;
            this.trocarButton.Text = "Trocar";
            this.trocarButton.UseVisualStyleBackColor = true;
            this.trocarButton.Click += new System.EventHandler(this.trocarButton_Click);
            // 
            // lab02Form
            // 
            this.AcceptButton = this.trocarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 183);
            this.Controls.Add(this.trocarButton);
            this.Controls.Add(this.paraTextBox);
            this.Controls.Add(this.paraLabel);
            this.Controls.Add(this.deTextBox);
            this.Controls.Add(this.deLabel);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.endereçoBuscadoLabel);
            this.Controls.Add(this.endereçoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "lab02Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label endereçoLabel;
        private System.Windows.Forms.Label endereçoBuscadoLabel;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Label deLabel;
        private System.Windows.Forms.TextBox deTextBox;
        private System.Windows.Forms.Label paraLabel;
        private System.Windows.Forms.TextBox paraTextBox;
        private System.Windows.Forms.Button trocarButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

