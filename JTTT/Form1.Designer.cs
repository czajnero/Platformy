namespace JTTT
{
    partial class Form1
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
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxTekst = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonWykonaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tasksListBox = new System.Windows.Forms.ListBox();
            this.AddToListButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.DeserialButton = new System.Windows.Forms.Button();
            this.SerialButton = new System.Windows.Forms.Button();
            this.buttonDeleteFromDatabase = new System.Windows.Forms.Button();
            this.tabQuestion = new System.Windows.Forms.TabControl();
            this.tabFindText = new System.Windows.Forms.TabPage();
            this.tabWeather = new System.Windows.Forms.TabPage();
            this.comboBoxTemp = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMiasto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControlAction = new System.Windows.Forms.TabControl();
            this.tabPageEmail = new System.Windows.Forms.TabPage();
            this.tabPageShowResults = new System.Windows.Forms.TabPage();
            this.tabQuestion.SuspendLayout();
            this.tabFindText.SuspendLayout();
            this.tabWeather.SuspendLayout();
            this.tabControlAction.SuspendLayout();
            this.tabPageEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(45, 21);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(198, 20);
            this.textBoxURL.TabIndex = 0;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // textBoxTekst
            // 
            this.textBoxTekst.Location = new System.Drawing.Point(44, 59);
            this.textBoxTekst.Name = "textBoxTekst";
            this.textBoxTekst.Size = new System.Drawing.Size(198, 20);
            this.textBoxTekst.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(66, 32);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(198, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // buttonWykonaj
            // 
            this.buttonWykonaj.Location = new System.Drawing.Point(431, 247);
            this.buttonWykonaj.Name = "buttonWykonaj";
            this.buttonWykonaj.Size = new System.Drawing.Size(248, 47);
            this.buttonWykonaj.TabIndex = 3;
            this.buttonWykonaj.Text = "Wykonaj!";
            this.buttonWykonaj.UseVisualStyleBackColor = true;
            this.buttonWykonaj.Click += new System.EventHandler(this.buttonWykonaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tekst:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(56, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "to wykonaj to:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(88, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jeżeli";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(184, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "to:";
            // 
            // tasksListBox
            // 
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.Location = new System.Drawing.Point(431, 19);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(248, 173);
            this.tasksListBox.TabIndex = 10;
            this.tasksListBox.SelectedIndexChanged += new System.EventHandler(this.tasksListBox_SelectedIndexChanged);
            // 
            // AddToListButton
            // 
            this.AddToListButton.Location = new System.Drawing.Point(94, 369);
            this.AddToListButton.Name = "AddToListButton";
            this.AddToListButton.Size = new System.Drawing.Size(197, 47);
            this.AddToListButton.TabIndex = 11;
            this.AddToListButton.Text = "Dodaj do listy";
            this.AddToListButton.UseVisualStyleBackColor = true;
            this.AddToListButton.Click += new System.EventHandler(this.AddToListButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(511, 198);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(75, 47);
            this.CleanButton.TabIndex = 12;
            this.CleanButton.Text = "Czyść!";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // DeserialButton
            // 
            this.DeserialButton.Location = new System.Drawing.Point(592, 198);
            this.DeserialButton.Name = "DeserialButton";
            this.DeserialButton.Size = new System.Drawing.Size(87, 21);
            this.DeserialButton.TabIndex = 13;
            this.DeserialButton.Text = "Deserializacja";
            this.DeserialButton.UseVisualStyleBackColor = true;
            this.DeserialButton.Click += new System.EventHandler(this.DeserialButton_Click);
            // 
            // SerialButton
            // 
            this.SerialButton.Location = new System.Drawing.Point(592, 225);
            this.SerialButton.Name = "SerialButton";
            this.SerialButton.Size = new System.Drawing.Size(87, 20);
            this.SerialButton.TabIndex = 14;
            this.SerialButton.Text = "Serializacja";
            this.SerialButton.UseVisualStyleBackColor = true;
            this.SerialButton.Click += new System.EventHandler(this.SerialButton_Click);
            // 
            // buttonDeleteFromDatabase
            // 
            this.buttonDeleteFromDatabase.Location = new System.Drawing.Point(431, 198);
            this.buttonDeleteFromDatabase.Name = "buttonDeleteFromDatabase";
            this.buttonDeleteFromDatabase.Size = new System.Drawing.Size(75, 47);
            this.buttonDeleteFromDatabase.TabIndex = 15;
            this.buttonDeleteFromDatabase.Text = "Usuń";
            this.buttonDeleteFromDatabase.UseVisualStyleBackColor = true;
            this.buttonDeleteFromDatabase.Click += new System.EventHandler(this.buttonDeleteFromDatabase_Click);
            // 
            // tabQuestion
            // 
            this.tabQuestion.Controls.Add(this.tabFindText);
            this.tabQuestion.Controls.Add(this.tabWeather);
            this.tabQuestion.Location = new System.Drawing.Point(12, 53);
            this.tabQuestion.Name = "tabQuestion";
            this.tabQuestion.SelectedIndex = 0;
            this.tabQuestion.Size = new System.Drawing.Size(392, 139);
            this.tabQuestion.TabIndex = 16;
            // 
            // tabFindText
            // 
            this.tabFindText.Controls.Add(this.textBoxURL);
            this.tabFindText.Controls.Add(this.label1);
            this.tabFindText.Controls.Add(this.label2);
            this.tabFindText.Controls.Add(this.textBoxTekst);
            this.tabFindText.Location = new System.Drawing.Point(4, 22);
            this.tabFindText.Name = "tabFindText";
            this.tabFindText.Padding = new System.Windows.Forms.Padding(3);
            this.tabFindText.Size = new System.Drawing.Size(384, 113);
            this.tabFindText.TabIndex = 0;
            this.tabFindText.Text = "Sprawdź stronę";
            this.tabFindText.UseVisualStyleBackColor = true;
            this.tabFindText.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabWeather
            // 
            this.tabWeather.Controls.Add(this.comboBoxTemp);
            this.tabWeather.Controls.Add(this.label9);
            this.tabWeather.Controls.Add(this.textBoxMiasto);
            this.tabWeather.Controls.Add(this.label8);
            this.tabWeather.Controls.Add(this.label7);
            this.tabWeather.Location = new System.Drawing.Point(4, 22);
            this.tabWeather.Name = "tabWeather";
            this.tabWeather.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeather.Size = new System.Drawing.Size(384, 113);
            this.tabWeather.TabIndex = 1;
            this.tabWeather.Text = "Sprawdź pogodę";
            this.tabWeather.UseVisualStyleBackColor = true;
            // 
            // comboBoxTemp
            // 
            this.comboBoxTemp.FormattingEnabled = true;
            this.comboBoxTemp.Location = new System.Drawing.Point(108, 75);
            this.comboBoxTemp.Name = "comboBoxTemp";
            this.comboBoxTemp.Size = new System.Drawing.Size(133, 21);
            this.comboBoxTemp.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Temperatura";
            // 
            // textBoxMiasto
            // 
            this.textBoxMiasto.Location = new System.Drawing.Point(109, 44);
            this.textBoxMiasto.Name = "textBoxMiasto";
            this.textBoxMiasto.Size = new System.Drawing.Size(132, 20);
            this.textBoxMiasto.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Miasto";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Temperatura w tym mieście jest wyższa niż wartość: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(701, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 173);
            this.listBox1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 26);
            this.label10.TabIndex = 7;
            this.label10.Text = "Podaj adres mailowy\r\n\r\n";
            // 
            // tabControlAction
            // 
            this.tabControlAction.Controls.Add(this.tabPageEmail);
            this.tabControlAction.Controls.Add(this.tabPageShowResults);
            this.tabControlAction.Location = new System.Drawing.Point(41, 229);
            this.tabControlAction.Name = "tabControlAction";
            this.tabControlAction.SelectedIndex = 0;
            this.tabControlAction.Size = new System.Drawing.Size(312, 100);
            this.tabControlAction.TabIndex = 19;
            // 
            // tabPageEmail
            // 
            this.tabPageEmail.Controls.Add(this.textBoxEmail);
            this.tabPageEmail.Controls.Add(this.label10);
            this.tabPageEmail.Controls.Add(this.label3);
            this.tabPageEmail.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmail.Name = "tabPageEmail";
            this.tabPageEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmail.Size = new System.Drawing.Size(304, 74);
            this.tabPageEmail.TabIndex = 0;
            this.tabPageEmail.Text = "Wyślij maila";
            this.tabPageEmail.UseVisualStyleBackColor = true;
            // 
            // tabPageShowResults
            // 
            this.tabPageShowResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageShowResults.Name = "tabPageShowResults";
            this.tabPageShowResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShowResults.Size = new System.Drawing.Size(304, 74);
            this.tabPageShowResults.TabIndex = 1;
            this.tabPageShowResults.Text = "Pokaż komunikat";
            this.tabPageShowResults.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 445);
            this.Controls.Add(this.tabControlAction);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabQuestion);
            this.Controls.Add(this.buttonDeleteFromDatabase);
            this.Controls.Add(this.SerialButton);
            this.Controls.Add(this.DeserialButton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.AddToListButton);
            this.Controls.Add(this.tasksListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonWykonaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabQuestion.ResumeLayout(false);
            this.tabFindText.ResumeLayout(false);
            this.tabFindText.PerformLayout();
            this.tabWeather.ResumeLayout(false);
            this.tabWeather.PerformLayout();
            this.tabControlAction.ResumeLayout(false);
            this.tabPageEmail.ResumeLayout(false);
            this.tabPageEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TextBox textBoxTekst;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonWykonaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox tasksListBox;
        private System.Windows.Forms.Button AddToListButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button DeserialButton;
        private System.Windows.Forms.Button SerialButton;
        private System.Windows.Forms.Button buttonDeleteFromDatabase;
        private System.Windows.Forms.TabControl tabQuestion;
        private System.Windows.Forms.TabPage tabFindText;
        private System.Windows.Forms.TabPage tabWeather;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMiasto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControlAction;
        private System.Windows.Forms.TabPage tabPageEmail;
        private System.Windows.Forms.TabPage tabPageShowResults;
    }
}

