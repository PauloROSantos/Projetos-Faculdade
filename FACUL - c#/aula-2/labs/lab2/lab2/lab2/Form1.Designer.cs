namespace lab2
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
            this.redLabel = new System.Windows.Forms.Label();
            this.verdeLabel = new System.Windows.Forms.Label();
            this.azulLabel = new System.Windows.Forms.Label();
            this.redvalorLabel = new System.Windows.Forms.Label();
            this.verdeValorLabel = new System.Windows.Forms.Label();
            this.azulValorLabel = new System.Windows.Forms.Label();
            this.corResultanteLabel = new System.Windows.Forms.Label();
            this.redHScrollBar = new System.Windows.Forms.HScrollBar();
            this.verdeHScrollBar = new System.Windows.Forms.HScrollBar();
            this.azulHScrollBar = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Red;
            this.redLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redLabel.Location = new System.Drawing.Point(12, 17);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(35, 23);
            this.redLabel.TabIndex = 0;
            this.redLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // verdeLabel
            // 
            this.verdeLabel.BackColor = System.Drawing.Color.Green;
            this.verdeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verdeLabel.Location = new System.Drawing.Point(12, 49);
            this.verdeLabel.Name = "verdeLabel";
            this.verdeLabel.Size = new System.Drawing.Size(35, 23);
            this.verdeLabel.TabIndex = 3;
            // 
            // azulLabel
            // 
            this.azulLabel.BackColor = System.Drawing.Color.Blue;
            this.azulLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.azulLabel.Location = new System.Drawing.Point(12, 79);
            this.azulLabel.Name = "azulLabel";
            this.azulLabel.Size = new System.Drawing.Size(35, 23);
            this.azulLabel.TabIndex = 6;
            // 
            // redvalorLabel
            // 
            this.redvalorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redvalorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redvalorLabel.Location = new System.Drawing.Point(53, 17);
            this.redvalorLabel.Name = "redvalorLabel";
            this.redvalorLabel.Size = new System.Drawing.Size(35, 23);
            this.redvalorLabel.TabIndex = 1;
            // 
            // verdeValorLabel
            // 
            this.verdeValorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verdeValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verdeValorLabel.Location = new System.Drawing.Point(53, 49);
            this.verdeValorLabel.Name = "verdeValorLabel";
            this.verdeValorLabel.Size = new System.Drawing.Size(35, 23);
            this.verdeValorLabel.TabIndex = 4;
            // 
            // azulValorLabel
            // 
            this.azulValorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.azulValorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.azulValorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azulValorLabel.Location = new System.Drawing.Point(53, 79);
            this.azulValorLabel.Name = "azulValorLabel";
            this.azulValorLabel.Size = new System.Drawing.Size(35, 23);
            this.azulValorLabel.TabIndex = 7;
            // 
            // corResultanteLabel
            // 
            this.corResultanteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.corResultanteLabel.Location = new System.Drawing.Point(12, 113);
            this.corResultanteLabel.Name = "corResultanteLabel";
            this.corResultanteLabel.Size = new System.Drawing.Size(263, 111);
            this.corResultanteLabel.TabIndex = 9;
            // 
            // redHScrollBar
            // 
            this.redHScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redHScrollBar.LargeChange = 1;
            this.redHScrollBar.Location = new System.Drawing.Point(91, 17);
            this.redHScrollBar.Maximum = 255;
            this.redHScrollBar.Name = "redHScrollBar";
            this.redHScrollBar.Size = new System.Drawing.Size(184, 17);
            this.redHScrollBar.TabIndex = 2;
            this.redHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redHScrollBar_Scroll);
            // 
            // verdeHScrollBar
            // 
            this.verdeHScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verdeHScrollBar.LargeChange = 1;
            this.verdeHScrollBar.Location = new System.Drawing.Point(91, 49);
            this.verdeHScrollBar.Maximum = 255;
            this.verdeHScrollBar.Name = "verdeHScrollBar";
            this.verdeHScrollBar.Size = new System.Drawing.Size(184, 17);
            this.verdeHScrollBar.TabIndex = 5;
            this.verdeHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.verdeHScrollBar_Scroll);
            // 
            // azulHScrollBar
            // 
            this.azulHScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.azulHScrollBar.LargeChange = 1;
            this.azulHScrollBar.Location = new System.Drawing.Point(91, 79);
            this.azulHScrollBar.Maximum = 255;
            this.azulHScrollBar.Name = "azulHScrollBar";
            this.azulHScrollBar.Size = new System.Drawing.Size(184, 17);
            this.azulHScrollBar.TabIndex = 8;
            this.azulHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.azulHScrollBar_Scroll);
            // 
            // lab02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.azulHScrollBar);
            this.Controls.Add(this.verdeHScrollBar);
            this.Controls.Add(this.redHScrollBar);
            this.Controls.Add(this.corResultanteLabel);
            this.Controls.Add(this.azulValorLabel);
            this.Controls.Add(this.verdeValorLabel);
            this.Controls.Add(this.redvalorLabel);
            this.Controls.Add(this.azulLabel);
            this.Controls.Add(this.verdeLabel);
            this.Controls.Add(this.redLabel);
            this.Name = "lab02Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "laboratorio";
            this.Load += new System.EventHandler(this.lab02Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label verdeLabel;
        private System.Windows.Forms.Label azulLabel;
        private System.Windows.Forms.Label redvalorLabel;
        private System.Windows.Forms.Label verdeValorLabel;
        private System.Windows.Forms.Label azulValorLabel;
        private System.Windows.Forms.Label corResultanteLabel;
        private System.Windows.Forms.HScrollBar redHScrollBar;
        private System.Windows.Forms.HScrollBar verdeHScrollBar;
        private System.Windows.Forms.HScrollBar azulHScrollBar;
    }
}

