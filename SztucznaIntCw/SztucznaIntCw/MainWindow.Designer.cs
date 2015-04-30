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
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.activityGroupBox = new System.Windows.Forms.GroupBox();
            this.aeroActivityTextBox = new System.Windows.Forms.TextBox();
            this.strenghtActivityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GeneratePersonalizedDiet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reduceWeightRadioButton = new System.Windows.Forms.RadioButton();
            this.increaseWeightRadioButton = new System.Windows.Forms.RadioButton();
            this.leaveCurrentWeightRadioButton = new System.Windows.Forms.RadioButton();
            this.GenerateDefaultDiet = new System.Windows.Forms.Button();
            this.dataGroupBox.SuspendLayout();
            this.activityGroupBox.SuspendLayout();
            this.physiqueGroupBox.SuspendLayout();
            this.inputDataTypeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.ageTextBox);
            this.dataGroupBox.Controls.Add(this.ageLabel);
            this.dataGroupBox.Controls.Add(this.calculateButton);
            this.dataGroupBox.Controls.Add(this.activityGroupBox);
            this.dataGroupBox.Controls.Add(this.physiqueGroupBox);
            this.dataGroupBox.Controls.Add(this.heightTextBox);
            this.dataGroupBox.Controls.Add(this.weightTextBox);
            this.dataGroupBox.Controls.Add(this.heightLabel);
            this.dataGroupBox.Controls.Add(this.weightLabel);
            this.dataGroupBox.Controls.Add(this.genderTextBox);
            this.dataGroupBox.Controls.Add(this.genderLabel);
            this.dataGroupBox.Location = new System.Drawing.Point(12, 65);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(296, 342);
            this.dataGroupBox.TabIndex = 0;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Dane";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(190, 105);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 10;
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(7, 105);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(58, 13);
            this.ageLabel.TabIndex = 9;
            this.ageLabel.Text = "Wiek [lata]";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(211, 307);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Oblicz";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // activityGroupBox
            // 
            this.activityGroupBox.Controls.Add(this.aeroActivityTextBox);
            this.activityGroupBox.Controls.Add(this.strenghtActivityTextBox);
            this.activityGroupBox.Controls.Add(this.label2);
            this.activityGroupBox.Controls.Add(this.label1);
            this.activityGroupBox.Location = new System.Drawing.Point(6, 211);
            this.activityGroupBox.Name = "activityGroupBox";
            this.activityGroupBox.Size = new System.Drawing.Size(284, 90);
            this.activityGroupBox.TabIndex = 8;
            this.activityGroupBox.TabStop = false;
            this.activityGroupBox.Text = "Tygodniowa aktywność fizyczna";
            // 
            // aeroActivityTextBox
            // 
            this.aeroActivityTextBox.Location = new System.Drawing.Point(178, 51);
            this.aeroActivityTextBox.Name = "aeroActivityTextBox";
            this.aeroActivityTextBox.Size = new System.Drawing.Size(100, 20);
            this.aeroActivityTextBox.TabIndex = 13;
            this.aeroActivityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aeroActivityTextBox_KeyPress);
            // 
            // strenghtActivityTextBox
            // 
            this.strenghtActivityTextBox.Location = new System.Drawing.Point(178, 25);
            this.strenghtActivityTextBox.Name = "strenghtActivityTextBox";
            this.strenghtActivityTextBox.Size = new System.Drawing.Size(100, 20);
            this.strenghtActivityTextBox.TabIndex = 11;
            this.strenghtActivityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strenghtActivityTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Trening aerobowy [min]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Trening siłowy [min]";
            // 
            // physiqueGroupBox
            // 
            this.physiqueGroupBox.Controls.Add(this.endoRadioButton);
            this.physiqueGroupBox.Controls.Add(this.mezoRadioButton);
            this.physiqueGroupBox.Controls.Add(this.ektoRadioButton);
            this.physiqueGroupBox.Location = new System.Drawing.Point(6, 153);
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
            this.inputDataTypeGroupBox.Size = new System.Drawing.Size(296, 46);
            this.inputDataTypeGroupBox.TabIndex = 1;
            this.inputDataTypeGroupBox.TabStop = false;
            this.inputDataTypeGroupBox.Text = "Czy chcesz podać szczegółowe dane?";
            // 
            // simpleDataRadioButton
            // 
            this.simpleDataRadioButton.AutoSize = true;
            this.simpleDataRadioButton.Location = new System.Drawing.Point(57, 20);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GeneratePersonalizedDiet);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.GenerateDefaultDiet);
            this.groupBox1.Location = new System.Drawing.Point(327, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generator diety";
            // 
            // GeneratePersonalizedDiet
            // 
            this.GeneratePersonalizedDiet.Location = new System.Drawing.Point(9, 165);
            this.GeneratePersonalizedDiet.Name = "GeneratePersonalizedDiet";
            this.GeneratePersonalizedDiet.Size = new System.Drawing.Size(277, 23);
            this.GeneratePersonalizedDiet.TabIndex = 5;
            this.GeneratePersonalizedDiet.Text = "Wygeneruj dietę na podstawie własnych preferencji";
            this.GeneratePersonalizedDiet.UseVisualStyleBackColor = true;
            this.GeneratePersonalizedDiet.Click += new System.EventHandler(this.GeneratePersonalizedDiet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reduceWeightRadioButton);
            this.groupBox2.Controls.Add(this.increaseWeightRadioButton);
            this.groupBox2.Controls.Add(this.leaveCurrentWeightRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 95);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Typ generowanej diety";
            // 
            // reduceWeightRadioButton
            // 
            this.reduceWeightRadioButton.AutoSize = true;
            this.reduceWeightRadioButton.Location = new System.Drawing.Point(15, 65);
            this.reduceWeightRadioButton.Name = "reduceWeightRadioButton";
            this.reduceWeightRadioButton.Size = new System.Drawing.Size(138, 17);
            this.reduceWeightRadioButton.TabIndex = 8;
            this.reduceWeightRadioButton.TabStop = true;
            this.reduceWeightRadioButton.Text = "Redukująca masę ciała";
            this.reduceWeightRadioButton.UseVisualStyleBackColor = true;
            // 
            // increaseWeightRadioButton
            // 
            this.increaseWeightRadioButton.AutoSize = true;
            this.increaseWeightRadioButton.Location = new System.Drawing.Point(15, 19);
            this.increaseWeightRadioButton.Name = "increaseWeightRadioButton";
            this.increaseWeightRadioButton.Size = new System.Drawing.Size(145, 17);
            this.increaseWeightRadioButton.TabIndex = 6;
            this.increaseWeightRadioButton.TabStop = true;
            this.increaseWeightRadioButton.Text = "Zwiększająca masę ciała";
            this.increaseWeightRadioButton.UseVisualStyleBackColor = true;
            // 
            // leaveCurrentWeightRadioButton
            // 
            this.leaveCurrentWeightRadioButton.AutoSize = true;
            this.leaveCurrentWeightRadioButton.Location = new System.Drawing.Point(15, 42);
            this.leaveCurrentWeightRadioButton.Name = "leaveCurrentWeightRadioButton";
            this.leaveCurrentWeightRadioButton.Size = new System.Drawing.Size(117, 17);
            this.leaveCurrentWeightRadioButton.TabIndex = 7;
            this.leaveCurrentWeightRadioButton.TabStop = true;
            this.leaveCurrentWeightRadioButton.Text = "Na utrzymanie wagi";
            this.leaveCurrentWeightRadioButton.UseVisualStyleBackColor = true;
            // 
            // GenerateDefaultDiet
            // 
            this.GenerateDefaultDiet.Location = new System.Drawing.Point(9, 136);
            this.GenerateDefaultDiet.Name = "GenerateDefaultDiet";
            this.GenerateDefaultDiet.Size = new System.Drawing.Size(277, 23);
            this.GenerateDefaultDiet.TabIndex = 4;
            this.GenerateDefaultDiet.Text = "Wygeneruj przykładowy plan żywieniowy";
            this.GenerateDefaultDiet.UseVisualStyleBackColor = true;
            this.GenerateDefaultDiet.Click += new System.EventHandler(this.GenerateDefaultDiet_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 432);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button GeneratePersonalizedDiet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton reduceWeightRadioButton;
        private System.Windows.Forms.RadioButton increaseWeightRadioButton;
        private System.Windows.Forms.RadioButton leaveCurrentWeightRadioButton;
        public System.Windows.Forms.Button GenerateDefaultDiet;
        public System.Windows.Forms.TextBox ageTextBox;
        public System.Windows.Forms.Label ageLabel;
        public System.Windows.Forms.TextBox aeroActivityTextBox;
        public System.Windows.Forms.TextBox strenghtActivityTextBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;

    }
}

