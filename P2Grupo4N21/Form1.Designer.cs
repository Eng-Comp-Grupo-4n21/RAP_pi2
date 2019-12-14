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
            this.CB_SERIAL = new System.Windows.Forms.ComboBox();
            this.TMR_SERIAL = new System.Windows.Forms.Timer(this.components);
            this.GPB_INFO_GARRAFA = new System.Windows.Forms.GroupBox();
            this.PCB_CODIGO_BARRAS = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_IMAGEM_PROGRESSO = new System.Windows.Forms.Label();
            this.PGB_IMAGEM_PROGRESSO = new System.Windows.Forms.ProgressBar();
            this.PCB_FOTO_PET = new System.Windows.Forms.PictureBox();
            this.TXT_PESO_EMBALAGEM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_PESO_LIQUIDO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_PESO_BRUTO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_DESCRICAO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_COD_BARRAS1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXT_JSON_RAP = new System.Windows.Forms.TextBox();
            this.GPB_INFO_GARRAFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_CODIGO_BARRAS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_FOTO_PET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.TXT_COD_BARRAS.Size = new System.Drawing.Size(254, 47);
            this.TXT_COD_BARRAS.TabIndex = 5;
            this.TXT_COD_BARRAS.Text = "7894900530025";
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
            // GPB_INFO_GARRAFA
            // 
            this.GPB_INFO_GARRAFA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPB_INFO_GARRAFA.Controls.Add(this.PCB_CODIGO_BARRAS);
            this.GPB_INFO_GARRAFA.Controls.Add(this.groupBox1);
            this.GPB_INFO_GARRAFA.Controls.Add(this.TXT_PESO_EMBALAGEM);
            this.GPB_INFO_GARRAFA.Controls.Add(this.label7);
            this.GPB_INFO_GARRAFA.Controls.Add(this.TXT_PESO_LIQUIDO);
            this.GPB_INFO_GARRAFA.Controls.Add(this.label6);
            this.GPB_INFO_GARRAFA.Controls.Add(this.TXT_PESO_BRUTO);
            this.GPB_INFO_GARRAFA.Controls.Add(this.label5);
            this.GPB_INFO_GARRAFA.Controls.Add(this.TXT_DESCRICAO);
            this.GPB_INFO_GARRAFA.Controls.Add(this.label3);
            this.GPB_INFO_GARRAFA.Controls.Add(this.TXT_COD_BARRAS1);
            this.GPB_INFO_GARRAFA.Controls.Add(this.label2);
            this.GPB_INFO_GARRAFA.Location = new System.Drawing.Point(12, 511);
            this.GPB_INFO_GARRAFA.Name = "GPB_INFO_GARRAFA";
            this.GPB_INFO_GARRAFA.Size = new System.Drawing.Size(1201, 302);
            this.GPB_INFO_GARRAFA.TabIndex = 13;
            this.GPB_INFO_GARRAFA.TabStop = false;
            this.GPB_INFO_GARRAFA.Visible = false;
            // 
            // PCB_CODIGO_BARRAS
            // 
            this.PCB_CODIGO_BARRAS.BackColor = System.Drawing.Color.Transparent;
            this.PCB_CODIGO_BARRAS.Location = new System.Drawing.Point(376, 16);
            this.PCB_CODIGO_BARRAS.Name = "PCB_CODIGO_BARRAS";
            this.PCB_CODIGO_BARRAS.Size = new System.Drawing.Size(179, 26);
            this.PCB_CODIGO_BARRAS.TabIndex = 13;
            this.PCB_CODIGO_BARRAS.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LBL_IMAGEM_PROGRESSO);
            this.groupBox1.Controls.Add(this.PGB_IMAGEM_PROGRESSO);
            this.groupBox1.Controls.Add(this.PCB_FOTO_PET);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(878, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 277);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FOTO DO PET";
            // 
            // LBL_IMAGEM_PROGRESSO
            // 
            this.LBL_IMAGEM_PROGRESSO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_IMAGEM_PROGRESSO.AutoSize = true;
            this.LBL_IMAGEM_PROGRESSO.BackColor = System.Drawing.Color.Transparent;
            this.LBL_IMAGEM_PROGRESSO.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_IMAGEM_PROGRESSO.Location = new System.Drawing.Point(142, 257);
            this.LBL_IMAGEM_PROGRESSO.Name = "LBL_IMAGEM_PROGRESSO";
            this.LBL_IMAGEM_PROGRESSO.Size = new System.Drawing.Size(35, 14);
            this.LBL_IMAGEM_PROGRESSO.TabIndex = 2;
            this.LBL_IMAGEM_PROGRESSO.Text = "000%";
            this.LBL_IMAGEM_PROGRESSO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PGB_IMAGEM_PROGRESSO
            // 
            this.PGB_IMAGEM_PROGRESSO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PGB_IMAGEM_PROGRESSO.Location = new System.Drawing.Point(7, 257);
            this.PGB_IMAGEM_PROGRESSO.Name = "PGB_IMAGEM_PROGRESSO";
            this.PGB_IMAGEM_PROGRESSO.Size = new System.Drawing.Size(305, 14);
            this.PGB_IMAGEM_PROGRESSO.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PGB_IMAGEM_PROGRESSO.TabIndex = 1;
            // 
            // PCB_FOTO_PET
            // 
            this.PCB_FOTO_PET.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCB_FOTO_PET.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PCB_FOTO_PET.Location = new System.Drawing.Point(6, 25);
            this.PCB_FOTO_PET.Name = "PCB_FOTO_PET";
            this.PCB_FOTO_PET.Size = new System.Drawing.Size(308, 226);
            this.PCB_FOTO_PET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCB_FOTO_PET.TabIndex = 0;
            this.PCB_FOTO_PET.TabStop = false;
            this.PCB_FOTO_PET.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.PCB_FOTO_PET_LoadProgressChanged);
            // 
            // TXT_PESO_EMBALAGEM
            // 
            this.TXT_PESO_EMBALAGEM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PESO_EMBALAGEM.Location = new System.Drawing.Point(181, 146);
            this.TXT_PESO_EMBALAGEM.Name = "TXT_PESO_EMBALAGEM";
            this.TXT_PESO_EMBALAGEM.Size = new System.Drawing.Size(132, 26);
            this.TXT_PESO_EMBALAGEM.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "PESO EMBALAGEM:";
            // 
            // TXT_PESO_LIQUIDO
            // 
            this.TXT_PESO_LIQUIDO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PESO_LIQUIDO.Location = new System.Drawing.Point(154, 114);
            this.TXT_PESO_LIQUIDO.Name = "TXT_PESO_LIQUIDO";
            this.TXT_PESO_LIQUIDO.Size = new System.Drawing.Size(159, 26);
            this.TXT_PESO_LIQUIDO.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "PESO LIQUIDO:";
            // 
            // TXT_PESO_BRUTO
            // 
            this.TXT_PESO_BRUTO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PESO_BRUTO.Location = new System.Drawing.Point(154, 82);
            this.TXT_PESO_BRUTO.Name = "TXT_PESO_BRUTO";
            this.TXT_PESO_BRUTO.Size = new System.Drawing.Size(159, 26);
            this.TXT_PESO_BRUTO.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "PESO BRUTO:";
            // 
            // TXT_DESCRICAO
            // 
            this.TXT_DESCRICAO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DESCRICAO.Location = new System.Drawing.Point(232, 50);
            this.TXT_DESCRICAO.Name = "TXT_DESCRICAO";
            this.TXT_DESCRICAO.Size = new System.Drawing.Size(640, 26);
            this.TXT_DESCRICAO.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESCRIÇÃO DA GARRAFA:";
            // 
            // TXT_COD_BARRAS1
            // 
            this.TXT_COD_BARRAS1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_COD_BARRAS1.Location = new System.Drawing.Point(191, 16);
            this.TXT_COD_BARRAS1.Name = "TXT_COD_BARRAS1";
            this.TXT_COD_BARRAS1.Size = new System.Drawing.Size(179, 26);
            this.TXT_COD_BARRAS1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "CODIGO DE BARRAS:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::P2Grupo4N21.Properties.Resources.img_1568861444187;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 218);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::P2Grupo4N21.Properties.Resources.Fundo_RAP_Transparente;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1008, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 218);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TXT_JSON_RAP
            // 
            this.TXT_JSON_RAP.Location = new System.Drawing.Point(224, 10);
            this.TXT_JSON_RAP.Multiline = true;
            this.TXT_JSON_RAP.Name = "TXT_JSON_RAP";
            this.TXT_JSON_RAP.Size = new System.Drawing.Size(778, 207);
            this.TXT_JSON_RAP.TabIndex = 15;
            this.TXT_JSON_RAP.Visible = false;
            // 
            // UserControl1
            // 
            this.AcceptButton = this.BTN_CONFIRMA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 825);
            this.Controls.Add(this.TXT_JSON_RAP);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.GPB_INFO_GARRAFA);
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
            this.GPB_INFO_GARRAFA.ResumeLayout(false);
            this.GPB_INFO_GARRAFA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_CODIGO_BARRAS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_FOTO_PET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.GroupBox GPB_INFO_GARRAFA;
        private System.Windows.Forms.TextBox TXT_PESO_EMBALAGEM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_PESO_LIQUIDO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_PESO_BRUTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_DESCRICAO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_COD_BARRAS1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PCB_FOTO_PET;
        private System.Windows.Forms.ProgressBar PGB_IMAGEM_PROGRESSO;
        private System.Windows.Forms.Label LBL_IMAGEM_PROGRESSO;
        private System.Windows.Forms.PictureBox PCB_CODIGO_BARRAS;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TXT_JSON_RAP;
    }
}

