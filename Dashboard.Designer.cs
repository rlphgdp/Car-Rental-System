using FontAwesome.Sharp;

namespace VehicleManagementSystem {
    partial class Dashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.reportAndAnalyticsBtn = new FontAwesome.Sharp.IconButton();
            this.docuManagementBtn = new FontAwesome.Sharp.IconButton();
            this.damageAndInspecBtn = new FontAwesome.Sharp.IconButton();
            this.maintenanceMangementBtn = new FontAwesome.Sharp.IconButton();
            this.vehManagementBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.maximizeBtn = new FontAwesome.Sharp.IconButton();
            this.searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.minimizeBtn = new FontAwesome.Sharp.IconButton();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.panelMenu.Controls.Add(this.reportAndAnalyticsBtn);
            this.panelMenu.Controls.Add(this.docuManagementBtn);
            this.panelMenu.Controls.Add(this.damageAndInspecBtn);
            this.panelMenu.Controls.Add(this.maintenanceMangementBtn);
            this.panelMenu.Controls.Add(this.vehManagementBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(354, 809);
            this.panelMenu.TabIndex = 0;
            // 
            // reportAndAnalyticsBtn
            // 
            this.reportAndAnalyticsBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportAndAnalyticsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportAndAnalyticsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportAndAnalyticsBtn.FlatAppearance.BorderSize = 0;
            this.reportAndAnalyticsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(81)))));
            this.reportAndAnalyticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportAndAnalyticsBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportAndAnalyticsBtn.ForeColor = System.Drawing.Color.White;
            this.reportAndAnalyticsBtn.IconChar = FontAwesome.Sharp.IconChar.CircleExclamation;
            this.reportAndAnalyticsBtn.IconColor = System.Drawing.Color.White;
            this.reportAndAnalyticsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportAndAnalyticsBtn.IconSize = 50;
            this.reportAndAnalyticsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportAndAnalyticsBtn.Location = new System.Drawing.Point(0, 550);
            this.reportAndAnalyticsBtn.Name = "reportAndAnalyticsBtn";
            this.reportAndAnalyticsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.reportAndAnalyticsBtn.Size = new System.Drawing.Size(354, 85);
            this.reportAndAnalyticsBtn.TabIndex = 5;
            this.reportAndAnalyticsBtn.Text = "Reports and Analytic";
            this.reportAndAnalyticsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportAndAnalyticsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportAndAnalyticsBtn.UseVisualStyleBackColor = false;
            this.reportAndAnalyticsBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // docuManagementBtn
            // 
            this.docuManagementBtn.BackColor = System.Drawing.Color.Transparent;
            this.docuManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.docuManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.docuManagementBtn.FlatAppearance.BorderSize = 0;
            this.docuManagementBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(81)))));
            this.docuManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docuManagementBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docuManagementBtn.ForeColor = System.Drawing.Color.White;
            this.docuManagementBtn.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.docuManagementBtn.IconColor = System.Drawing.Color.White;
            this.docuManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.docuManagementBtn.IconSize = 50;
            this.docuManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.docuManagementBtn.Location = new System.Drawing.Point(0, 465);
            this.docuManagementBtn.Name = "docuManagementBtn";
            this.docuManagementBtn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.docuManagementBtn.Size = new System.Drawing.Size(354, 85);
            this.docuManagementBtn.TabIndex = 4;
            this.docuManagementBtn.Text = "Document Management";
            this.docuManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.docuManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.docuManagementBtn.UseVisualStyleBackColor = false;
            this.docuManagementBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // damageAndInspecBtn
            // 
            this.damageAndInspecBtn.BackColor = System.Drawing.Color.Transparent;
            this.damageAndInspecBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.damageAndInspecBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.damageAndInspecBtn.FlatAppearance.BorderSize = 0;
            this.damageAndInspecBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(81)))));
            this.damageAndInspecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.damageAndInspecBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageAndInspecBtn.ForeColor = System.Drawing.Color.White;
            this.damageAndInspecBtn.IconChar = FontAwesome.Sharp.IconChar.CarCrash;
            this.damageAndInspecBtn.IconColor = System.Drawing.Color.White;
            this.damageAndInspecBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.damageAndInspecBtn.IconSize = 50;
            this.damageAndInspecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.damageAndInspecBtn.Location = new System.Drawing.Point(0, 380);
            this.damageAndInspecBtn.Name = "damageAndInspecBtn";
            this.damageAndInspecBtn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.damageAndInspecBtn.Size = new System.Drawing.Size(354, 85);
            this.damageAndInspecBtn.TabIndex = 3;
            this.damageAndInspecBtn.Text = "Damage and Inspection";
            this.damageAndInspecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.damageAndInspecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.damageAndInspecBtn.UseVisualStyleBackColor = false;
            this.damageAndInspecBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // maintenanceMangementBtn
            // 
            this.maintenanceMangementBtn.BackColor = System.Drawing.Color.Transparent;
            this.maintenanceMangementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maintenanceMangementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.maintenanceMangementBtn.FlatAppearance.BorderSize = 0;
            this.maintenanceMangementBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(81)))));
            this.maintenanceMangementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maintenanceMangementBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceMangementBtn.ForeColor = System.Drawing.Color.White;
            this.maintenanceMangementBtn.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.maintenanceMangementBtn.IconColor = System.Drawing.Color.White;
            this.maintenanceMangementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maintenanceMangementBtn.IconSize = 50;
            this.maintenanceMangementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maintenanceMangementBtn.Location = new System.Drawing.Point(0, 295);
            this.maintenanceMangementBtn.Name = "maintenanceMangementBtn";
            this.maintenanceMangementBtn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.maintenanceMangementBtn.Size = new System.Drawing.Size(354, 85);
            this.maintenanceMangementBtn.TabIndex = 2;
            this.maintenanceMangementBtn.Text = "Maintenance Management";
            this.maintenanceMangementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maintenanceMangementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.maintenanceMangementBtn.UseVisualStyleBackColor = false;
            this.maintenanceMangementBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // vehManagementBtn
            // 
            this.vehManagementBtn.BackColor = System.Drawing.Color.Transparent;
            this.vehManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vehManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vehManagementBtn.FlatAppearance.BorderSize = 0;
            this.vehManagementBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(81)))));
            this.vehManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehManagementBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehManagementBtn.ForeColor = System.Drawing.Color.White;
            this.vehManagementBtn.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.vehManagementBtn.IconColor = System.Drawing.Color.White;
            this.vehManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vehManagementBtn.IconSize = 50;
            this.vehManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehManagementBtn.Location = new System.Drawing.Point(0, 210);
            this.vehManagementBtn.Name = "vehManagementBtn";
            this.vehManagementBtn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.vehManagementBtn.Size = new System.Drawing.Size(354, 85);
            this.vehManagementBtn.TabIndex = 1;
            this.vehManagementBtn.Text = "Vehicle Management";
            this.vehManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehManagementBtn.UseVisualStyleBackColor = false;
            this.vehManagementBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(354, 210);
            this.panelLogo.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.searchButton);
            this.panelHeader.Controls.Add(this.maximizeBtn);
            this.panelHeader.Controls.Add(this.searchBar);
            this.panelHeader.Controls.Add(this.minimizeBtn);
            this.panelHeader.Controls.Add(this.closeBtn);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Location = new System.Drawing.Point(354, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1266, 80);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackColor = System.Drawing.Color.White;
            this.maximizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.maximizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.ForeColor = System.Drawing.Color.White;
            this.maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximizeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.maximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizeBtn.IconSize = 25;
            this.maximizeBtn.Location = new System.Drawing.Point(1128, 12);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(60, 30);
            this.maximizeBtn.TabIndex = 2;
            this.maximizeBtn.UseVisualStyleBackColor = false;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // searchBar
            // 
            this.searchBar.BorderRadius = 20;
            this.searchBar.BorderThickness = 5;
            this.searchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.DefaultText = "";
            this.searchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.searchBar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.searchBar.IconRight = global::VehicleManagementSystem.Properties.Resources.magnifying_glass;
            this.searchBar.IconRightOffset = new System.Drawing.Point(15, 0);
            this.searchBar.IconRightSize = new System.Drawing.Size(25, 25);
            this.searchBar.Location = new System.Drawing.Point(18, 15);
            this.searchBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchBar.Name = "searchBar";
            this.searchBar.PlaceholderText = "";
            this.searchBar.SelectedText = "";
            this.searchBar.Size = new System.Drawing.Size(687, 50);
            this.searchBar.TabIndex = 3;
            this.searchBar.TextOffset = new System.Drawing.Point(10, 0);
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            this.searchBar.Enter += new System.EventHandler(this.searchBar_Enter);
            this.searchBar.Leave += new System.EventHandler(this.searchBar_Leave);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.White;
            this.minimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimizeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeBtn.IconSize = 28;
            this.minimizeBtn.Location = new System.Drawing.Point(1062, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(60, 30);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 28;
            this.closeBtn.Location = new System.Drawing.Point(1194, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(60, 30);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.searchButton.BorderRadius = 20;
            this.searchButton.BorderThickness = 5;
            this.searchButton.CustomizableEdges.BottomLeft = false;
            this.searchButton.CustomizableEdges.TopLeft = false;
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.FillColor = System.Drawing.Color.Transparent;
            this.searchButton.FocusedColor = System.Drawing.Color.Gray;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = global::VehicleManagementSystem.Properties.Resources.magnifying_glass;
            this.searchButton.ImageSize = new System.Drawing.Size(30, 30);
            this.searchButton.Location = new System.Drawing.Point(625, 15);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 50);
            this.searchButton.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 809);
            this.ControlBox = false;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton vehManagementBtn;
        private FontAwesome.Sharp.IconButton reportAndAnalyticsBtn;
        private FontAwesome.Sharp.IconButton docuManagementBtn;
        private FontAwesome.Sharp.IconButton damageAndInspecBtn;
        private FontAwesome.Sharp.IconButton maintenanceMangementBtn;
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconButton maximizeBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private Guna.UI2.WinForms.Guna2Button searchButton;
    }
}