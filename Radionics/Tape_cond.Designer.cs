
namespace Radionics
{
    partial class Tape_cond
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
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.enterCopacity = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accuracy_literal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.accuracy_percent = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "код → C";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(128, 273);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 17);
            this.result.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ваш результат:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 2);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(169, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "C → код";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Введіть ємність(в пФ):";
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Location = new System.Drawing.Point(166, 119);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(52, 15);
            this.code.TabIndex = 7;
            this.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code_KeyPress);
            // 
            // enterCopacity
            // 
            this.enterCopacity.Location = new System.Drawing.Point(173, 387);
            this.enterCopacity.Name = "enterCopacity";
            this.enterCopacity.Size = new System.Drawing.Size(100, 22);
            this.enterCopacity.TabIndex = 8;
            this.enterCopacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterCopacity_KeyPress);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(255, 259);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(108, 31);
            this.Count.TabIndex = 9;
            this.Count.Text = "Розрахувати";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(289, 382);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(110, 32);
            this.submit.TabIndex = 10;
            this.submit.Text = "Підтвердити";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Radionics.Properties.Resources.Tape_cond;
            this.pictureBox1.Location = new System.Drawing.Point(71, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // accuracy_literal
            // 
            this.accuracy_literal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracy_literal.FormattingEnabled = true;
            this.accuracy_literal.Location = new System.Drawing.Point(224, 119);
            this.accuracy_literal.Name = "accuracy_literal";
            this.accuracy_literal.Size = new System.Drawing.Size(49, 24);
            this.accuracy_literal.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Оберіть точніть:";
            // 
            // accuracy_percent
            // 
            this.accuracy_percent.FormattingEnabled = true;
            this.accuracy_percent.Location = new System.Drawing.Point(134, 421);
            this.accuracy_percent.Name = "accuracy_percent";
            this.accuracy_percent.Size = new System.Drawing.Size(50, 24);
            this.accuracy_percent.TabIndex = 13;
            // 
            // Tape_cond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 461);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.accuracy_percent);
            this.Controls.Add(this.accuracy_literal);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.enterCopacity);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Tape_cond";
            this.Text = "Tape_cond";
            this.Load += new System.EventHandler(this.Tape_cond_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox enterCopacity;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox accuracy_literal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox accuracy_percent;
    }
}