namespace Insure_It_All
{
    partial class frmPolicyDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPolicyDetails));
            this.dtpPolicyStart = new System.Windows.Forms.DateTimePicker();
            this.lblPolicyStart = new System.Windows.Forms.Label();
            this.lblPolicyHolder = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.txtHolderFirstn = new System.Windows.Forms.TextBox();
            this.lblFirstn = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtHolderSurname = new System.Windows.Forms.TextBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.cboDrivers = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDrivers = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPolicyStart
            // 
            this.dtpPolicyStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPolicyStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPolicyStart.Location = new System.Drawing.Point(140, 6);
            this.dtpPolicyStart.MinDate = new System.DateTime(2017, 11, 24, 23, 59, 59, 0);
            this.dtpPolicyStart.Name = "dtpPolicyStart";
            this.dtpPolicyStart.Size = new System.Drawing.Size(167, 24);
            this.dtpPolicyStart.TabIndex = 0;
            this.dtpPolicyStart.Value = new System.DateTime(2017, 11, 24, 23, 59, 59, 0);
            // 
            // lblPolicyStart
            // 
            this.lblPolicyStart.AutoSize = true;
            this.lblPolicyStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicyStart.Location = new System.Drawing.Point(4, 8);
            this.lblPolicyStart.Name = "lblPolicyStart";
            this.lblPolicyStart.Size = new System.Drawing.Size(135, 18);
            this.lblPolicyStart.TabIndex = 1;
            this.lblPolicyStart.Text = "Policy Start Date";
            // 
            // lblPolicyHolder
            // 
            this.lblPolicyHolder.AutoSize = true;
            this.lblPolicyHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicyHolder.Location = new System.Drawing.Point(28, 40);
            this.lblPolicyHolder.Name = "lblPolicyHolder";
            this.lblPolicyHolder.Size = new System.Drawing.Size(109, 18);
            this.lblPolicyHolder.TabIndex = 0;
            this.lblPolicyHolder.Text = "Policy Holder";
            // 
            // cboTitle
            // 
            this.cboTitle.BackColor = System.Drawing.Color.White;
            this.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss.",
            "Fr.",
            "Dr."});
            this.cboTitle.Location = new System.Drawing.Point(130, 64);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(61, 26);
            this.cboTitle.TabIndex = 1;
            // 
            // txtHolderFirstn
            // 
            this.txtHolderFirstn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHolderFirstn.Location = new System.Drawing.Point(130, 96);
            this.txtHolderFirstn.Name = "txtHolderFirstn";
            this.txtHolderFirstn.Size = new System.Drawing.Size(177, 24);
            this.txtHolderFirstn.TabIndex = 2;
            // 
            // lblFirstn
            // 
            this.lblFirstn.AutoSize = true;
            this.lblFirstn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstn.Location = new System.Drawing.Point(43, 99);
            this.lblFirstn.Name = "lblFirstn";
            this.lblFirstn.Size = new System.Drawing.Size(81, 18);
            this.lblFirstn.TabIndex = 0;
            this.lblFirstn.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(56, 126);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(68, 18);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname";
            // 
            // txtHolderSurname
            // 
            this.txtHolderSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHolderSurname.Location = new System.Drawing.Point(130, 126);
            this.txtHolderSurname.Name = "txtHolderSurname";
            this.txtHolderSurname.Size = new System.Drawing.Size(177, 24);
            this.txtHolderSurname.TabIndex = 3;
            // 
            // picNext
            // 
            this.picNext.BackColor = System.Drawing.Color.Transparent;
            this.picNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picNext.BackgroundImage")));
            this.picNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNext.Location = new System.Drawing.Point(70, 272);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(191, 78);
            this.picNext.TabIndex = 6;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cboDrivers);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblDrivers);
            this.panelTop.Controls.Add(this.lblSurname);
            this.panelTop.Controls.Add(this.txtHolderSurname);
            this.panelTop.Controls.Add(this.lblFirstn);
            this.panelTop.Controls.Add(this.txtHolderFirstn);
            this.panelTop.Controls.Add(this.cboTitle);
            this.panelTop.Controls.Add(this.lblPolicyHolder);
            this.panelTop.Controls.Add(this.lblPolicyStart);
            this.panelTop.Controls.Add(this.dtpPolicyStart);
            this.panelTop.Location = new System.Drawing.Point(6, 63);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(318, 203);
            this.panelTop.TabIndex = 29;
            // 
            // cboDrivers
            // 
            this.cboDrivers.BackColor = System.Drawing.Color.White;
            this.cboDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDrivers.FormattingEnabled = true;
            this.cboDrivers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboDrivers.Location = new System.Drawing.Point(223, 156);
            this.cboDrivers.Name = "cboDrivers";
            this.cboDrivers.Size = new System.Drawing.Size(84, 26);
            this.cboDrivers.TabIndex = 36;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(89, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 18);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Title";
            // 
            // lblDrivers
            // 
            this.lblDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivers.Location = new System.Drawing.Point(38, 153);
            this.lblDrivers.Name = "lblDrivers";
            this.lblDrivers.Size = new System.Drawing.Size(187, 36);
            this.lblDrivers.TabIndex = 34;
            this.lblDrivers.Text = "How many drivers will this policy cover?";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Location = new System.Drawing.Point(59, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(212, 52);
            this.picLogo.TabIndex = 33;
            this.picLogo.TabStop = false;
            // 
            // frmPolicyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(333, 360);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.picNext);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPolicyDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Policy Holder";
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPolicyStart;
        private System.Windows.Forms.Label lblPolicyStart;
        private System.Windows.Forms.Label lblPolicyHolder;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.TextBox txtHolderFirstn;
        private System.Windows.Forms.Label lblFirstn;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtHolderSurname;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblDrivers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ComboBox cboDrivers;
    }
}

