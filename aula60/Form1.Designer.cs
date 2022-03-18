
namespace aula60
{
    partial class F_Principal
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
            this.btn_texto = new System.Windows.Forms.Button();
            this.lb_text = new System.Windows.Forms.Label();
            this.inp_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_texto
            // 
            this.btn_texto.BackColor = System.Drawing.Color.Black;
            this.btn_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_texto.ForeColor = System.Drawing.Color.Crimson;
            this.btn_texto.Location = new System.Drawing.Point(16, 63);
            this.btn_texto.Name = "btn_texto";
            this.btn_texto.Size = new System.Drawing.Size(261, 63);
            this.btn_texto.TabIndex = 0;
            this.btn_texto.Text = "OK";
            this.btn_texto.UseVisualStyleBackColor = false;
            this.btn_texto.Click += new System.EventHandler(this.btn_texto_Click);
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Location = new System.Drawing.Point(115, 129);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(45, 20);
            this.lb_text.TabIndex = 1;
            this.lb_text.Text = "FGM";
            // 
            // inp_texto
            // 
            this.inp_texto.Location = new System.Drawing.Point(31, 31);
            this.inp_texto.Name = "inp_texto";
            this.inp_texto.Size = new System.Drawing.Size(228, 26);
            this.inp_texto.TabIndex = 2;
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 555);
            this.Controls.Add(this.inp_texto);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.btn_texto);
            this.Name = "F_Principal";
            this.Text = "FGBM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_texto;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.TextBox inp_texto;
    }
}

