namespace SampleFormApplication
{
    partial class UsuarioView
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
            this.idLabel = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.View = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(34, 46);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(16, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Id";
            // 
            // Modelo
            // 
            this.Modelo.Location = new System.Drawing.Point(159, 146);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(75, 23);
            this.Modelo.TabIndex = 1;
            this.Modelo.Text = "Modelo";
            this.Modelo.UseVisualStyleBackColor = true;
            this.Modelo.Click += new System.EventHandler(this.Modelo_Click);
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(93, 43);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 2;
            this.Id.Text = "1";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(93, 69);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 20);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Nome";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(34, 72);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 3;
            this.nomeLabel.Text = "Nome";
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(93, 95);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(100, 20);
            this.Cidade.TabIndex = 6;
            this.Cidade.Text = "Fortaleza";
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Location = new System.Drawing.Point(34, 98);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(40, 13);
            this.cidadeLabel.TabIndex = 5;
            this.cidadeLabel.Text = "Cidade";
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(265, 146);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 7;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // UsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 283);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.cidadeLabel);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.idLabel);
            this.Name = "UsuarioView";
            this.Text = "Usuário View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button Modelo;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.Label cidadeLabel;
        private System.Windows.Forms.Button View;
    }
}

