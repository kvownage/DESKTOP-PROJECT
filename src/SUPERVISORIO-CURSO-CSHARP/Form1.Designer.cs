namespace SUPERVISORIO_CURSO_CSHARP
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
            this.lblCaixaAlta = new System.Windows.Forms.Label();
            this.lblCaixaBaixa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnLiga = new System.Windows.Forms.Button();
            this.btnDesliga = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConectado = new System.Windows.Forms.Label();
            this.lblConected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaixaAlta
            // 
            this.lblCaixaAlta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCaixaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixaAlta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCaixaAlta.Location = new System.Drawing.Point(721, 326);
            this.lblCaixaAlta.Name = "lblCaixaAlta";
            this.lblCaixaAlta.Size = new System.Drawing.Size(265, 202);
            this.lblCaixaAlta.TabIndex = 3;
            this.lblCaixaAlta.Text = "0";
            this.lblCaixaAlta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaixaBaixa
            // 
            this.lblCaixaBaixa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCaixaBaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.lblCaixaBaixa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCaixaBaixa.Location = new System.Drawing.Point(1139, 326);
            this.lblCaixaBaixa.Name = "lblCaixaBaixa";
            this.lblCaixaBaixa.Size = new System.Drawing.Size(265, 202);
            this.lblCaixaBaixa.TabIndex = 4;
            this.lblCaixaBaixa.Text = "0";
            this.lblCaixaBaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1087, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Produção Caixa Baixa";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInfo.Location = new System.Drawing.Point(0, 687);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(1902, 146);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Clique em conectar para iniciar";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(1666, 37);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(187, 58);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnLiga
            // 
            this.btnLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiga.Location = new System.Drawing.Point(107, 246);
            this.btnLiga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLiga.Name = "btnLiga";
            this.btnLiga.Size = new System.Drawing.Size(355, 81);
            this.btnLiga.TabIndex = 0;
            this.btnLiga.Text = "LIGA";
            this.btnLiga.UseVisualStyleBackColor = true;
            this.btnLiga.Click += new System.EventHandler(this.btnLiga_Click);
            // 
            // btnDesliga
            // 
            this.btnDesliga.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnDesliga.Location = new System.Drawing.Point(107, 388);
            this.btnDesliga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesliga.Name = "btnDesliga";
            this.btnDesliga.Size = new System.Drawing.Size(355, 81);
            this.btnDesliga.TabIndex = 1;
            this.btnDesliga.Text = "DESLIGA";
            this.btnDesliga.UseVisualStyleBackColor = true;
            this.btnDesliga.Click += new System.EventHandler(this.btnDesliga_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(107, 535);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(355, 81);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(678, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produção Caixa Alta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblConectado
            // 
            this.lblConectado.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblConectado.AutoSize = true;
            this.lblConectado.BackColor = System.Drawing.Color.Red;
            this.lblConectado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConectado.Location = new System.Drawing.Point(1672, 48);
            this.lblConectado.Name = "lblConectado";
            this.lblConectado.Size = new System.Drawing.Size(0, 16);
            this.lblConectado.TabIndex = 9;
            // 
            // lblConected
            // 
            this.lblConected.BackColor = System.Drawing.Color.Red;
            this.lblConected.Location = new System.Drawing.Point(1627, 37);
            this.lblConected.Name = "lblConected";
            this.lblConected.Size = new System.Drawing.Size(43, 58);
            this.lblConected.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 69);
            this.label1.TabIndex = 11;
            this.label1.Text = "Separador de caixas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SUPERVISORIO_CURSO_CSHARP.Properties.Resources.esteira_transportadora_grau;
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-1, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1903, 71);
            this.label4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 833);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConected);
            this.Controls.Add(this.lblConectado);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCaixaBaixa);
            this.Controls.Add(this.lblCaixaAlta);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDesliga);
            this.Controls.Add(this.btnLiga);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Onclosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCaixaAlta;
        private System.Windows.Forms.Label lblCaixaBaixa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnLiga;
        private System.Windows.Forms.Button btnDesliga;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConectado;
        private System.Windows.Forms.Label lblConected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

