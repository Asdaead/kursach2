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
            this.label5 = new System.Windows.Forms.Label();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.cyvarevDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyvarevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(544, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id_client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of birth";
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(659, 66);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(129, 20);
            this.id_box.TabIndex = 4;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(659, 92);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(129, 20);
            this.name_box.TabIndex = 5;
            // 
            // polis_box
            // 
            this.polis_box.Location = new System.Drawing.Point(659, 148);
            this.polis_box.Name = "polis_box";
            this.polis_box.Size = new System.Drawing.Size(129, 20);
            this.polis_box.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Polis";
            // 
            // change_client
            // 
            this.change_client.Location = new System.Drawing.Point(632, 288);
            this.change_client.Name = "change_client";
            this.change_client.Size = new System.Drawing.Size(75, 23);
            this.change_client.TabIndex = 9;
            this.change_client.Text = "Change";
            this.change_client.UseVisualStyleBackColor = true;
            this.change_client.Click += new System.EventHandler(this.change_client_Click);
            // 
            // add_client
            // 
            this.add_client.Location = new System.Drawing.Point(551, 288);
            this.add_client.Name = "add_client";
            this.add_client.Size = new System.Drawing.Size(75, 23);
            this.add_client.TabIndex = 10;
            this.add_client.Text = "Add";
            this.add_client.UseVisualStyleBackColor = true;
            this.add_client.Click += new System.EventHandler(this.add_client_Click);
            // 
            // delete_client
            // 
            this.delete_client.Location = new System.Drawing.Point(713, 288);
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
            this.dataGridView1.Location = new System.Drawing.Point(2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(435, 449);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(467, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label";
            this.label5.Visible = false;
            // 
            // datepick
            // 
            this.datepick.Location = new System.Drawing.Point(659, 122);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(129, 20);
            this.datepick.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.datepick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_client);
            this.Controls.Add(this.add_client);
            this.Controls.Add(this.change_client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.polis_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cyvarevDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyvarevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label5;
        private DateTimePicker datepick;
    }
}

