﻿using System;

namespace Assignment_2._0
{
    partial class GUI
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCreateEstate = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblDynamicTxt1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxLegalForm = new System.Windows.Forms.ComboBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.lblLegalForms = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tabSearchDelete = new System.Windows.Forms.TabPage();
            this.lblShowAll = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchLblCity = new System.Windows.Forms.Label();
            this.lblChangeEstate = new System.Windows.Forms.Label();
            this.btnChangeEstate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDeleteEstates = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblGenerate = new System.Windows.Forms.Label();
            this.lblRemoveAll = new System.Windows.Forms.Label();
            this.btnGenerateEstates = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAltXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabSearchDelete.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabSearchDelete);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 26);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(10, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(733, 517);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(725, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create / Change";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnCreateEstate);
            this.panel7.Location = new System.Drawing.Point(355, 254);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(232, 82);
            this.panel7.TabIndex = 3;
            // 
            // btnCreateEstate
            // 
            this.btnCreateEstate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateEstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEstate.Location = new System.Drawing.Point(48, 16);
            this.btnCreateEstate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateEstate.Name = "btnCreateEstate";
            this.btnCreateEstate.Size = new System.Drawing.Size(135, 41);
            this.btnCreateEstate.TabIndex = 0;
            this.btnCreateEstate.Text = "ADD ESTATE";
            this.btnCreateEstate.UseVisualStyleBackColor = false;
            this.btnCreateEstate.Click += new System.EventHandler(this.btnCreateEstate_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnSaveChanges);
            this.panel6.Location = new System.Drawing.Point(355, 353);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(232, 82);
            this.panel6.TabIndex = 2;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(48, 22);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(135, 41);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "SAVE CHANGES";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBoxImage);
            this.panel5.Controls.Add(this.btnChooseImage);
            this.panel5.Location = new System.Drawing.Point(355, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 245);
            this.panel5.TabIndex = 1;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(30, 15);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(167, 152);
            this.pictureBoxImage.TabIndex = 1;
            this.pictureBoxImage.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.Location = new System.Drawing.Point(48, 175);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(135, 58);
            this.btnChooseImage.TabIndex = 0;
            this.btnChooseImage.Text = "CHOOSE IMAGE (.jpg)";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(34, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 431);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.comboBoxType);
            this.panel4.Controls.Add(this.comboBoxCategory);
            this.panel4.Controls.Add(this.lblDynamicTxt1);
            this.panel4.Controls.Add(this.lblType);
            this.panel4.Controls.Add(this.lblCategory);
            this.panel4.Location = new System.Drawing.Point(1, 284);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 146);
            this.panel4.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(118, 84);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 23);
            this.textBox6.TabIndex = 6;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(118, 60);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 25);
            this.comboBoxType.TabIndex = 5;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(118, 36);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 25);
            this.comboBoxCategory.TabIndex = 4;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblDynamicTxt1
            // 
            this.lblDynamicTxt1.AutoSize = true;
            this.lblDynamicTxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDynamicTxt1.Location = new System.Drawing.Point(20, 86);
            this.lblDynamicTxt1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDynamicTxt1.Name = "lblDynamicTxt1";
            this.lblDynamicTxt1.Size = new System.Drawing.Size(43, 17);
            this.lblDynamicTxt1.TabIndex = 2;
            this.lblDynamicTxt1.Text = "-------";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(20, 63);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(20, 39);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBoxCountry);
            this.panel3.Controls.Add(this.textBoxCity);
            this.panel3.Controls.Add(this.textBoxZipCode);
            this.panel3.Controls.Add(this.textBoxStreet);
            this.panel3.Controls.Add(this.lblStreet);
            this.panel3.Controls.Add(this.lblZipCode);
            this.panel3.Controls.Add(this.lblCity);
            this.panel3.Controls.Add(this.lblCountry);
            this.panel3.Controls.Add(this.lblAddress);
            this.panel3.Location = new System.Drawing.Point(1, 119);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 156);
            this.panel3.TabIndex = 1;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(122, 36);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 25);
            this.comboBoxCountry.TabIndex = 8;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(122, 62);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(121, 23);
            this.textBoxCity.TabIndex = 7;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(122, 84);
            this.textBoxZipCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(121, 23);
            this.textBoxZipCode.TabIndex = 6;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(122, 107);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(121, 23);
            this.textBoxStreet.TabIndex = 5;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(23, 109);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(46, 17);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Street";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(23, 86);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(64, 17);
            this.lblZipCode.TabIndex = 3;
            this.lblZipCode.Text = "Zip-code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(23, 63);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(23, 39);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Country";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(100, 7);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 17);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBoxLegalForm);
            this.panel2.Controls.Add(this.textId);
            this.panel2.Controls.Add(this.lblLegalForms);
            this.panel2.Controls.Add(this.lblId);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 106);
            this.panel2.TabIndex = 0;
            // 
            // comboBoxLegalForm
            // 
            this.comboBoxLegalForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLegalForm.FormattingEnabled = true;
            this.comboBoxLegalForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxLegalForm.Location = new System.Drawing.Point(117, 59);
            this.comboBoxLegalForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLegalForm.Name = "comboBoxLegalForm";
            this.comboBoxLegalForm.Size = new System.Drawing.Size(121, 25);
            this.comboBoxLegalForm.TabIndex = 3;
            this.comboBoxLegalForm.SelectedIndexChanged += new System.EventHandler(this.comboBoxLegalForm_SelectedIndexChanged);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(117, 31);
            this.textId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(121, 23);
            this.textId.TabIndex = 2;
            // 
            // lblLegalForms
            // 
            this.lblLegalForms.AutoSize = true;
            this.lblLegalForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegalForms.Location = new System.Drawing.Point(14, 63);
            this.lblLegalForms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLegalForms.Name = "lblLegalForms";
            this.lblLegalForms.Size = new System.Drawing.Size(75, 17);
            this.lblLegalForms.TabIndex = 1;
            this.lblLegalForms.Text = "Legal form";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(14, 32);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id (4 numbers)";
            // 
            // tabSearchDelete
            // 
            this.tabSearchDelete.Controls.Add(this.lblShowAll);
            this.tabSearchDelete.Controls.Add(this.btnShowAll);
            this.tabSearchDelete.Controls.Add(this.textBox1);
            this.tabSearchDelete.Controls.Add(this.btnSearch);
            this.tabSearchDelete.Controls.Add(this.searchLblCity);
            this.tabSearchDelete.Controls.Add(this.lblChangeEstate);
            this.tabSearchDelete.Controls.Add(this.btnChangeEstate);
            this.tabSearchDelete.Controls.Add(this.btnDelete);
            this.tabSearchDelete.Controls.Add(this.lblDeleteEstates);
            this.tabSearchDelete.Controls.Add(this.listBox1);
            this.tabSearchDelete.Controls.Add(this.lblGenerate);
            this.tabSearchDelete.Controls.Add(this.lblRemoveAll);
            this.tabSearchDelete.Controls.Add(this.btnGenerateEstates);
            this.tabSearchDelete.Controls.Add(this.btnDeleteAll);
            this.tabSearchDelete.Controls.Add(this.label1);
            this.tabSearchDelete.Location = new System.Drawing.Point(4, 33);
            this.tabSearchDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSearchDelete.Name = "tabSearchDelete";
            this.tabSearchDelete.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSearchDelete.Size = new System.Drawing.Size(725, 480);
            this.tabSearchDelete.TabIndex = 1;
            this.tabSearchDelete.Text = "Delete / Search";
            this.tabSearchDelete.UseVisualStyleBackColor = true;
            // 
            // lblShowAll
            // 
            this.lblShowAll.AutoSize = true;
            this.lblShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAll.Location = new System.Drawing.Point(373, 299);
            this.lblShowAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowAll.Name = "lblShowAll";
            this.lblShowAll.Size = new System.Drawing.Size(122, 13);
            this.lblShowAll.TabIndex = 17;
            this.lblShowAll.Text = "Show all the estates";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowAll.Location = new System.Drawing.Point(358, 323);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(140, 33);
            this.btnShowAll.TabIndex = 16;
            this.btnShowAll.Text = "SHOW ALL";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 411);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 23);
            this.textBox1.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(16, 438);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 37);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchLblCity
            // 
            this.searchLblCity.AutoSize = true;
            this.searchLblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLblCity.Location = new System.Drawing.Point(13, 386);
            this.searchLblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLblCity.Name = "searchLblCity";
            this.searchLblCity.Size = new System.Drawing.Size(166, 13);
            this.searchLblCity.TabIndex = 13;
            this.searchLblCity.Text = "Search for estates with city:";
            // 
            // lblChangeEstate
            // 
            this.lblChangeEstate.AutoSize = true;
            this.lblChangeEstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeEstate.Location = new System.Drawing.Point(361, 417);
            this.lblChangeEstate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeEstate.Name = "lblChangeEstate";
            this.lblChangeEstate.Size = new System.Drawing.Size(155, 13);
            this.lblChangeEstate.TabIndex = 12;
            this.lblChangeEstate.Text = "Change highlighted estate";
            // 
            // btnChangeEstate
            // 
            this.btnChangeEstate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangeEstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEstate.Location = new System.Drawing.Point(363, 440);
            this.btnChangeEstate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeEstate.Name = "btnChangeEstate";
            this.btnChangeEstate.Size = new System.Drawing.Size(135, 37);
            this.btnChangeEstate.TabIndex = 11;
            this.btnChangeEstate.Text = "MODIFY ESTATE";
            this.btnChangeEstate.UseVisualStyleBackColor = false;
            this.btnChangeEstate.Click += new System.EventHandler(this.btnChangeEstate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(176, 440);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDeleteEstates
            // 
            this.lblDeleteEstates.AutoSize = true;
            this.lblDeleteEstates.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteEstates.Location = new System.Drawing.Point(174, 417);
            this.lblDeleteEstates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteEstates.Name = "lblDeleteEstates";
            this.lblDeleteEstates.Size = new System.Drawing.Size(149, 13);
            this.lblDeleteEstates.TabIndex = 0;
            this.lblDeleteEstates.Text = "Delete highlighted estate";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(16, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(701, 229);
            this.listBox1.TabIndex = 10;
            // 
            // lblGenerate
            // 
            this.lblGenerate.AutoSize = true;
            this.lblGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerate.Location = new System.Drawing.Point(520, 403);
            this.lblGenerate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenerate.Name = "lblGenerate";
            this.lblGenerate.Size = new System.Drawing.Size(187, 26);
            this.lblGenerate.TabIndex = 9;
            this.lblGenerate.Text = "Generate estates \r\n(Will remove previously estates)";
            this.lblGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemoveAll
            // 
            this.lblRemoveAll.AutoSize = true;
            this.lblRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveAll.Location = new System.Drawing.Point(199, 299);
            this.lblRemoveAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoveAll.Name = "lblRemoveAll";
            this.lblRemoveAll.Size = new System.Drawing.Size(115, 13);
            this.lblRemoveAll.TabIndex = 8;
            this.lblRemoveAll.Text = "Remove all estates";
            // 
            // btnGenerateEstates
            // 
            this.btnGenerateEstates.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerateEstates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateEstates.Location = new System.Drawing.Point(550, 440);
            this.btnGenerateEstates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateEstates.Name = "btnGenerateEstates";
            this.btnGenerateEstates.Size = new System.Drawing.Size(135, 37);
            this.btnGenerateEstates.TabIndex = 6;
            this.btnGenerateEstates.Text = "GENERATE";
            this.btnGenerateEstates.UseVisualStyleBackColor = false;
            this.btnGenerateEstates.Click += new System.EventHandler(this.btnGenerateEstates_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Location = new System.Drawing.Point(189, 323);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(135, 37);
            this.btnDeleteAll.TabIndex = 5;
            this.btnDeleteAll.Text = "REMOVE ALL";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID ----- Legal form ----- Category ----- Type ----- Country ----- City ----- Stre" +
    "et ----- Zip ----- UniqueAttribute";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCtrlNToolStripMenuItem,
            this.openCtrlOToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.exitAltXToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newCtrlNToolStripMenuItem
            // 
            this.newCtrlNToolStripMenuItem.Name = "newCtrlNToolStripMenuItem";
            this.newCtrlNToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newCtrlNToolStripMenuItem.Text = "New        Ctrl+N";
            this.newCtrlNToolStripMenuItem.Click += new System.EventHandler(this.newCtrlNToolStripMenuItem_Click);
            // 
            // openCtrlOToolStripMenuItem
            // 
            this.openCtrlOToolStripMenuItem.Name = "openCtrlOToolStripMenuItem";
            this.openCtrlOToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openCtrlOToolStripMenuItem.Text = "Open...    Ctrl+O";
            this.openCtrlOToolStripMenuItem.Click += new System.EventHandler(this.openCtrlOToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveToolStripMenuItem.Text = "Save         Ctrl+S";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveAsToolStripMenuItem.Text = "Save as..  ";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromXMLFileToolStripMenuItem,
            this.exportToXMLFileToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // importFromXMLFileToolStripMenuItem
            // 
            this.importFromXMLFileToolStripMenuItem.Enabled = false;
            this.importFromXMLFileToolStripMenuItem.Name = "importFromXMLFileToolStripMenuItem";
            this.importFromXMLFileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.importFromXMLFileToolStripMenuItem.Text = "Import from XML File";
            // 
            // exportToXMLFileToolStripMenuItem
            // 
            this.exportToXMLFileToolStripMenuItem.Name = "exportToXMLFileToolStripMenuItem";
            this.exportToXMLFileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exportToXMLFileToolStripMenuItem.Text = "Export to XML File";
            this.exportToXMLFileToolStripMenuItem.Click += new System.EventHandler(this.exportToXMLFileToolStripMenuItem_Click);
            // 
            // exitAltXToolStripMenuItem
            // 
            this.exitAltXToolStripMenuItem.Name = "exitAltXToolStripMenuItem";
            this.exitAltXToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitAltXToolStripMenuItem.Text = "Exit          Alt+X";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 540);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GUI";
            this.Text = "AganEstates";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabSearchDelete.ResumeLayout(false);
            this.tabSearchDelete.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        // GENERERAD METOD SOM SKA TAS BORT?
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabSearchDelete;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCreateEstate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxLegalForm;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label lblLegalForms;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label lblDynamicTxt1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDeleteEstates;
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenerate;
        private System.Windows.Forms.Label lblRemoveAll;
        private System.Windows.Forms.Button btnGenerateEstates;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromXMLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToXMLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAltXToolStripMenuItem;
        private System.Windows.Forms.Button btnChangeEstate;
        private System.Windows.Forms.Label lblChangeEstate;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label searchLblCity;
        private System.Windows.Forms.Label lblShowAll;
    }
}

