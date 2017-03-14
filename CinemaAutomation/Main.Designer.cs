namespace CinemaAutomation
{
    partial class Main
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
            this.SeatsListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FilmComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SeatsListPanel
            // 
            this.SeatsListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeatsListPanel.AutoScroll = true;
            this.SeatsListPanel.Location = new System.Drawing.Point(0, 68);
            this.SeatsListPanel.Name = "SeatsListPanel";
            this.SeatsListPanel.Size = new System.Drawing.Size(1113, 416);
            this.SeatsListPanel.TabIndex = 0;
            // 
            // FilmComboBox
            // 
            this.FilmComboBox.FormattingEnabled = true;
            this.FilmComboBox.Location = new System.Drawing.Point(12, 12);
            this.FilmComboBox.Name = "FilmComboBox";
            this.FilmComboBox.Size = new System.Drawing.Size(309, 32);
            this.FilmComboBox.TabIndex = 1;
            this.FilmComboBox.SelectedIndexChanged += new System.EventHandler(this.FilmComboBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(396, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 32);
            this.comboBox1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 484);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.FilmComboBox);
            this.Controls.Add(this.SeatsListPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SeatsListPanel;
        private System.Windows.Forms.ComboBox FilmComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

