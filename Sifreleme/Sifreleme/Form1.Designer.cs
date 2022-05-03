namespace Sifreleme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNormal = new System.Windows.Forms.TextBox();
            this.txtCozunen = new System.Windows.Forms.TextBox();
            this.txtSifreli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnCozumle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNormal
            // 
            this.txtNormal.Location = new System.Drawing.Point(131, 96);
            this.txtNormal.Multiline = true;
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(269, 163);
            this.txtNormal.TabIndex = 0;
            // 
            // txtCozunen
            // 
            this.txtCozunen.Location = new System.Drawing.Point(454, 181);
            this.txtCozunen.Multiline = true;
            this.txtCozunen.Name = "txtCozunen";
            this.txtCozunen.Size = new System.Drawing.Size(269, 170);
            this.txtCozunen.TabIndex = 3;
            // 
            // txtSifreli
            // 
            this.txtSifreli.Location = new System.Drawing.Point(454, 12);
            this.txtSifreli.Multiline = true;
            this.txtSifreli.Name = "txtSifreli";
            this.txtSifreli.Size = new System.Drawing.Size(269, 163);
            this.txtSifreli.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(387, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "➜";
            // 
            // btnSifrele
            // 
            this.btnSifrele.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSifrele.Location = new System.Drawing.Point(12, 58);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(113, 90);
            this.btnSifrele.TabIndex = 5;
            this.btnSifrele.Text = "ŞİFRELE";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // btnCozumle
            // 
            this.btnCozumle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCozumle.Location = new System.Drawing.Point(12, 209);
            this.btnCozumle.Name = "btnCozumle";
            this.btnCozumle.Size = new System.Drawing.Size(113, 90);
            this.btnCozumle.TabIndex = 6;
            this.btnCozumle.Text = "ÇÖZÜMLE";
            this.btnCozumle.UseVisualStyleBackColor = true;
            this.btnCozumle.Click += new System.EventHandler(this.btnCozumle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 363);
            this.Controls.Add(this.btnCozumle);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.txtCozunen);
            this.Controls.Add(this.txtSifreli);
            this.Controls.Add(this.txtNormal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNormal;
        private TextBox txtCozunen;
        private TextBox txtSifreli;
        private Label label1;
        private Button btnSifrele;
        private Button btnCozumle;
    }
}