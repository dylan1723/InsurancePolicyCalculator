namespace InsurancePolicyCalculator
{
    partial class frmAdmin
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
            this.txtAdminDisplay = new System.Windows.Forms.TextBox();
            this.lblAdminView = new System.Windows.Forms.Label();
            this.btnAdminPolicy = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dtpAdminDate = new System.Windows.Forms.DateTimePicker();
            this.lblAdminDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdminDisplay
            // 
            this.txtAdminDisplay.Location = new System.Drawing.Point(12, 89);
            this.txtAdminDisplay.Multiline = true;
            this.txtAdminDisplay.Name = "txtAdminDisplay";
            this.txtAdminDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdminDisplay.Size = new System.Drawing.Size(1522, 306);
            this.txtAdminDisplay.TabIndex = 0;
            // 
            // lblAdminView
            // 
            this.lblAdminView.AutoSize = true;
            this.lblAdminView.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminView.Location = new System.Drawing.Point(5, 9);
            this.lblAdminView.Name = "lblAdminView";
            this.lblAdminView.Size = new System.Drawing.Size(383, 42);
            this.lblAdminView.TabIndex = 1;
            this.lblAdminView.Text = "Admin: View Policies";
            // 
            // btnAdminPolicy
            // 
            this.btnAdminPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPolicy.Location = new System.Drawing.Point(133, 406);
            this.btnAdminPolicy.Name = "btnAdminPolicy";
            this.btnAdminPolicy.Size = new System.Drawing.Size(93, 46);
            this.btnAdminPolicy.TabIndex = 2;
            this.btnAdminPolicy.Text = "Show Policy";
            this.btnAdminPolicy.UseVisualStyleBackColor = true;
            this.btnAdminPolicy.Click += new System.EventHandler(this.btnAdminPolicy_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(305, 406);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(112, 46);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Back to Main Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dtpAdminDate
            // 
            this.dtpAdminDate.Location = new System.Drawing.Point(405, 63);
            this.dtpAdminDate.Name = "dtpAdminDate";
            this.dtpAdminDate.Size = new System.Drawing.Size(133, 20);
            this.dtpAdminDate.TabIndex = 4;
            // 
            // lblAdminDate
            // 
            this.lblAdminDate.AutoSize = true;
            this.lblAdminDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDate.Location = new System.Drawing.Point(290, 63);
            this.lblAdminDate.Name = "lblAdminDate";
            this.lblAdminDate.Size = new System.Drawing.Size(109, 18);
            this.lblAdminDate.TabIndex = 5;
            this.lblAdminDate.Text = "Choose date:";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 464);
            this.Controls.Add(this.lblAdminDate);
            this.Controls.Add(this.dtpAdminDate);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnAdminPolicy);
            this.Controls.Add(this.lblAdminView);
            this.Controls.Add(this.txtAdminDisplay);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdminDisplay;
        private System.Windows.Forms.Label lblAdminView;
        private System.Windows.Forms.Button btnAdminPolicy;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DateTimePicker dtpAdminDate;
        private System.Windows.Forms.Label lblAdminDate;
    }
}