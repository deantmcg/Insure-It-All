namespace Insure_It_All
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnID = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnOverview = new System.Windows.Forms.RadioButton();
            this.btnDriver5 = new System.Windows.Forms.RadioButton();
            this.btnDriver4 = new System.Windows.Forms.RadioButton();
            this.btnDriver3 = new System.Windows.Forms.RadioButton();
            this.btnDriver2 = new System.Windows.Forms.RadioButton();
            this.btnDriver1 = new System.Windows.Forms.RadioButton();
            this.btnHolder = new System.Windows.Forms.RadioButton();
            this.lblMain = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(355, 24);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Enter the ID of the policy you wish to view";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(373, 6);
            this.txtID.MaxLength = 9;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(175, 29);
            this.txtID.TabIndex = 1;
            // 
            // btnID
            // 
            this.btnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.Location = new System.Drawing.Point(554, 6);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(104, 29);
            this.btnID.TabIndex = 2;
            this.btnID.Text = "GO";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(16, 38);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(642, 39);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "lblHeader";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(501, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 50);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(501, 143);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(157, 50);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "MAIN MENU";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // grpButtons
            // 
            this.grpButtons.BackColor = System.Drawing.Color.Transparent;
            this.grpButtons.Controls.Add(this.btnOverview);
            this.grpButtons.Controls.Add(this.btnDriver5);
            this.grpButtons.Controls.Add(this.btnDriver4);
            this.grpButtons.Controls.Add(this.btnDriver3);
            this.grpButtons.Controls.Add(this.btnDriver2);
            this.grpButtons.Controls.Add(this.btnDriver1);
            this.grpButtons.Controls.Add(this.btnHolder);
            this.grpButtons.Location = new System.Drawing.Point(16, 80);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(153, 258);
            this.grpButtons.TabIndex = 14;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "Policy Details";
            // 
            // btnOverview
            // 
            this.btnOverview.AutoSize = true;
            this.btnOverview.BackColor = System.Drawing.Color.Transparent;
            this.btnOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.Location = new System.Drawing.Point(6, 19);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(107, 28);
            this.btnOverview.TabIndex = 20;
            this.btnOverview.TabStop = true;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = false;
            this.btnOverview.CheckedChanged += new System.EventHandler(this.btnOverview_CheckedChanged);
            // 
            // btnDriver5
            // 
            this.btnDriver5.AutoSize = true;
            this.btnDriver5.BackColor = System.Drawing.Color.Transparent;
            this.btnDriver5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDriver5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver5.Location = new System.Drawing.Point(4, 223);
            this.btnDriver5.Name = "btnDriver5";
            this.btnDriver5.Size = new System.Drawing.Size(92, 28);
            this.btnDriver5.TabIndex = 19;
            this.btnDriver5.TabStop = true;
            this.btnDriver5.Text = "Driver 5";
            this.btnDriver5.UseVisualStyleBackColor = false;
            this.btnDriver5.CheckedChanged += new System.EventHandler(this.btnDriver5_CheckedChanged);
            // 
            // btnDriver4
            // 
            this.btnDriver4.AutoSize = true;
            this.btnDriver4.BackColor = System.Drawing.Color.Transparent;
            this.btnDriver4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDriver4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver4.Location = new System.Drawing.Point(4, 189);
            this.btnDriver4.Name = "btnDriver4";
            this.btnDriver4.Size = new System.Drawing.Size(92, 28);
            this.btnDriver4.TabIndex = 18;
            this.btnDriver4.TabStop = true;
            this.btnDriver4.Text = "Driver 4";
            this.btnDriver4.UseVisualStyleBackColor = false;
            this.btnDriver4.CheckedChanged += new System.EventHandler(this.btnDriver4_CheckedChanged);
            // 
            // btnDriver3
            // 
            this.btnDriver3.AutoSize = true;
            this.btnDriver3.BackColor = System.Drawing.Color.Transparent;
            this.btnDriver3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDriver3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver3.Location = new System.Drawing.Point(4, 155);
            this.btnDriver3.Name = "btnDriver3";
            this.btnDriver3.Size = new System.Drawing.Size(92, 28);
            this.btnDriver3.TabIndex = 17;
            this.btnDriver3.TabStop = true;
            this.btnDriver3.Text = "Driver 3";
            this.btnDriver3.UseVisualStyleBackColor = false;
            this.btnDriver3.CheckedChanged += new System.EventHandler(this.btnDriver3_CheckedChanged);
            // 
            // btnDriver2
            // 
            this.btnDriver2.AutoSize = true;
            this.btnDriver2.BackColor = System.Drawing.Color.Transparent;
            this.btnDriver2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDriver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver2.Location = new System.Drawing.Point(4, 121);
            this.btnDriver2.Name = "btnDriver2";
            this.btnDriver2.Size = new System.Drawing.Size(92, 28);
            this.btnDriver2.TabIndex = 16;
            this.btnDriver2.TabStop = true;
            this.btnDriver2.Text = "Driver 2";
            this.btnDriver2.UseVisualStyleBackColor = false;
            this.btnDriver2.CheckedChanged += new System.EventHandler(this.btnDriver2_CheckedChanged);
            // 
            // btnDriver1
            // 
            this.btnDriver1.AutoSize = true;
            this.btnDriver1.BackColor = System.Drawing.Color.Transparent;
            this.btnDriver1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDriver1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver1.Location = new System.Drawing.Point(4, 87);
            this.btnDriver1.Name = "btnDriver1";
            this.btnDriver1.Size = new System.Drawing.Size(92, 28);
            this.btnDriver1.TabIndex = 15;
            this.btnDriver1.TabStop = true;
            this.btnDriver1.Text = "Driver 1";
            this.btnDriver1.UseVisualStyleBackColor = false;
            this.btnDriver1.CheckedChanged += new System.EventHandler(this.btnDriver1_CheckedChanged);
            // 
            // btnHolder
            // 
            this.btnHolder.AutoSize = true;
            this.btnHolder.BackColor = System.Drawing.Color.Transparent;
            this.btnHolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHolder.Location = new System.Drawing.Point(4, 53);
            this.btnHolder.Name = "btnHolder";
            this.btnHolder.Size = new System.Drawing.Size(140, 28);
            this.btnHolder.TabIndex = 14;
            this.btnHolder.TabStop = true;
            this.btnHolder.Text = "Policy Holder";
            this.btnHolder.UseVisualStyleBackColor = false;
            this.btnHolder.CheckedChanged += new System.EventHandler(this.btnHolder_CheckedChanged);
            // 
            // lblMain
            // 
            this.lblMain.BackColor = System.Drawing.Color.Transparent;
            this.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(178, 87);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(317, 251);
            this.lblMain.TabIndex = 15;
            this.lblMain.Text = "lblMain";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(501, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 50);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(670, 420);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.grpButtons.ResumeLayout(false);
            this.grpButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.RadioButton btnDriver5;
        private System.Windows.Forms.RadioButton btnDriver4;
        private System.Windows.Forms.RadioButton btnDriver3;
        private System.Windows.Forms.RadioButton btnDriver2;
        private System.Windows.Forms.RadioButton btnDriver1;
        private System.Windows.Forms.RadioButton btnHolder;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.RadioButton btnOverview;
        private System.Windows.Forms.Button btnExit;
    }
}