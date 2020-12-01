namespace ITMO.WFCS.L3U4NEWAPPL
{
    partial class FilForm1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.filControl1 = new ITMO.WFCS.L3U4.FilControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО (кликните в поле)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(217, 228);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(333, 112);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click_1);
            // 
            // filControl1
            // 
            this.filControl1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.filControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filControl1.Location = new System.Drawing.Point(131, 46);
            this.filControl1.Name = "filControl1";
            this.filControl1.Size = new System.Drawing.Size(488, 150);
            this.filControl1.TabIndex = 0;
            this.filControl1.Load += new System.EventHandler(this.filControl1_Load);
            this.filControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filControl1_KeyPress);
            // 
            // FilForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.filControl1);
            this.Name = "FilForm1";
            this.Text = "Мое приложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private L3U4.FilControl filControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

