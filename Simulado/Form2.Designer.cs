namespace Simulado
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            adicionar = new Button();
            remover = new Button();
            editar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(188, 103);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(430, 202);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // adicionar
            // 
            adicionar.Location = new Point(233, 338);
            adicionar.Name = "adicionar";
            adicionar.Size = new Size(75, 23);
            adicionar.TabIndex = 1;
            adicionar.Text = "Adicionar";
            adicionar.UseVisualStyleBackColor = true;
            adicionar.Click += adicionar_Click;
            // 
            // remover
            // 
            remover.Location = new Point(494, 338);
            remover.Name = "remover";
            remover.Size = new Size(75, 23);
            remover.TabIndex = 2;
            remover.Text = "Remover";
            remover.UseVisualStyleBackColor = true;
            remover.Click += remover_Click;
            // 
            // editar
            // 
            editar.Location = new Point(363, 338);
            editar.Name = "editar";
            editar.Size = new Size(75, 23);
            editar.TabIndex = 3;
            editar.Text = "Editar";
            editar.UseVisualStyleBackColor = true;
            editar.Click += editar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 62);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Contatos";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(editar);
            Controls.Add(remover);
            Controls.Add(adicionar);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button adicionar;
        private Button remover;
        private Button editar;
        private Label label1;
        public DataGridView dataGridView1;
    }
}