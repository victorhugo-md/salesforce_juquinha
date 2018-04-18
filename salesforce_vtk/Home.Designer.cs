namespace salesforce_vtk
{
    partial class Home
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
            this.btnCostumers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCostumers
            // 
            this.btnCostumers.Location = new System.Drawing.Point(21, 12);
            this.btnCostumers.Name = "btnCostumers";
            this.btnCostumers.Size = new System.Drawing.Size(75, 23);
            this.btnCostumers.TabIndex = 0;
            this.btnCostumers.Text = "Clientes";
            this.btnCostumers.UseVisualStyleBackColor = true;
            this.btnCostumers.Click += new System.EventHandler(this.btnCostumers_Click);
            this.btnCostumers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(21, 41);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(75, 23);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Produtos";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            this.btnProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(21, 70);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(75, 23);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Vendas";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            this.btnSales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(21, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 133);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnCostumers);
            this.Name = "Home";
            this.Text = "Juquinha Salesforce";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCostumers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnExit;
    }
}

