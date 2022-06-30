
namespace Radionics
{
    partial class Ceramic_cond
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
            this.result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.TextBox();
            this.enterCapacity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Radionics.Properties.Resources.Сeram_con;
            this.pictureBox1.Location = new System.Drawing.Point(107, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(157, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "код → C";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(117, 268);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 17);
            this.result.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Результат:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(23, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 2);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(157, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "C → код";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Введіть ємність(в пФ):";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(288, 258);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(115, 37);
            this.Count.TabIndex = 7;
            this.Count.Text = "Розрахувати";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(305, 345);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(110, 37);
            this.submit.TabIndex = 8;
            this.submit.Text = "Підтвердити";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Location = new System.Drawing.Point(177, 111);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(50, 15);
            this.code.TabIndex = 9;
            this.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code_KeyPress);
            // 
            // enterCapacity
            // 
            this.enterCapacity.Location = new System.Drawing.Point(163, 352);
            this.enterCapacity.Name = "enterCapacity";
            this.enterCapacity.Size = new System.Drawing.Size(128, 22);
            this.enterCapacity.TabIndex = 10;
            this.enterCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterCapacity_KeyPress);
            // 
            // Ceramic_cond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 397);
            this.Controls.Add(this.enterCapacity);
            this.Controls.Add(this.code);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ceramic_cond";
            this.Text = "Ceramic_cond";
            this.Load += new System.EventHandler(this.Ceramic_cond_Load);
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
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox enterCapacity;
    }
}