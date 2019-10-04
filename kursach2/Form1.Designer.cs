using System;
using System.Windows.Forms;

namespace kursach2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle184 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle185 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle186 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle187 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle188 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle189 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle190 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle191 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle192 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle181 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle182 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle183 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle193 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle194 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle195 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cyvarevDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyvarevDataSet = new kursach2.cyvarevDataSet();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.client_tab = new MetroFramework.Controls.MetroTabPage();
            this.datepick = new MetroFramework.Controls.MetroDateTime();
            this.id_client = new MetroFramework.Controls.MetroLabel();
            this.id_client_tb = new MetroFramework.Controls.MetroTextBox();
            this.add_client_bt = new MetroFramework.Controls.MetroButton();
            this.delete_client_bt = new MetroFramework.Controls.MetroButton();
            this.change_client_bt = new MetroFramework.Controls.MetroButton();
            this.polis_client_tb = new MetroFramework.Controls.MetroTextBox();
            this.client_birth = new MetroFramework.Controls.MetroLabel();
            this.client_polis = new MetroFramework.Controls.MetroLabel();
            this.client_name = new MetroFramework.Controls.MetroLabel();
            this.name_client_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.doc_tab = new MetroFramework.Controls.MetroTabPage();
            this.id_doc_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.phone_doc_tb = new MetroFramework.Controls.MetroTextBox();
            this.spec_doc_tb = new MetroFramework.Controls.MetroTextBox();
            this.name_doc_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.ord_tab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.id_order_tb = new MetroFramework.Controls.MetroTextBox();
            this.datepick_order = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.ord_branch_cb = new MetroFramework.Controls.MetroComboBox();
            this.ord_client_cb = new MetroFramework.Controls.MetroComboBox();
            this.ord_service_cb = new MetroFramework.Controls.MetroComboBox();
            this.metroGrid3 = new MetroFramework.Controls.MetroGrid();
            this.service_tab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.price_service_tb = new MetroFramework.Controls.MetroTextBox();
            this.name_service_tb = new MetroFramework.Controls.MetroTextBox();
            this.id_service_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid4 = new MetroFramework.Controls.MetroGrid();
            this.branch_tab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.phone_branch_tb = new MetroFramework.Controls.MetroTextBox();
            this.name_branch_tb = new MetroFramework.Controls.MetroTextBox();
            this.id_branch_tb = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid5 = new MetroFramework.Controls.MetroGrid();
            this.add_doctor_bt = new MetroFramework.Controls.MetroButton();
            this.change_doctor_bt = new MetroFramework.Controls.MetroButton();
            this.delete_doctor_bt = new MetroFramework.Controls.MetroButton();
            this.add_order_bt = new MetroFramework.Controls.MetroButton();
            this.change_order_bt = new MetroFramework.Controls.MetroButton();
            this.delete_order_bt = new MetroFramework.Controls.MetroButton();
            this.add_service_bt = new MetroFramework.Controls.MetroButton();
            this.change_service_bt = new MetroFramework.Controls.MetroButton();
            this.delete_service_bt = new MetroFramework.Controls.MetroButton();
            this.add_branch_bt = new MetroFramework.Controls.MetroButton();
            this.change_branch_bt = new MetroFramework.Controls.MetroButton();
            this.delete_branch_bt = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.cyvarevDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyvarevDataSet)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.client_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.doc_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.ord_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).BeginInit();
            this.service_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid4)).BeginInit();
            this.branch_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid5)).BeginInit();
            this.SuspendLayout();
            // 
            // cyvarevDataSetBindingSource
            // 
            this.cyvarevDataSetBindingSource.DataSource = this.cyvarevDataSet;
            this.cyvarevDataSetBindingSource.Position = 0;
            // 
            // cyvarevDataSet
            // 
            this.cyvarevDataSet.DataSetName = "cyvarevDataSet";
            this.cyvarevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.client_tab);
            this.metroTabControl1.Controls.Add(this.doc_tab);
            this.metroTabControl1.Controls.Add(this.ord_tab);
            this.metroTabControl1.Controls.Add(this.service_tab);
            this.metroTabControl1.Controls.Add(this.branch_tab);
            this.metroTabControl1.Location = new System.Drawing.Point(1, 21);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 427);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // client_tab
            // 
            this.client_tab.Controls.Add(this.datepick);
            this.client_tab.Controls.Add(this.id_client);
            this.client_tab.Controls.Add(this.id_client_tb);
            this.client_tab.Controls.Add(this.add_client_bt);
            this.client_tab.Controls.Add(this.delete_client_bt);
            this.client_tab.Controls.Add(this.change_client_bt);
            this.client_tab.Controls.Add(this.polis_client_tb);
            this.client_tab.Controls.Add(this.client_birth);
            this.client_tab.Controls.Add(this.client_polis);
            this.client_tab.Controls.Add(this.client_name);
            this.client_tab.Controls.Add(this.name_client_tb);
            this.client_tab.Controls.Add(this.metroGrid1);
            this.client_tab.HorizontalScrollbarBarColor = true;
            this.client_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.client_tab.HorizontalScrollbarSize = 10;
            this.client_tab.Location = new System.Drawing.Point(4, 38);
            this.client_tab.Name = "client_tab";
            this.client_tab.Size = new System.Drawing.Size(792, 385);
            this.client_tab.TabIndex = 0;
            this.client_tab.Text = "Client";
            this.client_tab.VerticalScrollbarBarColor = true;
            this.client_tab.VerticalScrollbarHighlightOnWheel = false;
            this.client_tab.VerticalScrollbarSize = 10;
            // 
            // datepick
            // 
            this.datepick.Location = new System.Drawing.Point(623, 121);
            this.datepick.MinimumSize = new System.Drawing.Size(0, 29);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(149, 29);
            this.datepick.TabIndex = 14;
            // 
            // id_client
            // 
            this.id_client.AutoSize = true;
            this.id_client.Location = new System.Drawing.Point(539, 63);
            this.id_client.Name = "id_client";
            this.id_client.Size = new System.Drawing.Size(21, 19);
            this.id_client.TabIndex = 13;
            this.id_client.Text = "ID";
            // 
            // id_client_tb
            // 
            // 
            // 
            // 
            this.id_client_tb.CustomButton.Image = null;
            this.id_client_tb.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.id_client_tb.CustomButton.Name = "";
            this.id_client_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.id_client_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id_client_tb.CustomButton.TabIndex = 1;
            this.id_client_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_client_tb.CustomButton.UseSelectable = true;
            this.id_client_tb.CustomButton.Visible = false;
            this.id_client_tb.Lines = new string[0];
            this.id_client_tb.Location = new System.Drawing.Point(623, 63);
            this.id_client_tb.MaxLength = 32767;
            this.id_client_tb.Name = "id_client_tb";
            this.id_client_tb.PasswordChar = '\0';
            this.id_client_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id_client_tb.SelectedText = "";
            this.id_client_tb.SelectionLength = 0;
            this.id_client_tb.SelectionStart = 0;
            this.id_client_tb.ShortcutsEnabled = true;
            this.id_client_tb.Size = new System.Drawing.Size(149, 23);
            this.id_client_tb.TabIndex = 12;
            this.id_client_tb.UseSelectable = true;
            this.id_client_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id_client_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // add_client_bt
            // 
            this.add_client_bt.Location = new System.Drawing.Point(510, 267);
            this.add_client_bt.Name = "add_client_bt";
            this.add_client_bt.Size = new System.Drawing.Size(75, 23);
            this.add_client_bt.TabIndex = 11;
            this.add_client_bt.Text = "Add";
            this.add_client_bt.UseSelectable = true;
            this.add_client_bt.Click += new System.EventHandler(this.Add_client_bt_Click);
            // 
            // delete_client_bt
            // 
            this.delete_client_bt.Location = new System.Drawing.Point(672, 267);
            this.delete_client_bt.Name = "delete_client_bt";
            this.delete_client_bt.Size = new System.Drawing.Size(75, 23);
            this.delete_client_bt.TabIndex = 10;
            this.delete_client_bt.Text = "Delete";
            this.delete_client_bt.UseSelectable = true;
            this.delete_client_bt.Click += new System.EventHandler(this.Delete_client_bt_Click);
            // 
            // change_client_bt
            // 
            this.change_client_bt.Location = new System.Drawing.Point(591, 267);
            this.change_client_bt.Name = "change_client_bt";
            this.change_client_bt.Size = new System.Drawing.Size(75, 23);
            this.change_client_bt.TabIndex = 9;
            this.change_client_bt.Text = "Change";
            this.change_client_bt.UseSelectable = true;
            this.change_client_bt.Click += new System.EventHandler(this.Change_client_bt_Click);
            // 
            // polis_client_tb
            // 
            // 
            // 
            // 
            this.polis_client_tb.CustomButton.Image = null;
            this.polis_client_tb.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.polis_client_tb.CustomButton.Name = "";
            this.polis_client_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.polis_client_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.polis_client_tb.CustomButton.TabIndex = 1;
            this.polis_client_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.polis_client_tb.CustomButton.UseSelectable = true;
            this.polis_client_tb.CustomButton.Visible = false;
            this.polis_client_tb.Lines = new string[0];
            this.polis_client_tb.Location = new System.Drawing.Point(623, 160);
            this.polis_client_tb.MaxLength = 32767;
            this.polis_client_tb.Name = "polis_client_tb";
            this.polis_client_tb.PasswordChar = '\0';
            this.polis_client_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.polis_client_tb.SelectedText = "";
            this.polis_client_tb.SelectionLength = 0;
            this.polis_client_tb.SelectionStart = 0;
            this.polis_client_tb.ShortcutsEnabled = true;
            this.polis_client_tb.Size = new System.Drawing.Size(149, 23);
            this.polis_client_tb.TabIndex = 7;
            this.polis_client_tb.UseSelectable = true;
            this.polis_client_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.polis_client_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // client_birth
            // 
            this.client_birth.AutoSize = true;
            this.client_birth.Location = new System.Drawing.Point(539, 131);
            this.client_birth.Name = "client_birth";
            this.client_birth.Size = new System.Drawing.Size(37, 19);
            this.client_birth.TabIndex = 6;
            this.client_birth.Text = "Birth";
            // 
            // client_polis
            // 
            this.client_polis.AutoSize = true;
            this.client_polis.Location = new System.Drawing.Point(539, 164);
            this.client_polis.Name = "client_polis";
            this.client_polis.Size = new System.Drawing.Size(35, 19);
            this.client_polis.TabIndex = 5;
            this.client_polis.Text = "Polis";
            // 
            // client_name
            // 
            this.client_name.AutoSize = true;
            this.client_name.Location = new System.Drawing.Point(539, 96);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(45, 19);
            this.client_name.TabIndex = 4;
            this.client_name.Text = "Name";
            // 
            // name_client_tb
            // 
            // 
            // 
            // 
            this.name_client_tb.CustomButton.Image = null;
            this.name_client_tb.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.name_client_tb.CustomButton.Name = "";
            this.name_client_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.name_client_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name_client_tb.CustomButton.TabIndex = 1;
            this.name_client_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name_client_tb.CustomButton.UseSelectable = true;
            this.name_client_tb.CustomButton.Visible = false;
            this.name_client_tb.Lines = new string[0];
            this.name_client_tb.Location = new System.Drawing.Point(623, 92);
            this.name_client_tb.MaxLength = 32767;
            this.name_client_tb.Name = "name_client_tb";
            this.name_client_tb.PasswordChar = '\0';
            this.name_client_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_client_tb.SelectedText = "";
            this.name_client_tb.SelectionLength = 0;
            this.name_client_tb.SelectionStart = 0;
            this.name_client_tb.ShortcutsEnabled = true;
            this.name_client_tb.Size = new System.Drawing.Size(149, 23);
            this.name_client_tb.TabIndex = 3;
            this.name_client_tb.UseSelectable = true;
            this.name_client_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_client_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle184.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle184.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle184.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle184.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle184.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle184.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle184.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle184;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle185.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle185.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle185.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle185.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle185.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle185.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle185.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle185;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(-4, 4);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle186.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle186.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle186.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle186.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle186.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle186.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle186.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle186;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(446, 385);
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetroGrid1_CellContentClick_1);
            // 
            // doc_tab
            // 
            this.doc_tab.Controls.Add(this.delete_doctor_bt);
            this.doc_tab.Controls.Add(this.change_doctor_bt);
            this.doc_tab.Controls.Add(this.add_doctor_bt);
            this.doc_tab.Controls.Add(this.id_doc_tb);
            this.doc_tab.Controls.Add(this.metroLabel4);
            this.doc_tab.Controls.Add(this.phone_doc_tb);
            this.doc_tab.Controls.Add(this.spec_doc_tb);
            this.doc_tab.Controls.Add(this.name_doc_tb);
            this.doc_tab.Controls.Add(this.metroLabel3);
            this.doc_tab.Controls.Add(this.metroLabel2);
            this.doc_tab.Controls.Add(this.metroLabel1);
            this.doc_tab.Controls.Add(this.metroGrid2);
            this.doc_tab.HorizontalScrollbarBarColor = true;
            this.doc_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.doc_tab.HorizontalScrollbarSize = 10;
            this.doc_tab.Location = new System.Drawing.Point(4, 38);
            this.doc_tab.Name = "doc_tab";
            this.doc_tab.Size = new System.Drawing.Size(792, 385);
            this.doc_tab.TabIndex = 1;
            this.doc_tab.Text = "Doctors";
            this.doc_tab.VerticalScrollbarBarColor = true;
            this.doc_tab.VerticalScrollbarHighlightOnWheel = false;
            this.doc_tab.VerticalScrollbarSize = 10;
            // 
            // id_doc_tb
            // 
            // 
            // 
            // 
            this.id_doc_tb.CustomButton.Image = null;
            this.id_doc_tb.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.id_doc_tb.CustomButton.Name = "";
            this.id_doc_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.id_doc_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id_doc_tb.CustomButton.TabIndex = 1;
            this.id_doc_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_doc_tb.CustomButton.UseSelectable = true;
            this.id_doc_tb.CustomButton.Visible = false;
            this.id_doc_tb.Lines = new string[0];
            this.id_doc_tb.Location = new System.Drawing.Point(649, 75);
            this.id_doc_tb.MaxLength = 32767;
            this.id_doc_tb.Name = "id_doc_tb";
            this.id_doc_tb.PasswordChar = '\0';
            this.id_doc_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id_doc_tb.SelectedText = "";
            this.id_doc_tb.SelectionLength = 0;
            this.id_doc_tb.SelectionStart = 0;
            this.id_doc_tb.ShortcutsEnabled = true;
            this.id_doc_tb.Size = new System.Drawing.Size(75, 23);
            this.id_doc_tb.TabIndex = 12;
            this.id_doc_tb.UseSelectable = true;
            this.id_doc_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id_doc_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(495, 75);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(21, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "ID";
            // 
            // phone_doc_tb
            // 
            // 
            // 
            // 
            this.phone_doc_tb.CustomButton.Image = null;
            this.phone_doc_tb.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.phone_doc_tb.CustomButton.Name = "";
            this.phone_doc_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phone_doc_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phone_doc_tb.CustomButton.TabIndex = 1;
            this.phone_doc_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phone_doc_tb.CustomButton.UseSelectable = true;
            this.phone_doc_tb.CustomButton.Visible = false;
            this.phone_doc_tb.Lines = new string[0];
            this.phone_doc_tb.Location = new System.Drawing.Point(649, 199);
            this.phone_doc_tb.MaxLength = 32767;
            this.phone_doc_tb.Name = "phone_doc_tb";
            this.phone_doc_tb.PasswordChar = '\0';
            this.phone_doc_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phone_doc_tb.SelectedText = "";
            this.phone_doc_tb.SelectionLength = 0;
            this.phone_doc_tb.SelectionStart = 0;
            this.phone_doc_tb.ShortcutsEnabled = true;
            this.phone_doc_tb.Size = new System.Drawing.Size(75, 23);
            this.phone_doc_tb.TabIndex = 9;
            this.phone_doc_tb.UseSelectable = true;
            this.phone_doc_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phone_doc_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // spec_doc_tb
            // 
            // 
            // 
            // 
            this.spec_doc_tb.CustomButton.Image = null;
            this.spec_doc_tb.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.spec_doc_tb.CustomButton.Name = "";
            this.spec_doc_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.spec_doc_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.spec_doc_tb.CustomButton.TabIndex = 1;
            this.spec_doc_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.spec_doc_tb.CustomButton.UseSelectable = true;
            this.spec_doc_tb.CustomButton.Visible = false;
            this.spec_doc_tb.Lines = new string[0];
            this.spec_doc_tb.Location = new System.Drawing.Point(649, 157);
            this.spec_doc_tb.MaxLength = 32767;
            this.spec_doc_tb.Name = "spec_doc_tb";
            this.spec_doc_tb.PasswordChar = '\0';
            this.spec_doc_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.spec_doc_tb.SelectedText = "";
            this.spec_doc_tb.SelectionLength = 0;
            this.spec_doc_tb.SelectionStart = 0;
            this.spec_doc_tb.ShortcutsEnabled = true;
            this.spec_doc_tb.Size = new System.Drawing.Size(75, 23);
            this.spec_doc_tb.TabIndex = 8;
            this.spec_doc_tb.UseSelectable = true;
            this.spec_doc_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.spec_doc_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // name_doc_tb
            // 
            // 
            // 
            // 
            this.name_doc_tb.CustomButton.Image = null;
            this.name_doc_tb.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.name_doc_tb.CustomButton.Name = "";
            this.name_doc_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.name_doc_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name_doc_tb.CustomButton.TabIndex = 1;
            this.name_doc_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name_doc_tb.CustomButton.UseSelectable = true;
            this.name_doc_tb.CustomButton.Visible = false;
            this.name_doc_tb.Lines = new string[0];
            this.name_doc_tb.Location = new System.Drawing.Point(649, 116);
            this.name_doc_tb.MaxLength = 32767;
            this.name_doc_tb.Name = "name_doc_tb";
            this.name_doc_tb.PasswordChar = '\0';
            this.name_doc_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_doc_tb.SelectedText = "";
            this.name_doc_tb.SelectionLength = 0;
            this.name_doc_tb.SelectionStart = 0;
            this.name_doc_tb.ShortcutsEnabled = true;
            this.name_doc_tb.Size = new System.Drawing.Size(75, 23);
            this.name_doc_tb.TabIndex = 7;
            this.name_doc_tb.UseSelectable = true;
            this.name_doc_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_doc_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(493, 203);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Specialization";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(493, 161);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Phone number";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(495, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Name";
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle187.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle187.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle187.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle187.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle187.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle187.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle187.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle187;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle188.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle188.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle188.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle188.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle188.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle188.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle188.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle188;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(-4, 0);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle189.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle189.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle189.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle189.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle189.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle189.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle189.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle189;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(441, 389);
            this.metroGrid2.TabIndex = 2;
            this.metroGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetroGrid2_CellContentClick);
            // 
            // ord_tab
            // 
            this.ord_tab.Controls.Add(this.delete_order_bt);
            this.ord_tab.Controls.Add(this.change_order_bt);
            this.ord_tab.Controls.Add(this.add_order_bt);
            this.ord_tab.Controls.Add(this.metroLabel14);
            this.ord_tab.Controls.Add(this.id_order_tb);
            this.ord_tab.Controls.Add(this.datepick_order);
            this.ord_tab.Controls.Add(this.metroLabel7);
            this.ord_tab.Controls.Add(this.metroLabel6);
            this.ord_tab.Controls.Add(this.metroLabel5);
            this.ord_tab.Controls.Add(this.ord_branch_cb);
            this.ord_tab.Controls.Add(this.ord_client_cb);
            this.ord_tab.Controls.Add(this.ord_service_cb);
            this.ord_tab.Controls.Add(this.metroGrid3);
            this.ord_tab.HorizontalScrollbarBarColor = true;
            this.ord_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.ord_tab.HorizontalScrollbarSize = 10;
            this.ord_tab.Location = new System.Drawing.Point(4, 38);
            this.ord_tab.Name = "ord_tab";
            this.ord_tab.Size = new System.Drawing.Size(792, 385);
            this.ord_tab.TabIndex = 2;
            this.ord_tab.Text = "Orders";
            this.ord_tab.VerticalScrollbarBarColor = true;
            this.ord_tab.VerticalScrollbarHighlightOnWheel = false;
            this.ord_tab.VerticalScrollbarSize = 10;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(533, 122);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(21, 19);
            this.metroLabel14.TabIndex = 12;
            this.metroLabel14.Text = "ID";
            // 
            // id_order_tb
            // 
            // 
            // 
            // 
            this.id_order_tb.CustomButton.Image = null;
            this.id_order_tb.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.id_order_tb.CustomButton.Name = "";
            this.id_order_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.id_order_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id_order_tb.CustomButton.TabIndex = 1;
            this.id_order_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_order_tb.CustomButton.UseSelectable = true;
            this.id_order_tb.CustomButton.Visible = false;
            this.id_order_tb.Lines = new string[0];
            this.id_order_tb.Location = new System.Drawing.Point(640, 119);
            this.id_order_tb.MaxLength = 32767;
            this.id_order_tb.Name = "id_order_tb";
            this.id_order_tb.PasswordChar = '\0';
            this.id_order_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id_order_tb.SelectedText = "";
            this.id_order_tb.SelectionLength = 0;
            this.id_order_tb.SelectionStart = 0;
            this.id_order_tb.ShortcutsEnabled = true;
            this.id_order_tb.Size = new System.Drawing.Size(75, 23);
            this.id_order_tb.TabIndex = 11;
            this.id_order_tb.UseSelectable = true;
            this.id_order_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id_order_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // datepick_order
            // 
            this.datepick_order.Location = new System.Drawing.Point(561, 57);
            this.datepick_order.MinimumSize = new System.Drawing.Size(0, 29);
            this.datepick_order.Name = "datepick_order";
            this.datepick_order.Size = new System.Drawing.Size(200, 29);
            this.datepick_order.TabIndex = 9;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(533, 162);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(42, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Client";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(533, 209);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Service";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(533, 256);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Branch";
            // 
            // ord_branch_cb
            // 
            this.ord_branch_cb.FormattingEnabled = true;
            this.ord_branch_cb.ItemHeight = 23;
            this.ord_branch_cb.Location = new System.Drawing.Point(640, 246);
            this.ord_branch_cb.Name = "ord_branch_cb";
            this.ord_branch_cb.Size = new System.Drawing.Size(121, 29);
            this.ord_branch_cb.TabIndex = 5;
            this.ord_branch_cb.UseSelectable = true;
            // 
            // ord_client_cb
            // 
            this.ord_client_cb.FormattingEnabled = true;
            this.ord_client_cb.ItemHeight = 23;
            this.ord_client_cb.Location = new System.Drawing.Point(640, 152);
            this.ord_client_cb.Name = "ord_client_cb";
            this.ord_client_cb.Size = new System.Drawing.Size(121, 29);
            this.ord_client_cb.TabIndex = 4;
            this.ord_client_cb.UseSelectable = true;
            // 
            // ord_service_cb
            // 
            this.ord_service_cb.FormattingEnabled = true;
            this.ord_service_cb.ItemHeight = 23;
            this.ord_service_cb.Location = new System.Drawing.Point(640, 199);
            this.ord_service_cb.Name = "ord_service_cb";
            this.ord_service_cb.Size = new System.Drawing.Size(121, 29);
            this.ord_service_cb.TabIndex = 3;
            this.ord_service_cb.UseSelectable = true;
            // 
            // metroGrid3
            // 
            this.metroGrid3.AllowUserToResizeRows = false;
            this.metroGrid3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle190.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle190.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle190.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle190.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle190.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle190.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle190.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle190;
            this.metroGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle191.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle191.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle191.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle191.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle191.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle191.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle191.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid3.DefaultCellStyle = dataGridViewCellStyle191;
            this.metroGrid3.EnableHeadersVisualStyles = false;
            this.metroGrid3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.Location = new System.Drawing.Point(-4, 0);
            this.metroGrid3.Name = "metroGrid3";
            this.metroGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle192.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle192.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle192.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle192.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle192.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle192.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle192.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle192;
            this.metroGrid3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid3.Size = new System.Drawing.Size(481, 382);
            this.metroGrid3.TabIndex = 2;
            this.metroGrid3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetroGrid3_CellContentClick);
            // 
            // service_tab
            // 
            this.service_tab.Controls.Add(this.delete_service_bt);
            this.service_tab.Controls.Add(this.change_service_bt);
            this.service_tab.Controls.Add(this.add_service_bt);
            this.service_tab.Controls.Add(this.metroLabel13);
            this.service_tab.Controls.Add(this.metroLabel12);
            this.service_tab.Controls.Add(this.metroLabel11);
            this.service_tab.Controls.Add(this.price_service_tb);
            this.service_tab.Controls.Add(this.name_service_tb);
            this.service_tab.Controls.Add(this.id_service_tb);
            this.service_tab.Controls.Add(this.metroGrid4);
            this.service_tab.HorizontalScrollbarBarColor = true;
            this.service_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.service_tab.HorizontalScrollbarSize = 10;
            this.service_tab.Location = new System.Drawing.Point(4, 38);
            this.service_tab.Name = "service_tab";
            this.service_tab.Size = new System.Drawing.Size(792, 385);
            this.service_tab.TabIndex = 3;
            this.service_tab.Text = "Services";
            this.service_tab.VerticalScrollbarBarColor = true;
            this.service_tab.VerticalScrollbarHighlightOnWheel = false;
            this.service_tab.VerticalScrollbarSize = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(495, 219);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(38, 19);
            this.metroLabel13.TabIndex = 8;
            this.metroLabel13.Text = "Price";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(495, 152);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(45, 19);
            this.metroLabel12.TabIndex = 7;
            this.metroLabel12.Text = "Name";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(495, 99);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(21, 19);
            this.metroLabel11.TabIndex = 6;
            this.metroLabel11.Text = "ID";
            // 
            // price_service_tb
            // 
            // 
            // 
            // 
            this.price_service_tb.CustomButton.Image = null;
            this.price_service_tb.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.price_service_tb.CustomButton.Name = "";
            this.price_service_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.price_service_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.price_service_tb.CustomButton.TabIndex = 1;
            this.price_service_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.price_service_tb.CustomButton.UseSelectable = true;
            this.price_service_tb.CustomButton.Visible = false;
            this.price_service_tb.Lines = new string[0];
            this.price_service_tb.Location = new System.Drawing.Point(614, 215);
            this.price_service_tb.MaxLength = 32767;
            this.price_service_tb.Name = "price_service_tb";
            this.price_service_tb.PasswordChar = '\0';
            this.price_service_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.price_service_tb.SelectedText = "";
            this.price_service_tb.SelectionLength = 0;
            this.price_service_tb.SelectionStart = 0;
            this.price_service_tb.ShortcutsEnabled = true;
            this.price_service_tb.Size = new System.Drawing.Size(75, 23);
            this.price_service_tb.TabIndex = 5;
            this.price_service_tb.UseSelectable = true;
            this.price_service_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.price_service_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // name_service_tb
            // 
            // 
            // 
            // 
            this.name_service_tb.CustomButton.Image = null;
            this.name_service_tb.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.name_service_tb.CustomButton.Name = "";
            this.name_service_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.name_service_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name_service_tb.CustomButton.TabIndex = 1;
            this.name_service_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name_service_tb.CustomButton.UseSelectable = true;
            this.name_service_tb.CustomButton.Visible = false;
            this.name_service_tb.Lines = new string[0];
            this.name_service_tb.Location = new System.Drawing.Point(614, 148);
            this.name_service_tb.MaxLength = 32767;
            this.name_service_tb.Name = "name_service_tb";
            this.name_service_tb.PasswordChar = '\0';
            this.name_service_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_service_tb.SelectedText = "";
            this.name_service_tb.SelectionLength = 0;
            this.name_service_tb.SelectionStart = 0;
            this.name_service_tb.ShortcutsEnabled = true;
            this.name_service_tb.Size = new System.Drawing.Size(75, 23);
            this.name_service_tb.TabIndex = 4;
            this.name_service_tb.UseSelectable = true;
            this.name_service_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_service_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // id_service_tb
            // 
            // 
            // 
            // 
            this.id_service_tb.CustomButton.Image = null;
            this.id_service_tb.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.id_service_tb.CustomButton.Name = "";
            this.id_service_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.id_service_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id_service_tb.CustomButton.TabIndex = 1;
            this.id_service_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_service_tb.CustomButton.UseSelectable = true;
            this.id_service_tb.CustomButton.Visible = false;
            this.id_service_tb.Lines = new string[0];
            this.id_service_tb.Location = new System.Drawing.Point(614, 96);
            this.id_service_tb.MaxLength = 32767;
            this.id_service_tb.Name = "id_service_tb";
            this.id_service_tb.PasswordChar = '\0';
            this.id_service_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id_service_tb.SelectedText = "";
            this.id_service_tb.SelectionLength = 0;
            this.id_service_tb.SelectionStart = 0;
            this.id_service_tb.ShortcutsEnabled = true;
            this.id_service_tb.Size = new System.Drawing.Size(75, 23);
            this.id_service_tb.TabIndex = 3;
            this.id_service_tb.UseSelectable = true;
            this.id_service_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id_service_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid4
            // 
            this.metroGrid4.AllowUserToResizeRows = false;
            this.metroGrid4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle181.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle181.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle181.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle181.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle181.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle181.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle181.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle181;
            this.metroGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle182.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle182.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle182.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle182.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle182.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle182.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle182.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid4.DefaultCellStyle = dataGridViewCellStyle182;
            this.metroGrid4.EnableHeadersVisualStyles = false;
            this.metroGrid4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid4.Location = new System.Drawing.Point(3, 4);
            this.metroGrid4.Name = "metroGrid4";
            this.metroGrid4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle183.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle183.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle183.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle183.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle183.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle183.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle183.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid4.RowHeadersDefaultCellStyle = dataGridViewCellStyle183;
            this.metroGrid4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid4.Size = new System.Drawing.Size(405, 378);
            this.metroGrid4.TabIndex = 2;
            this.metroGrid4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetroGrid4_CellContentClick);
            // 
            // branch_tab
            // 
            this.branch_tab.Controls.Add(this.delete_branch_bt);
            this.branch_tab.Controls.Add(this.change_branch_bt);
            this.branch_tab.Controls.Add(this.add_branch_bt);
            this.branch_tab.Controls.Add(this.metroLabel10);
            this.branch_tab.Controls.Add(this.metroLabel9);
            this.branch_tab.Controls.Add(this.metroLabel8);
            this.branch_tab.Controls.Add(this.phone_branch_tb);
            this.branch_tab.Controls.Add(this.name_branch_tb);
            this.branch_tab.Controls.Add(this.id_branch_tb);
            this.branch_tab.Controls.Add(this.metroGrid5);
            this.branch_tab.HorizontalScrollbarBarColor = true;
            this.branch_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.branch_tab.HorizontalScrollbarSize = 10;
            this.branch_tab.Location = new System.Drawing.Point(4, 38);
            this.branch_tab.Name = "branch_tab";
            this.branch_tab.Size = new System.Drawing.Size(792, 385);
            this.branch_tab.TabIndex = 4;
            this.branch_tab.Text = "Branches";
            this.branch_tab.VerticalScrollbarBarColor = true;
            this.branch_tab.VerticalScrollbarHighlightOnWheel = false;
            this.branch_tab.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(505, 185);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(46, 19);
            this.metroLabel10.TabIndex = 8;
            this.metroLabel10.Text = "Phone";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(505, 130);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(45, 19);
            this.metroLabel9.TabIndex = 7;
            this.metroLabel9.Text = "Name";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(505, 79);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(21, 19);
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "ID";
            // 
            // phone_branch_tb
            // 
            // 
            // 
            // 
            this.phone_branch_tb.CustomButton.Image = null;
            this.phone_branch_tb.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.phone_branch_tb.CustomButton.Name = "";
            this.phone_branch_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phone_branch_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phone_branch_tb.CustomButton.TabIndex = 1;
            this.phone_branch_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phone_branch_tb.CustomButton.UseSelectable = true;
            this.phone_branch_tb.CustomButton.Visible = false;
            this.phone_branch_tb.Lines = new string[0];
            this.phone_branch_tb.Location = new System.Drawing.Point(609, 182);
            this.phone_branch_tb.MaxLength = 32767;
            this.phone_branch_tb.Name = "phone_branch_tb";
            this.phone_branch_tb.PasswordChar = '\0';
            this.phone_branch_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phone_branch_tb.SelectedText = "";
            this.phone_branch_tb.SelectionLength = 0;
            this.phone_branch_tb.SelectionStart = 0;
            this.phone_branch_tb.ShortcutsEnabled = true;
            this.phone_branch_tb.Size = new System.Drawing.Size(75, 23);
            this.phone_branch_tb.TabIndex = 5;
            this.phone_branch_tb.UseSelectable = true;
            this.phone_branch_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phone_branch_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // name_branch_tb
            // 
            // 
            // 
            // 
            this.name_branch_tb.CustomButton.Image = null;
            this.name_branch_tb.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.name_branch_tb.CustomButton.Name = "";
            this.name_branch_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.name_branch_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name_branch_tb.CustomButton.TabIndex = 1;
            this.name_branch_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name_branch_tb.CustomButton.UseSelectable = true;
            this.name_branch_tb.CustomButton.Visible = false;
            this.name_branch_tb.Lines = new string[0];
            this.name_branch_tb.Location = new System.Drawing.Point(609, 127);
            this.name_branch_tb.MaxLength = 32767;
            this.name_branch_tb.Name = "name_branch_tb";
            this.name_branch_tb.PasswordChar = '\0';
            this.name_branch_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_branch_tb.SelectedText = "";
            this.name_branch_tb.SelectionLength = 0;
            this.name_branch_tb.SelectionStart = 0;
            this.name_branch_tb.ShortcutsEnabled = true;
            this.name_branch_tb.Size = new System.Drawing.Size(75, 23);
            this.name_branch_tb.TabIndex = 4;
            this.name_branch_tb.UseSelectable = true;
            this.name_branch_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_branch_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // id_branch_tb
            // 
            // 
            // 
            // 
            this.id_branch_tb.CustomButton.Image = null;
            this.id_branch_tb.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.id_branch_tb.CustomButton.Name = "";
            this.id_branch_tb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.id_branch_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id_branch_tb.CustomButton.TabIndex = 1;
            this.id_branch_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_branch_tb.CustomButton.UseSelectable = true;
            this.id_branch_tb.CustomButton.Visible = false;
            this.id_branch_tb.Lines = new string[0];
            this.id_branch_tb.Location = new System.Drawing.Point(609, 76);
            this.id_branch_tb.MaxLength = 32767;
            this.id_branch_tb.Name = "id_branch_tb";
            this.id_branch_tb.PasswordChar = '\0';
            this.id_branch_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id_branch_tb.SelectedText = "";
            this.id_branch_tb.SelectionLength = 0;
            this.id_branch_tb.SelectionStart = 0;
            this.id_branch_tb.ShortcutsEnabled = true;
            this.id_branch_tb.Size = new System.Drawing.Size(75, 23);
            this.id_branch_tb.TabIndex = 3;
            this.id_branch_tb.UseSelectable = true;
            this.id_branch_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id_branch_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid5
            // 
            this.metroGrid5.AllowUserToResizeRows = false;
            this.metroGrid5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid5.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle193.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle193.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle193.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle193.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle193.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle193.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle193.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle193;
            this.metroGrid5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle194.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle194.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle194.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle194.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle194.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle194.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle194.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid5.DefaultCellStyle = dataGridViewCellStyle194;
            this.metroGrid5.EnableHeadersVisualStyles = false;
            this.metroGrid5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid5.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid5.Location = new System.Drawing.Point(3, 4);
            this.metroGrid5.Name = "metroGrid5";
            this.metroGrid5.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle195.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle195.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle195.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle195.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle195.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle195.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle195.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid5.RowHeadersDefaultCellStyle = dataGridViewCellStyle195;
            this.metroGrid5.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid5.Size = new System.Drawing.Size(441, 385);
            this.metroGrid5.TabIndex = 2;
            this.metroGrid5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetroGrid5_CellContentClick);
            // 
            // add_doctor_bt
            // 
            this.add_doctor_bt.Location = new System.Drawing.Point(493, 267);
            this.add_doctor_bt.Name = "add_doctor_bt";
            this.add_doctor_bt.Size = new System.Drawing.Size(75, 23);
            this.add_doctor_bt.TabIndex = 13;
            this.add_doctor_bt.Text = "Add";
            this.add_doctor_bt.UseSelectable = true;
            this.add_doctor_bt.Click += new System.EventHandler(this.Add_doctor_bt_Click);
            // 
            // change_doctor_bt
            // 
            this.change_doctor_bt.Location = new System.Drawing.Point(587, 267);
            this.change_doctor_bt.Name = "change_doctor_bt";
            this.change_doctor_bt.Size = new System.Drawing.Size(75, 23);
            this.change_doctor_bt.TabIndex = 14;
            this.change_doctor_bt.Text = "Change";
            this.change_doctor_bt.UseSelectable = true;
            this.change_doctor_bt.Click += new System.EventHandler(this.Change_doctor_bt_Click);
            // 
            // delete_doctor_bt
            // 
            this.delete_doctor_bt.Location = new System.Drawing.Point(680, 267);
            this.delete_doctor_bt.Name = "delete_doctor_bt";
            this.delete_doctor_bt.Size = new System.Drawing.Size(75, 23);
            this.delete_doctor_bt.TabIndex = 15;
            this.delete_doctor_bt.Text = "Delete";
            this.delete_doctor_bt.UseSelectable = true;
            this.delete_doctor_bt.Click += new System.EventHandler(this.Delete_doctor_bt_Click);
            // 
            // add_order_bt
            // 
            this.add_order_bt.Location = new System.Drawing.Point(533, 308);
            this.add_order_bt.Name = "add_order_bt";
            this.add_order_bt.Size = new System.Drawing.Size(75, 23);
            this.add_order_bt.TabIndex = 13;
            this.add_order_bt.Text = "Add";
            this.add_order_bt.UseSelectable = true;
            this.add_order_bt.Click += new System.EventHandler(this.Add_order_bt_Click);
            // 
            // change_order_bt
            // 
            this.change_order_bt.Location = new System.Drawing.Point(614, 308);
            this.change_order_bt.Name = "change_order_bt";
            this.change_order_bt.Size = new System.Drawing.Size(75, 23);
            this.change_order_bt.TabIndex = 14;
            this.change_order_bt.Text = "Change";
            this.change_order_bt.UseSelectable = true;
            this.change_order_bt.Click += new System.EventHandler(this.Change_order_bt_Click);
            // 
            // delete_order_bt
            // 
            this.delete_order_bt.Location = new System.Drawing.Point(696, 307);
            this.delete_order_bt.Name = "delete_order_bt";
            this.delete_order_bt.Size = new System.Drawing.Size(75, 23);
            this.delete_order_bt.TabIndex = 15;
            this.delete_order_bt.Text = "Delete";
            this.delete_order_bt.UseSelectable = true;
            this.delete_order_bt.Click += new System.EventHandler(this.Delete_order_bt_Click_1);
            // 
            // add_service_bt
            // 
            this.add_service_bt.Location = new System.Drawing.Point(495, 287);
            this.add_service_bt.Name = "add_service_bt";
            this.add_service_bt.Size = new System.Drawing.Size(75, 23);
            this.add_service_bt.TabIndex = 10;
            this.add_service_bt.Text = "Add";
            this.add_service_bt.UseSelectable = true;
            this.add_service_bt.Click += new System.EventHandler(this.Add_service_bt_Click_1);
            // 
            // change_service_bt
            // 
            this.change_service_bt.Location = new System.Drawing.Point(576, 287);
            this.change_service_bt.Name = "change_service_bt";
            this.change_service_bt.Size = new System.Drawing.Size(75, 23);
            this.change_service_bt.TabIndex = 11;
            this.change_service_bt.Text = "Change";
            this.change_service_bt.UseSelectable = true;
            this.change_service_bt.Click += new System.EventHandler(this.Change_service_bt_Click_1);
            // 
            // delete_service_bt
            // 
            this.delete_service_bt.Location = new System.Drawing.Point(657, 287);
            this.delete_service_bt.Name = "delete_service_bt";
            this.delete_service_bt.Size = new System.Drawing.Size(75, 23);
            this.delete_service_bt.TabIndex = 12;
            this.delete_service_bt.Text = "Delete";
            this.delete_service_bt.UseSelectable = true;
            this.delete_service_bt.Click += new System.EventHandler(this.Delete_service_bt_Click_1);
            // 
            // add_branch_bt
            // 
            this.add_branch_bt.Location = new System.Drawing.Point(505, 271);
            this.add_branch_bt.Name = "add_branch_bt";
            this.add_branch_bt.Size = new System.Drawing.Size(75, 23);
            this.add_branch_bt.TabIndex = 10;
            this.add_branch_bt.Text = "Add";
            this.add_branch_bt.UseSelectable = true;
            this.add_branch_bt.Click += new System.EventHandler(this.Add_branch_bt_Click_1);
            // 
            // change_branch_bt
            // 
            this.change_branch_bt.Location = new System.Drawing.Point(586, 271);
            this.change_branch_bt.Name = "change_branch_bt";
            this.change_branch_bt.Size = new System.Drawing.Size(75, 23);
            this.change_branch_bt.TabIndex = 11;
            this.change_branch_bt.Text = "Change";
            this.change_branch_bt.UseSelectable = true;
            this.change_branch_bt.Click += new System.EventHandler(this.Change_branch_bt_Click_1);
            // 
            // delete_branch_bt
            // 
            this.delete_branch_bt.Location = new System.Drawing.Point(667, 271);
            this.delete_branch_bt.Name = "delete_branch_bt";
            this.delete_branch_bt.Size = new System.Drawing.Size(75, 23);
            this.delete_branch_bt.TabIndex = 12;
            this.delete_branch_bt.Text = "Delete";
            this.delete_branch_bt.UseSelectable = true;
            this.delete_branch_bt.Click += new System.EventHandler(this.Delete_branch_bt_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cyvarevDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyvarevDataSet)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.client_tab.ResumeLayout(false);
            this.client_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.doc_tab.ResumeLayout(false);
            this.doc_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.ord_tab.ResumeLayout(false);
            this.ord_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).EndInit();
            this.service_tab.ResumeLayout(false);
            this.service_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid4)).EndInit();
            this.branch_tab.ResumeLayout(false);
            this.branch_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid5)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.BindingSource cyvarevDataSetBindingSource;
        private cyvarevDataSet cyvarevDataSet;
        private MetroFramework.Controls.MetroTabPage client_tab;
        private MetroFramework.Controls.MetroLabel id_client;
        private MetroFramework.Controls.MetroTextBox id_client_tb;
        private MetroFramework.Controls.MetroButton add_client_bt;
        private MetroFramework.Controls.MetroButton delete_client_bt;
        private MetroFramework.Controls.MetroButton change_client_bt;
        private MetroFramework.Controls.MetroTextBox polis_client_tb;
        private MetroFramework.Controls.MetroLabel client_birth;
        private MetroFramework.Controls.MetroLabel client_polis;
        private MetroFramework.Controls.MetroLabel client_name;
        private MetroFramework.Controls.MetroTextBox name_client_tb;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTabPage doc_tab;
        private MetroFramework.Controls.MetroTabPage ord_tab;
        private MetroFramework.Controls.MetroTabPage service_tab;
        private MetroFramework.Controls.MetroTabPage branch_tab;
        private MetroFramework.Controls.MetroDateTime datepick;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroGrid metroGrid3;
        private MetroFramework.Controls.MetroGrid metroGrid4;
        private MetroFramework.Controls.MetroGrid metroGrid5;
        private MetroFramework.Controls.MetroComboBox ord_branch_cb;
        private MetroFramework.Controls.MetroComboBox ord_client_cb;
        private MetroFramework.Controls.MetroComboBox ord_service_cb;
        private MetroFramework.Controls.MetroTextBox phone_doc_tb;
        private MetroFramework.Controls.MetroTextBox spec_doc_tb;
        private MetroFramework.Controls.MetroTextBox name_doc_tb;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MetroFramework.Controls.MetroTextBox id_doc_tb;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime datepick_order;
        private MetroFramework.Controls.MetroTextBox id_order_tb;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox phone_branch_tb;
        private MetroFramework.Controls.MetroTextBox name_branch_tb;
        private MetroFramework.Controls.MetroTextBox id_branch_tb;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox price_service_tb;
        private MetroFramework.Controls.MetroTextBox name_service_tb;
        private MetroFramework.Controls.MetroTextBox id_service_tb;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroButton delete_doctor_bt;
        private MetroFramework.Controls.MetroButton change_doctor_bt;
        private MetroFramework.Controls.MetroButton add_doctor_bt;
        private MetroFramework.Controls.MetroButton delete_order_bt;
        private MetroFramework.Controls.MetroButton change_order_bt;
        private MetroFramework.Controls.MetroButton add_order_bt;
        private MetroFramework.Controls.MetroButton delete_service_bt;
        private MetroFramework.Controls.MetroButton change_service_bt;
        private MetroFramework.Controls.MetroButton add_service_bt;
        private MetroFramework.Controls.MetroButton delete_branch_bt;
        private MetroFramework.Controls.MetroButton change_branch_bt;
        private MetroFramework.Controls.MetroButton add_branch_bt;
    }
}

