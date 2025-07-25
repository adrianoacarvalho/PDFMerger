namespace PDFMerger
{
    partial class PdfMergerForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfMergerForm));
            this.listBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.mergeButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(6, 13);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(782, 199);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(12, 218);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(179, 52);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Adicionar Arquivos PDF";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // mergeButton
            // 
            this.mergeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mergeButton.Image = ((System.Drawing.Image)(resources.GetObject("mergeButton.Image")));
            this.mergeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mergeButton.Location = new System.Drawing.Point(609, 218);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(179, 52);
            this.mergeButton.TabIndex = 2;
            this.mergeButton.Text = "Unir Arquivos PDF e Salvar";
            this.mergeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanButton.Image = ((System.Drawing.Image)(resources.GetObject("cleanButton.Image")));
            this.cleanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cleanButton.Location = new System.Drawing.Point(197, 218);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(179, 52);
            this.cleanButton.TabIndex = 3;
            this.cleanButton.Text = "Limpar Lista";
            this.cleanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cleanButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // PdfMergerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PdfMergerForm";
            this.Text = "PDFMerger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Button cleanButton;
    }
}

