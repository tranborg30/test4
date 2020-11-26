namespace test4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBolig = new System.Windows.Forms.Button();
            this.btnSælger = new System.Windows.Forms.Button();
            this.btnKøber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(340, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "REALBOLIG A/S";
            // 
            // btnBolig
            // 
            this.btnBolig.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBolig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBolig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBolig.Location = new System.Drawing.Point(494, 199);
            this.btnBolig.Name = "btnBolig";
            this.btnBolig.Size = new System.Drawing.Size(158, 74);
            this.btnBolig.TabIndex = 1;
            this.btnBolig.Text = "BOLIG";
            this.btnBolig.UseVisualStyleBackColor = false;
            this.btnBolig.Click += new System.EventHandler(this.btnBolig_Click);
            // 
            // btnSælger
            // 
            this.btnSælger.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSælger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSælger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSælger.Location = new System.Drawing.Point(494, 306);
            this.btnSælger.Name = "btnSælger";
            this.btnSælger.Size = new System.Drawing.Size(158, 74);
            this.btnSælger.TabIndex = 2;
            this.btnSælger.Text = "SÆLGERE";
            this.btnSælger.UseVisualStyleBackColor = false;
            this.btnSælger.Click += new System.EventHandler(this.btnSælger_Click);
            // 
            // btnKøber
            // 
            this.btnKøber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKøber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKøber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKøber.Location = new System.Drawing.Point(494, 420);
            this.btnKøber.Name = "btnKøber";
            this.btnKøber.Size = new System.Drawing.Size(158, 74);
            this.btnKøber.TabIndex = 3;
            this.btnKøber.Text = "KØBERE";
            this.btnKøber.UseVisualStyleBackColor = false;
            this.btnKøber.Click += new System.EventHandler(this.btnKøber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 577);
            this.Controls.Add(this.btnKøber);
            this.Controls.Add(this.btnSælger);
            this.Controls.Add(this.btnBolig);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forside";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBolig;
        private System.Windows.Forms.Button btnSælger;
        private System.Windows.Forms.Button btnKøber;
    }
}

