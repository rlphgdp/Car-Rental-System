using System.Drawing;
using VehicleManagementSystem.Classes;

namespace VehicleManagementSystem.Forms {
    partial class frmAddNewVehicle {
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
            this.panelBg = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.backBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLowerInputs = new System.Windows.Forms.TableLayoutPanel();
            this.panelCarRental = new Guna.UI2.WinForms.Guna2Panel();
            this.inputTransmissionType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.inputFuelType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.inputSeatCapacity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.inputDailyRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panelRentalDetailsHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPurchaseDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.inputPurchaseDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.InputOdometer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.inputPurchasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelPurchaseDetailsHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelBasicInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.tableBasicInfo = new System.Windows.Forms.TableLayoutPanel();
            this.panelBasicInfoLeft = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.inputModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputManufacturer = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputVehicleIdentificationNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPlateNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelBasicInfoRight = new System.Windows.Forms.Panel();
            this.vehicleImageFilename = new Guna.UI2.WinForms.Guna2TextBox();
            this.addImageBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.inputColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputYearModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelBasicInfoHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelBg.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLowerInputs.SuspendLayout();
            this.panelCarRental.SuspendLayout();
            this.panelRentalDetailsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            this.panelPurchaseDetails.SuspendLayout();
            this.panelPurchaseDetailsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.panelBasicInformation.SuspendLayout();
            this.tableBasicInfo.SuspendLayout();
            this.panelBasicInfoLeft.SuspendLayout();
            this.panelBasicInfoRight.SuspendLayout();
            this.panelBasicInfoHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBg
            // 
            this.panelBg.BackColor = System.Drawing.Color.Transparent;
            this.panelBg.BorderRadius = 25;
            this.panelBg.Controls.Add(this.panelMain);
            this.panelBg.CustomizableEdges.BottomLeft = false;
            this.panelBg.CustomizableEdges.BottomRight = false;
            this.panelBg.CustomizableEdges.TopRight = false;
            this.panelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelBg.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelBg.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(1274, 683);
            this.panelBg.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.backBtn);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.tableLowerInputs);
            this.panelMain.Controls.Add(this.panelBasicInformation);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.CustomizableEdges.BottomLeft = false;
            this.panelMain.CustomizableEdges.BottomRight = false;
            this.panelMain.CustomizableEdges.TopRight = false;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelMain.Location = new System.Drawing.Point(24, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panelMain.Size = new System.Drawing.Size(1250, 683);
            this.panelMain.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.saveBtn);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Location = new System.Drawing.Point(54, 979);
            this.panel2.MaximumSize = new System.Drawing.Size(1203, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 73);
            this.panel2.TabIndex = 16;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BorderRadius = 10;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.saveBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Image = global::VehicleManagementSystem.Properties.Resources.save_icon;
            this.saveBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.saveBtn.Location = new System.Drawing.Point(923, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(230, 55);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save Vehicle";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BorderRadius = 10;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.Silver;
            this.cancelBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Image = global::VehicleManagementSystem.Properties.Resources.cancel_icon;
            this.cancelBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.cancelBtn.Location = new System.Drawing.Point(752, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(147, 55);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.BorderThickness = 4;
            this.backBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBtn.FillColor = System.Drawing.Color.Transparent;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::VehicleManagementSystem.Properties.Resources.chevron_backward_icon;
            this.backBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.backBtn.Location = new System.Drawing.Point(51, 38);
            this.backBtn.Name = "backBtn";
            this.backBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.backBtn.Size = new System.Drawing.Size(45, 45);
            this.backBtn.TabIndex = 17;
            this.backBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(636, 1085);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 26);
            this.panel1.TabIndex = 15;
            // 
            // tableLowerInputs
            // 
            this.tableLowerInputs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLowerInputs.ColumnCount = 2;
            this.tableLowerInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLowerInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLowerInputs.Controls.Add(this.panelCarRental, 1, 0);
            this.tableLowerInputs.Controls.Add(this.panelPurchaseDetails, 0, 0);
            this.tableLowerInputs.Location = new System.Drawing.Point(51, 604);
            this.tableLowerInputs.MaximumSize = new System.Drawing.Size(1203, 448);
            this.tableLowerInputs.Name = "tableLowerInputs";
            this.tableLowerInputs.RowCount = 1;
            this.tableLowerInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLowerInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLowerInputs.Size = new System.Drawing.Size(1153, 353);
            this.tableLowerInputs.TabIndex = 13;
            // 
            // panelCarRental
            // 
            this.panelCarRental.BorderRadius = 20;
            this.panelCarRental.Controls.Add(this.inputTransmissionType);
            this.panelCarRental.Controls.Add(this.inputFuelType);
            this.panelCarRental.Controls.Add(this.label20);
            this.panelCarRental.Controls.Add(this.inputSeatCapacity);
            this.panelCarRental.Controls.Add(this.label17);
            this.panelCarRental.Controls.Add(this.label18);
            this.panelCarRental.Controls.Add(this.inputDailyRate);
            this.panelCarRental.Controls.Add(this.label19);
            this.panelCarRental.Controls.Add(this.panelRentalDetailsHeader);
            this.panelCarRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarRental.FillColor = System.Drawing.Color.White;
            this.panelCarRental.Location = new System.Drawing.Point(596, 0);
            this.panelCarRental.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelCarRental.Name = "panelCarRental";
            this.panelCarRental.Size = new System.Drawing.Size(557, 341);
            this.panelCarRental.TabIndex = 14;
            // 
            // inputTransmissionType
            // 
            this.inputTransmissionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTransmissionType.BackColor = System.Drawing.Color.Transparent;
            this.inputTransmissionType.BorderRadius = 10;
            this.inputTransmissionType.BorderThickness = 2;
            this.inputTransmissionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.inputTransmissionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputTransmissionType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputTransmissionType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputTransmissionType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTransmissionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.inputTransmissionType.IntegralHeight = false;
            this.inputTransmissionType.ItemHeight = 50;
            this.inputTransmissionType.Location = new System.Drawing.Point(292, 241);
            this.inputTransmissionType.Margin = new System.Windows.Forms.Padding(10);
            this.inputTransmissionType.Name = "inputTransmissionType";
            this.inputTransmissionType.Size = new System.Drawing.Size(231, 56);
            this.inputTransmissionType.TabIndex = 24;
            // 
            // inputFuelType
            // 
            this.inputFuelType.BackColor = System.Drawing.Color.Transparent;
            this.inputFuelType.BorderRadius = 10;
            this.inputFuelType.BorderThickness = 2;
            this.inputFuelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.inputFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputFuelType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputFuelType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputFuelType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFuelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.inputFuelType.IntegralHeight = false;
            this.inputFuelType.ItemHeight = 50;
            this.inputFuelType.Location = new System.Drawing.Point(40, 241);
            this.inputFuelType.Margin = new System.Windows.Forms.Padding(10);
            this.inputFuelType.Name = "inputFuelType";
            this.inputFuelType.Size = new System.Drawing.Size(227, 56);
            this.inputFuelType.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label20.Location = new System.Drawing.Point(287, 211);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(192, 26);
            this.label20.TabIndex = 27;
            this.label20.Text = "Transmission Type";
            // 
            // inputSeatCapacity
            // 
            this.inputSeatCapacity.BorderRadius = 10;
            this.inputSeatCapacity.BorderThickness = 2;
            this.inputSeatCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputSeatCapacity.DefaultText = "";
            this.inputSeatCapacity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputSeatCapacity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputSeatCapacity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputSeatCapacity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputSeatCapacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputSeatCapacity.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSeatCapacity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputSeatCapacity.Location = new System.Drawing.Point(294, 121);
            this.inputSeatCapacity.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputSeatCapacity.Name = "inputSeatCapacity";
            this.inputSeatCapacity.PlaceholderText = "";
            this.inputSeatCapacity.SelectedText = "";
            this.inputSeatCapacity.Size = new System.Drawing.Size(229, 55);
            this.inputSeatCapacity.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label17.Location = new System.Drawing.Point(289, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 26);
            this.label17.TabIndex = 25;
            this.label17.Text = " Seating Capacity";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label18.Location = new System.Drawing.Point(35, 212);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 26);
            this.label18.TabIndex = 23;
            this.label18.Text = "Fuel Type";
            // 
            // inputDailyRate
            // 
            this.inputDailyRate.BorderRadius = 10;
            this.inputDailyRate.BorderThickness = 2;
            this.inputDailyRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputDailyRate.DefaultText = "";
            this.inputDailyRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputDailyRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputDailyRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputDailyRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputDailyRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputDailyRate.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDailyRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputDailyRate.Location = new System.Drawing.Point(40, 119);
            this.inputDailyRate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputDailyRate.Name = "inputDailyRate";
            this.inputDailyRate.PlaceholderText = "";
            this.inputDailyRate.SelectedText = "";
            this.inputDailyRate.Size = new System.Drawing.Size(227, 55);
            this.inputDailyRate.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label19.Location = new System.Drawing.Point(35, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 26);
            this.label19.TabIndex = 21;
            this.label19.Text = "Daily Rate (₱)";
            // 
            // panelRentalDetailsHeader
            // 
            this.panelRentalDetailsHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelRentalDetailsHeader.BorderRadius = 20;
            this.panelRentalDetailsHeader.Controls.Add(this.guna2CirclePictureBox4);
            this.panelRentalDetailsHeader.Controls.Add(this.label1);
            this.panelRentalDetailsHeader.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelRentalDetailsHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panelRentalDetailsHeader.CustomizableEdges.BottomLeft = false;
            this.panelRentalDetailsHeader.CustomizableEdges.BottomRight = false;
            this.panelRentalDetailsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRentalDetailsHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.panelRentalDetailsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelRentalDetailsHeader.Name = "panelRentalDetailsHeader";
            this.panelRentalDetailsHeader.Size = new System.Drawing.Size(557, 64);
            this.panelRentalDetailsHeader.TabIndex = 1;
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox4.FillColor = System.Drawing.Color.LightGray;
            this.guna2CirclePictureBox4.Image = global::VehicleManagementSystem.Properties.Resources.car_gear_icon;
            this.guna2CirclePictureBox4.ImageRotate = 0F;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(25, 15);
            this.guna2CirclePictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(34, 33);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox4.TabIndex = 11;
            this.guna2CirclePictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rental Details";
            // 
            // panelPurchaseDetails
            // 
            this.panelPurchaseDetails.BorderRadius = 20;
            this.panelPurchaseDetails.Controls.Add(this.inputPurchaseDate);
            this.panelPurchaseDetails.Controls.Add(this.InputOdometer);
            this.panelPurchaseDetails.Controls.Add(this.label16);
            this.panelPurchaseDetails.Controls.Add(this.inputPurchasePrice);
            this.panelPurchaseDetails.Controls.Add(this.label14);
            this.panelPurchaseDetails.Controls.Add(this.label13);
            this.panelPurchaseDetails.Controls.Add(this.panelPurchaseDetailsHeader);
            this.panelPurchaseDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPurchaseDetails.FillColor = System.Drawing.Color.White;
            this.panelPurchaseDetails.Location = new System.Drawing.Point(0, 0);
            this.panelPurchaseDetails.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panelPurchaseDetails.Name = "panelPurchaseDetails";
            this.panelPurchaseDetails.Size = new System.Drawing.Size(556, 341);
            this.panelPurchaseDetails.TabIndex = 11;
            // 
            // inputPurchaseDate
            // 
            this.inputPurchaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPurchaseDate.BackColor = System.Drawing.Color.White;
            this.inputPurchaseDate.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.inputPurchaseDate.BorderRadius = 10;
            this.inputPurchaseDate.BorderThickness = 6;
            this.inputPurchaseDate.Checked = true;
            this.inputPurchaseDate.FillColor = System.Drawing.Color.White;
            this.inputPurchaseDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inputPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.inputPurchaseDate.Location = new System.Drawing.Point(36, 121);
            this.inputPurchaseDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.inputPurchaseDate.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.inputPurchaseDate.Name = "inputPurchaseDate";
            this.inputPurchaseDate.Size = new System.Drawing.Size(482, 55);
            this.inputPurchaseDate.TabIndex = 20;
            this.inputPurchaseDate.Value = new System.DateTime(2026, 1, 20, 18, 53, 53, 702);
            // 
            // InputOdometer
            // 
            this.InputOdometer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputOdometer.BorderRadius = 10;
            this.InputOdometer.BorderThickness = 2;
            this.InputOdometer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputOdometer.DefaultText = "";
            this.InputOdometer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputOdometer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputOdometer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputOdometer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputOdometer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputOdometer.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOdometer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputOdometer.Location = new System.Drawing.Point(294, 243);
            this.InputOdometer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.InputOdometer.Name = "InputOdometer";
            this.InputOdometer.PlaceholderText = "";
            this.InputOdometer.SelectedText = "";
            this.InputOdometer.Size = new System.Drawing.Size(224, 55);
            this.InputOdometer.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label16.Location = new System.Drawing.Point(286, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(241, 26);
            this.label16.TabIndex = 19;
            this.label16.Text = "Current Odometer (Km)";
            // 
            // inputPurchasePrice
            // 
            this.inputPurchasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPurchasePrice.BorderRadius = 10;
            this.inputPurchasePrice.BorderThickness = 2;
            this.inputPurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPurchasePrice.DefaultText = "";
            this.inputPurchasePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputPurchasePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputPurchasePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputPurchasePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputPurchasePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputPurchasePrice.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPurchasePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputPurchasePrice.Location = new System.Drawing.Point(36, 242);
            this.inputPurchasePrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputPurchasePrice.Name = "inputPurchasePrice";
            this.inputPurchasePrice.PlaceholderText = "";
            this.inputPurchasePrice.SelectedText = "";
            this.inputPurchasePrice.Size = new System.Drawing.Size(227, 56);
            this.inputPurchasePrice.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label14.Location = new System.Drawing.Point(31, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 26);
            this.label14.TabIndex = 17;
            this.label14.Text = "Purchase Price";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label13.Location = new System.Drawing.Point(31, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 26);
            this.label13.TabIndex = 15;
            this.label13.Text = "Purchase Date";
            // 
            // panelPurchaseDetailsHeader
            // 
            this.panelPurchaseDetailsHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelPurchaseDetailsHeader.BorderRadius = 20;
            this.panelPurchaseDetailsHeader.Controls.Add(this.guna2CirclePictureBox2);
            this.panelPurchaseDetailsHeader.Controls.Add(this.label12);
            this.panelPurchaseDetailsHeader.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelPurchaseDetailsHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panelPurchaseDetailsHeader.CustomizableEdges.BottomLeft = false;
            this.panelPurchaseDetailsHeader.CustomizableEdges.BottomRight = false;
            this.panelPurchaseDetailsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPurchaseDetailsHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.panelPurchaseDetailsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelPurchaseDetailsHeader.Name = "panelPurchaseDetailsHeader";
            this.panelPurchaseDetailsHeader.Size = new System.Drawing.Size(556, 64);
            this.panelPurchaseDetailsHeader.TabIndex = 1;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.LightGray;
            this.guna2CirclePictureBox2.Image = global::VehicleManagementSystem.Properties.Resources.price_change_icon;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(25, 15);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(34, 33);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 11;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(66, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 29);
            this.label12.TabIndex = 8;
            this.label12.Text = "Purchase Details";
            // 
            // panelBasicInformation
            // 
            this.panelBasicInformation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBasicInformation.BackColor = System.Drawing.Color.Transparent;
            this.panelBasicInformation.BorderRadius = 20;
            this.panelBasicInformation.Controls.Add(this.tableBasicInfo);
            this.panelBasicInformation.Controls.Add(this.panelBasicInfoHeader);
            this.panelBasicInformation.FillColor = System.Drawing.Color.White;
            this.panelBasicInformation.Location = new System.Drawing.Point(51, 122);
            this.panelBasicInformation.MaximumSize = new System.Drawing.Size(1203, 448);
            this.panelBasicInformation.Name = "panelBasicInformation";
            this.panelBasicInformation.Size = new System.Drawing.Size(1153, 448);
            this.panelBasicInformation.TabIndex = 9;
            // 
            // tableBasicInfo
            // 
            this.tableBasicInfo.ColumnCount = 2;
            this.tableBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBasicInfo.Controls.Add(this.panelBasicInfoLeft, 0, 0);
            this.tableBasicInfo.Controls.Add(this.panelBasicInfoRight, 1, 0);
            this.tableBasicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBasicInfo.Location = new System.Drawing.Point(0, 64);
            this.tableBasicInfo.Name = "tableBasicInfo";
            this.tableBasicInfo.RowCount = 1;
            this.tableBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBasicInfo.Size = new System.Drawing.Size(1153, 384);
            this.tableBasicInfo.TabIndex = 1;
            // 
            // panelBasicInfoLeft
            // 
            this.panelBasicInfoLeft.Controls.Add(this.label21);
            this.panelBasicInfoLeft.Controls.Add(this.inputModel);
            this.panelBasicInfoLeft.Controls.Add(this.inputManufacturer);
            this.panelBasicInfoLeft.Controls.Add(this.inputVehicleIdentificationNumber);
            this.panelBasicInfoLeft.Controls.Add(this.label6);
            this.panelBasicInfoLeft.Controls.Add(this.label5);
            this.panelBasicInfoLeft.Controls.Add(this.label4);
            this.panelBasicInfoLeft.Controls.Add(this.inputPlateNum);
            this.panelBasicInfoLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBasicInfoLeft.Location = new System.Drawing.Point(3, 3);
            this.panelBasicInfoLeft.Name = "panelBasicInfoLeft";
            this.panelBasicInfoLeft.Size = new System.Drawing.Size(570, 378);
            this.panelBasicInfoLeft.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label21.Location = new System.Drawing.Point(304, 264);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 26);
            this.label21.TabIndex = 26;
            this.label21.Text = "Model";
            // 
            // inputModel
            // 
            this.inputModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputModel.BorderRadius = 10;
            this.inputModel.BorderThickness = 2;
            this.inputModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputModel.DefaultText = "";
            this.inputModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputModel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputModel.Location = new System.Drawing.Point(309, 295);
            this.inputModel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputModel.Name = "inputModel";
            this.inputModel.PlaceholderText = "";
            this.inputModel.SelectedText = "";
            this.inputModel.Size = new System.Drawing.Size(250, 55);
            this.inputModel.TabIndex = 25;
            // 
            // inputManufacturer
            // 
            this.inputManufacturer.BorderRadius = 10;
            this.inputManufacturer.BorderThickness = 2;
            this.inputManufacturer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputManufacturer.DefaultText = "";
            this.inputManufacturer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputManufacturer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputManufacturer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputManufacturer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputManufacturer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputManufacturer.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputManufacturer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputManufacturer.Location = new System.Drawing.Point(36, 295);
            this.inputManufacturer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputManufacturer.Name = "inputManufacturer";
            this.inputManufacturer.PlaceholderText = "";
            this.inputManufacturer.SelectedText = "";
            this.inputManufacturer.Size = new System.Drawing.Size(250, 55);
            this.inputManufacturer.TabIndex = 24;
            // 
            // inputVehicleIdentificationNumber
            // 
            this.inputVehicleIdentificationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputVehicleIdentificationNumber.BorderRadius = 10;
            this.inputVehicleIdentificationNumber.BorderThickness = 2;
            this.inputVehicleIdentificationNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputVehicleIdentificationNumber.DefaultText = "";
            this.inputVehicleIdentificationNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputVehicleIdentificationNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputVehicleIdentificationNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputVehicleIdentificationNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputVehicleIdentificationNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputVehicleIdentificationNumber.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputVehicleIdentificationNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputVehicleIdentificationNumber.Location = new System.Drawing.Point(36, 47);
            this.inputVehicleIdentificationNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputVehicleIdentificationNumber.Name = "inputVehicleIdentificationNumber";
            this.inputVehicleIdentificationNumber.PlaceholderText = "";
            this.inputVehicleIdentificationNumber.SelectedText = "";
            this.inputVehicleIdentificationNumber.Size = new System.Drawing.Size(523, 55);
            this.inputVehicleIdentificationNumber.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(31, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(31, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "License Plate Number";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Location = new System.Drawing.Point(31, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vehicle Identification Number (VIN)";
            // 
            // inputPlateNum
            // 
            this.inputPlateNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPlateNum.BorderRadius = 10;
            this.inputPlateNum.BorderThickness = 2;
            this.inputPlateNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPlateNum.DefaultText = "";
            this.inputPlateNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputPlateNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputPlateNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputPlateNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputPlateNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputPlateNum.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPlateNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputPlateNum.Location = new System.Drawing.Point(36, 170);
            this.inputPlateNum.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputPlateNum.Name = "inputPlateNum";
            this.inputPlateNum.PlaceholderText = "";
            this.inputPlateNum.SelectedText = "";
            this.inputPlateNum.Size = new System.Drawing.Size(523, 55);
            this.inputPlateNum.TabIndex = 10;
            // 
            // panelBasicInfoRight
            // 
            this.panelBasicInfoRight.Controls.Add(this.vehicleImageFilename);
            this.panelBasicInfoRight.Controls.Add(this.addImageBtn);
            this.panelBasicInfoRight.Controls.Add(this.label7);
            this.panelBasicInfoRight.Controls.Add(this.inputColor);
            this.panelBasicInfoRight.Controls.Add(this.inputYearModel);
            this.panelBasicInfoRight.Controls.Add(this.inputCategory);
            this.panelBasicInfoRight.Controls.Add(this.label9);
            this.panelBasicInfoRight.Controls.Add(this.label10);
            this.panelBasicInfoRight.Controls.Add(this.label11);
            this.panelBasicInfoRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBasicInfoRight.Location = new System.Drawing.Point(579, 3);
            this.panelBasicInfoRight.Name = "panelBasicInfoRight";
            this.panelBasicInfoRight.Size = new System.Drawing.Size(571, 378);
            this.panelBasicInfoRight.TabIndex = 1;
            // 
            // vehicleImageFilename
            // 
            this.vehicleImageFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleImageFilename.BorderRadius = 10;
            this.vehicleImageFilename.BorderThickness = 2;
            this.vehicleImageFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vehicleImageFilename.DefaultText = "";
            this.vehicleImageFilename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vehicleImageFilename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vehicleImageFilename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleImageFilename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vehicleImageFilename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleImageFilename.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleImageFilename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vehicleImageFilename.Location = new System.Drawing.Point(193, 295);
            this.vehicleImageFilename.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.vehicleImageFilename.Name = "vehicleImageFilename";
            this.vehicleImageFilename.PlaceholderText = "";
            this.vehicleImageFilename.ReadOnly = true;
            this.vehicleImageFilename.SelectedText = "";
            this.vehicleImageFilename.Size = new System.Drawing.Size(347, 55);
            this.vehicleImageFilename.TabIndex = 1;
            // 
            // addImageBtn
            // 
            this.addImageBtn.BorderRadius = 10;
            this.addImageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addImageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addImageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addImageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addImageBtn.FillColor = System.Drawing.Color.Silver;
            this.addImageBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImageBtn.ForeColor = System.Drawing.Color.White;
            this.addImageBtn.Image = global::VehicleManagementSystem.Properties.Resources.add_circle_icon;
            this.addImageBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.addImageBtn.Location = new System.Drawing.Point(17, 296);
            this.addImageBtn.Name = "addImageBtn";
            this.addImageBtn.Size = new System.Drawing.Size(156, 54);
            this.addImageBtn.TabIndex = 100;
            this.addImageBtn.Text = "Add Image";
            this.addImageBtn.Click += new System.EventHandler(this.addImageBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label7.Location = new System.Drawing.Point(12, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vehicles Image";
            // 
            // inputColor
            // 
            this.inputColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputColor.BorderRadius = 10;
            this.inputColor.BorderThickness = 2;
            this.inputColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputColor.DefaultText = "";
            this.inputColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputColor.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputColor.Location = new System.Drawing.Point(296, 47);
            this.inputColor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputColor.Name = "inputColor";
            this.inputColor.PlaceholderText = "";
            this.inputColor.SelectedText = "";
            this.inputColor.Size = new System.Drawing.Size(244, 55);
            this.inputColor.TabIndex = 24;
            // 
            // inputYearModel
            // 
            this.inputYearModel.BorderRadius = 10;
            this.inputYearModel.BorderThickness = 2;
            this.inputYearModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputYearModel.DefaultText = "";
            this.inputYearModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputYearModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputYearModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputYearModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputYearModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputYearModel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputYearModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputYearModel.Location = new System.Drawing.Point(17, 47);
            this.inputYearModel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputYearModel.Name = "inputYearModel";
            this.inputYearModel.PlaceholderText = "";
            this.inputYearModel.SelectedText = "";
            this.inputYearModel.Size = new System.Drawing.Size(250, 55);
            this.inputYearModel.TabIndex = 23;
            // 
            // inputCategory
            // 
            this.inputCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCategory.BackColor = System.Drawing.Color.Transparent;
            this.inputCategory.BorderRadius = 10;
            this.inputCategory.BorderThickness = 2;
            this.inputCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.inputCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.inputCategory.IntegralHeight = false;
            this.inputCategory.ItemHeight = 50;
            this.inputCategory.Location = new System.Drawing.Point(17, 170);
            this.inputCategory.Margin = new System.Windows.Forms.Padding(10);
            this.inputCategory.Name = "inputCategory";
            this.inputCategory.Size = new System.Drawing.Size(523, 56);
            this.inputCategory.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Location = new System.Drawing.Point(12, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Year Model";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label10.Location = new System.Drawing.Point(12, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Category";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label11.Location = new System.Drawing.Point(291, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 26);
            this.label11.TabIndex = 21;
            this.label11.Text = "Color";
            // 
            // panelBasicInfoHeader
            // 
            this.panelBasicInfoHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBasicInfoHeader.BorderRadius = 20;
            this.panelBasicInfoHeader.Controls.Add(this.guna2CirclePictureBox1);
            this.panelBasicInfoHeader.Controls.Add(this.label2);
            this.panelBasicInfoHeader.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBasicInfoHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panelBasicInfoHeader.CustomizableEdges.BottomLeft = false;
            this.panelBasicInfoHeader.CustomizableEdges.BottomRight = false;
            this.panelBasicInfoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBasicInfoHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(132)))), ((int)(((byte)(191)))));
            this.panelBasicInfoHeader.Location = new System.Drawing.Point(0, 0);
            this.panelBasicInfoHeader.Name = "panelBasicInfoHeader";
            this.panelBasicInfoHeader.Size = new System.Drawing.Size(1153, 64);
            this.panelBasicInfoHeader.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.LightGray;
            this.guna2CirclePictureBox1.Image = global::VehicleManagementSystem.Properties.Resources.pen_icon;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(25, 15);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(34, 33);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Basic Vehicle Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(118, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Input vehicle specifications and VIN.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label8.Location = new System.Drawing.Point(114, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(398, 43);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bring in a New Vehicle";
            // 
            // frmAddNewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 683);
            this.Controls.Add(this.panelBg);
            this.DoubleBuffered = true;
            this.Name = "frmAddNewVehicle";
            this.Text = "AddNewVeh";
            this.panelBg.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLowerInputs.ResumeLayout(false);
            this.panelCarRental.ResumeLayout(false);
            this.panelCarRental.PerformLayout();
            this.panelRentalDetailsHeader.ResumeLayout(false);
            this.panelRentalDetailsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            this.panelPurchaseDetails.ResumeLayout(false);
            this.panelPurchaseDetails.PerformLayout();
            this.panelPurchaseDetailsHeader.ResumeLayout(false);
            this.panelPurchaseDetailsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.panelBasicInformation.ResumeLayout(false);
            this.tableBasicInfo.ResumeLayout(false);
            this.panelBasicInfoLeft.ResumeLayout(false);
            this.panelBasicInfoLeft.PerformLayout();
            this.panelBasicInfoRight.ResumeLayout(false);
            this.panelBasicInfoRight.PerformLayout();
            this.panelBasicInfoHeader.ResumeLayout(false);
            this.panelBasicInfoHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelBg;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private Guna.UI2.WinForms.Guna2Panel panelBasicInformation;
        private Guna.UI2.WinForms.Guna2Panel panelBasicInfoHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox inputVehicleIdentificationNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox inputPlateNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox inputCategory;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox inputColor;
        private Guna.UI2.WinForms.Guna2TextBox inputYearModel;
        private System.Windows.Forms.TableLayoutPanel tableBasicInfo;
        private System.Windows.Forms.Panel panelBasicInfoLeft;
        private System.Windows.Forms.Panel panelBasicInfoRight;
        private Guna.UI2.WinForms.Guna2Panel panelPurchaseDetails;
        private Guna.UI2.WinForms.Guna2Panel panelPurchaseDetailsHeader;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLowerInputs;
        private Guna.UI2.WinForms.Guna2Panel panelCarRental;
        private Guna.UI2.WinForms.Guna2Panel panelRentalDetailsHeader;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox inputPurchasePrice;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox InputOdometer;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox inputSeatCapacity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox inputDailyRate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2ComboBox inputTransmissionType;
        private Guna.UI2.WinForms.Guna2ComboBox inputFuelType;
        private Guna.UI2.WinForms.Guna2DateTimePicker inputPurchaseDate;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2TextBox inputModel;
        private Guna.UI2.WinForms.Guna2TextBox inputManufacturer;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button addImageBtn;
        private Guna.UI2.WinForms.Guna2TextBox vehicleImageFilename;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2CircleButton backBtn;
        private System.Windows.Forms.Panel panel2;
    }
}