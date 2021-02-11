namespace InsurancePolicyCalculator
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnInputForm = new System.Windows.Forms.Button();
            this.btnAdminForm = new System.Windows.Forms.Button();
            this.lblWeCare = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInputForm
            // 
            this.btnInputForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputForm.Location = new System.Drawing.Point(172, 139);
            this.btnInputForm.Name = "btnInputForm";
            this.btnInputForm.Size = new System.Drawing.Size(95, 50);
            this.btnInputForm.TabIndex = 0;
            this.btnInputForm.Text = "Add a Policy";
            this.btnInputForm.UseVisualStyleBackColor = true;
            this.btnInputForm.Click += new System.EventHandler(this.btnInputForm_Click);
            // 
            // btnAdminForm
            // 
            this.btnAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminForm.Location = new System.Drawing.Point(172, 276);
            this.btnAdminForm.Name = "btnAdminForm";
            this.btnAdminForm.Size = new System.Drawing.Size(95, 52);
            this.btnAdminForm.TabIndex = 1;
            this.btnAdminForm.Text = "Admin";
            this.btnAdminForm.UseVisualStyleBackColor = true;
            this.btnAdminForm.Click += new System.EventHandler(this.btnAdminForm_Click);
            // 
            // lblWeCare
            // 
            this.lblWeCare.AutoSize = true;
            this.lblWeCare.BackColor = System.Drawing.Color.Transparent;
            this.lblWeCare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeCare.ForeColor = System.Drawing.Color.Orange;
            this.lblWeCare.Location = new System.Drawing.Point(88, 20);
            this.lblWeCare.Name = "lblWeCare";
            this.lblWeCare.Size = new System.Drawing.Size(256, 31);
            this.lblWeCare.TabIndex = 2;
            this.lblWeCare.Text = "WeCare Insurance";
            // 
            // lblAdd
            // 
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.Black;
            this.lblAdd.Location = new System.Drawing.Point(77, 51);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(278, 61);
            this.lblAdd.TabIndex = 3;
            this.lblAdd.Text = "Press the Add a Policy button if you want to create and calculate your own insura" +
    "nce policy.";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAdmin
            // 
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(27, 204);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(392, 60);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Press the Admin button to access the admin section. Here you can view policies ma" +
    "de before todays date, although you will need an admin login to access this page" +
    ".\r\n";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(448, 379);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblWeCare);
            this.Controls.Add(this.btnAdminForm);
            this.Controls.Add(this.btnInputForm);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInputForm;
        private System.Windows.Forms.Button btnAdminForm;
        private System.Windows.Forms.Label lblWeCare;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblAdmin;
    }
}