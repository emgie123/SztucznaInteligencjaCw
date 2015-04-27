namespace SztucznaIntCw
{
    partial class MainWindow
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
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.activityGroupBox = new System.Windows.Forms.GroupBox();
            this.activityHighRadioButton = new System.Windows.Forms.RadioButton();
            this.activityMediumRadioButton = new System.Windows.Forms.RadioButton();
            this.activitySmallRadioButton = new System.Windows.Forms.RadioButton();
            this.physiqueGroupBox = new System.Windows.Forms.GroupBox();
            this.endoRadioButton = new System.Windows.Forms.RadioButton();
            this.mezoRadioButton = new System.Windows.Forms.RadioButton();
            this.ektoRadioButton = new System.Windows.Forms.RadioButton();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.inputDataTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.simpleDataRadioButton = new System.Windows.Forms.RadioButton();
            this.detailsDataRadioButton = new System.Windows.Forms.RadioButton();
            this.neededKcalLabel = new System.Windows.Forms.Label();
            this.dataGroupBox.SuspendLayout();
            this.activityGroupBox.SuspendLayout();
            this.physiqueGroupBox.SuspendLayout();
            this.inputDataTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.calculateButton);
            this.dataGroupBox.Controls.Add(this.activityGroupBox);
            this.dataGroupBox.Controls.Add(this.physiqueGroupBox);
            this.dataGroupBox.Controls.Add(this.heightTextBox);
            this.dataGroupBox.Controls.Add(this.weightTextBox);
            this.dataGroupBox.Controls.Add(this.heightLabel);
            this.dataGroupBox.Controls.Add(this.weightLabel);
            this.dataGroupBox.Controls.Add(this.genderTextBox);
            this.dataGroupBox.Controls.Add(this.genderLabel);
            this.dataGroupBox.Location = new System.Drawing.Point(12, 99);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(296, 264);
            this.dataGroupBox.TabIndex = 0;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Dane";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(215, 235);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Oblicz";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // activityGroupBox
            // 
            this.activityGroupBox.Controls.Add(this.activityHighRadioButton);
            this.activityGroupBox.Controls.Add(this.activityMediumRadioButton);
            this.activityGroupBox.Controls.Add(this.activitySmallRadioButton);
            this.activityGroupBox.Location = new System.Drawing.Point(6, 171);
            this.activityGroupBox.Name = "activityGroupBox";
            this.activityGroupBox.Size = new System.Drawing.Size(284, 52);
            this.activityGroupBox.TabIndex = 8;
            this.activityGroupBox.TabStop = false;
            this.activityGroupBox.Text = "Aktywność fizyczna";
            // 
            // activityHighRadioButton
            // 
            this.activityHighRadioButton.AutoSize = true;
            this.activityHighRadioButton.Location = new System.Drawing.Point(173, 20);
            this.activityHighRadioButton.Name = "activityHighRadioButton";
            this.activityHighRadioButton.Size = new System.Drawing.Size(50, 17);
            this.activityHighRadioButton.TabIndex = 2;
            this.activityHighRadioButton.TabStop = true;
            this.activityHighRadioButton.Text = "Duża";
            this.activityHighRadioButton.UseVisualStyleBackColor = true;
            // 
            // activityMediumRadioButton
            // 
            this.activityMediumRadioButton.AutoSize = true;
            this.activityMediumRadioButton.Location = new System.Drawing.Point(88, 20);
            this.activityMediumRadioButton.Name = "activityMediumRadioButton";
            this.activityMediumRadioButton.Size = new System.Drawing.Size(61, 17);
            this.activityMediumRadioButton.TabIndex = 1;
            this.activityMediumRadioButton.TabStop = true;
            this.activityMediumRadioButton.Text = "Średnia";
            this.activityMediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // activitySmallRadioButton
            // 
            this.activitySmallRadioButton.AutoSize = true;
            this.activitySmallRadioButton.Location = new System.Drawing.Point(7, 20);
            this.activitySmallRadioButton.Name = "activitySmallRadioButton";
            this.activitySmallRadioButton.Size = new System.Drawing.Size(50, 17);
            this.activitySmallRadioButton.TabIndex = 0;
            this.activitySmallRadioButton.TabStop = true;
            this.activitySmallRadioButton.Text = "Mała";
            this.activitySmallRadioButton.UseVisualStyleBackColor = true;
            // 
            // physiqueGroupBox
            // 
            this.physiqueGroupBox.Controls.Add(this.endoRadioButton);
            this.physiqueGroupBox.Controls.Add(this.mezoRadioButton);
            this.physiqueGroupBox.Controls.Add(this.ektoRadioButton);
            this.physiqueGroupBox.Location = new System.Drawing.Point(6, 113);
            this.physiqueGroupBox.Name = "physiqueGroupBox";
            this.physiqueGroupBox.Size = new System.Drawing.Size(284, 52);
            this.physiqueGroupBox.TabIndex = 7;
            this.physiqueGroupBox.TabStop = false;
            this.physiqueGroupBox.Text = "Budowa ciała";
            // 
            // endoRadioButton
            // 
            this.endoRadioButton.AutoSize = true;
            this.endoRadioButton.Location = new System.Drawing.Point(173, 20);
            this.endoRadioButton.Name = "endoRadioButton";
            this.endoRadioButton.Size = new System.Drawing.Size(78, 17);
            this.endoRadioButton.TabIndex = 2;
            this.endoRadioButton.TabStop = true;
            this.endoRadioButton.Text = "Endomorfik";
            this.endoRadioButton.UseVisualStyleBackColor = true;
            // 
            // mezoRadioButton
            // 
            this.mezoRadioButton.AutoSize = true;
            this.mezoRadioButton.Location = new System.Drawing.Point(88, 20);
            this.mezoRadioButton.Name = "mezoRadioButton";
            this.mezoRadioButton.Size = new System.Drawing.Size(79, 17);
            this.mezoRadioButton.TabIndex = 1;
            this.mezoRadioButton.TabStop = true;
            this.mezoRadioButton.Text = "Mezomorfik";
            this.mezoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ektoRadioButton
            // 
            this.ektoRadioButton.AutoSize = true;
            this.ektoRadioButton.Location = new System.Drawing.Point(7, 20);
            this.ektoRadioButton.Name = "ektoRadioButton";
            this.ektoRadioButton.Size = new System.Drawing.Size(75, 17);
            this.ektoRadioButton.TabIndex = 0;
            this.ektoRadioButton.TabStop = true;
            this.ektoRadioButton.Text = "Ektomorfik";
            this.ektoRadioButton.UseVisualStyleBackColor = true;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(190, 76);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 6;
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTextBox_KeyPress);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(190, 52);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 5;
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightTextBox_KeyPress);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(7, 83);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(63, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Wzrost [cm]";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(7, 59);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(57, 13);
            this.weightLabel.TabIndex = 2;
            this.weightLabel.Text = "Waga [kg]";
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(190, 26);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 20);
            this.genderTextBox.TabIndex = 1;
            this.genderTextBox.TextChanged += new System.EventHandler(this.genderTextBox_TextChanged);
            this.genderTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genderTextBox_KeyDown);
            this.genderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderTextBox_KeyPress);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(7, 33);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(60, 13);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Płeć [M/K]";
            // 
            // inputDataTypeGroupBox
            // 
            this.inputDataTypeGroupBox.Controls.Add(this.simpleDataRadioButton);
            this.inputDataTypeGroupBox.Controls.Add(this.detailsDataRadioButton);
            this.inputDataTypeGroupBox.Location = new System.Drawing.Point(12, 13);
            this.inputDataTypeGroupBox.Name = "inputDataTypeGroupBox";
            this.inputDataTypeGroupBox.Size = new System.Drawing.Size(296, 80);
            this.inputDataTypeGroupBox.TabIndex = 1;
            this.inputDataTypeGroupBox.TabStop = false;
            this.inputDataTypeGroupBox.Text = "Czy chcesz podać szczegółowe dane?";
            this.inputDataTypeGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // simpleDataRadioButton
            // 
            this.simpleDataRadioButton.AutoSize = true;
            this.simpleDataRadioButton.Location = new System.Drawing.Point(7, 43);
            this.simpleDataRadioButton.Name = "simpleDataRadioButton";
            this.simpleDataRadioButton.Size = new System.Drawing.Size(41, 17);
            this.simpleDataRadioButton.TabIndex = 1;
            this.simpleDataRadioButton.TabStop = true;
            this.simpleDataRadioButton.Text = "Nie";
            this.simpleDataRadioButton.UseVisualStyleBackColor = true;
            this.simpleDataRadioButton.CheckedChanged += new System.EventHandler(this.simpleDataRadioButton_CheckedChanged);
            // 
            // detailsDataRadioButton
            // 
            this.detailsDataRadioButton.AutoSize = true;
            this.detailsDataRadioButton.Location = new System.Drawing.Point(7, 20);
            this.detailsDataRadioButton.Name = "detailsDataRadioButton";
            this.detailsDataRadioButton.Size = new System.Drawing.Size(44, 17);
            this.detailsDataRadioButton.TabIndex = 0;
            this.detailsDataRadioButton.TabStop = true;
            this.detailsDataRadioButton.Text = "Tak";
            this.detailsDataRadioButton.UseVisualStyleBackColor = true;
            this.detailsDataRadioButton.CheckedChanged += new System.EventHandler(this.detailsDataRadioButton_CheckedChanged);
            // 
            // neededKcalLabel
            // 
            this.neededKcalLabel.AutoSize = true;
            this.neededKcalLabel.Location = new System.Drawing.Point(9, 377);
            this.neededKcalLabel.Name = "neededKcalLabel";
            this.neededKcalLabel.Size = new System.Drawing.Size(43, 13);
            this.neededKcalLabel.TabIndex = 2;
            this.neededKcalLabel.Text = "            ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 578);
            this.Controls.Add(this.neededKcalLabel);
            this.Controls.Add(this.inputDataTypeGroupBox);
            this.Controls.Add(this.dataGroupBox);
            this.Name = "MainWindow";
            this.Text = "Meal";
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.activityGroupBox.ResumeLayout(false);
            this.activityGroupBox.PerformLayout();
            this.physiqueGroupBox.ResumeLayout(false);
            this.physiqueGroupBox.PerformLayout();
            this.inputDataTypeGroupBox.ResumeLayout(false);
            this.inputDataTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox dataGroupBox;
        public System.Windows.Forms.GroupBox inputDataTypeGroupBox;
        public System.Windows.Forms.RadioButton simpleDataRadioButton;
        public System.Windows.Forms.RadioButton detailsDataRadioButton;
        public System.Windows.Forms.Label genderLabel;
        public System.Windows.Forms.Label neededKcalLabel;
        public System.Windows.Forms.GroupBox activityGroupBox;
        public System.Windows.Forms.RadioButton activityHighRadioButton;
        public System.Windows.Forms.RadioButton activityMediumRadioButton;
        public System.Windows.Forms.RadioButton activitySmallRadioButton;
        public System.Windows.Forms.GroupBox physiqueGroupBox;
        public System.Windows.Forms.RadioButton endoRadioButton;
        public System.Windows.Forms.RadioButton mezoRadioButton;
        public System.Windows.Forms.RadioButton ektoRadioButton;
        public System.Windows.Forms.TextBox heightTextBox;
        public System.Windows.Forms.Label heightLabel;
        public System.Windows.Forms.Label weightLabel;
        public System.Windows.Forms.Button calculateButton;
        public System.Windows.Forms.TextBox weightTextBox;
        public System.Windows.Forms.TextBox genderTextBox;

    }
}

