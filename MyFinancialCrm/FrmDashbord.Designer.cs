namespace MyFinancialCrm
{
    partial class FrmDashbord
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
            this.lblGelenHavale = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProperties = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnBankProcesses = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnSpendings = new System.Windows.Forms.Button();
            this.btnCatagoriys = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLastBankProcessAmount
            // 
            this.lblLastBankProcessAmount.AutoSize = true;
            this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastBankProcessAmount.ForeColor = System.Drawing.Color.White;
            this.lblLastBankProcessAmount.Location = new System.Drawing.Point(12, 72);
            this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
            this.lblLastBankProcessAmount.Size = new System.Drawing.Size(145, 58);
            this.lblLastBankProcessAmount.TabIndex = 4;
            this.lblLastBankProcessAmount.Text = "0.00 ₺";
            // 
            // lblGelenHavale
            // 
            this.lblGelenHavale.AutoSize = true;
            this.lblGelenHavale.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelenHavale.ForeColor = System.Drawing.Color.White;
            this.lblGelenHavale.Location = new System.Drawing.Point(16, 10);
            this.lblGelenHavale.Name = "lblGelenHavale";
            this.lblGelenHavale.Size = new System.Drawing.Size(166, 28);
            this.lblGelenHavale.TabIndex = 3;
            this.lblGelenHavale.Text = "Gelen Havaleler";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panel5.Controls.Add(this.lblLastBankProcessAmount);
            this.panel5.Controls.Add(this.lblGelenHavale);
            this.panel5.Location = new System.Drawing.Point(919, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 162);
            this.panel5.TabIndex = 10;
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillAmount.ForeColor = System.Drawing.Color.White;
            this.lblBillAmount.Location = new System.Drawing.Point(0, 72);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(145, 58);
            this.lblBillAmount.TabIndex = 4;
            this.lblBillAmount.Text = "0.00 ₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Bakiyem";
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTitle.ForeColor = System.Drawing.Color.White;
            this.lblBillTitle.Location = new System.Drawing.Point(16, 10);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(138, 28);
            this.lblBillTitle.TabIndex = 3;
            this.lblBillTitle.Text = "Fatura Başlığı";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalBalance.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalance.Location = new System.Drawing.Point(12, 72);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(145, 58);
            this.lblTotalBalance.TabIndex = 4;
            this.lblTotalBalance.Text = "0.00 ₺";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.panel3.Controls.Add(this.lblTotalBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(321, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 162);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard / Genel Bakış Formu";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1231, 60);
            this.panel2.TabIndex = 8;
            // 
            // btnProperties
            // 
            this.btnProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnProperties.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProperties.ForeColor = System.Drawing.Color.White;
            this.btnProperties.Location = new System.Drawing.Point(30, 417);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(213, 56);
            this.btnProperties.TabIndex = 6;
            this.btnProperties.Text = "Ayarlar";
            this.btnProperties.UseVisualStyleBackColor = false;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(30, 355);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(213, 56);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dashbord";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnBankProcesses
            // 
            this.btnBankProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnBankProcesses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcesses.ForeColor = System.Drawing.Color.White;
            this.btnBankProcesses.Location = new System.Drawing.Point(30, 293);
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
            this.btnBillForm.Location = new System.Drawing.Point(30, 231);
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
            this.btnSpendings.Location = new System.Drawing.Point(30, 169);
            this.btnSpendings.Name = "btnSpendings";
            this.btnSpendings.Size = new System.Drawing.Size(213, 56);
            this.btnSpendings.TabIndex = 2;
            this.btnSpendings.Text = "Faturalar";
            this.btnSpendings.UseVisualStyleBackColor = false;
            this.btnSpendings.Click += new System.EventHandler(this.btnSpendings_Click);
            // 
            // btnCatagoriys
            // 
            this.btnCatagoriys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnCatagoriys.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCatagoriys.ForeColor = System.Drawing.Color.White;
            this.btnCatagoriys.Location = new System.Drawing.Point(30, 45);
            this.btnCatagoriys.Name = "btnCatagoriys";
            this.btnCatagoriys.Size = new System.Drawing.Size(213, 56);
            this.btnCatagoriys.TabIndex = 0;
            this.btnCatagoriys.Text = "Kategoriler";
            this.btnCatagoriys.UseVisualStyleBackColor = false;
            this.btnCatagoriys.Click += new System.EventHandler(this.btnCatagoriys_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel4.Controls.Add(this.lblBillAmount);
            this.panel4.Controls.Add(this.lblBillTitle);
            this.panel4.Location = new System.Drawing.Point(620, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 162);
            this.panel4.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnProperties);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnBankProcesses);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.btnSpendings);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Controls.Add(this.btnCatagoriys);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 643);
            this.panel1.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(30, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(213, 56);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBanks
            // 
            this.btnBanks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(38)))), ((int)(((byte)(153)))));
            this.btnBanks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanks.ForeColor = System.Drawing.Color.White;
            this.btnBanks.Location = new System.Drawing.Point(30, 107);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(213, 56);
            this.btnBanks.TabIndex = 1;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.UseVisualStyleBackColor = false;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(290, 320);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(428, 311);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(784, 320);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Faturalar";
            series2.YValuesPerPoint = 6;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(428, 311);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(293, 246);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(428, 68);
            this.panel6.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bankalar ve banka hesaplarındaki para miktarına\r\naşağıdaki gafikten ulaşabilirsin" +
    "iz\r\n";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(784, 246);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(428, 68);
            this.panel7.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ödenen ve ödenmesi gereken fatura tutarlarına\r\naşağıdaki gafikten ulaşabilirsiniz" +
    "\r\n";
            // 
            // FrmDashbord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Formu";
            this.Load += new System.EventHandler(this.FrmDashbord_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLastBankProcessAmount;
        private System.Windows.Forms.Label lblGelenHavale;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnBankProcesses;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnSpendings;
        private System.Windows.Forms.Button btnCatagoriys;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
    }
}

