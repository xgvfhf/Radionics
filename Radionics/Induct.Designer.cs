﻿
namespace Radionics
{
    partial class Induct
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.line1 = new System.Windows.Forms.Label();
            this.line4 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Label();
            this.my_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Radionics.Properties.Resources.Induct;
            this.pictureBox1.Location = new System.Drawing.Point(42, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(284, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "маркеровка → L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "смуга 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "смуга 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "смуга 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "смуга 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ваш результат:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(275, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "L → маркеровка";
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(455, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            // 
            // comboBox2
            // 
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(455, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            // 
            // comboBox3
            // 
            this.comboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(455, 155);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 23);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            // 
            // comboBox4
            // 
            this.comboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(455, 185);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 23);
            this.comboBox4.TabIndex = 11;
            this.comboBox4.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(30, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(598, 2);
            this.label8.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Розрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(466, 352);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(121, 35);
            this.submit.TabIndex = 22;
            this.submit.Text = "Підтвердити";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 23;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Введіть індуктивність катушки(в мкГн):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Оберіть точніть:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(146, 388);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(95, 24);
            this.comboBox5.TabIndex = 26;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line1.Location = new System.Drawing.Point(140, 136);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(12, 53);
            this.line1.TabIndex = 27;
            // 
            // line4
            // 
            this.line4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line4.Location = new System.Drawing.Point(219, 136);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(12, 53);
            this.line4.TabIndex = 28;
            // 
            // line2
            // 
            this.line2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line2.Location = new System.Drawing.Point(158, 136);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(12, 53);
            this.line2.TabIndex = 29;
            // 
            // line3
            // 
            this.line3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line3.Location = new System.Drawing.Point(176, 136);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(12, 53);
            this.line3.TabIndex = 30;
            // 
            // my_result
            // 
            this.my_result.AutoSize = true;
            this.my_result.Location = new System.Drawing.Point(176, 264);
            this.my_result.Name = "my_result";
            this.my_result.Size = new System.Drawing.Size(0, 17);
            this.my_result.TabIndex = 31;
            // 
            // Induct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 441);
            this.Controls.Add(this.my_result);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Induct";
            this.Text = "Induct";
            this.Load += new System.EventHandler(this.Induct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label line4;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label line3;
        private System.Windows.Forms.Label my_result;
    }
}