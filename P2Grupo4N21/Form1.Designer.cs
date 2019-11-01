namespace P2Grupo4N21
{
    partial class UserControl1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.labelTop = new System.Windows.Forms.Label();
            this.labelTopUnder = new System.Windows.Forms.Label();
            this.labelMensager = new System.Windows.Forms.Label();
            this.buttonconfirma = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Editcpf1 = new System.Windows.Forms.MaskedTextBox();
            this.TXT_COD_BARRAS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTop.AutoSize = true;
            this.labelTop.Enabled = false;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(265, 68);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(350, 55);
            this.labelTop.TabIndex = 4;
            this.labelTop.Text = "RECICLANDO";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTopUnder
            // 
            this.labelTopUnder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTopUnder.AutoSize = true;
            this.labelTopUnder.Enabled = false;
            this.labelTopUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopUnder.Location = new System.Drawing.Point(168, 138);
            this.labelTopUnder.Name = "labelTopUnder";
            this.labelTopUnder.Size = new System.Drawing.Size(583, 55);
            this.labelTopUnder.TabIndex = 3;
            this.labelTopUnder.Text = "GARRAFAS PLÁSTICAS";
            this.labelTopUnder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMensager
            // 
            this.labelMensager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMensager.AutoSize = true;
            this.labelMensager.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensager.Location = new System.Drawing.Point(123, 239);
            this.labelMensager.Name = "labelMensager";
            this.labelMensager.Size = new System.Drawing.Size(661, 55);
            this.labelMensager.TabIndex = 2;
            this.labelMensager.Text = "Entre com o número do CPF";
            this.labelMensager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonconfirma
            // 
            this.buttonconfirma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonconfirma.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonconfirma.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonconfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconfirma.Location = new System.Drawing.Point(301, 433);
            this.buttonconfirma.Name = "buttonconfirma";
            this.buttonconfirma.Size = new System.Drawing.Size(292, 61);
            this.buttonconfirma.TabIndex = 1;
            this.buttonconfirma.Text = "buttonconfirma";
            this.buttonconfirma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonconfirma.UseVisualStyleBackColor = false;
            this.buttonconfirma.Click += new System.EventHandler(this.Buttonconfirma_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM99";
            // 
            // Editcpf1
            // 
            this.Editcpf1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Editcpf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editcpf1.Location = new System.Drawing.Point(319, 342);
            this.Editcpf1.Mask = "000,000,000-00";
            this.Editcpf1.Name = "Editcpf1";
            this.Editcpf1.Size = new System.Drawing.Size(245, 47);
            this.Editcpf1.TabIndex = 0;
            this.Editcpf1.ValidatingType = typeof(int);
            // 
            // TXT_COD_BARRAS
            // 
            this.TXT_COD_BARRAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_COD_BARRAS.Location = new System.Drawing.Point(319, 342);
            this.TXT_COD_BARRAS.Name = "TXT_COD_BARRAS";
            this.TXT_COD_BARRAS.Size = new System.Drawing.Size(245, 47);
            this.TXT_COD_BARRAS.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // UserControl1
            // 
            this.AcceptButton = this.buttonconfirma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_COD_BARRAS);
            this.Controls.Add(this.Editcpf1);
            this.Controls.Add(this.buttonconfirma);
            this.Controls.Add(this.labelMensager);
            this.Controls.Add(this.labelTopUnder);
            this.Controls.Add(this.labelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserControl1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reciclando";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserControl1_FormClosed);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelMensager;
        private System.Windows.Forms.Button buttonconfirma;
        private System.Windows.Forms.Label labelTopUnder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MaskedTextBox Editcpf1;
        private System.Windows.Forms.TextBox TXT_COD_BARRAS;
        private System.Windows.Forms.Label label1;
    }
}

