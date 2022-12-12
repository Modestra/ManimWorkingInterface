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
            this.directoryLink = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.labelLink = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.CreateVideoButton.Click += new System.EventHandler(this.CreateVideoButton_Click);
            // 
            // videoQuality
            // 
            this.videoQuality.FormattingEnabled = true;
            this.videoQuality.Items.AddRange(new object[] {
            "Низкое",
            "Высокое"});
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
            // directoryLink
            // 
            this.directoryLink.Location = new System.Drawing.Point(12, 12);
            this.directoryLink.Name = "directoryLink";
            this.directoryLink.Size = new System.Drawing.Size(121, 23);
            this.directoryLink.TabIndex = 4;
            this.directoryLink.Text = "Путь к папке";
            this.directoryLink.UseVisualStyleBackColor = true;
            this.directoryLink.Click += new System.EventHandler(this.directoryLink_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(12, 38);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(44, 16);
            this.labelLink.TabIndex = 5;
            this.labelLink.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(148, 172);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(166, 111);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(151, 172);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pythons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Классы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.directoryLink);
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
        private System.Windows.Forms.Button directoryLink;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

