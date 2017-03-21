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
            this.SeanslarComboBox = new System.Windows.Forms.ComboBox();
            this.AddFilmButton = new System.Windows.Forms.Button();
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
            this.SeatsListPanel.Size = new System.Drawing.Size(1086, 416);
            this.SeatsListPanel.TabIndex = 0;
            // 
            // FilmComboBox
            // 
            this.FilmComboBox.FormattingEnabled = true;
            this.FilmComboBox.Location = new System.Drawing.Point(81, 12);
            this.FilmComboBox.Name = "FilmComboBox";
            this.FilmComboBox.Size = new System.Drawing.Size(309, 32);
            this.FilmComboBox.TabIndex = 1;
            this.FilmComboBox.SelectedIndexChanged += new System.EventHandler(this.FilmComboBox_SelectedIndexChanged);
            // 
            // SeanslarComboBox
            // 
            this.SeanslarComboBox.FormattingEnabled = true;
            this.SeanslarComboBox.Location = new System.Drawing.Point(396, 12);
            this.SeanslarComboBox.Name = "SeanslarComboBox";
            this.SeanslarComboBox.Size = new System.Drawing.Size(366, 32);
            this.SeanslarComboBox.TabIndex = 2;
            this.SeanslarComboBox.SelectedIndexChanged += new System.EventHandler(this.SeanslarComboBox_SelectedIndexChanged);
            // 
            // AddFilmButton
            // 
            this.AddFilmButton.Location = new System.Drawing.Point(12, 12);
            this.AddFilmButton.Name = "AddFilmButton";
            this.AddFilmButton.Size = new System.Drawing.Size(63, 32);
            this.AddFilmButton.TabIndex = 3;
            this.AddFilmButton.Text = "+";
            this.AddFilmButton.UseVisualStyleBackColor = true;
            this.AddFilmButton.Click += new System.EventHandler(this.AddFilmButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 484);
            this.Controls.Add(this.AddFilmButton);
            this.Controls.Add(this.SeanslarComboBox);
            this.Controls.Add(this.FilmComboBox);
            this.Controls.Add(this.SeatsListPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SeatsListPanel;
        private System.Windows.Forms.ComboBox FilmComboBox;
        private System.Windows.Forms.ComboBox SeanslarComboBox;
        private System.Windows.Forms.Button AddFilmButton;
    }
}

