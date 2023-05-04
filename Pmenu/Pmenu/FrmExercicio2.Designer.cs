namespace Pmenu
{
    partial class FrmExercicio2
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
            this.btnCompara = new System.Windows.Forms.Button();
            this.btnInsere1 = new System.Windows.Forms.Button();
            this.btnInsere2 = new System.Windows.Forms.Button();
            this.lblpalavra1 = new System.Windows.Forms.Label();
            this.lblpalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(179, 328);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(82, 53);
            this.btnCompara.TabIndex = 0;
            this.btnCompara.Text = "Verificar se são iguais";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.BtnCompara_Click);
            // 
            // btnInsere1
            // 
            this.btnInsere1.Location = new System.Drawing.Point(317, 328);
            this.btnInsere1.Name = "btnInsere1";
            this.btnInsere1.Size = new System.Drawing.Size(82, 53);
            this.btnInsere1.TabIndex = 1;
            this.btnInsere1.Text = "Insere 1° no meio do 2°";
            this.btnInsere1.UseVisualStyleBackColor = true;
            this.btnInsere1.Click += new System.EventHandler(this.BtnInsere1_Click);
            // 
            // btnInsere2
            // 
            this.btnInsere2.Location = new System.Drawing.Point(464, 328);
            this.btnInsere2.Name = "btnInsere2";
            this.btnInsere2.Size = new System.Drawing.Size(82, 53);
            this.btnInsere2.TabIndex = 2;
            this.btnInsere2.Text = "Insere ** no meio da 1°";
            this.btnInsere2.UseVisualStyleBackColor = true;
            this.btnInsere2.Click += new System.EventHandler(this.BtnInsere2_Click);
            // 
            // lblpalavra1
            // 
            this.lblpalavra1.AutoSize = true;
            this.lblpalavra1.Location = new System.Drawing.Point(45, 55);
            this.lblpalavra1.Name = "lblpalavra1";
            this.lblpalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblpalavra1.TabIndex = 3;
            this.lblpalavra1.Text = "Palavra 1";
            // 
            // lblpalavra2
            // 
            this.lblpalavra2.AutoSize = true;
            this.lblpalavra2.Location = new System.Drawing.Point(45, 143);
            this.lblpalavra2.Name = "lblpalavra2";
            this.lblpalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblpalavra2.TabIndex = 4;
            this.lblpalavra2.Text = "Palavra 2";
            this.lblpalavra2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(391, 48);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 5;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(391, 136);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 6;
            // 
            // FrmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblpalavra2);
            this.Controls.Add(this.lblpalavra1);
            this.Controls.Add(this.btnInsere2);
            this.Controls.Add(this.btnInsere1);
            this.Controls.Add(this.btnCompara);
            this.Name = "FrmExercicio2";
            this.Text = "FrmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.Button btnInsere1;
        private System.Windows.Forms.Button btnInsere2;
        private System.Windows.Forms.Label lblpalavra1;
        private System.Windows.Forms.Label lblpalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
    }
}