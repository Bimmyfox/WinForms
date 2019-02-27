namespace TestTask
{
    partial class MainWindow
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
            this.beginProcessing = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // beginProcessing
            // 
            this.beginProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.beginProcessing.Location = new System.Drawing.Point(168, 56);
            this.beginProcessing.Name = "beginProcessing";
            this.beginProcessing.Size = new System.Drawing.Size(241, 92);
            this.beginProcessing.TabIndex = 0;
            this.beginProcessing.Text = "Begin Processing";
            this.beginProcessing.UseVisualStyleBackColor = true;
            this.beginProcessing.Click += new System.EventHandler(this.beginProcessing_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.Location = new System.Drawing.Point(230, 202);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(108, 18);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Message Label";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 256);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.beginProcessing);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginProcessing;
        private System.Windows.Forms.Label messageLabel;
    }
}

