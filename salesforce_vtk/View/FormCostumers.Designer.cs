namespace salesforce_vtk.View
{
    partial class FormCostumers
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbReference = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(204, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(38, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 20);
            this.txtName.TabIndex = 0;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCostumers_KeyDown);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(38, 118);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(211, 46);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCostumers_KeyDown);
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(38, 186);
            this.txtReference.Multiline = true;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(211, 52);
            this.txtReference.TabIndex = 2;
            this.txtReference.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCostumers_KeyDown);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(38, 270);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(211, 76);
            this.txtContact.TabIndex = 3;
            this.txtContact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCostumers_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(35, 49);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(35, 13);
            this.lbFullName.TabIndex = 5;
            this.lbFullName.Text = "Nome";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(35, 102);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(53, 13);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "Endereço";
            // 
            // lbReference
            // 
            this.lbReference.AutoSize = true;
            this.lbReference.Location = new System.Drawing.Point(35, 170);
            this.lbReference.Name = "lbReference";
            this.lbReference.Size = new System.Drawing.Size(105, 13);
            this.lbReference.TabIndex = 7;
            this.lbReference.Text = "Ponto de Referência";
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Location = new System.Drawing.Point(35, 254);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(44, 13);
            this.lbContact.TabIndex = 8;
            this.lbContact.Text = "Contato";
            // 
            // FormCostumers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 419);
            this.Controls.Add(this.lbContact);
            this.Controls.Add(this.lbReference);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnBack);
            this.Name = "FormCostumers";
            this.Text = "Cadastro de clientes";
            this.Load += new System.EventHandler(this.FormCostumers_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCostumers_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbReference;
        private System.Windows.Forms.Label lbContact;
    }
}