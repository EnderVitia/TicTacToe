namespace TicTacToe
{
    partial class StartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Start3x3 = new System.Windows.Forms.Button();
            this.Start4x4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Крестики-нолики";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start3x3
            // 
            this.Start3x3.Location = new System.Drawing.Point(120, 134);
            this.Start3x3.Name = "Start3x3";
            this.Start3x3.Size = new System.Drawing.Size(148, 36);
            this.Start3x3.TabIndex = 1;
            this.Start3x3.Text = "3X3";
            this.Start3x3.UseVisualStyleBackColor = true;
            this.Start3x3.Click += new System.EventHandler(this.Start3x3_Click);
            // 
            // Start4x4
            // 
            this.Start4x4.Location = new System.Drawing.Point(120, 203);
            this.Start4x4.Name = "Start4x4";
            this.Start4x4.Size = new System.Drawing.Size(148, 36);
            this.Start4x4.TabIndex = 2;
            this.Start4x4.Text = "4X4";
            this.Start4x4.UseVisualStyleBackColor = true;
            this.Start4x4.Click += new System.EventHandler(this.Start4x4_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 315);
            this.Controls.Add(this.Start4x4);
            this.Controls.Add(this.Start3x3);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.Text = "Крестики-нолики";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start3x3;
        private System.Windows.Forms.Button Start4x4;
    }
}

