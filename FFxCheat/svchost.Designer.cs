
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
            this.butStart = new System.Windows.Forms.Button();
            this.butRadar = new System.Windows.Forms.Button();
            this.butJump = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(12, 12);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Wallhack";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butRadar
            // 
            this.butRadar.Location = new System.Drawing.Point(93, 12);
            this.butRadar.Name = "butRadar";
            this.butRadar.Size = new System.Drawing.Size(75, 23);
            this.butRadar.TabIndex = 1;
            this.butRadar.Text = "Radar";
            this.butRadar.UseVisualStyleBackColor = true;
            this.butRadar.Click += new System.EventHandler(this.butRadar_Click);
            // 
            // butJump
            // 
            this.butJump.Location = new System.Drawing.Point(174, 12);
            this.butJump.Name = "butJump";
            this.butJump.Size = new System.Drawing.Size(75, 23);
            this.butJump.TabIndex = 2;
            this.butJump.Text = "BunnyHope";
            this.butJump.UseVisualStyleBackColor = true;
            this.butJump.Click += new System.EventHandler(this.butJump_Click);
            // 
            // svchost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 41);
            this.Controls.Add(this.butJump);
            this.Controls.Add(this.butRadar);
            this.Controls.Add(this.butStart);
            this.Name = "svchost";
            this.Text = "svchost";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butRadar;
        private System.Windows.Forms.Button butJump;
    }
}

