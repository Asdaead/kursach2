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
            this.cyvarevDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyvarevDataSet = new kursach2.cyvarevDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.polis_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.change_client = new System.Windows.Forms.Button();
            this.add_client = new System.Windows.Forms.Button();
            this.delete_client = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_client = new System.Windows.Forms.Label();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.Client_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.spec_doc_tb = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.add_doc = new System.Windows.Forms.Button();
            this.label_doc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.delete_doc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.change_doc = new System.Windows.Forms.Button();
            this.id_doc_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.name_doc_tb = new System.Windows.Forms.TextBox();
            this.phone_doc_tb = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.amount_item_tb = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.add_item_bt = new System.Windows.Forms.Button();
            this.label_item = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.delete_item_bt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.change_item_bt = new System.Windows.Forms.Button();
            this.id_item_tb = new System.Windows.Forms.TextBox();
            this.name_item_tb = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.datepick_order = new System.Windows.Forms.DateTimePicker();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.add_order_bt = new System.Windows.Forms.Button();
            this.label_order = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.delete_order_bt = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.change_order_bt = new System.Windows.Forms.Button();
            this.id_order_tb = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.request_tb = new System.Windows.Forms.TextBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.add_request_bt = new System.Windows.Forms.Button();
            this.label_request = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.delete_request_bt = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.change_request_bt = new System.Windows.Forms.Button();
            this.id_request_tb = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.price_service_tb = new System.Windows.Forms.TextBox();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.add_service_bt = new System.Windows.Forms.Button();
            this.label_service = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.delete_service_bt = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.change_service_bt = new System.Windows.Forms.Button();
            this.id_service_tb = new System.Windows.Forms.TextBox();
            this.name_service_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cyvarevDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyvarevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Client_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id_client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of birth";
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(587, 42);
            this.id_box.Name = "id_box";
            this.id_box.ReadOnly = true;
            this.id_box.Size = new System.Drawing.Size(129, 20);
            this.id_box.TabIndex = 4;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(587, 68);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(129, 20);
            this.name_box.TabIndex = 5;
            // 
            // polis_box
            // 
            this.polis_box.Location = new System.Drawing.Point(587, 124);
            this.polis_box.Name = "polis_box";
            this.polis_box.Size = new System.Drawing.Size(129, 20);
            this.polis_box.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Polis";
            // 
            // change_client
            // 
            this.change_client.Location = new System.Drawing.Point(560, 264);
            this.change_client.Name = "change_client";
            this.change_client.Size = new System.Drawing.Size(75, 23);
            this.change_client.TabIndex = 9;
            this.change_client.Text = "Change";
            this.change_client.UseVisualStyleBackColor = true;
            this.change_client.Click += new System.EventHandler(this.change_client_Click);
            // 
            // add_client
            // 
            this.add_client.Location = new System.Drawing.Point(479, 264);
            this.add_client.Name = "add_client";
            this.add_client.Size = new System.Drawing.Size(75, 23);
            this.add_client.TabIndex = 10;
            this.add_client.Text = "Add";
            this.add_client.UseVisualStyleBackColor = true;
            this.add_client.Click += new System.EventHandler(this.add_client_Click);
            // 
            // delete_client
            // 
            this.delete_client.Location = new System.Drawing.Point(641, 264);
            this.delete_client.Name = "delete_client";
            this.delete_client.Size = new System.Drawing.Size(75, 23);
            this.delete_client.TabIndex = 11;
            this.delete_client.Text = "Delete";
            this.delete_client.UseVisualStyleBackColor = true;
            this.delete_client.Click += new System.EventHandler(this.delete_client_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(422, 428);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // label_client
            // 
            this.label_client.AutoSize = true;
            this.label_client.ForeColor = System.Drawing.Color.Red;
            this.label_client.Location = new System.Drawing.Point(435, 337);
            this.label_client.Name = "label_client";
            this.label_client.Size = new System.Drawing.Size(29, 13);
            this.label_client.TabIndex = 13;
            this.label_client.Text = "label";
            this.label_client.Visible = false;
            // 
            // datepick
            // 
            this.datepick.AllowDrop = true;
            this.datepick.Location = new System.Drawing.Point(587, 98);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(129, 20);
            this.datepick.TabIndex = 14;
            // 
            // Client_tab
            // 
            this.Client_tab.Controls.Add(this.tabPage1);
            this.Client_tab.Controls.Add(this.tabPage2);
            this.Client_tab.Controls.Add(this.tabPage3);
            this.Client_tab.Controls.Add(this.tabPage4);
            this.Client_tab.Controls.Add(this.tabPage5);
            this.Client_tab.Controls.Add(this.tabPage6);
            this.Client_tab.Location = new System.Drawing.Point(0, -1);
            this.Client_tab.Name = "Client_tab";
            this.Client_tab.SelectedIndex = 0;
            this.Client_tab.Size = new System.Drawing.Size(808, 454);
            this.Client_tab.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.datepick);
            this.tabPage1.Controls.Add(this.add_client);
            this.tabPage1.Controls.Add(this.label_client);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.delete_client);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.change_client);
            this.tabPage1.Controls.Add(this.id_box);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.name_box);
            this.tabPage1.Controls.Add(this.polis_box);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.spec_doc_tb);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.add_doc);
            this.tabPage2.Controls.Add(this.label_doc);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.delete_doc);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.change_doc);
            this.tabPage2.Controls.Add(this.id_doc_tb);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.name_doc_tb);
            this.tabPage2.Controls.Add(this.phone_doc_tb);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(800, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doctors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // spec_doc_tb
            // 
            this.spec_doc_tb.Location = new System.Drawing.Point(591, 98);
            this.spec_doc_tb.Name = "spec_doc_tb";
            this.spec_doc_tb.Size = new System.Drawing.Size(129, 20);
            this.spec_doc_tb.TabIndex = 27;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(422, 428);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // add_doc
            // 
            this.add_doc.Location = new System.Drawing.Point(483, 264);
            this.add_doc.Name = "add_doc";
            this.add_doc.Size = new System.Drawing.Size(75, 23);
            this.add_doc.TabIndex = 23;
            this.add_doc.Text = "Add";
            this.add_doc.UseVisualStyleBackColor = true;
            this.add_doc.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label_doc
            // 
            this.label_doc.AutoSize = true;
            this.label_doc.ForeColor = System.Drawing.Color.Red;
            this.label_doc.Location = new System.Drawing.Point(439, 337);
            this.label_doc.Name = "label_doc";
            this.label_doc.Size = new System.Drawing.Size(29, 13);
            this.label_doc.TabIndex = 26;
            this.label_doc.Text = "label";
            this.label_doc.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "id_doctor";
            // 
            // delete_doc
            // 
            this.delete_doc.Location = new System.Drawing.Point(645, 264);
            this.delete_doc.Name = "delete_doc";
            this.delete_doc.Size = new System.Drawing.Size(75, 23);
            this.delete_doc.TabIndex = 24;
            this.delete_doc.Text = "Delete";
            this.delete_doc.UseVisualStyleBackColor = true;
            this.delete_doc.Click += new System.EventHandler(this.Delete_doc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Specialization";
            // 
            // change_doc
            // 
            this.change_doc.Location = new System.Drawing.Point(564, 264);
            this.change_doc.Name = "change_doc";
            this.change_doc.Size = new System.Drawing.Size(75, 23);
            this.change_doc.TabIndex = 22;
            this.change_doc.Text = "Change";
            this.change_doc.UseVisualStyleBackColor = true;
            this.change_doc.Click += new System.EventHandler(this.Change_doc_Click);
            // 
            // id_doc_tb
            // 
            this.id_doc_tb.Enabled = false;
            this.id_doc_tb.Location = new System.Drawing.Point(591, 42);
            this.id_doc_tb.Name = "id_doc_tb";
            this.id_doc_tb.ReadOnly = true;
            this.id_doc_tb.Size = new System.Drawing.Size(129, 20);
            this.id_doc_tb.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(476, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Phone number";
            // 
            // name_doc_tb
            // 
            this.name_doc_tb.Location = new System.Drawing.Point(591, 68);
            this.name_doc_tb.Name = "name_doc_tb";
            this.name_doc_tb.Size = new System.Drawing.Size(129, 20);
            this.name_doc_tb.TabIndex = 19;
            // 
            // phone_doc_tb
            // 
            this.phone_doc_tb.Location = new System.Drawing.Point(591, 124);
            this.phone_doc_tb.Name = "phone_doc_tb";
            this.phone_doc_tb.Size = new System.Drawing.Size(129, 20);
            this.phone_doc_tb.TabIndex = 20;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.amount_item_tb);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.add_item_bt);
            this.tabPage3.Controls.Add(this.label_item);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.delete_item_bt);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.change_item_bt);
            this.tabPage3.Controls.Add(this.id_item_tb);
            this.tabPage3.Controls.Add(this.name_item_tb);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(800, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // amount_item_tb
            // 
            this.amount_item_tb.Location = new System.Drawing.Point(591, 98);
            this.amount_item_tb.Name = "amount_item_tb";
            this.amount_item_tb.Size = new System.Drawing.Size(129, 20);
            this.amount_item_tb.TabIndex = 40;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(422, 428);
            this.dataGridView3.TabIndex = 38;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellContentClick);
            // 
            // add_item_bt
            // 
            this.add_item_bt.Location = new System.Drawing.Point(483, 264);
            this.add_item_bt.Name = "add_item_bt";
            this.add_item_bt.Size = new System.Drawing.Size(75, 23);
            this.add_item_bt.TabIndex = 36;
            this.add_item_bt.Text = "Add";
            this.add_item_bt.UseVisualStyleBackColor = true;
            this.add_item_bt.Click += new System.EventHandler(this.Add_item_bt_Click);
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.ForeColor = System.Drawing.Color.Red;
            this.label_item.Location = new System.Drawing.Point(439, 337);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(29, 13);
            this.label_item.TabIndex = 39;
            this.label_item.Text = "label";
            this.label_item.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "id_item";
            // 
            // delete_item_bt
            // 
            this.delete_item_bt.Location = new System.Drawing.Point(645, 264);
            this.delete_item_bt.Name = "delete_item_bt";
            this.delete_item_bt.Size = new System.Drawing.Size(75, 23);
            this.delete_item_bt.TabIndex = 37;
            this.delete_item_bt.Text = "Delete";
            this.delete_item_bt.UseVisualStyleBackColor = true;
            this.delete_item_bt.Click += new System.EventHandler(this.Delete_item_bt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(476, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Amount";
            // 
            // change_item_bt
            // 
            this.change_item_bt.Location = new System.Drawing.Point(564, 264);
            this.change_item_bt.Name = "change_item_bt";
            this.change_item_bt.Size = new System.Drawing.Size(75, 23);
            this.change_item_bt.TabIndex = 35;
            this.change_item_bt.Text = "Change";
            this.change_item_bt.UseVisualStyleBackColor = true;
            this.change_item_bt.Click += new System.EventHandler(this.Change_item_bt_Click);
            // 
            // id_item_tb
            // 
            this.id_item_tb.Enabled = false;
            this.id_item_tb.Location = new System.Drawing.Point(591, 42);
            this.id_item_tb.Name = "id_item_tb";
            this.id_item_tb.ReadOnly = true;
            this.id_item_tb.Size = new System.Drawing.Size(129, 20);
            this.id_item_tb.TabIndex = 31;
            // 
            // name_item_tb
            // 
            this.name_item_tb.Location = new System.Drawing.Point(591, 68);
            this.name_item_tb.Name = "name_item_tb";
            this.name_item_tb.Size = new System.Drawing.Size(129, 20);
            this.name_item_tb.TabIndex = 32;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.datepick_order);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.add_order_bt);
            this.tabPage4.Controls.Add(this.label_order);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.delete_order_bt);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.change_order_bt);
            this.tabPage4.Controls.Add(this.id_order_tb);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(800, 428);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Orders";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // datepick_order
            // 
            this.datepick_order.Location = new System.Drawing.Point(587, 72);
            this.datepick_order.Name = "datepick_order";
            this.datepick_order.Size = new System.Drawing.Size(132, 20);
            this.datepick_order.TabIndex = 15;
            this.datepick_order.Value = new System.DateTime(2019, 6, 3, 21, 19, 44, 0);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(-4, -3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(422, 428);
            this.dataGridView4.TabIndex = 49;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView4_CellContentClick);
            // 
            // add_order_bt
            // 
            this.add_order_bt.Location = new System.Drawing.Point(479, 261);
            this.add_order_bt.Name = "add_order_bt";
            this.add_order_bt.Size = new System.Drawing.Size(75, 23);
            this.add_order_bt.TabIndex = 47;
            this.add_order_bt.Text = "Add";
            this.add_order_bt.UseVisualStyleBackColor = true;
            this.add_order_bt.Click += new System.EventHandler(this.Add_order_bt_Click);
            // 
            // label_order
            // 
            this.label_order.AutoSize = true;
            this.label_order.ForeColor = System.Drawing.Color.Red;
            this.label_order.Location = new System.Drawing.Point(435, 334);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(29, 13);
            this.label_order.TabIndex = 50;
            this.label_order.Text = "label";
            this.label_order.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(472, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "id_order";
            // 
            // delete_order_bt
            // 
            this.delete_order_bt.Location = new System.Drawing.Point(641, 261);
            this.delete_order_bt.Name = "delete_order_bt";
            this.delete_order_bt.Size = new System.Drawing.Size(75, 23);
            this.delete_order_bt.TabIndex = 48;
            this.delete_order_bt.Text = "Delete";
            this.delete_order_bt.UseVisualStyleBackColor = true;
            this.delete_order_bt.Click += new System.EventHandler(this.Delete_order_bt_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(472, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Date";
            // 
            // change_order_bt
            // 
            this.change_order_bt.Location = new System.Drawing.Point(560, 261);
            this.change_order_bt.Name = "change_order_bt";
            this.change_order_bt.Size = new System.Drawing.Size(75, 23);
            this.change_order_bt.TabIndex = 46;
            this.change_order_bt.Text = "Change";
            this.change_order_bt.UseVisualStyleBackColor = true;
            this.change_order_bt.Click += new System.EventHandler(this.Change_order_bt_Click);
            // 
            // id_order_tb
            // 
            this.id_order_tb.Enabled = false;
            this.id_order_tb.Location = new System.Drawing.Point(587, 39);
            this.id_order_tb.Name = "id_order_tb";
            this.id_order_tb.ReadOnly = true;
            this.id_order_tb.Size = new System.Drawing.Size(129, 20);
            this.id_order_tb.TabIndex = 44;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.request_tb);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Controls.Add(this.add_request_bt);
            this.tabPage5.Controls.Add(this.label_request);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.delete_request_bt);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.change_request_bt);
            this.tabPage5.Controls.Add(this.id_request_tb);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(800, 428);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Repair requests";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // request_tb
            // 
            this.request_tb.Location = new System.Drawing.Point(548, 75);
            this.request_tb.Multiline = true;
            this.request_tb.Name = "request_tb";
            this.request_tb.Size = new System.Drawing.Size(218, 232);
            this.request_tb.TabIndex = 51;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(422, 428);
            this.dataGridView5.TabIndex = 49;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView5_CellContentClick);
            // 
            // add_request_bt
            // 
            this.add_request_bt.Location = new System.Drawing.Point(510, 372);
            this.add_request_bt.Name = "add_request_bt";
            this.add_request_bt.Size = new System.Drawing.Size(75, 23);
            this.add_request_bt.TabIndex = 47;
            this.add_request_bt.Text = "Add";
            this.add_request_bt.UseVisualStyleBackColor = true;
            this.add_request_bt.Click += new System.EventHandler(this.Add_request_bt_Click);
            // 
            // label_request
            // 
            this.label_request.AutoSize = true;
            this.label_request.ForeColor = System.Drawing.Color.Red;
            this.label_request.Location = new System.Drawing.Point(476, 332);
            this.label_request.Name = "label_request";
            this.label_request.Size = new System.Drawing.Size(29, 13);
            this.label_request.TabIndex = 50;
            this.label_request.Text = "label";
            this.label_request.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(476, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "id_request";
            // 
            // delete_request_bt
            // 
            this.delete_request_bt.Location = new System.Drawing.Point(672, 372);
            this.delete_request_bt.Name = "delete_request_bt";
            this.delete_request_bt.Size = new System.Drawing.Size(75, 23);
            this.delete_request_bt.TabIndex = 48;
            this.delete_request_bt.Text = "Delete";
            this.delete_request_bt.UseVisualStyleBackColor = true;
            this.delete_request_bt.Click += new System.EventHandler(this.Delete_request_bt_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(476, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Request:";
            // 
            // change_request_bt
            // 
            this.change_request_bt.Location = new System.Drawing.Point(591, 372);
            this.change_request_bt.Name = "change_request_bt";
            this.change_request_bt.Size = new System.Drawing.Size(75, 23);
            this.change_request_bt.TabIndex = 46;
            this.change_request_bt.Text = "Change";
            this.change_request_bt.UseVisualStyleBackColor = true;
            this.change_request_bt.Click += new System.EventHandler(this.Change_request_bt_Click);
            // 
            // id_request_tb
            // 
            this.id_request_tb.Location = new System.Drawing.Point(548, 42);
            this.id_request_tb.Name = "id_request_tb";
            this.id_request_tb.ReadOnly = true;
            this.id_request_tb.Size = new System.Drawing.Size(129, 20);
            this.id_request_tb.TabIndex = 44;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.price_service_tb);
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Controls.Add(this.add_service_bt);
            this.tabPage6.Controls.Add(this.label_service);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.delete_service_bt);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.change_service_bt);
            this.tabPage6.Controls.Add(this.id_service_tb);
            this.tabPage6.Controls.Add(this.name_service_tb);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(800, 428);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Services";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // price_service_tb
            // 
            this.price_service_tb.Location = new System.Drawing.Point(591, 98);
            this.price_service_tb.Name = "price_service_tb";
            this.price_service_tb.Size = new System.Drawing.Size(129, 20);
            this.price_service_tb.TabIndex = 51;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(0, 0);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.Size = new System.Drawing.Size(422, 428);
            this.dataGridView6.TabIndex = 49;
            this.dataGridView6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView6_CellContentClick);
            // 
            // add_service_bt
            // 
            this.add_service_bt.Location = new System.Drawing.Point(483, 264);
            this.add_service_bt.Name = "add_service_bt";
            this.add_service_bt.Size = new System.Drawing.Size(75, 23);
            this.add_service_bt.TabIndex = 47;
            this.add_service_bt.Text = "Add";
            this.add_service_bt.UseVisualStyleBackColor = true;
            this.add_service_bt.Click += new System.EventHandler(this.Add_service_bt_Click);
            // 
            // label_service
            // 
            this.label_service.AutoSize = true;
            this.label_service.ForeColor = System.Drawing.Color.Red;
            this.label_service.Location = new System.Drawing.Point(439, 337);
            this.label_service.Name = "label_service";
            this.label_service.Size = new System.Drawing.Size(29, 13);
            this.label_service.TabIndex = 50;
            this.label_service.Text = "label";
            this.label_service.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(476, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "id_service";
            // 
            // delete_service_bt
            // 
            this.delete_service_bt.Location = new System.Drawing.Point(645, 264);
            this.delete_service_bt.Name = "delete_service_bt";
            this.delete_service_bt.Size = new System.Drawing.Size(75, 23);
            this.delete_service_bt.TabIndex = 48;
            this.delete_service_bt.Text = "Delete";
            this.delete_service_bt.UseVisualStyleBackColor = true;
            this.delete_service_bt.Click += new System.EventHandler(this.Delete_service_bt_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(476, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(476, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 43;
            this.label21.Text = "Price";
            // 
            // change_service_bt
            // 
            this.change_service_bt.Location = new System.Drawing.Point(564, 264);
            this.change_service_bt.Name = "change_service_bt";
            this.change_service_bt.Size = new System.Drawing.Size(75, 23);
            this.change_service_bt.TabIndex = 46;
            this.change_service_bt.Text = "Change";
            this.change_service_bt.UseVisualStyleBackColor = true;
            this.change_service_bt.Click += new System.EventHandler(this.Change_service_bt_Click);
            // 
            // id_service_tb
            // 
            this.id_service_tb.Location = new System.Drawing.Point(591, 42);
            this.id_service_tb.Name = "id_service_tb";
            this.id_service_tb.ReadOnly = true;
            this.id_service_tb.Size = new System.Drawing.Size(129, 20);
            this.id_service_tb.TabIndex = 44;
            // 
            // name_service_tb
            // 
            this.name_service_tb.Location = new System.Drawing.Point(591, 68);
            this.name_service_tb.Name = "name_service_tb";
            this.name_service_tb.Size = new System.Drawing.Size(129, 20);
            this.name_service_tb.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.Client_tab);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cyvarevDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyvarevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Client_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.BindingSource cyvarevDataSetBindingSource;
        private cyvarevDataSet cyvarevDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox polis_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button change_client;
        private System.Windows.Forms.Button add_client;
        private System.Windows.Forms.Button delete_client;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Label label_client;
        private DateTimePicker datepick;
        private TabControl Client_tab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox spec_doc_tb;
        private DataGridView dataGridView2;
        private Button add_doc;
        private Label label_doc;
        private Label label7;
        private Button delete_doc;
        private Label label8;
        private Label label9;
        private Button change_doc;
        private TextBox id_doc_tb;
        private Label label10;
        private TextBox name_doc_tb;
        private TextBox phone_doc_tb;
        private TabPage tabPage3;
        private TextBox amount_item_tb;
        private DataGridView dataGridView3;
        private Button add_item_bt;
        private Label label_item;
        private Label label6;
        private Button delete_item_bt;
        private Label label11;
        private Label label12;
        private Button change_item_bt;
        private TextBox id_item_tb;
        private TextBox name_item_tb;
        private TabPage tabPage4;
        private DataGridView dataGridView4;
        private Button add_order_bt;
        private Label label_order;
        private Label label14;
        private Button delete_order_bt;
        private Label label15;
        private Button change_order_bt;
        private TextBox id_order_tb;
        private DateTimePicker datepick_order;
        private TabPage tabPage5;
      
        private DataGridView dataGridView5;
        private Button add_request_bt;
        private Label label_request;
        private Label label17;
        private Button delete_request_bt;
        private Label label18;
        
        private Button change_request_bt;
        private TextBox id_request_tb;
        
        private TextBox request_tb;
        private TabPage tabPage6;
        private TextBox price_service_tb;
        private DataGridView dataGridView6;
        private Button add_service_bt;
        private Label label_service;
        private Label label13;
        private Button delete_service_bt;
        private Label label20;
        private Label label21;
        private Button change_service_bt;
        private TextBox id_service_tb;
        private TextBox name_service_tb;
    }
}

