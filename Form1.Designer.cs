
namespace Aula04fase2APPbanco
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldoValor = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seu saldo atual:";
            // 
            // lblSaldoValor
            // 
            this.lblSaldoValor.AutoSize = true;
            this.lblSaldoValor.BackColor = System.Drawing.Color.Black;
            this.lblSaldoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoValor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaldoValor.Location = new System.Drawing.Point(49, 89);
            this.lblSaldoValor.Name = "lblSaldoValor";
            this.lblSaldoValor.Size = new System.Drawing.Size(43, 18);
            this.lblSaldoValor.TabIndex = 2;
            this.lblSaldoValor.Text = "R$:0";
            this.lblSaldoValor.Click += new System.EventHandler(this.lblSaldoValor_Click);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(35, 4);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(180, 18);
            this.lblTitulo2.TabIndex = 3;
            this.lblTitulo2.Text = "Operaçoes disponiveis";
            this.lblTitulo2.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSacar);
            this.panel1.Controls.Add(this.btnDepositar);
            this.panel1.Controls.Add(this.lblTitulo2);
            this.panel1.Location = new System.Drawing.Point(37, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 272);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblDeposito);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(14, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 187);
            this.panel2.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Black;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.Location = new System.Drawing.Point(70, 144);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 38);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(22, 76);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(177, 20);
            this.txtValor.TabIndex = 11;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Informe o valor:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(3, 9);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(93, 18);
            this.lblDeposito.TabIndex = 9;
            this.lblDeposito.Text = "DEPÓSITO";
            this.lblDeposito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDeposito.Click += new System.EventHandler(this.lblDeposito_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.Black;
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.ForeColor = System.Drawing.Color.White;
            this.btnSacar.Location = new System.Drawing.Point(131, 25);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(116, 39);
            this.btnSacar.TabIndex = 7;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.Black;
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.ForeColor = System.Drawing.Color.White;
            this.btnDepositar.Location = new System.Drawing.Point(14, 25);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(111, 39);
            this.btnDepositar.TabIndex = 6;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnExtrato
            // 
            this.btnExtrato.BackColor = System.Drawing.Color.Black;
            this.btnExtrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrato.ForeColor = System.Drawing.Color.White;
            this.btnExtrato.Location = new System.Drawing.Point(186, 77);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(99, 30);
            this.btnExtrato.TabIndex = 5;
            this.btnExtrato.Text = "Ver extrato";
            this.btnExtrato.UseVisualStyleBackColor = false;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Black;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(6, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(131, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Eduzito\'Bank";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-253, -135);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(523, 457);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(330, 463);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSaldoValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldoValor;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnExtrato;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

