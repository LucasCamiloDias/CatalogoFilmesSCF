namespace CatalogoFilmesSCF.View
{
    partial class TelaCadastroFilme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbox_filme = new System.Windows.Forms.TextBox();
            this.txb_estreia = new System.Windows.Forms.TextBox();
            this.txt_duracao = new System.Windows.Forms.TextBox();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estreia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Th", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(88, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(497, 77);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cadastrar FILME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duração:";
            // 
            // txbox_filme
            // 
            this.txbox_filme.Location = new System.Drawing.Point(113, 183);
            this.txbox_filme.Name = "txbox_filme";
            this.txbox_filme.Size = new System.Drawing.Size(431, 23);
            this.txbox_filme.TabIndex = 5;
            // 
            // txb_estreia
            // 
            this.txb_estreia.Location = new System.Drawing.Point(113, 250);
            this.txb_estreia.Name = "txb_estreia";
            this.txb_estreia.Size = new System.Drawing.Size(171, 23);
            this.txb_estreia.TabIndex = 6;
            // 
            // txt_duracao
            // 
            this.txt_duracao.Location = new System.Drawing.Point(113, 322);
            this.txt_duracao.Name = "txt_duracao";
            this.txt_duracao.Size = new System.Drawing.Size(171, 23);
            this.txt_duracao.TabIndex = 7;
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Items.AddRange(new object[] {
            "Terror",
            "",
            "Romance",
            "",
            "Comédia",
            "",
            "Ficção",
            "",
            "Ação",
            "",
            "Suspense",
            "",
            "Drama",
            "",
            "Animação"});
            this.cmb_Categoria.Location = new System.Drawing.Point(373, 250);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(171, 23);
            this.cmb_Categoria.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaCadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_Categoria);
            this.Controls.Add(this.txt_duracao);
            this.Controls.Add(this.txb_estreia);
            this.Controls.Add(this.txbox_filme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroFilme";
            this.Text = "TelaCadastroFilme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbox_filme;
        private TextBox txb_estreia;
        private TextBox txt_duracao;
        private ComboBox cmb_Categoria;
        private Button button1;
    }
}