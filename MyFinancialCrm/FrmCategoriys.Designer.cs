namespace MyFinancialCrm
{
    partial class FrmCategoriys
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdateCategoriy = new System.Windows.Forms.Button();
            this.btnRemoveCategoriy = new System.Windows.Forms.Button();
            this.btnCreateCategoriy = new System.Windows.Forms.Button();
            this.btnCategoriyList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoriyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoriyId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnDashbord = new System.Windows.Forms.Button();
            this.btnBankProcesses = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnSpendings = new System.Windows.Forms.Button();
            this.btnBaksForm = new System.Windows.Forms.Button();
            this.btnCatagoriys = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(287, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 396);
            this.panel1.TabIndex = 0;
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
            this.dataGridView1.Size = new System.Drawing.Size(945, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUpdateCategoriy
            // 
            this.btnUpdateCategoriy.BackColor = System.Drawing.Color.Lime;
            this.btnUpdateCategoriy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCategoriy.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCategoriy.Location = new System.Drawing.Point(970, 211);
            this.btnUpdateCategoriy.Name = "btnUpdateCategoriy";
            this.btnUpdateCategoriy.Size = new System.Drawing.Size(179, 42);
            this.btnUpdateCategoriy.TabIndex = 15;
            this.btnUpdateCategoriy.Text = "Kategori Güncelle";
            this.btnUpdateCategoriy.UseVisualStyleBackColor = false;
            this.btnUpdateCategoriy.Click += new System.EventHandler(this.btnUpdateCategoriy_Click);
            // 
            // btnRemoveCategoriy
            // 
            this.btnRemoveCategoriy.BackColor = System.Drawing.Color.Lime;
            this.btnRemoveCategoriy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveCategoriy.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveCategoriy.Location = new System.Drawing.Point(785, 211);
            this.btnRemoveCategoriy.Name = "btnRemoveCategoriy";
            this.btnRemoveCategoriy.Size = new System.Drawing.Size(179, 42);
            this.btnRemoveCategoriy.TabIndex = 14;
            this.btnRemoveCategoriy.Text = "Kategori Sil";
            this.btnRemoveCategoriy.UseVisualStyleBackColor = false;
            this.btnRemoveCategoriy.Click += new System.EventHandler(this.btnRemoveCategoriy_Click);
            // 
            // btnCreateCategoriy
            // 
            this.btnCreateCategoriy.BackColor = System.Drawing.Color.Lime;
            this.btnCreateCategoriy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateCategoriy.ForeColor = System.Drawing.Color.Black;
            this.btnCreateCategoriy.Location = new System.Drawing.Point(600, 211);
            this.btnCreateCategoriy.Name = "btnCreateCategoriy";
            this.btnCreateCategoriy.Size = new System.Drawing.Size(179, 42);
            this.btnCreateCategoriy.TabIndex = 13;
            this.btnCreateCategoriy.Text = "Yeni Kategori";
            this.btnCreateCategoriy.UseVisualStyleBackColor = false;
            this.btnCreateCategoriy.Click += new System.EventHandler(this.btnCreateCategoriy_Click);
            // 
            // btnCategoriyList
            // 
            this.btnCategoriyList.BackColor = System.Drawing.Color.Lime;
            this.btnCategoriyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoriyList.ForeColor = System.Drawing.Color.Black;
            this.btnCategoriyList.Location = new System.Drawing.Point(415, 211);
            this.btnCategoriyList.Name = "btnCategoriyList";
            this.btnCategoriyList.Size = new System.Drawing.Size(179, 42);
            this.btnCategoriyList.TabIndex = 12;
            this.btnCategoriyList.Text = "Kategori Listesi";
            this.btnCategoriyList.UseVisualStyleBackColor = false;
            this.btnCategoriyList.Click += new System.EventHandler(this.btnCategoriyList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(467, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategori:";
            // 
            // txtCategoriyName
            // 
            this.txtCategoriyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCategoriyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoriyName.Location = new System.Drawing.Point(556, 135);
            this.txtCategoriyName.Name = "txtCategoriyName";
            this.txtCategoriyName.Size = new System.Drawing.Size(519, 28);
            this.txtCategoriyName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(448, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Id:";
            // 
            // txtCategoriyId
            // 
            this.txtCategoriyId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCategoriyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoriyId.Location = new System.Drawing.Point(556, 101);
            this.txtCategoriyId.Name = "txtCategoriyId";
            this.txtCategoriyId.Size = new System.Drawing.Size(519, 28);
            this.txtCategoriyId.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnProperties);
            this.panel3.Controls.Add(this.btnDashbord);
            this.panel3.Controls.Add(this.btnBankProcesses);
            this.panel3.Controls.Add(this.btnBillForm);
            this.panel3.Controls.Add(this.btnSpendings);
            this.panel3.Controls.Add(this.btnBaksForm);
            this.panel3.Controls.Add(this.btnCatagoriys);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(1, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 647);
            this.panel3.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(30, 555);
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
            this.btnProperties.Location = new System.Drawing.Point(30, 477);
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
            this.btnDashbord.Location = new System.Drawing.Point(30, 396);
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
            this.btnBankProcesses.Location = new System.Drawing.Point(30, 321);
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
            this.btnBillForm.Location = new System.Drawing.Point(30, 251);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(213, 56);
            this.btnBillForm.TabIndex = 3;
            this.btnBillForm.Text = "Giderler";
            this.btnBillForm.UseVisualStyleBackColor = false;
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
            // 
            // btnSpendings
            // 
            this.btnSpendings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendings.ForeColor = System.Drawing.Color.White;
            this.btnSpendings.Location = new System.Drawing.Point(30, 174);
            this.btnSpendings.Name = "btnSpendings";
            this.btnSpendings.Size = new System.Drawing.Size(213, 56);
            this.btnSpendings.TabIndex = 2;
            this.btnSpendings.Text = "Faturalar";
            this.btnSpendings.UseVisualStyleBackColor = false;
            this.btnSpendings.Click += new System.EventHandler(this.btnSpendings_Click);
            // 
            // btnBaksForm
            // 
            this.btnBaksForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnBaksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaksForm.ForeColor = System.Drawing.Color.White;
            this.btnBaksForm.Location = new System.Drawing.Point(30, 99);
            this.btnBaksForm.Name = "btnBaksForm";
            this.btnBaksForm.Size = new System.Drawing.Size(213, 56);
            this.btnBaksForm.TabIndex = 1;
            this.btnBaksForm.Text = "Bankalar";
            this.btnBaksForm.UseVisualStyleBackColor = false;
            this.btnBaksForm.Click += new System.EventHandler(this.btnBaksForm_Click);
            // 
            // btnCatagoriys
            // 
            this.btnCatagoriys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnCatagoriys.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCatagoriys.ForeColor = System.Drawing.Color.White;
            this.btnCatagoriys.Location = new System.Drawing.Point(30, 23);
            this.btnCatagoriys.Name = "btnCatagoriys";
            this.btnCatagoriys.Size = new System.Drawing.Size(213, 56);
            this.btnCatagoriys.TabIndex = 0;
            this.btnCatagoriys.Text = "Kategoriler";
            this.btnCatagoriys.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1231, 60);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Formu";
            // 
            // FrmCategoriys
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.btnUpdateCategoriy);
            this.Controls.Add(this.btnRemoveCategoriy);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnCreateCategoriy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCategoriyList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategoriyName);
            this.Controls.Add(this.txtCategoriyId);
            this.Controls.Add(this.label2);
            this.Name = "FrmCategoriys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoriys";
            this.Load += new System.EventHandler(this.FrmCategoriys_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Button btnBankProcesses;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnSpendings;
        private System.Windows.Forms.Button btnBaksForm;
        private System.Windows.Forms.Button btnCatagoriys;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoriyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoriyId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateCategoriy;
        private System.Windows.Forms.Button btnRemoveCategoriy;
        private System.Windows.Forms.Button btnCreateCategoriy;
        private System.Windows.Forms.Button btnCategoriyList;
    }
}