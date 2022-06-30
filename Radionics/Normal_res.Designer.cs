
namespace Radionics
{
    partial class Normal_res
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
            this.line1 = new System.Windows.Forms.Label();
            this.line4 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Label();
            this.ColorOfLine1 = new System.Windows.Forms.ComboBox();
            this.ColorOfLine2 = new System.Windows.Forms.ComboBox();
            this.ColorOfLine3 = new System.Windows.Forms.ComboBox();
            this.ColorOfLine4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.my_result = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Button();
            this.resistance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.accuracy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Radionics.Properties.Resources.resistor;
            this.pictureBox1.Location = new System.Drawing.Point(30, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(161, 134);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 47);
            this.line1.TabIndex = 1;
            this.line1.Text = " ";
            // 
            // line4
            // 
            this.line4.Location = new System.Drawing.Point(231, 134);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(10, 47);
            this.line4.TabIndex = 2;
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(189, 137);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(9, 40);
            this.line2.TabIndex = 3;
            this.line2.Text = " ";
            // 
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(204, 137);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(9, 40);
            this.line3.TabIndex = 4;
            // 
            // ColorOfLine1
            // 
            this.ColorOfLine1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ColorOfLine1.FormattingEnabled = true;
            this.ColorOfLine1.Location = new System.Drawing.Point(497, 74);
            this.ColorOfLine1.Name = "ColorOfLine1";
            this.ColorOfLine1.Size = new System.Drawing.Size(121, 23);
            this.ColorOfLine1.TabIndex = 5;
            this.ColorOfLine1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ColorOfLine1_DrawItem);
            // 
            // ColorOfLine2
            // 
            this.ColorOfLine2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ColorOfLine2.FormattingEnabled = true;
            this.ColorOfLine2.Location = new System.Drawing.Point(497, 116);
            this.ColorOfLine2.Name = "ColorOfLine2";
            this.ColorOfLine2.Size = new System.Drawing.Size(121, 23);
            this.ColorOfLine2.TabIndex = 6;
            this.ColorOfLine2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ColorOfLine1_DrawItem);
            // 
            // ColorOfLine3
            // 
            this.ColorOfLine3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ColorOfLine3.FormattingEnabled = true;
            this.ColorOfLine3.Location = new System.Drawing.Point(497, 157);
            this.ColorOfLine3.Name = "ColorOfLine3";
            this.ColorOfLine3.Size = new System.Drawing.Size(121, 23);
            this.ColorOfLine3.TabIndex = 7;
            this.ColorOfLine3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ColorOfLine1_DrawItem);
            // 
            // ColorOfLine4
            // 
            this.ColorOfLine4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ColorOfLine4.FormattingEnabled = true;
            this.ColorOfLine4.Location = new System.Drawing.Point(497, 199);
            this.ColorOfLine4.Name = "ColorOfLine4";
            this.ColorOfLine4.Size = new System.Drawing.Size(121, 23);
            this.ColorOfLine4.TabIndex = 8;
            this.ColorOfLine4.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ColorOfLine1_DrawItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "смуга 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "смуга 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "смуга 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "смуга 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(253, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "маркеровка → Ω";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ваш результат:";
            // 
            // my_result
            // 
            this.my_result.AutoSize = true;
            this.my_result.Location = new System.Drawing.Point(179, 286);
            this.my_result.Name = "my_result";
            this.my_result.Size = new System.Drawing.Size(0, 17);
            this.my_result.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(42, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(576, 2);
            this.label7.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(253, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ω → маркеровка";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(479, 277);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(121, 35);
            this.count.TabIndex = 18;
            this.count.Text = "Розрахувати";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // resistance
            // 
            this.resistance.Location = new System.Drawing.Point(257, 391);
            this.resistance.Name = "resistance";
            this.resistance.Size = new System.Drawing.Size(163, 22);
            this.resistance.TabIndex = 19;
            this.resistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resistance_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Введіть опір резистора(в Ом):";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(443, 385);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(121, 35);
            this.submit.TabIndex = 21;
            this.submit.Text = "Підтвердити";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // accuracy
            // 
            this.accuracy.FormattingEnabled = true;
            this.accuracy.Location = new System.Drawing.Point(257, 419);
            this.accuracy.Name = "accuracy";
            this.accuracy.Size = new System.Drawing.Size(121, 24);
            this.accuracy.TabIndex = 22;
            this.accuracy.SelectedIndexChanged += new System.EventHandler(this.accuracy_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Оберіть точніть:";
            // 
            // Normal_res
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 463);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.accuracy);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resistance);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.my_result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorOfLine4);
            this.Controls.Add(this.ColorOfLine3);
            this.Controls.Add(this.ColorOfLine2);
            this.Controls.Add(this.ColorOfLine1);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(23, 20);
            this.Name = "Normal_res";
            this.Text = "Normal_res";
            this.Load += new System.EventHandler(this.Normal_res_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label line4;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label line3;
        private System.Windows.Forms.ComboBox ColorOfLine1;
        private System.Windows.Forms.ComboBox ColorOfLine2;
        private System.Windows.Forms.ComboBox ColorOfLine3;
        private System.Windows.Forms.ComboBox ColorOfLine4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label my_result;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.TextBox resistance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox accuracy;
        private System.Windows.Forms.Label label10;
    }
}