namespace lab3
{
    partial class lab03Form
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
            this.buscarOpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buscarButton = new System.Windows.Forms.Button();
            this.fundoPanel = new System.Windows.Forms.Panel();
            this.imagemPictureBox = new System.Windows.Forms.PictureBox();
            this.fundoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarButton
            // 
            this.buscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.Location = new System.Drawing.Point(197, 208);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 0;
            this.buscarButton.Text = "&Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // fundoPanel
            // 
            this.fundoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fundoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fundoPanel.Controls.Add(this.imagemPictureBox);
            this.fundoPanel.Location = new System.Drawing.Point(12, 12);
            this.fundoPanel.Name = "fundoPanel";
            this.fundoPanel.Size = new System.Drawing.Size(260, 190);
            this.fundoPanel.TabIndex = 1;
            // 
            // imagemPictureBox
            // 
            this.imagemPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagemPictureBox.Location = new System.Drawing.Point(13, 15);
            this.imagemPictureBox.Name = "imagemPictureBox";
            this.imagemPictureBox.Size = new System.Drawing.Size(233, 160);
            this.imagemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemPictureBox.TabIndex = 0;
            this.imagemPictureBox.TabStop = false;
            // 
            // lab03Form
            // 
            this.AcceptButton = this.buscarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.fundoPanel);
            this.Name = "lab03Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio";
            this.fundoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagemPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog buscarOpenFileDialog1;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Panel fundoPanel;
        private System.Windows.Forms.PictureBox imagemPictureBox;
    }
}

