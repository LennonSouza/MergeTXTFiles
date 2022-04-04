namespace JuntarTXT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_join = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.ofd_Files = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_join
            // 
            this.btn_join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_join.Location = new System.Drawing.Point(274, 8);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(50, 22);
            this.btn_join.TabIndex = 0;
            this.btn_join.Text = "Join";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(12, 9);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(256, 20);
            this.txt_path.TabIndex = 1;
            // 
            // ofd_Files
            // 
            this.ofd_Files.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 41);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_join);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge TXT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.OpenFileDialog ofd_Files;
    }
}

