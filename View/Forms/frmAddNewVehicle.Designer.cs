using System;
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
            this.errorLabelSeatCapacity = new System.Windows.Forms.Label();
            this.errorLabelDailyRate = new System.Windows.Forms.Label();
            this.inputTransmissionType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.inputFuelType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.inputSeatCapacity = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelSeatCapacity = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.inputDailyRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelDailyRate = new System.Windows.Forms.Label();
            this.panelRentalDetailsHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPurchaseDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.errorLabelCurrentOdometer = new System.Windows.Forms.Label();
            this.errorLabelPurchasePrice = new System.Windows.Forms.Label();
            this.inputPurchaseDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.inputCurrentOdometer = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelCurrentOdometer = new System.Windows.Forms.Label();
            this.inputPurchasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPurchasePrice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelPurchaseDetailsHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelBasicInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.tableBasicInfo = new System.Windows.Forms.TableLayoutPanel();
            this.panelBasicInfoLeft = new System.Windows.Forms.Panel();
            this.closeImageBtn = new FontAwesome.Sharp.IconButton();
            this.addImageBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.vehiclePictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelBasicInfoRight = new System.Windows.Forms.Panel();
            this.errorLabelColor = new System.Windows.Forms.Label();
            this.errorLabelYearModel = new System.Windows.Forms.Label();
            this.errorLabelManufacturer = new System.Windows.Forms.Label();
            this.errorLabelModel = new System.Windows.Forms.Label();
            this.errorLabelPlateNum = new System.Windows.Forms.Label();
            this.errorLabelVehicleIdentificationNumber = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.inputVehicleIdentificationNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputPlateNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputManufacturer = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.inputCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelVehicleIdentificationNumber = new System.Windows.Forms.Label();
            this.inputColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPlateNum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelYearModel = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.inputYearModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelBasicInfoHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorLabelInputImage = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(51, 1119);
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
            this.saveBtn.TabIndex = 16;
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
            this.cancelBtn.TabIndex = 15;
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
            this.panel1.Location = new System.Drawing.Point(633, 1196);
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
            this.tableLowerInputs.Location = new System.Drawing.Point(51, 747);
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
            this.panelCarRental.BorderRadius = 15;
            this.panelCarRental.Controls.Add(this.errorLabelSeatCapacity);
            this.panelCarRental.Controls.Add(this.errorLabelDailyRate);
            this.panelCarRental.Controls.Add(this.inputTransmissionType);
            this.panelCarRental.Controls.Add(this.inputFuelType);
            this.panelCarRental.Controls.Add(this.label20);
            this.panelCarRental.Controls.Add(this.inputSeatCapacity);
            this.panelCarRental.Controls.Add(this.labelSeatCapacity);
            this.panelCarRental.Controls.Add(this.label18);
            this.panelCarRental.Controls.Add(this.inputDailyRate);
            this.panelCarRental.Controls.Add(this.labelDailyRate);
            this.panelCarRental.Controls.Add(this.panelRentalDetailsHeader);
            this.panelCarRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCarRental.FillColor = System.Drawing.Color.White;
            this.panelCarRental.Location = new System.Drawing.Point(596, 0);
            this.panelCarRental.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelCarRental.Name = "panelCarRental";
            this.panelCarRental.Size = new System.Drawing.Size(557, 341);
            this.panelCarRental.TabIndex = 14;
            // 
            // errorLabelSeatCapacity
            // 
            this.errorLabelSeatCapacity.AutoSize = true;
            this.errorLabelSeatCapacity.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelSeatCapacity.ForeColor = System.Drawing.Color.Red;
            this.errorLabelSeatCapacity.Location = new System.Drawing.Point(293, 181);
            this.errorLabelSeatCapacity.Name = "errorLabelSeatCapacity";
            this.errorLabelSeatCapacity.Size = new System.Drawing.Size(75, 19);
            this.errorLabelSeatCapacity.TabIndex = 34;
            this.errorLabelSeatCapacity.Text = "Required";
            this.errorLabelSeatCapacity.Visible = false;
            // 
            // errorLabelDailyRate
            // 
            this.errorLabelDailyRate.AutoSize = true;
            this.errorLabelDailyRate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelDailyRate.ForeColor = System.Drawing.Color.Red;
            this.errorLabelDailyRate.Location = new System.Drawing.Point(42, 179);
            this.errorLabelDailyRate.Name = "errorLabelDailyRate";
            this.errorLabelDailyRate.Size = new System.Drawing.Size(75, 19);
            this.errorLabelDailyRate.TabIndex = 33;
            this.errorLabelDailyRate.Text = "Required";
            this.errorLabelDailyRate.Visible = false;
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
            this.inputTransmissionType.TabIndex = 14;
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
            this.inputFuelType.TabIndex = 13;
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
            this.inputSeatCapacity.TabIndex = 12;
            // 
            // labelSeatCapacity
            // 
            this.labelSeatCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSeatCapacity.AutoSize = true;
            this.labelSeatCapacity.BackColor = System.Drawing.Color.Transparent;
            this.labelSeatCapacity.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.labelSeatCapacity.Location = new System.Drawing.Point(289, 90);
            this.labelSeatCapacity.Name = "labelSeatCapacity";
            this.labelSeatCapacity.Size = new System.Drawing.Size(183, 26);
            this.labelSeatCapacity.TabIndex = 25;
            this.labelSeatCapacity.Text = " Seating Capacity";
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
            this.inputDailyRate.TabIndex = 11;
            // 
            // labelDailyRate
            // 
            this.labelDailyRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDailyRate.AutoSize = true;
            this.labelDailyRate.BackColor = System.Drawing.Color.Transparent;
            this.labelDailyRate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDailyRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.labelDailyRate.Location = new System.Drawing.Point(35, 89);
            this.labelDailyRate.Name = "labelDailyRate";
            this.labelDailyRate.Size = new System.Drawing.Size(148, 26);
            this.labelDailyRate.TabIndex = 21;
            this.labelDailyRate.Text = "Daily Rate (₱)";
            // 
            // panelRentalDetailsHeader
            // 
            this.panelRentalDetailsHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelRentalDetailsHeader.BorderRadius = 15;
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
            this.panelPurchaseDetails.BorderRadius = 15;
            this.panelPurchaseDetails.Controls.Add(this.errorLabelCurrentOdometer);
            this.panelPurchaseDetails.Controls.Add(this.errorLabelPurchasePrice);
            this.panelPurchaseDetails.Controls.Add(this.inputPurchaseDate);
            this.panelPurchaseDetails.Controls.Add(this.inputCurrentOdometer);
            this.panelPurchaseDetails.Controls.Add(this.labelCurrentOdometer);
            this.panelPurchaseDetails.Controls.Add(this.inputPurchasePrice);
            this.panelPurchaseDetails.Controls.Add(this.labelPurchasePrice);
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
            // errorLabelCurrentOdometer
            // 
            this.errorLabelCurrentOdometer.AutoSize = true;
            this.errorLabelCurrentOdometer.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelCurrentOdometer.ForeColor = System.Drawing.Color.Red;
            this.errorLabelCurrentOdometer.Location = new System.Drawing.Point(290, 303);
            this.errorLabelCurrentOdometer.Name = "errorLabelCurrentOdometer";
            this.errorLabelCurrentOdometer.Size = new System.Drawing.Size(75, 19);
            this.errorLabelCurrentOdometer.TabIndex = 36;
            this.errorLabelCurrentOdometer.Text = "Required";
            this.errorLabelCurrentOdometer.Visible = false;
            // 
            // errorLabelPurchasePrice
            // 
            this.errorLabelPurchasePrice.AutoSize = true;
            this.errorLabelPurchasePrice.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelPurchasePrice.ForeColor = System.Drawing.Color.Red;
            this.errorLabelPurchasePrice.Location = new System.Drawing.Point(32, 303);
            this.errorLabelPurchasePrice.Name = "errorLabelPurchasePrice";
            this.errorLabelPurchasePrice.Size = new System.Drawing.Size(75, 19);
            this.errorLabelPurchasePrice.TabIndex = 35;
            this.errorLabelPurchasePrice.Text = "Required";
            this.errorLabelPurchasePrice.Visible = false;
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
            this.inputPurchaseDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.inputPurchaseDate.Location = new System.Drawing.Point(36, 121);
            this.inputPurchaseDate.MaxDate = new System.DateTime(2026, 1, 27, 0, 0, 0, 0);
            this.inputPurchaseDate.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.inputPurchaseDate.Name = "inputPurchaseDate";
            this.inputPurchaseDate.Size = new System.Drawing.Size(482, 55);
            this.inputPurchaseDate.TabIndex = 8;
            this.inputPurchaseDate.Value = new System.DateTime(2026, 1, 20, 18, 53, 53, 702);
            // 
            // inputCurrentOdometer
            // 
            this.inputCurrentOdometer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCurrentOdometer.BorderRadius = 10;
            this.inputCurrentOdometer.BorderThickness = 2;
            this.inputCurrentOdometer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputCurrentOdometer.DefaultText = "";
            this.inputCurrentOdometer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputCurrentOdometer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputCurrentOdometer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputCurrentOdometer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputCurrentOdometer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputCurrentOdometer.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCurrentOdometer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputCurrentOdometer.Location = new System.Drawing.Point(294, 243);
            this.inputCurrentOdometer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputCurrentOdometer.Name = "inputCurrentOdometer";
            this.inputCurrentOdometer.PlaceholderText = "";
            this.inputCurrentOdometer.SelectedText = "";
            this.inputCurrentOdometer.Size = new System.Drawing.Size(224, 55);
            this.inputCurrentOdometer.TabIndex = 10;
            // 
            // labelCurrentOdometer
            // 
            this.labelCurrentOdometer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCurrentOdometer.AutoSize = true;
            this.labelCurrentOdometer.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentOdometer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOdometer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.labelCurrentOdometer.Location = new System.Drawing.Point(286, 212);
            this.labelCurrentOdometer.Name = "labelCurrentOdometer";
            this.labelCurrentOdometer.Size = new System.Drawing.Size(241, 26);
            this.labelCurrentOdometer.TabIndex = 19;
            this.labelCurrentOdometer.Text = "Current Odometer (Km)";
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
            this.inputPurchasePrice.TabIndex = 9;
            // 
            // labelPurchasePrice
            // 
            this.labelPurchasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPurchasePrice.AutoSize = true;
            this.labelPurchasePrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPurchasePrice.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.labelPurchasePrice.Location = new System.Drawing.Point(31, 212);
            this.labelPurchasePrice.Name = "labelPurchasePrice";
            this.labelPurchasePrice.Size = new System.Drawing.Size(160, 26);
            this.labelPurchasePrice.TabIndex = 17;
            this.labelPurchasePrice.Text = "Purchase Price";
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
            this.panelPurchaseDetailsHeader.BorderRadius = 15;
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
            this.panelBasicInformation.BorderRadius = 15;
            this.panelBasicInformation.Controls.Add(this.tableBasicInfo);
            this.panelBasicInformation.Controls.Add(this.panelBasicInfoHeader);
            this.panelBasicInformation.FillColor = System.Drawing.Color.White;
            this.panelBasicInformation.Location = new System.Drawing.Point(51, 122);
            this.panelBasicInformation.MaximumSize = new System.Drawing.Size(1203, 648);
            this.panelBasicInformation.Name = "panelBasicInformation";
            this.panelBasicInformation.Size = new System.Drawing.Size(1153, 587);
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
            this.tableBasicInfo.Size = new System.Drawing.Size(1153, 523);
            this.tableBasicInfo.TabIndex = 1;
            // 
            // panelBasicInfoLeft
            // 
            this.panelBasicInfoLeft.Controls.Add(this.errorLabelInputImage);
            this.panelBasicInfoLeft.Controls.Add(this.closeImageBtn);
            this.panelBasicInfoLeft.Controls.Add(this.addImageBtn);
            this.panelBasicInfoLeft.Controls.Add(this.label7);
            this.panelBasicInfoLeft.Controls.Add(this.vehiclePictureBox);
            this.panelBasicInfoLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBasicInfoLeft.Location = new System.Drawing.Point(3, 3);
            this.panelBasicInfoLeft.Name = "panelBasicInfoLeft";
            this.panelBasicInfoLeft.Size = new System.Drawing.Size(570, 517);
            this.panelBasicInfoLeft.TabIndex = 0;
            // 
            // closeImageBtn
            // 
            this.closeImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeImageBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.closeImageBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closeImageBtn.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.closeImageBtn.FlatAppearance.BorderSize = 2;
            this.closeImageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.closeImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeImageBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.closeImageBtn.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.closeImageBtn.IconColor = System.Drawing.Color.RosyBrown;
            this.closeImageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeImageBtn.IconSize = 28;
            this.closeImageBtn.Location = new System.Drawing.Point(493, 60);
            this.closeImageBtn.Name = "closeImageBtn";
            this.closeImageBtn.Size = new System.Drawing.Size(42, 38);
            this.closeImageBtn.TabIndex = 102;
            this.closeImageBtn.UseVisualStyleBackColor = false;
            this.closeImageBtn.Visible = false;
            this.closeImageBtn.Click += new System.EventHandler(this.closeImageBtn_Click);
            // 
            // addImageBtn
            // 
            this.addImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addImageBtn.BorderColor = System.Drawing.Color.Red;
            this.addImageBtn.BorderRadius = 10;
            this.addImageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addImageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addImageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addImageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addImageBtn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.addImageBtn.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImageBtn.ForeColor = System.Drawing.Color.Gray;
            this.addImageBtn.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.addImageBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.addImageBtn.Location = new System.Drawing.Point(22, 51);
            this.addImageBtn.Name = "addImageBtn";
            this.addImageBtn.Size = new System.Drawing.Size(523, 416);
            this.addImageBtn.TabIndex = 0;
            this.addImageBtn.Text = "Click here to add vehicle image.";
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
            this.label7.Location = new System.Drawing.Point(17, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vehicles Image";
            // 
            // vehiclePictureBox
            // 
            this.vehiclePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehiclePictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vehiclePictureBox.BorderRadius = 10;
            this.vehiclePictureBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.vehiclePictureBox.ImageRotate = 0F;
            this.vehiclePictureBox.Location = new System.Drawing.Point(22, 51);
            this.vehiclePictureBox.Name = "vehiclePictureBox";
            this.vehiclePictureBox.Size = new System.Drawing.Size(523, 416);
            this.vehiclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vehiclePictureBox.TabIndex = 101;
            this.vehiclePictureBox.TabStop = false;
            // 
            // panelBasicInfoRight
            // 
            this.panelBasicInfoRight.Controls.Add(this.errorLabelColor);
            this.panelBasicInfoRight.Controls.Add(this.errorLabelYearModel);
            this.panelBasicInfoRight.Controls.Add(this.errorLabelManufacturer);
            this.panelBasicInfoRight.Controls.Add(this.errorLabelModel);
            this.panelBasicInfoRight.Controls.Add(this.errorLabelPlateNum);
            this.panelBasicInfoRight.Controls.Add(this.errorLabelVehicleIdentificationNumber);
            this.panelBasicInfoRight.Controls.Add(this.labelModel);
            this.panelBasicInfoRight.Controls.Add(this.inputVehicleIdentificationNumber);
            this.panelBasicInfoRight.Controls.Add(this.inputModel);
            this.panelBasicInfoRight.Controls.Add(this.inputPlateNum);
            this.panelBasicInfoRight.Controls.Add(this.inputManufacturer);
            this.panelBasicInfoRight.Controls.Add(this.labelColor);
            this.panelBasicInfoRight.Controls.Add(this.inputCategory);
            this.panelBasicInfoRight.Controls.Add(this.labelVehicleIdentificationNumber);
            this.panelBasicInfoRight.Controls.Add(this.inputColor);
            this.panelBasicInfoRight.Controls.Add(this.labelPlateNum);
            this.panelBasicInfoRight.Controls.Add(this.label10);
            this.panelBasicInfoRight.Controls.Add(this.labelYearModel);
            this.panelBasicInfoRight.Controls.Add(this.labelManufacturer);
            this.panelBasicInfoRight.Controls.Add(this.inputYearModel);
            this.panelBasicInfoRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBasicInfoRight.Location = new System.Drawing.Point(579, 3);
            this.panelBasicInfoRight.Name = "panelBasicInfoRight";
            this.panelBasicInfoRight.Size = new System.Drawing.Size(571, 517);
            this.panelBasicInfoRight.TabIndex = 1;
            // 
            // errorLabelColor
            // 
            this.errorLabelColor.AutoSize = true;
            this.errorLabelColor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelColor.ForeColor = System.Drawing.Color.Red;
            this.errorLabelColor.Location = new System.Drawing.Point(289, 482);
            this.errorLabelColor.Name = "errorLabelColor";
            this.errorLabelColor.Size = new System.Drawing.Size(75, 19);
            this.errorLabelColor.TabIndex = 32;
            this.errorLabelColor.Text = "Required";
            this.errorLabelColor.Visible = false;
            // 
            // errorLabelYearModel
            // 
            this.errorLabelYearModel.AutoSize = true;
            this.errorLabelYearModel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelYearModel.ForeColor = System.Drawing.Color.Red;
            this.errorLabelYearModel.Location = new System.Drawing.Point(15, 482);
            this.errorLabelYearModel.Name = "errorLabelYearModel";
            this.errorLabelYearModel.Size = new System.Drawing.Size(75, 19);
            this.errorLabelYearModel.TabIndex = 31;
            this.errorLabelYearModel.Text = "Required";
            this.errorLabelYearModel.Visible = false;
            // 
            // errorLabelManufacturer
            // 
            this.errorLabelManufacturer.AutoSize = true;
            this.errorLabelManufacturer.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelManufacturer.ForeColor = System.Drawing.Color.Red;
            this.errorLabelManufacturer.Location = new System.Drawing.Point(15, 359);
            this.errorLabelManufacturer.Name = "errorLabelManufacturer";
            this.errorLabelManufacturer.Size = new System.Drawing.Size(75, 19);
            this.errorLabelManufacturer.TabIndex = 30;
            this.errorLabelManufacturer.Text = "Required";
            this.errorLabelManufacturer.Visible = false;
            // 
            // errorLabelModel
            // 
            this.errorLabelModel.AutoSize = true;
            this.errorLabelModel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelModel.ForeColor = System.Drawing.Color.Red;
            this.errorLabelModel.Location = new System.Drawing.Point(289, 359);
            this.errorLabelModel.Name = "errorLabelModel";
            this.errorLabelModel.Size = new System.Drawing.Size(75, 19);
            this.errorLabelModel.TabIndex = 29;
            this.errorLabelModel.Text = "Required";
            this.errorLabelModel.Visible = false;
            // 
            // errorLabelPlateNum
            // 
            this.errorLabelPlateNum.AutoSize = true;
            this.errorLabelPlateNum.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelPlateNum.ForeColor = System.Drawing.Color.Red;
            this.errorLabelPlateNum.Location = new System.Drawing.Point(15, 234);
            this.errorLabelPlateNum.Name = "errorLabelPlateNum";
            this.errorLabelPlateNum.Size = new System.Drawing.Size(75, 19);
            this.errorLabelPlateNum.TabIndex = 28;
            this.errorLabelPlateNum.Text = "Required";
            this.errorLabelPlateNum.Visible = false;
            // 
            // errorLabelVehicleIdentificationNumber
            // 
            this.errorLabelVehicleIdentificationNumber.AutoSize = true;
            this.errorLabelVehicleIdentificationNumber.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelVehicleIdentificationNumber.ForeColor = System.Drawing.Color.Red;
            this.errorLabelVehicleIdentificationNumber.Location = new System.Drawing.Point(15, 111);
            this.errorLabelVehicleIdentificationNumber.Name = "errorLabelVehicleIdentificationNumber";
            this.errorLabelVehicleIdentificationNumber.Size = new System.Drawing.Size(75, 19);
            this.errorLabelVehicleIdentificationNumber.TabIndex = 27;
            this.errorLabelVehicleIdentificationNumber.Text = "Required";
            this.errorLabelVehicleIdentificationNumber.Visible = false;
            // 
            // labelModel
            // 
            this.labelModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.Color.Transparent;
            this.labelModel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.labelModel.Location = new System.Drawing.Point(285, 268);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(71, 26);
            this.labelModel.TabIndex = 26;
            this.labelModel.Text = "Model";
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
            this.inputVehicleIdentificationNumber.Location = new System.Drawing.Point(17, 51);
            this.inputVehicleIdentificationNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputVehicleIdentificationNumber.Name = "inputVehicleIdentificationNumber";
            this.inputVehicleIdentificationNumber.PlaceholderText = "";
            this.inputVehicleIdentificationNumber.SelectedText = "";
            this.inputVehicleIdentificationNumber.Size = new System.Drawing.Size(523, 55);
            this.inputVehicleIdentificationNumber.TabIndex = 1;
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
            this.inputModel.Location = new System.Drawing.Point(290, 299);
            this.inputModel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputModel.Name = "inputModel";
            this.inputModel.PlaceholderText = "";
            this.inputModel.SelectedText = "";
            this.inputModel.Size = new System.Drawing.Size(250, 55);
            this.inputModel.TabIndex = 5;
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
            this.inputPlateNum.Location = new System.Drawing.Point(17, 174);
            this.inputPlateNum.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputPlateNum.Name = "inputPlateNum";
            this.inputPlateNum.PlaceholderText = "";
            this.inputPlateNum.SelectedText = "";
            this.inputPlateNum.Size = new System.Drawing.Size(250, 55);
            this.inputPlateNum.TabIndex = 2;
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
            this.inputManufacturer.Location = new System.Drawing.Point(17, 299);
            this.inputManufacturer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputManufacturer.Name = "inputManufacturer";
            this.inputManufacturer.PlaceholderText = "";
            this.inputManufacturer.SelectedText = "";
            this.inputManufacturer.Size = new System.Drawing.Size(250, 55);
            this.inputManufacturer.TabIndex = 4;
            // 
            // labelColor
            // 
            this.labelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.Color.Transparent;
            this.labelColor.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.labelColor.Location = new System.Drawing.Point(285, 391);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(64, 26);
            this.labelColor.TabIndex = 21;
            this.labelColor.Text = "Color";
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
            this.inputCategory.Location = new System.Drawing.Point(290, 171);
            this.inputCategory.Margin = new System.Windows.Forms.Padding(10);
            this.inputCategory.Name = "inputCategory";
            this.inputCategory.Size = new System.Drawing.Size(244, 56);
            this.inputCategory.TabIndex = 3;
            // 
            // labelVehicleIdentificationNumber
            // 
            this.labelVehicleIdentificationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVehicleIdentificationNumber.AutoSize = true;
            this.labelVehicleIdentificationNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelVehicleIdentificationNumber.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleIdentificationNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.labelVehicleIdentificationNumber.Location = new System.Drawing.Point(12, 21);
            this.labelVehicleIdentificationNumber.Name = "labelVehicleIdentificationNumber";
            this.labelVehicleIdentificationNumber.Size = new System.Drawing.Size(352, 26);
            this.labelVehicleIdentificationNumber.TabIndex = 9;
            this.labelVehicleIdentificationNumber.Text = "Vehicle Identification Number (VIN)";
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
            this.inputColor.Location = new System.Drawing.Point(290, 422);
            this.inputColor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputColor.Name = "inputColor";
            this.inputColor.PlaceholderText = "";
            this.inputColor.SelectedText = "";
            this.inputColor.Size = new System.Drawing.Size(250, 55);
            this.inputColor.TabIndex = 7;
            // 
            // labelPlateNum
            // 
            this.labelPlateNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPlateNum.AutoSize = true;
            this.labelPlateNum.BackColor = System.Drawing.Color.Transparent;
            this.labelPlateNum.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlateNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.labelPlateNum.Location = new System.Drawing.Point(14, 143);
            this.labelPlateNum.Name = "labelPlateNum";
            this.labelPlateNum.Size = new System.Drawing.Size(227, 26);
            this.labelPlateNum.TabIndex = 11;
            this.labelPlateNum.Text = "License Plate Number";
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
            this.label10.Location = new System.Drawing.Point(285, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Category";
            // 
            // labelYearModel
            // 
            this.labelYearModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYearModel.AutoSize = true;
            this.labelYearModel.BackColor = System.Drawing.Color.Transparent;
            this.labelYearModel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.labelYearModel.Location = new System.Drawing.Point(12, 392);
            this.labelYearModel.Name = "labelYearModel";
            this.labelYearModel.Size = new System.Drawing.Size(122, 26);
            this.labelYearModel.TabIndex = 17;
            this.labelYearModel.Text = "Year Model";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.BackColor = System.Drawing.Color.Transparent;
            this.labelManufacturer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.labelManufacturer.Location = new System.Drawing.Point(12, 268);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(139, 26);
            this.labelManufacturer.TabIndex = 13;
            this.labelManufacturer.Text = "Manufacturer";
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
            this.inputYearModel.Location = new System.Drawing.Point(17, 422);
            this.inputYearModel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.inputYearModel.Name = "inputYearModel";
            this.inputYearModel.PlaceholderText = "";
            this.inputYearModel.SelectedText = "";
            this.inputYearModel.Size = new System.Drawing.Size(250, 55);
            this.inputYearModel.TabIndex = 6;
            // 
            // panelBasicInfoHeader
            // 
            this.panelBasicInfoHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBasicInfoHeader.BorderRadius = 15;
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
            // errorLabelInputImage
            // 
            this.errorLabelInputImage.AutoSize = true;
            this.errorLabelInputImage.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabelInputImage.ForeColor = System.Drawing.Color.Red;
            this.errorLabelInputImage.Location = new System.Drawing.Point(18, 482);
            this.errorLabelInputImage.Name = "errorLabelInputImage";
            this.errorLabelInputImage.Size = new System.Drawing.Size(75, 19);
            this.errorLabelInputImage.TabIndex = 33;
            this.errorLabelInputImage.Text = "Required";
            this.errorLabelInputImage.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).EndInit();
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
        private System.Windows.Forms.Label labelVehicleIdentificationNumber;
        private System.Windows.Forms.Label labelPlateNum;
        private Guna.UI2.WinForms.Guna2TextBox inputPlateNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelYearModel;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelColor;
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
        private System.Windows.Forms.Label labelPurchasePrice;
        private Guna.UI2.WinForms.Guna2TextBox inputCurrentOdometer;
        private System.Windows.Forms.Label labelCurrentOdometer;
        private Guna.UI2.WinForms.Guna2TextBox inputSeatCapacity;
        private System.Windows.Forms.Label labelSeatCapacity;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox inputDailyRate;
        private System.Windows.Forms.Label labelDailyRate;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2ComboBox inputTransmissionType;
        private Guna.UI2.WinForms.Guna2ComboBox inputFuelType;
        private Guna.UI2.WinForms.Guna2DateTimePicker inputPurchaseDate;
        private System.Windows.Forms.Label labelModel;
        private Guna.UI2.WinForms.Guna2TextBox inputModel;
        private Guna.UI2.WinForms.Guna2TextBox inputManufacturer;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button addImageBtn;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2CircleButton backBtn;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox vehiclePictureBox;
        private FontAwesome.Sharp.IconButton closeImageBtn;
        private System.Windows.Forms.Label errorLabelColor;
        private System.Windows.Forms.Label errorLabelYearModel;
        private System.Windows.Forms.Label errorLabelManufacturer;
        private System.Windows.Forms.Label errorLabelModel;
        private System.Windows.Forms.Label errorLabelPlateNum;
        private System.Windows.Forms.Label errorLabelVehicleIdentificationNumber;
        private System.Windows.Forms.Label errorLabelSeatCapacity;
        private System.Windows.Forms.Label errorLabelDailyRate;
        private System.Windows.Forms.Label errorLabelCurrentOdometer;
        private System.Windows.Forms.Label errorLabelPurchasePrice;
        private System.Windows.Forms.Label errorLabelInputImage;
    }
}