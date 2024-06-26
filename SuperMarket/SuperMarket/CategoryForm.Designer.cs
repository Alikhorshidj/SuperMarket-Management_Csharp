﻿namespace SuperMarket
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CatDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CatDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CatEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CatDescTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatIDTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 48);
            this.button1.TabIndex = 27;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 48);
            this.button3.TabIndex = 29;
            this.button3.Text = "Selling";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 48);
            this.button2.TabIndex = 28;
            this.button2.Text = "Products";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Impact", 21.75F);
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(1088, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 48);
            this.button5.TabIndex = 26;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.guna2Panel1.Controls.Add(this.CatDGV);
            this.guna2Panel1.Controls.Add(this.CatDelete);
            this.guna2Panel1.Controls.Add(this.CatEdit);
            this.guna2Panel1.Controls.Add(this.bunifuThinButton21);
            this.guna2Panel1.Controls.Add(this.CatDescTb);
            this.guna2Panel1.Controls.Add(this.CatNameTb);
            this.guna2Panel1.Controls.Add(this.CatIDTb);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.button4);
            this.guna2Panel1.Location = new System.Drawing.Point(209, 63);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(919, 590);
            this.guna2Panel1.TabIndex = 25;
            // 
            // CatDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.CatDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.CatDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatDGV.BackgroundColor = System.Drawing.Color.White;
            this.CatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CatDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.CatDGV.EnableHeadersVisualStyles = false;
            this.CatDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.Location = new System.Drawing.Point(359, 101);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersVisible = false;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(536, 472);
            this.CatDGV.TabIndex = 18;
            this.CatDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CatDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CatDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CatDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.CatDGV.ThemeStyle.ReadOnly = false;
            this.CatDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CatDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatDGV.ThemeStyle.RowsStyle.Height = 22;
            this.CatDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // CatDelete
            // 
            this.CatDelete.ActiveBorderThickness = 1;
            this.CatDelete.ActiveCornerRadius = 20;
            this.CatDelete.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.CatDelete.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.CatDelete.ActiveLineColor = System.Drawing.Color.OrangeRed;
            this.CatDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.CatDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CatDelete.BackgroundImage")));
            this.CatDelete.ButtonText = "DELETE";
            this.CatDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatDelete.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.CatDelete.IdleBorderThickness = 1;
            this.CatDelete.IdleCornerRadius = 20;
            this.CatDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CatDelete.IdleForecolor = System.Drawing.Color.Transparent;
            this.CatDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CatDelete.Location = new System.Drawing.Point(235, 273);
            this.CatDelete.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.CatDelete.Name = "CatDelete";
            this.CatDelete.Size = new System.Drawing.Size(84, 49);
            this.CatDelete.TabIndex = 17;
            this.CatDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CatDelete.Click += new System.EventHandler(this.CatDelete_Click);
            // 
            // CatEdit
            // 
            this.CatEdit.ActiveBorderThickness = 1;
            this.CatEdit.ActiveCornerRadius = 20;
            this.CatEdit.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.CatEdit.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.CatEdit.ActiveLineColor = System.Drawing.Color.OrangeRed;
            this.CatEdit.BackColor = System.Drawing.Color.DarkOrange;
            this.CatEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CatEdit.BackgroundImage")));
            this.CatEdit.ButtonText = "EDIT";
            this.CatEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatEdit.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.CatEdit.IdleBorderThickness = 1;
            this.CatEdit.IdleCornerRadius = 20;
            this.CatEdit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CatEdit.IdleForecolor = System.Drawing.Color.Transparent;
            this.CatEdit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CatEdit.Location = new System.Drawing.Point(124, 273);
            this.CatEdit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.CatEdit.Name = "CatEdit";
            this.CatEdit.Size = new System.Drawing.Size(84, 49);
            this.CatEdit.TabIndex = 16;
            this.CatEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CatEdit.Click += new System.EventHandler(this.CatEdit_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.OrangeRed;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "ADD";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(28, 273);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(84, 49);
            this.bunifuThinButton21.TabIndex = 15;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // CatDescTb
            // 
            this.CatDescTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CatDescTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CatDescTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CatDescTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatDescTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CatDescTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CatDescTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatDescTb.HintText = "";
            this.CatDescTb.isPassword = false;
            this.CatDescTb.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.CatDescTb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CatDescTb.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.CatDescTb.LineThickness = 3;
            this.CatDescTb.Location = new System.Drawing.Point(169, 203);
            this.CatDescTb.Margin = new System.Windows.Forms.Padding(4);
            this.CatDescTb.MaxLength = 32767;
            this.CatDescTb.Name = "CatDescTb";
            this.CatDescTb.Size = new System.Drawing.Size(169, 33);
            this.CatDescTb.TabIndex = 12;
            this.CatDescTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatNameTb
            // 
            this.CatNameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CatNameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CatNameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CatNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CatNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CatNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatNameTb.HintText = "";
            this.CatNameTb.isPassword = false;
            this.CatNameTb.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.CatNameTb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CatNameTb.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.CatNameTb.LineThickness = 3;
            this.CatNameTb.Location = new System.Drawing.Point(169, 149);
            this.CatNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.CatNameTb.MaxLength = 32767;
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(169, 33);
            this.CatNameTb.TabIndex = 11;
            this.CatNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatIDTb
            // 
            this.CatIDTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CatIDTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CatIDTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CatIDTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatIDTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CatIDTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CatIDTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatIDTb.HintText = "";
            this.CatIDTb.isPassword = false;
            this.CatIDTb.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.CatIDTb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CatIDTb.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.CatIDTb.LineThickness = 3;
            this.CatIDTb.Location = new System.Drawing.Point(169, 97);
            this.CatIDTb.Margin = new System.Windows.Forms.Padding(4);
            this.CatIDTb.MaxLength = 32767;
            this.CatIDTb.Name = "CatIDTb";
            this.CatIDTb.Size = new System.Drawing.Size(169, 33);
            this.CatIDTb.TabIndex = 10;
            this.CatIDTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(15, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "DESCRIPTIOPN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID ";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(294, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(326, 48);
            this.button4.TabIndex = 2;
            this.button4.Text = "MANAGE CATEGORY";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1, 605);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 48);
            this.button6.TabIndex = 30;
            this.button6.Text = "LogOut";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 846);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView CatDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 CatDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 CatEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatDescTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatIDTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
    }
}