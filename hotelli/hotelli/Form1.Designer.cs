namespace hotelli
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.kayttajaLB = new System.Windows.Forms.Label();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(296, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kirjaudu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kayttajaTB.Location = new System.Drawing.Point(319, 185);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(274, 33);
            this.kayttajaTB.TabIndex = 1;
            // 
            // salasanaTB
            // 
            this.salasanaTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salasanaTB.Location = new System.Drawing.Point(319, 237);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(274, 33);
            this.salasanaTB.TabIndex = 2;
            // 
            // kayttajaLB
            // 
            this.kayttajaLB.AutoSize = true;
            this.kayttajaLB.BackColor = System.Drawing.Color.DarkCyan;
            this.kayttajaLB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kayttajaLB.ForeColor = System.Drawing.Color.Khaki;
            this.kayttajaLB.Location = new System.Drawing.Point(138, 188);
            this.kayttajaLB.Name = "kayttajaLB";
            this.kayttajaLB.Size = new System.Drawing.Size(147, 25);
            this.kayttajaLB.TabIndex = 3;
            this.kayttajaLB.Text = "Käyttäjätunnus:";
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.BackColor = System.Drawing.Color.DarkCyan;
            this.salasanaLB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salasanaLB.ForeColor = System.Drawing.Color.Khaki;
            this.salasanaLB.Location = new System.Drawing.Point(138, 240);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(91, 25);
            this.salasanaLB.TabIndex = 4;
            this.salasanaLB.Text = "Salasana:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.salasanaLB);
            this.Controls.Add(this.kayttajaLB);
            this.Controls.Add(this.salasanaTB);
            this.Controls.Add(this.kayttajaTB);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Kirjautumisikkuna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox kayttajaTB;
        private TextBox salasanaTB;
        private Label kayttajaLB;
        private Label salasanaLB;
    }
}