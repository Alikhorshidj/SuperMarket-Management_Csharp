namespace SuperMarket
{
    partial class EPProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EPProd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button6 = new System.Windows.Forms.Button();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SearchCb = new System.Windows.Forms.ComboBox();
            this.ProdDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProdDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ProdEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ProdAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.ProdPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProdQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProdName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ProdId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1, 605);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 48);
            this.button6.TabIndex = 37;
            this.button6.Text = "LogOut";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.OrangeRed;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Refresh";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuThinButton24.Location = new System.Drawing.Point(783, 49);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(84, 42);
            this.bunifuThinButton24.TabIndex = 20;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchCb
            // 
            this.SearchCb.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCb.FormattingEnabled = true;
            this.SearchCb.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.SearchCb.Location = new System.Drawing.Point(596, 57);
            this.SearchCb.Name = "SearchCb";
            this.SearchCb.Size = new System.Drawing.Size(178, 31);
            this.SearchCb.TabIndex = 19;
            this.SearchCb.Text = "Select Category";
            // 
            // ProdDGV
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.ProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.ProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.White;
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.ProdDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle33;
            this.ProdDGV.EnableHeadersVisualStyles = false;
            this.ProdDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.Location = new System.Drawing.Point(359, 101);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersVisible = false;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(536, 472);
            this.ProdDGV.TabIndex = 18;
            this.ProdDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProdDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProdDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProdDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProdDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.ProdDGV.ThemeStyle.ReadOnly = false;
            this.ProdDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProdDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ProdDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ProdDelete
            // 
            this.ProdDelete.ActiveBorderThickness = 1;
            this.ProdDelete.ActiveCornerRadius = 20;
            this.ProdDelete.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.ProdDelete.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.ProdDelete.ActiveLineColor = System.Drawing.Color.OrangeRed;
            this.ProdDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.ProdDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProdDelete.BackgroundImage")));
            this.ProdDelete.ButtonText = "DELETE";
            this.ProdDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProdDelete.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.ProdDelete.IdleBorderThickness = 1;
            this.ProdDelete.IdleCornerRadius = 20;
            this.ProdDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ProdDelete.IdleForecolor = System.Drawing.Color.Transparent;
            this.ProdDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ProdDelete.Location = new System.Drawing.Point(224, 373);
            this.ProdDelete.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ProdDelete.Name = "ProdDelete";
            this.ProdDelete.Size = new System.Drawing.Size(84, 49);
            this.ProdDelete.TabIndex = 17;
            this.ProdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProdDelete.Click += new System.EventHandler(this.ProdDelete_Click);
            // 
            // ProdEdit
            // 
            this.ProdEdit.ActiveBorderThickness = 1;
            this.ProdEdit.ActiveCornerRadius = 20;
            this.ProdEdit.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.ProdEdit.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.ProdEdit.ActiveLineColor = System.Drawing.Color.OrangeRed;
            this.ProdEdit.BackColor = System.Drawing.Color.DarkOrange;
            this.ProdEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProdEdit.BackgroundImage")));
            this.ProdEdit.ButtonText = "EDIT";
            this.ProdEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProdEdit.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.ProdEdit.IdleBorderThickness = 1;
            this.ProdEdit.IdleCornerRadius = 20;
            this.ProdEdit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ProdEdit.IdleForecolor = System.Drawing.Color.Transparent;
            this.ProdEdit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ProdEdit.Location = new System.Drawing.Point(113, 373);
            this.ProdEdit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ProdEdit.Name = "ProdEdit";
            this.ProdEdit.Size = new System.Drawing.Size(84, 49);
            this.ProdEdit.TabIndex = 16;
            this.ProdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProdEdit.Click += new System.EventHandler(this.ProdEdit_Click);
            // 
            // ProdAdd
            // 
            this.ProdAdd.ActiveBorderThickness = 1;
            this.ProdAdd.ActiveCornerRadius = 20;
            this.ProdAdd.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.ProdAdd.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.ProdAdd.ActiveLineColor = System.Drawing.Color.OrangeRed;
            this.ProdAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.ProdAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProdAdd.BackgroundImage")));
            this.ProdAdd.ButtonText = "ADD";
            this.ProdAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProdAdd.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.ProdAdd.IdleBorderThickness = 1;
            this.ProdAdd.IdleCornerRadius = 20;
            this.ProdAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ProdAdd.IdleForecolor = System.Drawing.Color.Transparent;
            this.ProdAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ProdAdd.Location = new System.Drawing.Point(17, 373);
            this.ProdAdd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ProdAdd.Name = "ProdAdd";
            this.ProdAdd.Size = new System.Drawing.Size(84, 49);
            this.ProdAdd.TabIndex = 15;
            this.ProdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProdAdd.Click += new System.EventHandler(this.ProdAdd_Click);
            // 
            // CatCb
            // 
            this.CatCb.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.CatCb.Location = new System.Drawing.Point(139, 319);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(169, 31);
            this.CatCb.TabIndex = 14;
            this.CatCb.Text = "Select Category";
            this.CatCb.SelectedIndexChanged += new System.EventHandler(this.CatCb_SelectedIndexChanged);
            // 
            // ProdPrice
            // 
            this.ProdPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProdPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProdPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProdPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProdPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProdPrice.HintForeColor = System.Drawing.Color.Empty;
            this.ProdPrice.HintText = "";
            this.ProdPrice.isPassword = false;
            this.ProdPrice.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.ProdPrice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ProdPrice.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.ProdPrice.LineThickness = 3;
            this.ProdPrice.Location = new System.Drawing.Point(139, 258);
            this.ProdPrice.Margin = new System.Windows.Forms.Padding(4);
            this.ProdPrice.MaxLength = 32767;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(169, 33);
            this.ProdPrice.TabIndex = 13;
            this.ProdPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProdQty
            // 
            this.ProdQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProdQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProdQty.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProdQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdQty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProdQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProdQty.HintForeColor = System.Drawing.Color.Empty;
            this.ProdQty.HintText = "";
            this.ProdQty.isPassword = false;
            this.ProdQty.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.ProdQty.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ProdQty.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.ProdQty.LineThickness = 3;
            this.ProdQty.Location = new System.Drawing.Point(139, 203);
            this.ProdQty.Margin = new System.Windows.Forms.Padding(4);
            this.ProdQty.MaxLength = 32767;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(169, 33);
            this.ProdQty.TabIndex = 12;
            this.ProdQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProdName
            // 
            this.ProdName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProdName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProdName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProdName.HintForeColor = System.Drawing.Color.Empty;
            this.ProdName.HintText = "";
            this.ProdName.isPassword = false;
            this.ProdName.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.ProdName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ProdName.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.ProdName.LineThickness = 3;
            this.ProdName.Location = new System.Drawing.Point(139, 149);
            this.ProdName.Margin = new System.Windows.Forms.Padding(4);
            this.ProdName.MaxLength = 32767;
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(169, 33);
            this.ProdName.TabIndex = 11;
            this.ProdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 48);
            this.button1.TabIndex = 33;
            this.button1.Text = "Product";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 48);
            this.button2.TabIndex = 34;
            this.button2.Text = "Categories";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProdId
            // 
            this.ProdId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProdId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProdId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProdId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ProdId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProdId.HintForeColor = System.Drawing.Color.Empty;
            this.ProdId.HintText = "";
            this.ProdId.isPassword = false;
            this.ProdId.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.ProdId.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ProdId.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.ProdId.LineThickness = 3;
            this.ProdId.Location = new System.Drawing.Point(139, 97);
            this.ProdId.Margin = new System.Windows.Forms.Padding(4);
            this.ProdId.MaxLength = 32767;
            this.ProdId.Name = "ProdId";
            this.ProdId.Size = new System.Drawing.Size(169, 33);
            this.ProdId.TabIndex = 10;
            this.ProdId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "CATEGORY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(15, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "PRICE";
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
            this.button4.Text = "MANAGE PRODUCT";
            this.button4.UseVisualStyleBackColor = true;
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
            this.button5.TabIndex = 36;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(15, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "QUANTITY";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.guna2Panel1.Controls.Add(this.bunifuThinButton24);
            this.guna2Panel1.Controls.Add(this.SearchCb);
            this.guna2Panel1.Controls.Add(this.ProdDGV);
            this.guna2Panel1.Controls.Add(this.ProdDelete);
            this.guna2Panel1.Controls.Add(this.ProdEdit);
            this.guna2Panel1.Controls.Add(this.ProdAdd);
            this.guna2Panel1.Controls.Add(this.CatCb);
            this.guna2Panel1.Controls.Add(this.ProdPrice);
            this.guna2Panel1.Controls.Add(this.ProdQty);
            this.guna2Panel1.Controls.Add(this.ProdName);
            this.guna2Panel1.Controls.Add(this.ProdId);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.button4);
            this.guna2Panel1.Location = new System.Drawing.Point(209, 63);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(919, 590);
            this.guna2Panel1.TabIndex = 32;
            // 
            // EPProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 846);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EPProd";
            this.Text = "EPProd";
            this.Load += new System.EventHandler(this.EPProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private System.Windows.Forms.ComboBox SearchCb;
        private Guna.UI2.WinForms.Guna2DataGridView ProdDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 ProdDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 ProdEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 ProdAdd;
        private System.Windows.Forms.ComboBox CatCb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdQty;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProdId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}