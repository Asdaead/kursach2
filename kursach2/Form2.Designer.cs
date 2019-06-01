namespace kursach2
{
    partial class Form2
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
            this.logintl = new System.Windows.Forms.Label();
            this.passtl = new System.Windows.Forms.Label();
            this.enterbt = new System.Windows.Forms.Button();
            this.passtb = new System.Windows.Forms.TextBox();
            this.logintb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logintl
            // 
            this.logintl.AutoSize = true;
            this.logintl.Location = new System.Drawing.Point(116, 72);
            this.logintl.Name = "logintl";
            this.logintl.Size = new System.Drawing.Size(38, 13);
            this.logintl.TabIndex = 0;
            this.logintl.Text = "Логин";
            // 
            // passtl
            // 
            this.passtl.AutoSize = true;
            this.passtl.Location = new System.Drawing.Point(116, 120);
            this.passtl.Name = "passtl";
            this.passtl.Size = new System.Drawing.Size(45, 13);
            this.passtl.TabIndex = 1;
            this.passtl.Text = "Пароль";
            // 
            // enterbt
            // 
            this.enterbt.Location = new System.Drawing.Point(119, 180);
            this.enterbt.Name = "enterbt";
            this.enterbt.Size = new System.Drawing.Size(62, 31);
            this.enterbt.TabIndex = 2;
            this.enterbt.Text = "Вход";
            this.enterbt.UseVisualStyleBackColor = true;
            this.enterbt.Click += new System.EventHandler(this.Enterbt_Click);
            // 
            // passtb
            // 
            this.passtb.Location = new System.Drawing.Point(199, 120);
            this.passtb.Name = "passtb";
            this.passtb.Size = new System.Drawing.Size(103, 20);
            this.passtb.TabIndex = 4;
            // 
            // logintb
            // 
            this.logintb.Location = new System.Drawing.Point(199, 69);
            this.logintb.Name = "logintb";
            this.logintb.Size = new System.Drawing.Size(103, 20);
            this.logintb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(113, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Авторизация";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logintb);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.enterbt);
            this.Controls.Add(this.passtl);
            this.Controls.Add(this.logintl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logintl;
        private System.Windows.Forms.Label passtl;
        private System.Windows.Forms.Button enterbt;
        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.TextBox logintb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}