namespace Simulado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            adicionar = new Button();
            NomeBox = new TextBox();
            SobrenomeBox = new TextBox();
            TelefoneBox = new TextBox();
            comboBox1 = new ComboBox();
            Tipo = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // adicionar
            // 
            adicionar.Location = new Point(68, 285);
            adicionar.Name = "adicionar";
            adicionar.Size = new Size(75, 23);
            adicionar.TabIndex = 0;
            adicionar.Text = "Adicionar";
            adicionar.UseVisualStyleBackColor = true;
            adicionar.Click += adicionar_Click;
            // 
            // NomeBox
            // 
            NomeBox.Location = new Point(68, 79);
            NomeBox.Name = "NomeBox";
            NomeBox.Size = new Size(217, 23);
            NomeBox.TabIndex = 1;
            NomeBox.TextChanged += NomeBox_TextChanged;
            // 
            // SobrenomeBox
            // 
            SobrenomeBox.Location = new Point(68, 143);
            SobrenomeBox.Name = "SobrenomeBox";
            SobrenomeBox.Size = new Size(217, 23);
            SobrenomeBox.TabIndex = 2;
            SobrenomeBox.TextChanged += SobrenomeBox_TextChanged;
            // 
            // TelefoneBox
            // 
            TelefoneBox.Location = new Point(68, 211);
            TelefoneBox.Name = "TelefoneBox";
            TelefoneBox.Size = new Size(217, 23);
            TelefoneBox.TabIndex = 3;
            TelefoneBox.TextChanged += TelefoneBox_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Zap ", "Celular", "Comercial" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(409, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Tipo
            // 
            Tipo.AutoSize = true;
            Tipo.Location = new Point(409, 61);
            Tipo.Name = "Tipo";
            Tipo.Size = new Size(30, 15);
            Tipo.TabIndex = 5;
            Tipo.Text = "Tipo";
            Tipo.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 61);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 125);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 7;
            label3.Text = "Sobrenome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 193);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "Telefone";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Tipo);
            Controls.Add(comboBox1);
            Controls.Add(TelefoneBox);
            Controls.Add(SobrenomeBox);
            Controls.Add(NomeBox);
            Controls.Add(adicionar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adicionar;
        private TextBox NomeBox;
        private TextBox SobrenomeBox;
        private TextBox TelefoneBox;
        private Label Tipo;
        private Label label2;
        private Label label3;
        private Label label4;
        public ComboBox comboBox1;
    }
}
