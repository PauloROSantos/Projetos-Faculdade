namespace Exemplo2
{
    partial class programaForm
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
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeTextbox = new System.Windows.Forms.TextBox();
            this.dataMatriculaLabel = new System.Windows.Forms.Label();
            this.dataMatriculaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeLabel.Location = new System.Drawing.Point(30, 36);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nomeLabel.Size = new System.Drawing.Size(37, 15);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome";
            // 
            // nomeTextbox
            // 
            this.nomeTextbox.Location = new System.Drawing.Point(58, 54);
            this.nomeTextbox.Name = "nomeTextbox";
            this.nomeTextbox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextbox.TabIndex = 1;
            // 
            // dataMatriculaLabel
            // 
            this.dataMatriculaLabel.AutoSize = true;
            this.dataMatriculaLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dataMatriculaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataMatriculaLabel.Location = new System.Drawing.Point(30, 83);
            this.dataMatriculaLabel.Name = "dataMatriculaLabel";
            this.dataMatriculaLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataMatriculaLabel.Size = new System.Drawing.Size(93, 15);
            this.dataMatriculaLabel.TabIndex = 2;
            this.dataMatriculaLabel.Text = "Data de Matricula";
            // 
            // dataMatriculaDateTimePicker
            // 
            this.dataMatriculaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataMatriculaDateTimePicker.Location = new System.Drawing.Point(58, 101);
            this.dataMatriculaDateTimePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dataMatriculaDateTimePicker.Name = "dataMatriculaDateTimePicker";
            this.dataMatriculaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataMatriculaDateTimePicker.TabIndex = 3;
            // 
            // cidadeComboBox
            // 
            this.cidadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cidadeComboBox.FormattingEnabled = true;
            this.cidadeComboBox.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Bosnia",
            "Samsung",
            "Jurrassic Park"});
            this.cidadeComboBox.Location = new System.Drawing.Point(58, 150);
            this.cidadeComboBox.Name = "cidadeComboBox";
            this.cidadeComboBox.Size = new System.Drawing.Size(121, 21);
            this.cidadeComboBox.TabIndex = 4;
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Location = new System.Drawing.Point(32, 134);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(43, 13);
            this.cidadeLabel.TabIndex = 5;
            this.cidadeLabel.Text = "Cidade:";
            // 
            // programaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(428, 371);
            this.Controls.Add(this.cidadeLabel);
            this.Controls.Add(this.cidadeComboBox);
            this.Controls.Add(this.dataMatriculaDateTimePicker);
            this.Controls.Add(this.dataMatriculaLabel);
            this.Controls.Add(this.nomeTextbox);
            this.Controls.Add(this.nomeLabel);
            this.Name = "programaForm";
            this.Text = "Programa1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeTextbox;
        private System.Windows.Forms.Label dataMatriculaLabel;
        private System.Windows.Forms.DateTimePicker dataMatriculaDateTimePicker;
        private System.Windows.Forms.ComboBox cidadeComboBox;
        private System.Windows.Forms.Label cidadeLabel;
    }
}

