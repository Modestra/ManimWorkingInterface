namespace ManimInterface
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
            this.CreateVideoButton = new System.Windows.Forms.Button();
            this.videoQuality = new System.Windows.Forms.ComboBox();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateVideoButton
            // 
            this.CreateVideoButton.Location = new System.Drawing.Point(139, 315);
            this.CreateVideoButton.Name = "CreateVideoButton";
            this.CreateVideoButton.Size = new System.Drawing.Size(178, 42);
            this.CreateVideoButton.TabIndex = 0;
            this.CreateVideoButton.Text = "Создать";
            this.CreateVideoButton.UseVisualStyleBackColor = true;
            // 
            // videoQuality
            // 
            this.videoQuality.FormattingEnabled = true;
            this.videoQuality.Location = new System.Drawing.Point(12, 315);
            this.videoQuality.Name = "videoQuality";
            this.videoQuality.Size = new System.Drawing.Size(121, 24);
            this.videoQuality.TabIndex = 2;
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(12, 286);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(112, 16);
            this.qualityLabel.TabIndex = 3;
            this.qualityLabel.Text = "Качество видео";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 369);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.videoQuality);
            this.Controls.Add(this.CreateVideoButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateVideoButton;
        private System.Windows.Forms.ComboBox videoQuality;
        private System.Windows.Forms.Label qualityLabel;
    }
}

