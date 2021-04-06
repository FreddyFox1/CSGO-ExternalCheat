
namespace FFx
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
            this.cbFh = new System.Windows.Forms.CheckBox();
            this.cbBh = new System.Windows.Forms.CheckBox();
            this.cbRh = new System.Windows.Forms.CheckBox();
            this.cbWh = new System.Windows.Forms.CheckBox();
            this.butStart = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFh);
            this.groupBox1.Controls.Add(this.cbBh);
            this.groupBox1.Controls.Add(this.cbRh);
            this.groupBox1.Controls.Add(this.cbWh);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор";
            // 
            // cbFh
            // 
            this.cbFh.AutoSize = true;
            this.cbFh.Checked = true;
            this.cbFh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFh.Location = new System.Drawing.Point(5, 82);
            this.cbFh.Name = "cbFh";
            this.cbFh.Size = new System.Drawing.Size(77, 17);
            this.cbFh.TabIndex = 3;
            this.cbFh.Text = "FlashHack";
            this.cbFh.UseVisualStyleBackColor = true;
            // 
            // cbBh
            // 
            this.cbBh.AutoSize = true;
            this.cbBh.Checked = true;
            this.cbBh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBh.Location = new System.Drawing.Point(5, 61);
            this.cbBh.Name = "cbBh";
            this.cbBh.Size = new System.Drawing.Size(82, 17);
            this.cbBh.TabIndex = 2;
            this.cbBh.Text = "BannyHope";
            this.cbBh.UseVisualStyleBackColor = true;
            // 
            // cbRh
            // 
            this.cbRh.AutoSize = true;
            this.cbRh.Checked = true;
            this.cbRh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRh.Location = new System.Drawing.Point(5, 40);
            this.cbRh.Name = "cbRh";
            this.cbRh.Size = new System.Drawing.Size(81, 17);
            this.cbRh.TabIndex = 1;
            this.cbRh.Text = "RadarHack";
            this.cbRh.UseVisualStyleBackColor = true;
            // 
            // cbWh
            // 
            this.cbWh.AutoSize = true;
            this.cbWh.Checked = true;
            this.cbWh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWh.Location = new System.Drawing.Point(5, 19);
            this.cbWh.Name = "cbWh";
            this.cbWh.Size = new System.Drawing.Size(73, 17);
            this.cbWh.TabIndex = 0;
            this.cbWh.Text = "WallHack";
            this.cbWh.UseVisualStyleBackColor = true;
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(15, 124);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 1;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            this.colorDialog.SolidColorOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(55, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "created by FFx";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // svchost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(185, 169);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "svchost";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "svchost";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbBh;
        private System.Windows.Forms.CheckBox cbRh;
        private System.Windows.Forms.CheckBox cbWh;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.CheckBox cbFh;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

