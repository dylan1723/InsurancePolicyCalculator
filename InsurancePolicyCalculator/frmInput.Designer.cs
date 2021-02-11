namespace InsurancePolicyCalculator
{
    partial class frmInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInput));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnQuote = new System.Windows.Forms.Button();
            this.lblDob = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.lblHolderName = new System.Windows.Forms.Label();
            this.lblHolderDob = new System.Windows.Forms.Label();
            this.lblHolderOccupation = new System.Windows.Forms.Label();
            this.lblHolderClaim = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblUsage = new System.Windows.Forms.Label();
            this.lblKept = new System.Windows.Forms.Label();
            this.txtHolderClaim = new System.Windows.Forms.TextBox();
            this.txtHolderName = new System.Windows.Forms.TextBox();
            this.cmbUsage = new System.Windows.Forms.ComboBox();
            this.cmbKept = new System.Windows.Forms.ComboBox();
            this.dtpHolderDob = new System.Windows.Forms.DateTimePicker();
            this.lstHolderOccupation = new System.Windows.Forms.ListBox();
            this.lstVehicle = new System.Windows.Forms.ListBox();
            this.btnAddPolicy = new System.Windows.Forms.Button();
            this.lblAddPolicy = new System.Windows.Forms.Label();
            this.lblAddDrivers = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.mspInput = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdInput = new System.Windows.Forms.SaveFileDialog();
            this.fbdInput = new System.Windows.Forms.FolderBrowserDialog();
            this.lstJobNumber = new System.Windows.Forms.ListBox();
            this.lstVehNumber = new System.Windows.Forms.ListBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.lblBeforeAdd = new System.Windows.Forms.Label();
            this.mspInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(528, 144);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Driver Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(612, 144);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 8;
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Enabled = false;
            this.btnAddDriver.Location = new System.Drawing.Point(622, 211);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(78, 33);
            this.btnAddDriver.TabIndex = 15;
            this.btnAddDriver.Text = "Add a driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnQuote
            // 
            this.btnQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuote.Location = new System.Drawing.Point(512, 358);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(98, 57);
            this.btnQuote.TabIndex = 16;
            this.btnQuote.Text = "Check Insurance Quotes";
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(492, 185);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(102, 13);
            this.lblDob.TabIndex = 22;
            this.lblDob.Text = "Drivers Date of Birth";
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(612, 185);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 20);
            this.dtpDob.TabIndex = 23;
            // 
            // lblHolderName
            // 
            this.lblHolderName.AutoSize = true;
            this.lblHolderName.Location = new System.Drawing.Point(40, 83);
            this.lblHolderName.Name = "lblHolderName";
            this.lblHolderName.Size = new System.Drawing.Size(100, 13);
            this.lblHolderName.TabIndex = 24;
            this.lblHolderName.Text = "Policy Holder Name";
            // 
            // lblHolderDob
            // 
            this.lblHolderDob.AutoSize = true;
            this.lblHolderDob.Location = new System.Drawing.Point(41, 111);
            this.lblHolderDob.Name = "lblHolderDob";
            this.lblHolderDob.Size = new System.Drawing.Size(105, 13);
            this.lblHolderDob.TabIndex = 25;
            this.lblHolderDob.Text = "Holders Date of Birth";
            // 
            // lblHolderOccupation
            // 
            this.lblHolderOccupation.AutoSize = true;
            this.lblHolderOccupation.Location = new System.Drawing.Point(40, 137);
            this.lblHolderOccupation.Name = "lblHolderOccupation";
            this.lblHolderOccupation.Size = new System.Drawing.Size(101, 13);
            this.lblHolderOccupation.TabIndex = 26;
            this.lblHolderOccupation.Text = "Holders Occupation";
            // 
            // lblHolderClaim
            // 
            this.lblHolderClaim.AutoSize = true;
            this.lblHolderClaim.Location = new System.Drawing.Point(41, 249);
            this.lblHolderClaim.Name = "lblHolderClaim";
            this.lblHolderClaim.Size = new System.Drawing.Size(149, 13);
            this.lblHolderClaim.TabIndex = 27;
            this.lblHolderClaim.Text = "Years Without a Claim (Max 6)";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(41, 284);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(42, 13);
            this.lblVehicle.TabIndex = 28;
            this.lblVehicle.Text = "Vehicle";
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Location = new System.Drawing.Point(41, 337);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(57, 13);
            this.lblUsage.TabIndex = 29;
            this.lblUsage.Text = "Car Usage";
            // 
            // lblKept
            // 
            this.lblKept.AutoSize = true;
            this.lblKept.Location = new System.Drawing.Point(41, 370);
            this.lblKept.Name = "lblKept";
            this.lblKept.Size = new System.Drawing.Size(130, 13);
            this.lblKept.TabIndex = 30;
            this.lblKept.Text = "Where the Vehicle is Kept";
            // 
            // txtHolderClaim
            // 
            this.txtHolderClaim.Location = new System.Drawing.Point(195, 249);
            this.txtHolderClaim.Name = "txtHolderClaim";
            this.txtHolderClaim.Size = new System.Drawing.Size(100, 20);
            this.txtHolderClaim.TabIndex = 31;
            // 
            // txtHolderName
            // 
            this.txtHolderName.Location = new System.Drawing.Point(195, 80);
            this.txtHolderName.Name = "txtHolderName";
            this.txtHolderName.Size = new System.Drawing.Size(100, 20);
            this.txtHolderName.TabIndex = 32;
            // 
            // cmbUsage
            // 
            this.cmbUsage.FormattingEnabled = true;
            this.cmbUsage.Items.AddRange(new object[] {
            "Social Domestic Pleasure",
            "Social and Commuting",
            "Business"});
            this.cmbUsage.Location = new System.Drawing.Point(203, 337);
            this.cmbUsage.Name = "cmbUsage";
            this.cmbUsage.Size = new System.Drawing.Size(121, 21);
            this.cmbUsage.TabIndex = 33;
            // 
            // cmbKept
            // 
            this.cmbKept.FormattingEnabled = true;
            this.cmbKept.Items.AddRange(new object[] {
            "Pubilc Road",
            "Private Drive",
            "Garage"});
            this.cmbKept.Location = new System.Drawing.Point(203, 370);
            this.cmbKept.Name = "cmbKept";
            this.cmbKept.Size = new System.Drawing.Size(121, 21);
            this.cmbKept.TabIndex = 34;
            // 
            // dtpHolderDob
            // 
            this.dtpHolderDob.Location = new System.Drawing.Point(195, 111);
            this.dtpHolderDob.Name = "dtpHolderDob";
            this.dtpHolderDob.Size = new System.Drawing.Size(200, 20);
            this.dtpHolderDob.TabIndex = 35;
            // 
            // lstHolderOccupation
            // 
            this.lstHolderOccupation.FormattingEnabled = true;
            this.lstHolderOccupation.Location = new System.Drawing.Point(147, 137);
            this.lstHolderOccupation.Name = "lstHolderOccupation";
            this.lstHolderOccupation.Size = new System.Drawing.Size(248, 56);
            this.lstHolderOccupation.TabIndex = 36;
            this.lstHolderOccupation.SelectedIndexChanged += new System.EventHandler(this.lstHolderOccupation_SelectedIndexChanged);
            // 
            // lstVehicle
            // 
            this.lstVehicle.FormattingEnabled = true;
            this.lstVehicle.Location = new System.Drawing.Point(147, 275);
            this.lstVehicle.Name = "lstVehicle";
            this.lstVehicle.Size = new System.Drawing.Size(248, 56);
            this.lstVehicle.TabIndex = 37;
            this.lstVehicle.SelectedIndexChanged += new System.EventHandler(this.lstVehicle_SelectedIndexChanged);
            // 
            // btnAddPolicy
            // 
            this.btnAddPolicy.Enabled = false;
            this.btnAddPolicy.Location = new System.Drawing.Point(195, 405);
            this.btnAddPolicy.Name = "btnAddPolicy";
            this.btnAddPolicy.Size = new System.Drawing.Size(94, 45);
            this.btnAddPolicy.TabIndex = 38;
            this.btnAddPolicy.Text = "Add Policy Details";
            this.btnAddPolicy.UseVisualStyleBackColor = true;
            this.btnAddPolicy.Click += new System.EventHandler(this.btnAddPolicy_Click);
            // 
            // lblAddPolicy
            // 
            this.lblAddPolicy.AutoSize = true;
            this.lblAddPolicy.BackColor = System.Drawing.Color.Transparent;
            this.lblAddPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPolicy.Location = new System.Drawing.Point(66, 45);
            this.lblAddPolicy.Name = "lblAddPolicy";
            this.lblAddPolicy.Size = new System.Drawing.Size(223, 20);
            this.lblAddPolicy.TabIndex = 39;
            this.lblAddPolicy.Text = "Enter Policy Details Below:";
            // 
            // lblAddDrivers
            // 
            this.lblAddDrivers.BackColor = System.Drawing.SystemColors.Control;
            this.lblAddDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDrivers.Location = new System.Drawing.Point(532, 33);
            this.lblAddDrivers.Name = "lblAddDrivers";
            this.lblAddDrivers.Size = new System.Drawing.Size(201, 65);
            this.lblAddDrivers.TabIndex = 40;
            this.lblAddDrivers.Text = "Do you wish to add more drivers to this policy? Maximum of 5 drivers allowed incl" +
    "uding policy holder!";
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(535, 101);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 41;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(195, 208);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 43;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(41, 208);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(98, 13);
            this.lblStartDate.TabIndex = 42;
            this.lblStartDate.Text = "Start Date of Policy";
            // 
            // mspInput
            // 
            this.mspInput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mspInput.Location = new System.Drawing.Point(0, 0);
            this.mspInput.Name = "mspInput";
            this.mspInput.Size = new System.Drawing.Size(815, 24);
            this.mspInput.TabIndex = 44;
            this.mspInput.Text = "mspInput";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePolicyToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // savePolicyToolStripMenuItem
            // 
            this.savePolicyToolStripMenuItem.Name = "savePolicyToolStripMenuItem";
            this.savePolicyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.savePolicyToolStripMenuItem.Text = "Save Policy";
            this.savePolicyToolStripMenuItem.Click += new System.EventHandler(this.savePolicyToolStripMenuItem_Click);
            // 
            // lstJobNumber
            // 
            this.lstJobNumber.FormattingEnabled = true;
            this.lstJobNumber.Location = new System.Drawing.Point(401, 137);
            this.lstJobNumber.Name = "lstJobNumber";
            this.lstJobNumber.Size = new System.Drawing.Size(62, 56);
            this.lstJobNumber.TabIndex = 45;
            // 
            // lstVehNumber
            // 
            this.lstVehNumber.FormattingEnabled = true;
            this.lstVehNumber.Location = new System.Drawing.Point(401, 275);
            this.lstVehNumber.Name = "lstVehNumber";
            this.lstVehNumber.Size = new System.Drawing.Size(62, 56);
            this.lstVehNumber.TabIndex = 46;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(659, 360);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(98, 52);
            this.btnMenu.TabIndex = 47;
            this.btnMenu.Text = "Back To Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(639, 101);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 48;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Enabled = false;
            this.btnFinished.Location = new System.Drawing.Point(612, 255);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(102, 42);
            this.btnFinished.TabIndex = 49;
            this.btnFinished.Text = "Finished adding drivers?";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // lblBeforeAdd
            // 
            this.lblBeforeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeforeAdd.Location = new System.Drawing.Point(309, 405);
            this.lblBeforeAdd.Name = "lblBeforeAdd";
            this.lblBeforeAdd.Size = new System.Drawing.Size(180, 45);
            this.lblBeforeAdd.TabIndex = 50;
            this.lblBeforeAdd.Text = "You must press yes or no on the add drivers section before you can add a policy.";
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(815, 451);
            this.Controls.Add(this.lblBeforeAdd);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lstVehNumber);
            this.Controls.Add(this.lstJobNumber);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblAddDrivers);
            this.Controls.Add(this.lblAddPolicy);
            this.Controls.Add(this.btnAddPolicy);
            this.Controls.Add(this.lstVehicle);
            this.Controls.Add(this.lstHolderOccupation);
            this.Controls.Add(this.dtpHolderDob);
            this.Controls.Add(this.cmbKept);
            this.Controls.Add(this.cmbUsage);
            this.Controls.Add(this.txtHolderName);
            this.Controls.Add(this.txtHolderClaim);
            this.Controls.Add(this.lblKept);
            this.Controls.Add(this.lblUsage);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblHolderClaim);
            this.Controls.Add(this.lblHolderOccupation);
            this.Controls.Add(this.lblHolderDob);
            this.Controls.Add(this.lblHolderName);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.btnQuote);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.mspInput);
            this.MainMenuStrip = this.mspInput;
            this.Name = "frmInput";
            this.Text = "frmInput";
            this.mspInput.ResumeLayout(false);
            this.mspInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label lblHolderName;
        private System.Windows.Forms.Label lblHolderDob;
        private System.Windows.Forms.Label lblHolderOccupation;
        private System.Windows.Forms.Label lblHolderClaim;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.Label lblKept;
        private System.Windows.Forms.TextBox txtHolderClaim;
        private System.Windows.Forms.TextBox txtHolderName;
        private System.Windows.Forms.ComboBox cmbUsage;
        private System.Windows.Forms.ComboBox cmbKept;
        private System.Windows.Forms.DateTimePicker dtpHolderDob;
        private System.Windows.Forms.ListBox lstHolderOccupation;
        private System.Windows.Forms.ListBox lstVehicle;
        private System.Windows.Forms.Button btnAddPolicy;
        private System.Windows.Forms.Label lblAddPolicy;
        private System.Windows.Forms.Label lblAddDrivers;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.MenuStrip mspInput;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePolicyToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdInput;
        private System.Windows.Forms.FolderBrowserDialog fbdInput;
        private System.Windows.Forms.ListBox lstJobNumber;
        private System.Windows.Forms.ListBox lstVehNumber;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Label lblBeforeAdd;
    }
}

