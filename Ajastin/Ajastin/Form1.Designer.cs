namespace Ajastin
{
    partial class aikaForm
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
            this.minLB = new System.Windows.Forms.Label();
            this.sekLB = new System.Windows.Forms.Label();
            this.kelloLB = new System.Windows.Forms.Label();
            this.startBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.minCB = new System.Windows.Forms.ComboBox();
            this.sekCB = new System.Windows.Forms.ComboBox();
            this.ajastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minLB
            // 
            this.minLB.AutoSize = true;
            this.minLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minLB.Location = new System.Drawing.Point(143, 46);
            this.minLB.Name = "minLB";
            this.minLB.Size = new System.Drawing.Size(84, 25);
            this.minLB.TabIndex = 0;
            this.minLB.Text = "Minuutit";
            // 
            // sekLB
            // 
            this.sekLB.AutoSize = true;
            this.sekLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sekLB.Location = new System.Drawing.Point(349, 46);
            this.sekLB.Name = "sekLB";
            this.sekLB.Size = new System.Drawing.Size(85, 25);
            this.sekLB.TabIndex = 1;
            this.sekLB.Text = "Sekunnit";
            // 
            // kelloLB
            // 
            this.kelloLB.AutoSize = true;
            this.kelloLB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kelloLB.Location = new System.Drawing.Point(188, 143);
            this.kelloLB.Name = "kelloLB";
            this.kelloLB.Size = new System.Drawing.Size(191, 86);
            this.kelloLB.TabIndex = 2;
            this.kelloLB.Text = "00:00";
            // 
            // startBT
            // 
            this.startBT.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startBT.Location = new System.Drawing.Point(152, 266);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(75, 43);
            this.startBT.TabIndex = 3;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopBT.Location = new System.Drawing.Point(328, 266);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(75, 43);
            this.stopBT.TabIndex = 4;
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.button2_Click);
            // 
            // minCB
            // 
            this.minCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minCB.FormattingEnabled = true;
            this.minCB.Location = new System.Drawing.Point(124, 91);
            this.minCB.Name = "minCB";
            this.minCB.Size = new System.Drawing.Size(121, 29);
            this.minCB.TabIndex = 5;
            // 
            // sekCB
            // 
            this.sekCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sekCB.FormattingEnabled = true;
            this.sekCB.Location = new System.Drawing.Point(328, 91);
            this.sekCB.Name = "sekCB";
            this.sekCB.Size = new System.Drawing.Size(121, 29);
            this.sekCB.TabIndex = 6;
            // 
            // ajastinTM
            // 
            this.ajastinTM.Interval = 1000;
            // 
            // aikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 344);
            this.Controls.Add(this.sekCB);
            this.Controls.Add(this.minCB);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.kelloLB);
            this.Controls.Add(this.sekLB);
            this.Controls.Add(this.minLB);
            this.Name = "aikaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.aikaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label minLB;
        private Label sekLB;
        private Label kelloLB;
        private Button startBT;
        private Button stopBT;
        private ComboBox minCB;
        private ComboBox sekCB;
        private System.Windows.Forms.Timer ajastinTM;
    }
}