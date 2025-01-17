namespace MyFinancialCrm
{
    partial class frmSpendings
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnDashbord = new System.Windows.Forms.Button();
            this.btnBankProcesses = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.btnCatagoriys = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mskSpendingDate = new System.Windows.Forms.MaskedTextBox();
            this.txtSpendingAmount = new System.Windows.Forms.TextBox();
            this.cmbCategoriyId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateSpendings = new System.Windows.Forms.Button();
            this.btnRemoveSpendings = new System.Windows.Forms.Button();
            this.btnCreateSpendings = new System.Windows.Forms.Button();
            this.btnSpendingsList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpendingTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpendingId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 50);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Harcamalar";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnProperties);
            this.panel1.Controls.Add(this.btnDashbord);
            this.panel1.Controls.Add(this.btnBankProcesses);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Controls.Add(this.btnCatagoriys);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 650);
            this.panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 524);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(213, 56);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProperties
            // 
            this.btnProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnProperties.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProperties.ForeColor = System.Drawing.Color.White;
            this.btnProperties.Location = new System.Drawing.Point(12, 462);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(213, 56);
            this.btnProperties.TabIndex = 6;
            this.btnProperties.Text = "Ayarlar";
            this.btnProperties.UseVisualStyleBackColor = false;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnDashbord
            // 
            this.btnDashbord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnDashbord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashbord.ForeColor = System.Drawing.Color.White;
            this.btnDashbord.Location = new System.Drawing.Point(12, 400);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.Size = new System.Drawing.Size(213, 56);
            this.btnDashbord.TabIndex = 5;
            this.btnDashbord.Text = "Dashbord";
            this.btnDashbord.UseVisualStyleBackColor = false;
            this.btnDashbord.Click += new System.EventHandler(this.btnDashbord_Click);
            // 
            // btnBankProcesses
            // 
            this.btnBankProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnBankProcesses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcesses.ForeColor = System.Drawing.Color.White;
            this.btnBankProcesses.Location = new System.Drawing.Point(12, 338);
            this.btnBankProcesses.Name = "btnBankProcesses";
            this.btnBankProcesses.Size = new System.Drawing.Size(213, 56);
            this.btnBankProcesses.TabIndex = 4;
            this.btnBankProcesses.Text = "Banka Hareketleri";
            this.btnBankProcesses.UseVisualStyleBackColor = false;
            this.btnBankProcesses.Click += new System.EventHandler(this.btnBankProcesses_Click);
            // 
            // btnBillForm
            // 
            this.btnBillForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.White;
            this.btnBillForm.Location = new System.Drawing.Point(12, 276);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(213, 56);
            this.btnBillForm.TabIndex = 3;
            this.btnBillForm.Text = "Giderler";
            this.btnBillForm.UseVisualStyleBackColor = false;
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnBanks
            // 
            this.btnBanks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnBanks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanks.ForeColor = System.Drawing.Color.White;
            this.btnBanks.Location = new System.Drawing.Point(12, 152);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(213, 56);
            this.btnBanks.TabIndex = 1;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.UseVisualStyleBackColor = false;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // btnCatagoriys
            // 
            this.btnCatagoriys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnCatagoriys.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCatagoriys.ForeColor = System.Drawing.Color.White;
            this.btnCatagoriys.Location = new System.Drawing.Point(12, 90);
            this.btnCatagoriys.Name = "btnCatagoriys";
            this.btnCatagoriys.Size = new System.Drawing.Size(213, 56);
            this.btnCatagoriys.TabIndex = 0;
            this.btnCatagoriys.Text = "Kategoriler";
            this.btnCatagoriys.UseVisualStyleBackColor = false;
            this.btnCatagoriys.Click += new System.EventHandler(this.btnCatagoriys_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(250, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 332);
            this.panel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // mskSpendingDate
            // 
            this.mskSpendingDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mskSpendingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskSpendingDate.Location = new System.Drawing.Point(502, 252);
            this.mskSpendingDate.Mask = "00/00/0000";
            this.mskSpendingDate.Name = "mskSpendingDate";
            this.mskSpendingDate.Size = new System.Drawing.Size(416, 30);
            this.mskSpendingDate.TabIndex = 19;
            this.mskSpendingDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskSpendingDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtSpendingAmount
            // 
            this.txtSpendingAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtSpendingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingAmount.Location = new System.Drawing.Point(502, 190);
            this.txtSpendingAmount.Name = "txtSpendingAmount";
            this.txtSpendingAmount.Size = new System.Drawing.Size(416, 30);
            this.txtSpendingAmount.TabIndex = 33;
            // 
            // cmbCategoriyId
            // 
            this.cmbCategoriyId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmbCategoriyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCategoriyId.FormattingEnabled = true;
            this.cmbCategoriyId.Location = new System.Drawing.Point(502, 303);
            this.cmbCategoriyId.Name = "cmbCategoriyId";
            this.cmbCategoriyId.Size = new System.Drawing.Size(416, 33);
            this.cmbCategoriyId.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(365, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Harcama Türü:";
            // 
            // btnUpdateSpendings
            // 
            this.btnUpdateSpendings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSpendings.BackColor = System.Drawing.Color.Lime;
            this.btnUpdateSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateSpendings.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateSpendings.Location = new System.Drawing.Point(969, 292);
            this.btnUpdateSpendings.Name = "btnUpdateSpendings";
            this.btnUpdateSpendings.Size = new System.Drawing.Size(185, 60);
            this.btnUpdateSpendings.TabIndex = 28;
            this.btnUpdateSpendings.Text = "Güncelle";
            this.btnUpdateSpendings.UseVisualStyleBackColor = false;
            this.btnUpdateSpendings.Click += new System.EventHandler(this.btnUpdateSpendings_Click);
            // 
            // btnRemoveSpendings
            // 
            this.btnRemoveSpendings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSpendings.BackColor = System.Drawing.Color.Lime;
            this.btnRemoveSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveSpendings.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveSpendings.Location = new System.Drawing.Point(969, 221);
            this.btnRemoveSpendings.Name = "btnRemoveSpendings";
            this.btnRemoveSpendings.Size = new System.Drawing.Size(185, 60);
            this.btnRemoveSpendings.TabIndex = 27;
            this.btnRemoveSpendings.Text = "Sil";
            this.btnRemoveSpendings.UseVisualStyleBackColor = false;
            this.btnRemoveSpendings.Click += new System.EventHandler(this.btnRemoveSpendings_Click);
            // 
            // btnCreateSpendings
            // 
            this.btnCreateSpendings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateSpendings.BackColor = System.Drawing.Color.Lime;
            this.btnCreateSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateSpendings.ForeColor = System.Drawing.Color.Black;
            this.btnCreateSpendings.Location = new System.Drawing.Point(969, 150);
            this.btnCreateSpendings.Name = "btnCreateSpendings";
            this.btnCreateSpendings.Size = new System.Drawing.Size(185, 60);
            this.btnCreateSpendings.TabIndex = 26;
            this.btnCreateSpendings.Text = "Ekle";
            this.btnCreateSpendings.UseVisualStyleBackColor = false;
            this.btnCreateSpendings.Click += new System.EventHandler(this.btnCreateSpendings_Click);
            // 
            // btnSpendingsList
            // 
            this.btnSpendingsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpendingsList.BackColor = System.Drawing.Color.Lime;
            this.btnSpendingsList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingsList.ForeColor = System.Drawing.Color.Black;
            this.btnSpendingsList.Location = new System.Drawing.Point(969, 78);
            this.btnSpendingsList.Name = "btnSpendingsList";
            this.btnSpendingsList.Size = new System.Drawing.Size(185, 60);
            this.btnSpendingsList.TabIndex = 25;
            this.btnSpendingsList.Text = "Banka Listesi";
            this.btnSpendingsList.UseVisualStyleBackColor = false;
            this.btnSpendingsList.Click += new System.EventHandler(this.btnSpendingsList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(357, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Harcama Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(343, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Harcama Miktarı:";
            // 
            // txtSpendingTitle
            // 
            this.txtSpendingTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtSpendingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingTitle.Location = new System.Drawing.Point(502, 138);
            this.txtSpendingTitle.Name = "txtSpendingTitle";
            this.txtSpendingTitle.Size = new System.Drawing.Size(416, 30);
            this.txtSpendingTitle.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(328, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Harcama Açıklama:";
            // 
            // txtSpendingId
            // 
            this.txtSpendingId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtSpendingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingId.Location = new System.Drawing.Point(502, 92);
            this.txtSpendingId.Name = "txtSpendingId";
            this.txtSpendingId.Size = new System.Drawing.Size(416, 30);
            this.txtSpendingId.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(387, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Harcama Id:";
            // 
            // frmSpendings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.mskSpendingDate);
            this.Controls.Add(this.txtSpendingAmount);
            this.Controls.Add(this.cmbCategoriyId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdateSpendings);
            this.Controls.Add(this.btnRemoveSpendings);
            this.Controls.Add(this.btnCreateSpendings);
            this.Controls.Add(this.btnSpendingsList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSpendingTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpendingId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmSpendings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harcamalar Formu";
            this.Load += new System.EventHandler(this.frmSpendings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Button btnBankProcesses;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnCatagoriys;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskSpendingDate;
        private System.Windows.Forms.TextBox txtSpendingAmount;
        private System.Windows.Forms.ComboBox cmbCategoriyId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdateSpendings;
        private System.Windows.Forms.Button btnRemoveSpendings;
        private System.Windows.Forms.Button btnCreateSpendings;
        private System.Windows.Forms.Button btnSpendingsList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpendingTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpendingId;
        private System.Windows.Forms.Label label5;
    }
}