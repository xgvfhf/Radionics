
namespace Radionics
{
    partial class Big_diametr
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
            this.Count_diam = new System.Windows.Forms.Button();
            this.Count_amper = new System.Windows.Forms.Button();
            this.diametr = new System.Windows.Forms.Label();
            this.amperage = new System.Windows.Forms.Label();
            this.amper = new System.Windows.Forms.TextBox();
            this.diam = new System.Windows.Forms.TextBox();
            this.material2 = new System.Windows.Forms.ComboBox();
            this.material1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Count_diam
            // 
            this.Count_diam.Location = new System.Drawing.Point(278, 364);
            this.Count_diam.Name = "Count_diam";
            this.Count_diam.Size = new System.Drawing.Size(110, 32);
            this.Count_diam.TabIndex = 33;
            this.Count_diam.Text = "Розрахувати";
            this.Count_diam.UseVisualStyleBackColor = true;
            this.Count_diam.Click += new System.EventHandler(this.Count_diam_Click);
            // 
            // Count_amper
            // 
            this.Count_amper.Location = new System.Drawing.Point(290, 168);
            this.Count_amper.Name = "Count_amper";
            this.Count_amper.Size = new System.Drawing.Size(109, 38);
            this.Count_amper.TabIndex = 32;
            this.Count_amper.Text = "Розрахувати";
            this.Count_amper.UseVisualStyleBackColor = true;
            this.Count_amper.Click += new System.EventHandler(this.Count_amper_Click);
            // 
            // diametr
            // 
            this.diametr.AutoSize = true;
            this.diametr.Location = new System.Drawing.Point(167, 372);
            this.diametr.Name = "diametr";
            this.diametr.Size = new System.Drawing.Size(0, 17);
            this.diametr.TabIndex = 31;
            // 
            // amperage
            // 
            this.amperage.AutoSize = true;
            this.amperage.Location = new System.Drawing.Point(144, 171);
            this.amperage.Name = "amperage";
            this.amperage.Size = new System.Drawing.Size(0, 17);
            this.amperage.TabIndex = 30;
            // 
            // amper
            // 
            this.amper.Location = new System.Drawing.Point(165, 322);
            this.amper.Name = "amper";
            this.amper.Size = new System.Drawing.Size(121, 22);
            this.amper.TabIndex = 29;
            this.amper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diam_KeyPress);
            // 
            // diam
            // 
            this.diam.Location = new System.Drawing.Point(147, 123);
            this.diam.Name = "diam";
            this.diam.Size = new System.Drawing.Size(121, 22);
            this.diam.TabIndex = 28;
            this.diam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diam_KeyPress);
            // 
            // material2
            // 
            this.material2.FormattingEnabled = true;
            this.material2.Location = new System.Drawing.Point(182, 274);
            this.material2.Name = "material2";
            this.material2.Size = new System.Drawing.Size(121, 24);
            this.material2.TabIndex = 27;
            // 
            // material1
            // 
            this.material1.FormattingEnabled = true;
            this.material1.Location = new System.Drawing.Point(182, 83);
            this.material1.Name = "material1";
            this.material1.Size = new System.Drawing.Size(121, 24);
            this.material1.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(15, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(411, 2);
            this.label9.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Сила струму (А):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Діаметр (в мм):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Сила струму (А):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Виберіть матеріал:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(114, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Розрахунок сили струму";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(123, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Розрахунок діаметра";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Діаметр (в мм):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Виберіть матеріал:";
            // 
            // Big_diametr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 423);
            this.Controls.Add(this.Count_diam);
            this.Controls.Add(this.Count_amper);
            this.Controls.Add(this.diametr);
            this.Controls.Add(this.amperage);
            this.Controls.Add(this.amper);
            this.Controls.Add(this.diam);
            this.Controls.Add(this.material2);
            this.Controls.Add(this.material1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Big_diametr";
            this.Text = "Big_diametr";
            this.Load += new System.EventHandler(this.Big_diametr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Count_diam;
        private System.Windows.Forms.Button Count_amper;
        private System.Windows.Forms.Label diametr;
        private System.Windows.Forms.Label amperage;
        private System.Windows.Forms.TextBox amper;
        private System.Windows.Forms.TextBox diam;
        private System.Windows.Forms.ComboBox material2;
        private System.Windows.Forms.ComboBox material1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}