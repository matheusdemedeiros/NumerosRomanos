namespace NumerosRomanos.WinApp
{
    partial class TelaPrincipalForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRomano = new System.Windows.Forms.TextBox();
            this.txtArabico = new System.Windows.Forms.TextBox();
            this.btnConverterParaArabico = new System.Windows.Forms.Button();
            this.btnConverterParaRomano = new System.Windows.Forms.Button();
            this.labelHoraRomana = new System.Windows.Forms.Label();
            this.labelSegundoArabico = new System.Windows.Forms.Label();
            this.labelMinutoRomano = new System.Windows.Forms.Label();
            this.labelSegundoRomano = new System.Windows.Forms.Label();
            this.labelHoraArabico = new System.Windows.Forms.Label();
            this.labelMinutoArabico = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número romano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número arábico:";
            // 
            // txtRomano
            // 
            this.txtRomano.Location = new System.Drawing.Point(125, 29);
            this.txtRomano.Name = "txtRomano";
            this.txtRomano.Size = new System.Drawing.Size(170, 23);
            this.txtRomano.TabIndex = 2;
            // 
            // txtArabico
            // 
            this.txtArabico.Location = new System.Drawing.Point(125, 71);
            this.txtArabico.Name = "txtArabico";
            this.txtArabico.Size = new System.Drawing.Size(170, 23);
            this.txtArabico.TabIndex = 3;
            // 
            // btnConverterParaArabico
            // 
            this.btnConverterParaArabico.Location = new System.Drawing.Point(313, 28);
            this.btnConverterParaArabico.Name = "btnConverterParaArabico";
            this.btnConverterParaArabico.Size = new System.Drawing.Size(157, 23);
            this.btnConverterParaArabico.TabIndex = 4;
            this.btnConverterParaArabico.Text = "Converter para Arábico";
            this.btnConverterParaArabico.UseVisualStyleBackColor = true;
            this.btnConverterParaArabico.Click += new System.EventHandler(this.btnConverterParaArabico_Click);
            // 
            // btnConverterParaRomano
            // 
            this.btnConverterParaRomano.Location = new System.Drawing.Point(313, 75);
            this.btnConverterParaRomano.Name = "btnConverterParaRomano";
            this.btnConverterParaRomano.Size = new System.Drawing.Size(157, 23);
            this.btnConverterParaRomano.TabIndex = 5;
            this.btnConverterParaRomano.Text = "Converter para Romano";
            this.btnConverterParaRomano.UseVisualStyleBackColor = true;
            this.btnConverterParaRomano.Click += new System.EventHandler(this.btnConverterParaRomano_Click);
            // 
            // labelHoraRomana
            // 
            this.labelHoraRomana.AutoSize = true;
            this.labelHoraRomana.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHoraRomana.Location = new System.Drawing.Point(133, 150);
            this.labelHoraRomana.Name = "labelHoraRomana";
            this.labelHoraRomana.Size = new System.Drawing.Size(63, 25);
            this.labelHoraRomana.TabIndex = 6;
            this.labelHoraRomana.Text = "label3";
            // 
            // labelSegundoArabico
            // 
            this.labelSegundoArabico.AutoSize = true;
            this.labelSegundoArabico.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSegundoArabico.Location = new System.Drawing.Point(317, 192);
            this.labelSegundoArabico.Name = "labelSegundoArabico";
            this.labelSegundoArabico.Size = new System.Drawing.Size(63, 25);
            this.labelSegundoArabico.TabIndex = 7;
            this.labelSegundoArabico.Text = "label4";
            // 
            // labelMinutoRomano
            // 
            this.labelMinutoRomano.AutoSize = true;
            this.labelMinutoRomano.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMinutoRomano.Location = new System.Drawing.Point(225, 150);
            this.labelMinutoRomano.Name = "labelMinutoRomano";
            this.labelMinutoRomano.Size = new System.Drawing.Size(63, 25);
            this.labelMinutoRomano.TabIndex = 8;
            this.labelMinutoRomano.Text = "label5";
            // 
            // labelSegundoRomano
            // 
            this.labelSegundoRomano.AutoSize = true;
            this.labelSegundoRomano.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSegundoRomano.Location = new System.Drawing.Point(317, 150);
            this.labelSegundoRomano.Name = "labelSegundoRomano";
            this.labelSegundoRomano.Size = new System.Drawing.Size(63, 25);
            this.labelSegundoRomano.TabIndex = 9;
            this.labelSegundoRomano.Text = "label6";
            // 
            // labelHoraArabico
            // 
            this.labelHoraArabico.AutoSize = true;
            this.labelHoraArabico.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHoraArabico.Location = new System.Drawing.Point(133, 192);
            this.labelHoraArabico.Name = "labelHoraArabico";
            this.labelHoraArabico.Size = new System.Drawing.Size(63, 25);
            this.labelHoraArabico.TabIndex = 10;
            this.labelHoraArabico.Text = "label7";
            // 
            // labelMinutoArabico
            // 
            this.labelMinutoArabico.AutoSize = true;
            this.labelMinutoArabico.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMinutoArabico.Location = new System.Drawing.Point(225, 192);
            this.labelMinutoArabico.Name = "labelMinutoArabico";
            this.labelMinutoArabico.Size = new System.Drawing.Size(63, 25);
            this.labelMinutoArabico.TabIndex = 11;
            this.labelMinutoArabico.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(294, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(202, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(202, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(294, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Não se atrase...";
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 258);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelMinutoArabico);
            this.Controls.Add(this.labelHoraArabico);
            this.Controls.Add(this.labelSegundoRomano);
            this.Controls.Add(this.labelMinutoRomano);
            this.Controls.Add(this.labelSegundoArabico);
            this.Controls.Add(this.labelHoraRomana);
            this.Controls.Add(this.btnConverterParaRomano);
            this.Controls.Add(this.btnConverterParaArabico);
            this.Controls.Add(this.txtArabico);
            this.Controls.Add(this.txtRomano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Números Romanos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaPrincipalForm_FormClosing);
            this.Load += new System.EventHandler(this.TelaPrincipalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRomano;
        private System.Windows.Forms.TextBox txtArabico;
        private System.Windows.Forms.Button btnConverterParaArabico;
        private System.Windows.Forms.Button btnConverterParaRomano;
        private System.Windows.Forms.Label labelHoraRomana;
        private System.Windows.Forms.Label labelSegundoArabico;
        private System.Windows.Forms.Label labelMinutoRomano;
        private System.Windows.Forms.Label labelSegundoRomano;
        private System.Windows.Forms.Label labelHoraArabico;
        private System.Windows.Forms.Label labelMinutoArabico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
    }
}
