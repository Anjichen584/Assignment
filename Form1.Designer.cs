namespace SedapMakanChefModule
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.txtMenuPrice = new System.Windows.Forms.TextBox();
            this.chkMenuAvailable = new System.Windows.Forms.CheckBox();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.btnToggleAvailability = new System.Windows.Forms.Button();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.btnLoadOrders = new System.Windows.Forms.Button();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnUpdateOrderStatus = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(30, 30);
            this.txtMenuName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(178, 35);
            this.txtMenuName.TabIndex = 0;
            // 
            // txtMenuPrice
            // 
            this.txtMenuPrice.Location = new System.Drawing.Point(240, 30);
            this.txtMenuPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.Size = new System.Drawing.Size(118, 35);
            this.txtMenuPrice.TabIndex = 1;
            // 
            // chkMenuAvailable
            // 
            this.chkMenuAvailable.Location = new System.Drawing.Point(390, 30);
            this.chkMenuAvailable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMenuAvailable.Name = "chkMenuAvailable";
            this.chkMenuAvailable.Size = new System.Drawing.Size(150, 36);
            this.chkMenuAvailable.TabIndex = 2;
            this.chkMenuAvailable.Text = "Available";
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(570, 30);
            this.btnAddMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(150, 36);
            this.btnAddMenu.TabIndex = 3;
            this.btnAddMenu.Text = "Add Menu";
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // btnToggleAvailability
            // 
            this.btnToggleAvailability.Location = new System.Drawing.Point(750, 30);
            this.btnToggleAvailability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToggleAvailability.Name = "btnToggleAvailability";
            this.btnToggleAvailability.Size = new System.Drawing.Size(195, 36);
            this.btnToggleAvailability.TabIndex = 4;
            this.btnToggleAvailability.Text = "Toggle Availability";
            this.btnToggleAvailability.Click += new System.EventHandler(this.btnToggleAvailability_Click);
            // 
            // lstMenu
            // 
            this.lstMenu.ItemHeight = 24;
            this.lstMenu.Location = new System.Drawing.Point(30, 90);
            this.lstMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(448, 148);
            this.lstMenu.TabIndex = 5;
            // 
            // btnLoadOrders
            // 
            this.btnLoadOrders.Location = new System.Drawing.Point(30, 270);
            this.btnLoadOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadOrders.Name = "btnLoadOrders";
            this.btnLoadOrders.Size = new System.Drawing.Size(180, 36);
            this.btnLoadOrders.TabIndex = 6;
            this.btnLoadOrders.Text = "Load Orders";
            this.btnLoadOrders.Click += new System.EventHandler(this.btnLoadOrders_Click);
            // 
            // lstOrders
            // 
            this.lstOrders.ItemHeight = 24;
            this.lstOrders.Location = new System.Drawing.Point(30, 330);
            this.lstOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(448, 148);
            this.lstOrders.TabIndex = 7;
            // 
            // btnUpdateOrderStatus
            // 
            this.btnUpdateOrderStatus.Location = new System.Drawing.Point(510, 330);
            this.btnUpdateOrderStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateOrderStatus.Name = "btnUpdateOrderStatus";
            this.btnUpdateOrderStatus.Size = new System.Drawing.Size(210, 36);
            this.btnUpdateOrderStatus.TabIndex = 8;
            this.btnUpdateOrderStatus.Text = "Update Order Status";
            this.btnUpdateOrderStatus.Click += new System.EventHandler(this.btnUpdateOrderStatus_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(30, 510);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(223, 35);
            this.txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(270, 510);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 35);
            this.txtPassword.TabIndex = 10;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(510, 510);
            this.btnUpdateProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(210, 36);
            this.btnUpdateProfile.TabIndex = 11;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 731);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.txtMenuPrice);
            this.Controls.Add(this.chkMenuAvailable);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.btnToggleAvailability);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.btnLoadOrders);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.btnUpdateOrderStatus);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnUpdateProfile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Chef Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.TextBox txtMenuPrice;
        private System.Windows.Forms.CheckBox chkMenuAvailable;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnToggleAvailability;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.Button btnLoadOrders;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Button btnUpdateOrderStatus;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnUpdateProfile;
    }
}
