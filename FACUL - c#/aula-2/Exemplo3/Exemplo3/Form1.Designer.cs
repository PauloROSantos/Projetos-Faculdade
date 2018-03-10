namespace Exemplo3
{
    partial class cadastroForm
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
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.dataLabel = new System.Windows.Forms.Label();
            this.dataMatriculaDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.horarioPanel = new System.Windows.Forms.Panel();
            this.horarioLabel = new System.Windows.Forms.Label();
            this.periodoManhaButton = new System.Windows.Forms.RadioButton();
            this.periodoTardeButton = new System.Windows.Forms.RadioButton();
            this.periodoNoiteButton = new System.Windows.Forms.RadioButton();
            this.confirmarButton = new System.Windows.Forms.Button();
            this.principalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.comandosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teste2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horarioPanel.SuspendLayout();
            this.principalMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(12, 35);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(56, 32);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(182, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(15, 83);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(91, 13);
            this.dataLabel.TabIndex = 2;
            this.dataLabel.Text = "data de matricula:";
            // 
            // dataMatriculaDateTimePicker1
            // 
            this.dataMatriculaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataMatriculaDateTimePicker1.Location = new System.Drawing.Point(112, 77);
            this.dataMatriculaDateTimePicker1.Name = "dataMatriculaDateTimePicker1";
            this.dataMatriculaDateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dataMatriculaDateTimePicker1.TabIndex = 3;
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Location = new System.Drawing.Point(15, 128);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(43, 13);
            this.cidadeLabel.TabIndex = 4;
            this.cidadeLabel.Text = "Cidade:";
            // 
            // cidadeComboBox
            // 
            this.cidadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cidadeComboBox.FormattingEnabled = true;
            this.cidadeComboBox.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "Bosnia",
            "Ucrania"});
            this.cidadeComboBox.Location = new System.Drawing.Point(75, 125);
            this.cidadeComboBox.Name = "cidadeComboBox";
            this.cidadeComboBox.Size = new System.Drawing.Size(121, 21);
            this.cidadeComboBox.TabIndex = 5;
            // 
            // horarioPanel
            // 
            this.horarioPanel.Controls.Add(this.periodoNoiteButton);
            this.horarioPanel.Controls.Add(this.periodoTardeButton);
            this.horarioPanel.Controls.Add(this.periodoManhaButton);
            this.horarioPanel.Location = new System.Drawing.Point(18, 177);
            this.horarioPanel.Name = "horarioPanel";
            this.horarioPanel.Size = new System.Drawing.Size(190, 31);
            this.horarioPanel.TabIndex = 6;
            // 
            // horarioLabel
            // 
            this.horarioLabel.AutoSize = true;
            this.horarioLabel.Location = new System.Drawing.Point(15, 161);
            this.horarioLabel.Name = "horarioLabel";
            this.horarioLabel.Size = new System.Drawing.Size(42, 13);
            this.horarioLabel.TabIndex = 7;
            this.horarioLabel.Text = "horario:";
            // 
            // periodoManhaButton
            // 
            this.periodoManhaButton.AutoSize = true;
            this.periodoManhaButton.Location = new System.Drawing.Point(4, 4);
            this.periodoManhaButton.Name = "periodoManhaButton";
            this.periodoManhaButton.Size = new System.Drawing.Size(58, 17);
            this.periodoManhaButton.TabIndex = 0;
            this.periodoManhaButton.TabStop = true;
            this.periodoManhaButton.Text = "Manhã";
            this.periodoManhaButton.UseVisualStyleBackColor = true;
            // 
            // periodoTardeButton
            // 
            this.periodoTardeButton.AutoSize = true;
            this.periodoTardeButton.Location = new System.Drawing.Point(68, 4);
            this.periodoTardeButton.Name = "periodoTardeButton";
            this.periodoTardeButton.Size = new System.Drawing.Size(53, 17);
            this.periodoTardeButton.TabIndex = 1;
            this.periodoTardeButton.TabStop = true;
            this.periodoTardeButton.Text = "Tarde";
            this.periodoTardeButton.UseVisualStyleBackColor = true;
            // 
            // periodoNoiteButton
            // 
            this.periodoNoiteButton.AutoSize = true;
            this.periodoNoiteButton.Location = new System.Drawing.Point(128, 4);
            this.periodoNoiteButton.Name = "periodoNoiteButton";
            this.periodoNoiteButton.Size = new System.Drawing.Size(50, 17);
            this.periodoNoiteButton.TabIndex = 2;
            this.periodoNoiteButton.TabStop = true;
            this.periodoNoiteButton.Text = "Noite";
            this.periodoNoiteButton.UseVisualStyleBackColor = true;
            // 
            // confirmarButton
            // 
            this.confirmarButton.Location = new System.Drawing.Point(15, 225);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(75, 23);
            this.confirmarButton.TabIndex = 8;
            this.confirmarButton.Text = "Confirmar";
            this.confirmarButton.UseVisualStyleBackColor = true;
            this.confirmarButton.Click += new System.EventHandler(this.confirmarButton_Click);
            // 
            // principalMenuStrip
            // 
            this.principalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comandosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.principalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.principalMenuStrip.Name = "principalMenuStrip";
            this.principalMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.principalMenuStrip.TabIndex = 9;
            this.principalMenuStrip.Text = "menuPrincipal";
            // 
            // comandosToolStripMenuItem
            // 
            this.comandosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.comandosToolStripMenuItem.Name = "comandosToolStripMenuItem";
            this.comandosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.comandosToolStripMenuItem.Text = "Comandos";
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F7)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.testeToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem1,
            this.teste2ToolStripMenuItem});
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testeToolStripMenuItem.Text = "teste";
            // 
            // testeToolStripMenuItem1
            // 
            this.testeToolStripMenuItem1.Name = "testeToolStripMenuItem1";
            this.testeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.testeToolStripMenuItem1.Text = "teste";
            // 
            // teste2ToolStripMenuItem
            // 
            this.teste2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teste3ToolStripMenuItem});
            this.teste2ToolStripMenuItem.Name = "teste2ToolStripMenuItem";
            this.teste2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.teste2ToolStripMenuItem.Text = "teste2";
            // 
            // teste3ToolStripMenuItem
            // 
            this.teste3ToolStripMenuItem.Name = "teste3ToolStripMenuItem";
            this.teste3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.teste3ToolStripMenuItem.Text = "teste3";
            // 
            // cadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.confirmarButton);
            this.Controls.Add(this.horarioLabel);
            this.Controls.Add(this.horarioPanel);
            this.Controls.Add(this.cidadeComboBox);
            this.Controls.Add(this.cidadeLabel);
            this.Controls.Add(this.dataMatriculaDateTimePicker1);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.principalMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.principalMenuStrip;
            this.MaximizeBox = false;
            this.Name = "cadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de aluno";
            this.horarioPanel.ResumeLayout(false);
            this.horarioPanel.PerformLayout();
            this.principalMenuStrip.ResumeLayout(false);
            this.principalMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.DateTimePicker dataMatriculaDateTimePicker1;
        private System.Windows.Forms.Label cidadeLabel;
        private System.Windows.Forms.ComboBox cidadeComboBox;
        private System.Windows.Forms.Panel horarioPanel;
        private System.Windows.Forms.Label horarioLabel;
        private System.Windows.Forms.RadioButton periodoNoiteButton;
        private System.Windows.Forms.RadioButton periodoTardeButton;
        private System.Windows.Forms.RadioButton periodoManhaButton;
        private System.Windows.Forms.Button confirmarButton;
        private System.Windows.Forms.MenuStrip principalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem comandosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teste2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste3ToolStripMenuItem;
    }
}

