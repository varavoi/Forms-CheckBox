namespace Forms_CheckBox
{
    partial class Form1
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
            this.bold = new System.Windows.Forms.CheckBox();
            this.underline = new System.Windows.Forms.CheckBox();
            this.italic = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bold
            // 
            this.bold.AutoSize = true;
            this.bold.Location = new System.Drawing.Point(50, 160);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(69, 17);
            this.bold.TabIndex = 0;
            this.bold.Text = "Жирный";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.CheckedChanged += new System.EventHandler(this.bold_CheckedChanged);
            // 
            // underline
            // 
            this.underline.AutoSize = true;
            this.underline.Location = new System.Drawing.Point(50, 183);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(92, 17);
            this.underline.TabIndex = 1;
            this.underline.Text = "Зачеркнутый";
            this.underline.UseVisualStyleBackColor = true;
            this.underline.CheckedChanged += new System.EventHandler(this.underline_CheckedChanged);
            // 
            // italic
            // 
            this.italic.AutoSize = true;
            this.italic.Location = new System.Drawing.Point(50, 206);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(62, 17);
            this.italic.TabIndex = 2;
            this.italic.Text = "Курсив";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.CheckedChanged += new System.EventHandler(this.italic_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 101);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбери стиль шрифта";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.italic);
            this.Controls.Add(this.underline);
            this.Controls.Add(this.bold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox bold;
        private System.Windows.Forms.CheckBox underline;
        private System.Windows.Forms.CheckBox italic;
        private System.Windows.Forms.Label label1;
    }
}

