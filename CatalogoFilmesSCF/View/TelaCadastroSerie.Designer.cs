namespace CatalogoFilmesSCF.View
{
    partial class TelaCadastroSerie
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.txt_Temporadas = new System.Windows.Forms.TextBox();
            this.txb_estreia = new System.Windows.Forms.TextBox();
            this.txbox_serie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.cmb_Categoria.Location = new System.Drawing.Point(412, 253);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(171, 23);
            this.cmb_Categoria.TabIndex = 18;
            // 
            // txt_Temporadas
            // 
            this.txt_Temporadas.Location = new System.Drawing.Point(152, 325);
            this.txt_Temporadas.Name = "txt_Temporadas";
            this.txt_Temporadas.Size = new System.Drawing.Size(171, 23);
            this.txt_Temporadas.TabIndex = 17;
            // 
            // txb_estreia
            // 
            this.txb_estreia.Location = new System.Drawing.Point(152, 253);
            this.txb_estreia.Name = "txb_estreia";
            this.txb_estreia.Size = new System.Drawing.Size(171, 23);
            this.txb_estreia.TabIndex = 16;
            // 
            // txbox_serie
            // 
            this.txbox_serie.Location = new System.Drawing.Point(152, 186);
            this.txbox_serie.Name = "txbox_serie";
            this.txbox_serie.Size = new System.Drawing.Size(431, 23);
            this.txbox_serie.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Temporadas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Th", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(127, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(488, 77);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cadastrar SERIE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Categoria: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Estreia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Serie:";
            // 
            // TelaCadastroSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_Categoria);
            this.Controls.Add(this.txt_Temporadas);
            this.Controls.Add(this.txb_estreia);
            this.Controls.Add(this.txbox_serie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroSerie";
            this.Text = "TelaCadastroSerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox cmb_Categoria;
        private TextBox txt_Temporadas;
        private TextBox txb_estreia;
        private TextBox txbox_serie;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}