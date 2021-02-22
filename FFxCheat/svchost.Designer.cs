
namespace FFxCheat
{
    partial class svchost
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbWh = new System.Windows.Forms.CheckBox();
            this.cbRh = new System.Windows.Forms.CheckBox();
            this.cbBh = new System.Windows.Forms.CheckBox();
            this.butStart = new System.Windows.Forms.Button();
            this.cbFh = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFh);
            this.groupBox1.Controls.Add(this.cbBh);
            this.groupBox1.Controls.Add(this.cbRh);
            this.groupBox1.Controls.Add(this.cbWh);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор";
            // 
            // cbWh
            // 
            this.cbWh.AutoSize = true;
            this.cbWh.Location = new System.Drawing.Point(5, 19);
            this.cbWh.Name = "cbWh";
            this.cbWh.Size = new System.Drawing.Size(73, 17);
            this.cbWh.TabIndex = 0;
            this.cbWh.Text = "WallHack";
            this.cbWh.UseVisualStyleBackColor = true;
            // 
            // cbRh
            // 
            this.cbRh.AutoSize = true;
            this.cbRh.Location = new System.Drawing.Point(5, 40);
            this.cbRh.Name = "cbRh";
            this.cbRh.Size = new System.Drawing.Size(81, 17);
            this.cbRh.TabIndex = 1;
            this.cbRh.Text = "RadarHack";
            this.cbRh.UseVisualStyleBackColor = true;
            // 
            // cbBh
            // 
            this.cbBh.AutoSize = true;
            this.cbBh.Location = new System.Drawing.Point(5, 61);
            this.cbBh.Name = "cbBh";
            this.cbBh.Size = new System.Drawing.Size(82, 17);
            this.cbBh.TabIndex = 2;
            this.cbBh.Text = "BannyHope";
            this.cbBh.UseVisualStyleBackColor = true;
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(24, 124);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 1;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            // 
            // cbFh
            // 
            this.cbFh.AutoSize = true;
            this.cbFh.Location = new System.Drawing.Point(5, 82);
            this.cbFh.Name = "cbFh";
            this.cbFh.Size = new System.Drawing.Size(77, 17);
            this.cbFh.TabIndex = 3;
            this.cbFh.Text = "FlashHack";
            this.cbFh.UseVisualStyleBackColor = true;
            // 
            // svchost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(130, 151);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "svchost";
            this.Text = "svchost";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbBh;
        private System.Windows.Forms.CheckBox cbRh;
        private System.Windows.Forms.CheckBox cbWh;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.CheckBox cbFh;
    }
}

