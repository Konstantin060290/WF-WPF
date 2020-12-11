namespace ITMO.WFCS.L3U4
{
    partial class FilControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FilTextBox1 = new System.Windows.Forms.TextBox();
            this.FilTextBox2 = new System.Windows.Forms.TextBox();
            this.FilTextBox3 = new System.Windows.Forms.TextBox();
            this.Fillabel1 = new System.Windows.Forms.Label();
            this.Fillabel2 = new System.Windows.Forms.Label();
            this.Fillabel3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // FilTextBox1
            // 
            this.FilTextBox1.Location = new System.Drawing.Point(134, 22);
            this.FilTextBox1.Name = "FilTextBox1";
            this.FilTextBox1.Size = new System.Drawing.Size(225, 20);
            this.FilTextBox1.TabIndex = 0;
            this.FilTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.FilTextBox1_Validating_1);
            // 
            // FilTextBox2
            // 
            this.FilTextBox2.Location = new System.Drawing.Point(134, 61);
            this.FilTextBox2.Name = "FilTextBox2";
            this.FilTextBox2.Size = new System.Drawing.Size(225, 20);
            this.FilTextBox2.TabIndex = 0;
            this.FilTextBox2.TabStop = false;
            this.FilTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.FilTextBox2_Validating);
            // 
            // FilTextBox3
            // 
            this.FilTextBox3.Location = new System.Drawing.Point(134, 102);
            this.FilTextBox3.Name = "FilTextBox3";
            this.FilTextBox3.Size = new System.Drawing.Size(225, 20);
            this.FilTextBox3.TabIndex = 0;
            this.FilTextBox3.TabStop = false;
            this.FilTextBox3.Validating += new System.ComponentModel.CancelEventHandler(this.FilTextBox3_Validating);
            // 
            // Fillabel1
            // 
            this.Fillabel1.AutoSize = true;
            this.Fillabel1.Location = new System.Drawing.Point(78, 25);
            this.Fillabel1.Name = "Fillabel1";
            this.Fillabel1.Size = new System.Drawing.Size(56, 13);
            this.Fillabel1.TabIndex = 1;
            this.Fillabel1.Text = "Фамилия";
            // 
            // Fillabel2
            // 
            this.Fillabel2.AutoSize = true;
            this.Fillabel2.Location = new System.Drawing.Point(97, 64);
            this.Fillabel2.Name = "Fillabel2";
            this.Fillabel2.Size = new System.Drawing.Size(29, 13);
            this.Fillabel2.TabIndex = 1;
            this.Fillabel2.Text = "Имя";
            // 
            // Fillabel3
            // 
            this.Fillabel3.AutoSize = true;
            this.Fillabel3.Location = new System.Drawing.Point(74, 105);
            this.Fillabel3.Name = "Fillabel3";
            this.Fillabel3.Size = new System.Drawing.Size(54, 13);
            this.Fillabel3.TabIndex = 1;
            this.Fillabel3.Text = "Отчество";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // FilControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Fillabel3);
            this.Controls.Add(this.Fillabel2);
            this.Controls.Add(this.Fillabel1);
            this.Controls.Add(this.FilTextBox3);
            this.Controls.Add(this.FilTextBox2);
            this.Controls.Add(this.FilTextBox1);
            this.Name = "FilControl";
            this.Size = new System.Drawing.Size(488, 150);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Fillabel1;
        private System.Windows.Forms.Label Fillabel2;
        private System.Windows.Forms.Label Fillabel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        public System.Windows.Forms.TextBox FilTextBox1;
        public System.Windows.Forms.TextBox FilTextBox2;
        public System.Windows.Forms.TextBox FilTextBox3;
    }
}
