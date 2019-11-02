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
            this.BTN_CONFIRMA = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.MTB_CPF = new System.Windows.Forms.MaskedTextBox();
            this.TXT_COD_BARRAS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CB_SERIAL = new System.Windows.Forms.ComboBox();
            this.TMR_SERIAL = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTop.AutoSize = true;
            this.labelTop.BackColor = System.Drawing.Color.Transparent;
            this.labelTop.Enabled = false;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(421, 237);
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
            this.labelTopUnder.BackColor = System.Drawing.Color.Transparent;
            this.labelTopUnder.Enabled = false;
            this.labelTopUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopUnder.Location = new System.Drawing.Point(324, 307);
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
            this.labelMensager.BackColor = System.Drawing.Color.Transparent;
            this.labelMensager.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensager.Location = new System.Drawing.Point(279, 408);
            this.labelMensager.Name = "labelMensager";
            this.labelMensager.Size = new System.Drawing.Size(661, 55);
            this.labelMensager.TabIndex = 2;
            this.labelMensager.Text = "Entre com o número do CPF";
            this.labelMensager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_CONFIRMA
            // 
            this.BTN_CONFIRMA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_CONFIRMA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTN_CONFIRMA.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTN_CONFIRMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CONFIRMA.Location = new System.Drawing.Point(457, 602);
            this.BTN_CONFIRMA.Name = "BTN_CONFIRMA";
            this.BTN_CONFIRMA.Size = new System.Drawing.Size(292, 61);
            this.BTN_CONFIRMA.TabIndex = 1;
            this.BTN_CONFIRMA.Text = "&CONFIRMA";
            this.BTN_CONFIRMA.UseVisualStyleBackColor = false;
            this.BTN_CONFIRMA.Click += new System.EventHandler(this.Buttonconfirma_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM0";
            // 
            // MTB_CPF
            // 
            this.MTB_CPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MTB_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTB_CPF.Location = new System.Drawing.Point(475, 511);
            this.MTB_CPF.Mask = "000,000,000-00";
            this.MTB_CPF.Name = "MTB_CPF";
            this.MTB_CPF.Size = new System.Drawing.Size(245, 47);
            this.MTB_CPF.TabIndex = 0;
            this.MTB_CPF.ValidatingType = typeof(int);
            // 
            // TXT_COD_BARRAS
            // 
            this.TXT_COD_BARRAS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_COD_BARRAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_COD_BARRAS.Location = new System.Drawing.Point(475, 511);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::P2Grupo4N21.Properties.Resources.Fundo_RAP_Transparente;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1108, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 108);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CB_SERIAL
            // 
            this.CB_SERIAL.BackColor = System.Drawing.Color.Black;
            this.CB_SERIAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CB_SERIAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CB_SERIAL.FormattingEnabled = true;
            this.CB_SERIAL.Location = new System.Drawing.Point(74, 5);
            this.CB_SERIAL.Name = "CB_SERIAL";
            this.CB_SERIAL.Size = new System.Drawing.Size(130, 28);
            this.CB_SERIAL.TabIndex = 12;
            this.CB_SERIAL.Text = "SELECIONE";
            this.CB_SERIAL.Visible = false;
            // 
            // TMR_SERIAL
            // 
            this.TMR_SERIAL.Enabled = true;
            this.TMR_SERIAL.Interval = 1;
            // 
            // UserControl1
            // 
            this.AcceptButton = this.BTN_CONFIRMA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 825);
            this.Controls.Add(this.CB_SERIAL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_COD_BARRAS);
            this.Controls.Add(this.MTB_CPF);
            this.Controls.Add(this.BTN_CONFIRMA);
            this.Controls.Add(this.labelMensager);
            this.Controls.Add(this.labelTopUnder);
            this.Controls.Add(this.labelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserControl1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reciclando";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserControl1_FormClosed);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelMensager;
        private System.Windows.Forms.Button BTN_CONFIRMA;
        private System.Windows.Forms.Label labelTopUnder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MaskedTextBox MTB_CPF;
        private System.Windows.Forms.TextBox TXT_COD_BARRAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CB_SERIAL;
        private System.Windows.Forms.Timer TMR_SERIAL;
    }
}

