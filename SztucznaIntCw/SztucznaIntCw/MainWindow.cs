﻿using System;
using System.Windows.Forms;
using SztucznaIntCw.Classes;
using SztucznaIntCw.Enums;

namespace SztucznaIntCw
{
    public partial class MainWindow : Form
    {

        private TypeOfProvidedData providedDataType;

        public MainWindow()
        {
            InitializeComponent();
            genderTextBox.MaxLength = 1;
            simpleDataRadioButton.Checked = true;
            EnableBasicData();
            weightTextBox.MaxLength = 3;
            heightTextBox.MaxLength = 3;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void genderTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(genderTextBox.Text != string.Empty && e.KeyCode == Keys.Enter)) return;

            if (providedDataType != TypeOfProvidedData.Detail) return;
        }

        private void genderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == 'M' || e.KeyChar == 'K' || e.KeyChar =='m' || e.KeyChar =='k' || e.KeyChar == (char)Keys.Back);
        }


        private void EnableBasicData()
        {
            
            dataGroupBox.Enabled = true;
            weightTextBox.Enabled = false;
            heightTextBox.Enabled = false;
            activityGroupBox.Enabled = false;
            physiqueGroupBox.Enabled = false;
        }


        private void EnableDetailsData()
        {

            dataGroupBox.Enabled = true;
            weightTextBox.Enabled = true;
            heightTextBox.Enabled = true;
            activityGroupBox.Enabled = true;
            physiqueGroupBox.Enabled = true;
         
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.Verify(this);
            
        }

        private void simpleDataRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnableBasicData();
        }

        private void detailsDataRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnableDetailsData();
        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {//48-57
            e.Handled = (e.KeyChar<48 || e.KeyChar>57);
        }

        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar < 48 || e.KeyChar > 57);
        }
    }
}
