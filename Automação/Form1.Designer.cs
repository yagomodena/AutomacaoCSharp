namespace Automação
{
    partial class Form1
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
            this.btnMapear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnAdicionarTexto = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnMapear
            // 
            this.btnMapear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapear.Location = new System.Drawing.Point(212, 23);
            this.btnMapear.Name = "btnMapear";
            this.btnMapear.Size = new System.Drawing.Size(137, 42);
            this.btnMapear.TabIndex = 0;
            this.btnMapear.Text = "MAPEAR";
            this.btnMapear.UseVisualStyleBackColor = true;
            this.btnMapear.Click += new System.EventHandler(this.btnMapear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y:";
            // 
            // btnParar
            // 
            this.btnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.Location = new System.Drawing.Point(365, 23);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(137, 42);
            this.btnParar.TabIndex = 8;
            this.btnParar.Text = "PARAR";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Visible = false;
            // 
            // btnAdicionarTexto
            // 
            this.btnAdicionarTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarTexto.Location = new System.Drawing.Point(212, 81);
            this.btnAdicionarTexto.Name = "btnAdicionarTexto";
            this.btnAdicionarTexto.Size = new System.Drawing.Size(290, 42);
            this.btnAdicionarTexto.TabIndex = 9;
            this.btnAdicionarTexto.Text = "ADICIONAR TEXTO";
            this.btnAdicionarTexto.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(212, 139);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(290, 42);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tipo,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 212);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(523, 235);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Etapa";
            this.Tipo.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tipo";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor";
            this.columnHeader2.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 447);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAdicionarTexto);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMapear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMapear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnAdicionarTexto;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

