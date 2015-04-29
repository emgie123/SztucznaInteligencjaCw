using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SztucznaIntCw.Utilities;

namespace SztucznaIntCw
{
    public partial class QuestionWindow : Form
    {
        private Dictionary<Label, TextBox> categoryValue;
        private List<CheckBox> categorySelect;      //  dokończyć liste checkboxów.
 
        public QuestionWindow()
        {
          
            InitializeComponent();
       
         
        }

        public QuestionWindow(Question question)
        {
            InitializeComponent();

            this.richTextBox1.Text = question.Content;
            this.label2.Text = question.Number.ToString();

            categoryValue = new Dictionary<Label, TextBox>();
            categorySelect = new List<CheckBox>();

            int xCoordinate = 5;
            int yCoordinate = 5;


            foreach (var product in question.Products)
            {
                categoryValue.Add(new Label() {Location = new Point(xCoordinate, yCoordinate), 
                    Text = product.Name}, new TextBox(){Location = new Point(xCoordinate + 200, yCoordinate), MaxLength = 2, Text = "50"});
                categorySelect.Add(new CheckBox() { Location = new Point(xCoordinate + 320, yCoordinate), Checked = true });

                //categoryValue.Values.Last().KeyPress += (sender, e) => e.Handled = (e.KeyChar == 8 || e.KeyChar < 48 || e.KeyChar > 57);
                categoryValue.Values.Last().KeyDown += (sender, e) =>
                {
                    if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && e.KeyCode == Keys.Back)
                    {
                        e.SuppressKeyPress = false;
                    }
                    else
                    {
                        e.SuppressKeyPress = true;
                    }
                };

                yCoordinate += 25;

                this.panel1.Controls.Add(categorySelect.Last());
                this.panel1.Controls.Add(categoryValue.Last().Key);
                this.panel1.Controls.Add(categoryValue.Last().Value);
            }

        }

    }
}
