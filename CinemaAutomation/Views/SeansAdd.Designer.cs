namespace CinemaAutomation.Views
{
    partial class SeansAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hallNameComboBox = new System.Windows.Forms.ComboBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startClockTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hallNameComboBox
            // 
            this.hallNameComboBox.FormattingEnabled = true;
            this.hallNameComboBox.Location = new System.Drawing.Point(169, 9);
            this.hallNameComboBox.Name = "hallNameComboBox";
            this.hallNameComboBox.Size = new System.Drawing.Size(200, 32);
            this.hallNameComboBox.TabIndex = 0;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(169, 47);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.startDateTimePicker.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(275, 127);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 33);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "İptal";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(169, 127);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 33);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salon İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Başlama Tarihi";
            // 
            // startClockTimePicker
            // 
            this.startClockTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startClockTimePicker.Location = new System.Drawing.Point(169, 82);
            this.startClockTimePicker.Name = "startClockTimePicker";
            this.startClockTimePicker.Size = new System.Drawing.Size(200, 29);
            this.startClockTimePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Başlama Saati";
            // 
            // SeansAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 172);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startClockTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.hallNameComboBox);
            this.Name = "SeansAdd";
            this.Text = "SeansAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hallNameComboBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startClockTimePicker;
        private System.Windows.Forms.Label label3;
    }
}