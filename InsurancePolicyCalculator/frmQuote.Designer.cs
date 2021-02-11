namespace InsurancePolicyCalculator
{
    partial class frmQuote
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.ofdQuote = new System.Windows.Forms.OpenFileDialog();
            this.txtDisPolicy = new System.Windows.Forms.TextBox();
            this.dtpPolicyDate = new System.Windows.Forms.DateTimePicker();
            this.lblChooseDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(214, 403);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 44);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate Insurance Policy";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // ofdQuote
            // 
            this.ofdQuote.FileName = "openFileDialog1";
            // 
            // txtDisPolicy
            // 
            this.txtDisPolicy.Location = new System.Drawing.Point(12, 62);
            this.txtDisPolicy.Multiline = true;
            this.txtDisPolicy.Name = "txtDisPolicy";
            this.txtDisPolicy.Size = new System.Drawing.Size(1534, 335);
            this.txtDisPolicy.TabIndex = 33;
            // 
            // dtpPolicyDate
            // 
            this.dtpPolicyDate.Location = new System.Drawing.Point(189, 36);
            this.dtpPolicyDate.Name = "dtpPolicyDate";
            this.dtpPolicyDate.Size = new System.Drawing.Size(185, 20);
            this.dtpPolicyDate.TabIndex = 34;
            // 
            // lblChooseDate
            // 
            this.lblChooseDate.AutoSize = true;
            this.lblChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseDate.Location = new System.Drawing.Point(11, 36);
            this.lblChooseDate.Name = "lblChooseDate";
            this.lblChooseDate.Size = new System.Drawing.Size(176, 16);
            this.lblChooseDate.TabIndex = 35;
            this.lblChooseDate.Text = "Choose Date For Policy:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(475, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 46);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back to Add Policy Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1558, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblChooseDate);
            this.Controls.Add(this.dtpPolicyDate);
            this.Controls.Add(this.txtDisPolicy);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmQuote";
            this.Text = "frmQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.OpenFileDialog ofdQuote;
        private System.Windows.Forms.TextBox txtDisPolicy;
        private System.Windows.Forms.DateTimePicker dtpPolicyDate;
        private System.Windows.Forms.Label lblChooseDate;
        private System.Windows.Forms.Button btnBack;
    }
}