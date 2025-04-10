namespace hotelli
{
    partial class VaraustenHallinta
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
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ulosDTP = new System.Windows.Forms.DateTimePicker();
            this.sisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.asiakasCB = new System.Windows.Forms.ComboBox();
            this.huonenroCB = new System.Windows.Forms.ComboBox();
            this.huonetyyppiCB = new System.Windows.Forms.ComboBox();
            this.varausnroTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.varausBT = new System.Windows.Forms.Button();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.varausDG = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varausDG)).BeginInit();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.ForeColor = System.Drawing.Color.Khaki;
            this.otsikkoLB.Location = new System.Drawing.Point(76, 14);
            this.otsikkoLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(287, 45);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Varausten hallinta";
            this.otsikkoLB.Click += new System.EventHandler(this.otsikkoLB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Varaus nro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ulosDTP);
            this.groupBox1.Controls.Add(this.sisaanDTP);
            this.groupBox1.Controls.Add(this.asiakasCB);
            this.groupBox1.Controls.Add(this.huonenroCB);
            this.groupBox1.Controls.Add(this.huonetyyppiCB);
            this.groupBox1.Controls.Add(this.varausnroTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(439, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ulosDTP
            // 
            this.ulosDTP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ulosDTP.Location = new System.Drawing.Point(170, 214);
            this.ulosDTP.Name = "ulosDTP";
            this.ulosDTP.Size = new System.Drawing.Size(239, 25);
            this.ulosDTP.TabIndex = 16;
            // 
            // sisaanDTP
            // 
            this.sisaanDTP.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sisaanDTP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sisaanDTP.Location = new System.Drawing.Point(170, 179);
            this.sisaanDTP.Name = "sisaanDTP";
            this.sisaanDTP.Size = new System.Drawing.Size(239, 25);
            this.sisaanDTP.TabIndex = 15;
            // 
            // asiakasCB
            // 
            this.asiakasCB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asiakasCB.FormattingEnabled = true;
            this.asiakasCB.Location = new System.Drawing.Point(169, 67);
            this.asiakasCB.Name = "asiakasCB";
            this.asiakasCB.Size = new System.Drawing.Size(240, 33);
            this.asiakasCB.TabIndex = 14;
            // 
            // huonenroCB
            // 
            this.huonenroCB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.huonenroCB.FormattingEnabled = true;
            this.huonenroCB.Location = new System.Drawing.Point(169, 140);
            this.huonenroCB.Margin = new System.Windows.Forms.Padding(2);
            this.huonenroCB.Name = "huonenroCB";
            this.huonenroCB.Size = new System.Drawing.Size(240, 33);
            this.huonenroCB.TabIndex = 10;
            // 
            // huonetyyppiCB
            // 
            this.huonetyyppiCB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.huonetyyppiCB.FormattingEnabled = true;
            this.huonetyyppiCB.Location = new System.Drawing.Point(169, 103);
            this.huonetyyppiCB.Margin = new System.Windows.Forms.Padding(2);
            this.huonetyyppiCB.Name = "huonetyyppiCB";
            this.huonetyyppiCB.Size = new System.Drawing.Size(240, 33);
            this.huonetyyppiCB.TabIndex = 9;
            this.huonetyyppiCB.SelectedIndexChanged += new System.EventHandler(this.huonetyyppiCB_SelectedIndexChanged);
            // 
            // varausnroTB
            // 
            this.varausnroTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.varausnroTB.Location = new System.Drawing.Point(170, 31);
            this.varausnroTB.Margin = new System.Windows.Forms.Padding(2);
            this.varausnroTB.Name = "varausnroTB";
            this.varausnroTB.Size = new System.Drawing.Size(239, 32);
            this.varausnroTB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkCyan;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(25, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ulos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkCyan;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(25, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sisään:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(25, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Huoneen nro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Huonetyyppi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asiakas nro:";
            // 
            // varausBT
            // 
            this.varausBT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.varausBT.Location = new System.Drawing.Point(17, 370);
            this.varausBT.Margin = new System.Windows.Forms.Padding(2);
            this.varausBT.Name = "varausBT";
            this.varausBT.Size = new System.Drawing.Size(125, 35);
            this.varausBT.TabIndex = 11;
            this.varausBT.Text = "Lisää varaus";
            this.varausBT.UseVisualStyleBackColor = true;
            this.varausBT.Click += new System.EventHandler(this.varausBT_Click);
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.muokkaaBT.Location = new System.Drawing.Point(168, 370);
            this.muokkaaBT.Margin = new System.Windows.Forms.Padding(2);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(125, 35);
            this.muokkaaBT.TabIndex = 12;
            this.muokkaaBT.Text = "Muokkaa";
            this.muokkaaBT.UseVisualStyleBackColor = true;
            this.muokkaaBT.Click += new System.EventHandler(this.muokkaaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.poistaBT.Location = new System.Drawing.Point(320, 370);
            this.poistaBT.Margin = new System.Windows.Forms.Padding(2);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(125, 35);
            this.poistaBT.TabIndex = 13;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tyhjennaBT.Location = new System.Drawing.Point(256, 426);
            this.tyhjennaBT.Margin = new System.Windows.Forms.Padding(2);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(189, 35);
            this.tyhjennaBT.TabIndex = 14;
            this.tyhjennaBT.Text = "Tyhjennä kentät";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            // 
            // varausDG
            // 
            this.varausDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varausDG.Location = new System.Drawing.Point(479, 34);
            this.varausDG.Margin = new System.Windows.Forms.Padding(2);
            this.varausDG.Name = "varausDG";
            this.varausDG.RowHeadersWidth = 62;
            this.varausDG.RowTemplate.Height = 33;
            this.varausDG.Size = new System.Drawing.Size(524, 420);
            this.varausDG.TabIndex = 15;
            this.varausDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varausDG_CellClick);
            this.varausDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varausDG_CellContentClick);
            // 
            // VaraustenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1075, 499);
            this.Controls.Add(this.varausDG);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.muokkaaBT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.otsikkoLB);
            this.Controls.Add(this.varausBT);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VaraustenHallinta";
            this.Text = "VaraustenHallinta";
            this.Load += new System.EventHandler(this.VaraustenHallinta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varausDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox varausnroTB;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox huonenroCB;
        private ComboBox huonetyyppiCB;
        private Button varausBT;
        private Button muokkaaBT;
        private Button poistaBT;
        private Button tyhjennaBT;
        private DataGridView varausDG;
        private ComboBox asiakasCB;
        private DateTimePicker ulosDTP;
        private DateTimePicker sisaanDTP;
    }
}