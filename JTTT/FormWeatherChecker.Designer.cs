namespace JTTT
{
    partial class FormWeatherChecker
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
            this.label1 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CityButton = new System.Windows.Forms.Button();
            this.WeatherDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miasto:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CityTextBox.Location = new System.Drawing.Point(75, 39);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(363, 24);
            this.CityTextBox.TabIndex = 1;
            // 
            // CityButton
            // 
            this.CityButton.Location = new System.Drawing.Point(75, 80);
            this.CityButton.Name = "CityButton";
            this.CityButton.Size = new System.Drawing.Size(363, 46);
            this.CityButton.TabIndex = 2;
            this.CityButton.Text = "Jaka jest pogoda?";
            this.CityButton.UseVisualStyleBackColor = true;
            this.CityButton.Click += new System.EventHandler(this.CityButton_Click);
            // 
            // WeatherDescriptionTextBox
            // 
            this.WeatherDescriptionTextBox.Location = new System.Drawing.Point(75, 143);
            this.WeatherDescriptionTextBox.Name = "WeatherDescriptionTextBox";
            this.WeatherDescriptionTextBox.Size = new System.Drawing.Size(245, 96);
            this.WeatherDescriptionTextBox.TabIndex = 3;
            this.WeatherDescriptionTextBox.Text = "";
            this.WeatherDescriptionTextBox.TextChanged += new System.EventHandler(this.WeatherDescriptionTextBox_TextChanged);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(338, 143);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(100, 96);
            this.PictureBox.TabIndex = 4;
            this.PictureBox.TabStop = false;
            // 
            // FormWeatherChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 260);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.WeatherDescriptionTextBox);
            this.Controls.Add(this.CityButton);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormWeatherChecker";
            this.Text = "FormWeatherChecker";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Button CityButton;
        private System.Windows.Forms.RichTextBox WeatherDescriptionTextBox;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}