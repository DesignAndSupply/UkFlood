﻿namespace JodanQuote
{
    partial class FrmSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dT_customer1 = new JodanQuote.Datasource.DT_customer();
            this.dTSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_Settings = new JodanQuote.Datasource.DT_Settings();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.ada_setting = new JodanQuote.Datasource.DT_SettingsTableAdapters.ada_setting();
            this.tab_settings = new System.Windows.Forms.TabControl();
            this.tab_markup = new System.Windows.Forms.TabPage();
            this.grid_settings = new System.Windows.Forms.DataGridView();
            this.markup_hardware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markup_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labour_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.single_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.double_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.single_flood_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.double_flood_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_modified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_stock = new System.Windows.Forms.TabPage();
            this.pct_clear = new System.Windows.Forms.PictureBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.lbl_des = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.grid_stock = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec_rating_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_jodan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cviewhardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_hardware = new JodanQuote.Datasource.DT_hardware();
            this.dThardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_hardwareTableAdapter = new JodanQuote.Datasource.DT_hardwareTableAdapters.c_view_hardwareTableAdapter();
            this.btn_select_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dT_customer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSettingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            this.tab_settings.SuspendLayout();
            this.tab_markup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_settings)).BeginInit();
            this.tab_stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewhardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_hardware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dThardwareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dT_customer1
            // 
            this.dT_customer1.DataSetName = "DT_customer";
            this.dT_customer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTSettingBindingSource
            // 
            this.dTSettingBindingSource.DataMember = "DT_Setting";
            this.dTSettingBindingSource.DataSource = this.dT_Settings;
            // 
            // dT_Settings
            // 
            this.dT_Settings.DataSetName = "DT_Settings";
            this.dT_Settings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pct_logo
            // 
            this.pct_logo.Image = ((System.Drawing.Image)(resources.GetObject("pct_logo.Image")));
            this.pct_logo.Location = new System.Drawing.Point(22, 12);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(151, 86);
            this.pct_logo.TabIndex = 69;
            this.pct_logo.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_save.Image = global::JodanQuote.Properties.Resources.Save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(1013, 64);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 37);
            this.btn_save.TabIndex = 70;
            this.btn_save.Text = "     Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ada_setting
            // 
            this.ada_setting.ClearBeforeFill = true;
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.tab_markup);
            this.tab_settings.Controls.Add(this.tab_stock);
            this.tab_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_settings.Location = new System.Drawing.Point(22, 107);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.SelectedIndex = 0;
            this.tab_settings.Size = new System.Drawing.Size(1101, 461);
            this.tab_settings.TabIndex = 71;
            // 
            // tab_markup
            // 
            this.tab_markup.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tab_markup.Controls.Add(this.grid_settings);
            this.tab_markup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_markup.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tab_markup.Location = new System.Drawing.Point(4, 22);
            this.tab_markup.Name = "tab_markup";
            this.tab_markup.Padding = new System.Windows.Forms.Padding(3);
            this.tab_markup.Size = new System.Drawing.Size(1093, 435);
            this.tab_markup.TabIndex = 0;
            this.tab_markup.Text = "Markup";
            // 
            // grid_settings
            // 
            this.grid_settings.AllowUserToAddRows = false;
            this.grid_settings.AllowUserToDeleteRows = false;
            this.grid_settings.AllowUserToResizeColumns = false;
            this.grid_settings.AllowUserToResizeRows = false;
            this.grid_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_settings.AutoGenerateColumns = false;
            this.grid_settings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_settings.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.grid_settings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_settings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.grid_settings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_settings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.markup_hardware,
            this.markup_material,
            this.labour_rate,
            this.single_extra,
            this.double_extra,
            this.single_flood_extra,
            this.double_flood_extra,
            this.date_modified});
            this.grid_settings.DataSource = this.dTSettingBindingSource;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_settings.DefaultCellStyle = dataGridViewCellStyle27;
            this.grid_settings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_settings.GridColor = System.Drawing.Color.AliceBlue;
            this.grid_settings.Location = new System.Drawing.Point(18, 49);
            this.grid_settings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_settings.MaximumSize = new System.Drawing.Size(7055, 328);
            this.grid_settings.Name = "grid_settings";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_settings.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.grid_settings.RowHeadersVisible = false;
            this.grid_settings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_settings.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_settings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_settings.Size = new System.Drawing.Size(1049, 119);
            this.grid_settings.TabIndex = 72;
            // 
            // markup_hardware
            // 
            this.markup_hardware.DataPropertyName = "markup_hardware";
            this.markup_hardware.HeaderText = "Markup Hardware";
            this.markup_hardware.Name = "markup_hardware";
            // 
            // markup_material
            // 
            this.markup_material.DataPropertyName = "markup_material";
            this.markup_material.HeaderText = "Markup Material";
            this.markup_material.Name = "markup_material";
            // 
            // labour_rate
            // 
            this.labour_rate.DataPropertyName = "labour_rate";
            this.labour_rate.HeaderText = "Labour Rate";
            this.labour_rate.Name = "labour_rate";
            // 
            // single_extra
            // 
            this.single_extra.DataPropertyName = "single_extra";
            this.single_extra.HeaderText = "Single Extra";
            this.single_extra.Name = "single_extra";
            // 
            // double_extra
            // 
            this.double_extra.DataPropertyName = "double_extra";
            this.double_extra.HeaderText = "Double Extra";
            this.double_extra.Name = "double_extra";
            // 
            // single_flood_extra
            // 
            this.single_flood_extra.DataPropertyName = "single_flood_extra";
            this.single_flood_extra.HeaderText = "Single Flood Extra";
            this.single_flood_extra.Name = "single_flood_extra";
            // 
            // double_flood_extra
            // 
            this.double_flood_extra.DataPropertyName = "double_flood_extra";
            this.double_flood_extra.HeaderText = "Double Flood Extra";
            this.double_flood_extra.Name = "double_flood_extra";
            // 
            // date_modified
            // 
            this.date_modified.DataPropertyName = "date_modified";
            this.date_modified.HeaderText = "Date Modified";
            this.date_modified.Name = "date_modified";
            // 
            // tab_stock
            // 
            this.tab_stock.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tab_stock.Controls.Add(this.btn_select_all);
            this.tab_stock.Controls.Add(this.pct_clear);
            this.tab_stock.Controls.Add(this.lbl_description);
            this.tab_stock.Controls.Add(this.cmb_type);
            this.tab_stock.Controls.Add(this.lbl_des);
            this.tab_stock.Controls.Add(this.txt_description);
            this.tab_stock.Controls.Add(this.btn_filter);
            this.tab_stock.Controls.Add(this.grid_stock);
            this.tab_stock.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tab_stock.Location = new System.Drawing.Point(4, 22);
            this.tab_stock.Name = "tab_stock";
            this.tab_stock.Padding = new System.Windows.Forms.Padding(3);
            this.tab_stock.Size = new System.Drawing.Size(1093, 435);
            this.tab_stock.TabIndex = 1;
            this.tab_stock.Text = "Stock";
            // 
            // pct_clear
            // 
            this.pct_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_clear.Image = global::JodanQuote.Properties.Resources.clear;
            this.pct_clear.Location = new System.Drawing.Point(522, 32);
            this.pct_clear.Name = "pct_clear";
            this.pct_clear.Size = new System.Drawing.Size(26, 20);
            this.pct_clear.TabIndex = 79;
            this.pct_clear.TabStop = false;
            this.pct_clear.Click += new System.EventHandler(this.pct_clear_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_description.Location = new System.Drawing.Point(330, 11);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(41, 15);
            this.lbl_description.TabIndex = 78;
            this.lbl_description.Text = "Type:";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_type.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(333, 32);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(163, 21);
            this.cmb_type.TabIndex = 77;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // lbl_des
            // 
            this.lbl_des.AutoSize = true;
            this.lbl_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_des.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_des.Location = new System.Drawing.Point(177, 11);
            this.lbl_des.Name = "lbl_des";
            this.lbl_des.Size = new System.Drawing.Size(84, 15);
            this.lbl_des.TabIndex = 76;
            this.lbl_des.Text = "Description:";
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_description.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_description.Location = new System.Drawing.Point(177, 32);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(110, 20);
            this.txt_description.TabIndex = 75;
            this.txt_description.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_description_KeyDown);
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_filter.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_filter.Image = global::JodanQuote.Properties.Resources.Filter_Blue;
            this.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filter.Location = new System.Drawing.Point(984, 122);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(98, 37);
            this.btn_filter.TabIndex = 74;
            this.btn_filter.Text = "           View                  Jodan        ";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // grid_stock
            // 
            this.grid_stock.AllowUserToAddRows = false;
            this.grid_stock.AllowUserToDeleteRows = false;
            this.grid_stock.AllowUserToResizeColumns = false;
            this.grid_stock.AllowUserToResizeRows = false;
            this.grid_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_stock.AutoGenerateColumns = false;
            this.grid_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_stock.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.grid_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grid_stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.grid_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.Cost,
            this.sec_rating_level,
            this.id,
            this.chk_jodan});
            this.grid_stock.DataSource = this.cviewhardwareBindingSource;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_stock.DefaultCellStyle = dataGridViewCellStyle24;
            this.grid_stock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.grid_stock.GridColor = System.Drawing.Color.AliceBlue;
            this.grid_stock.Location = new System.Drawing.Point(176, 79);
            this.grid_stock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_stock.MaximumSize = new System.Drawing.Size(7055, 328);
            this.grid_stock.Name = "grid_stock";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.grid_stock.RowHeadersVisible = false;
            this.grid_stock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_stock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_stock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_stock.Size = new System.Drawing.Size(791, 328);
            this.grid_stock.TabIndex = 73;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 120F;
            this.descriptionDataGridViewTextBoxColumn.Frozen = true;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 297;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cost.DataPropertyName = "Cost";
            this.Cost.FillWeight = 60F;
            this.Cost.Frozen = true;
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.Width = 148;
            // 
            // sec_rating_level
            // 
            this.sec_rating_level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sec_rating_level.DataPropertyName = "sec_rating_level";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.NullValue = "0";
            this.sec_rating_level.DefaultCellStyle = dataGridViewCellStyle23;
            this.sec_rating_level.FillWeight = 50F;
            this.sec_rating_level.Frozen = true;
            this.sec_rating_level.HeaderText = "Security Rating";
            this.sec_rating_level.Name = "sec_rating_level";
            this.sec_rating_level.Width = 150;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // chk_jodan
            // 
            this.chk_jodan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chk_jodan.DataPropertyName = "jodan_stock";
            this.chk_jodan.FillWeight = 40F;
            this.chk_jodan.HeaderText = "Jodan Stock";
            this.chk_jodan.Name = "chk_jodan";
            this.chk_jodan.TrueValue = "1";
            // 
            // cviewhardwareBindingSource
            // 
            this.cviewhardwareBindingSource.DataMember = "c_view_hardware";
            this.cviewhardwareBindingSource.DataSource = this.dT_hardware;
            // 
            // dT_hardware
            // 
            this.dT_hardware.DataSetName = "DT_hardware";
            this.dT_hardware.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c_view_hardwareTableAdapter
            // 
            this.c_view_hardwareTableAdapter.ClearBeforeFill = true;
            // 
            // btn_select_all
            // 
            this.btn_select_all.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_select_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_select_all.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btn_select_all.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_select_all.Image = global::JodanQuote.Properties.Resources.tick2;
            this.btn_select_all.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_select_all.Location = new System.Drawing.Point(984, 79);
            this.btn_select_all.Name = "btn_select_all";
            this.btn_select_all.Size = new System.Drawing.Size(98, 37);
            this.btn_select_all.TabIndex = 80;
            this.btn_select_all.Text = "   Select All";
            this.btn_select_all.UseVisualStyleBackColor = false;
            this.btn_select_all.Click += new System.EventHandler(this.btn_select_all_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1135, 580);
            this.Controls.Add(this.tab_settings);
            this.Controls.Add(this.pct_logo);
            this.Controls.Add(this.btn_save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dT_customer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSettingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            this.tab_settings.ResumeLayout(false);
            this.tab_markup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_settings)).EndInit();
            this.tab_stock.ResumeLayout(false);
            this.tab_stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewhardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT_hardware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dThardwareBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Datasource.DT_customer dT_customer1;
        private Datasource.DT_Settings dT_Settings;
        private System.Windows.Forms.BindingSource dTSettingBindingSource;
        private Datasource.DT_SettingsTableAdapters.ada_setting ada_setting;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedmodifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TabControl tab_settings;
        private System.Windows.Forms.TabPage tab_markup;
        private System.Windows.Forms.DataGridView grid_settings;
        private System.Windows.Forms.TabPage tab_stock;
        private System.Windows.Forms.DataGridView grid_stock;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.BindingSource cviewhardwareBindingSource;
        private Datasource.DT_hardware dT_hardware;
        private System.Windows.Forms.BindingSource dThardwareBindingSource;
        private Datasource.DT_hardwareTableAdapters.c_view_hardwareTableAdapter c_view_hardwareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn markup_hardware;
        private System.Windows.Forms.DataGridViewTextBoxColumn markup_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn labour_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn single_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn double_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn single_flood_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn double_flood_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_modified;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label lbl_des;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.PictureBox pct_clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec_rating_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_jodan;
        private System.Windows.Forms.Button btn_select_all;
    }
}