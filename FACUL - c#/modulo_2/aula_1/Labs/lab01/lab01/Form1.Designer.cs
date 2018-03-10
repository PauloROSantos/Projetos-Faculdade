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
            this.lerButton = new System.Windows.Forms.Button();
            this.textoListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lerButton
            // 
            this.lerButton.Location = new System.Drawing.Point(12, 12);
            this.lerButton.Name = "lerButton";
            this.lerButton.Size = new System.Drawing.Size(75, 23);
            this.lerButton.TabIndex = 0;
            this.lerButton.Text = "Ler Arquivo";
            this.lerButton.UseVisualStyleBackColor = true;
            this.lerButton.Click += new System.EventHandler(this.lerButton_Click);
            // 
            // textoListBox
            // 
            this.textoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textoListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoListBox.FormattingEnabled = true;
            this.textoListBox.ItemHeight = 14;
            this.textoListBox.Location = new System.Drawing.Point(12, 41);
            this.textoListBox.Name = "textoListBox";
            this.textoListBox.Size = new System.Drawing.Size(603, 284);
            this.textoListBox.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lab01Form
            // 
            this.AcceptButton = this.lerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 355);
            this.Controls.Add(this.textoListBox);
            this.Controls.Add(this.lerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "lab01Form";
            this.Text = "Laboratorio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lerButton;
        private System.Windows.Forms.ListBox textoListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

