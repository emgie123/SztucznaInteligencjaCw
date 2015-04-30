using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SztucznaIntCw.Classes.Interfaces;
using SztucznaIntCw.Classes.NonAbstract;
using SztucznaIntCw.Utilities;

namespace SztucznaIntCw
{
    public partial class QuestionWindow : Form
    {
        private Dictionary<Label, TextBox> categoryValue;
        private List<CheckBox> categorySelect;

        private List<Product> injectedProducts;
        private List<Question> questions;
        private Person systemUser;
 
        public QuestionWindow()
        {
          
            InitializeComponent();
       
        }

        public QuestionWindow(List<Question> questions, Person person)
        {
            InitializeComponent();

            systemUser = person;
            this.questions = questions;

            injectedProducts = questions[MainWindow.QuestionCounter].Products;

            this.richTextBox1.Text = questions[MainWindow.QuestionCounter].Content;
            this.label2.Text = questions[MainWindow.QuestionCounter].Number.ToString();

            categoryValue = new Dictionary<Label, TextBox>();
            categorySelect = new List<CheckBox>();

            int xCoordinate = 5;
            int yCoordinate = 5;


            foreach (var product in injectedProducts)
            {
                categoryValue.Add(new Label() {Location = new Point(xCoordinate, yCoordinate), 
                    Text = product.Name}, new TextBox(){Location = new Point(xCoordinate + 200, yCoordinate), MaxLength = 2, Text = "50"});
                categorySelect.Add(new CheckBox() { Location = new Point(xCoordinate + 320, yCoordinate), Checked = true });

                categoryValue.Values.Last().KeyPress += (sender, e) => e.Handled = ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != (char)Keys.Back);
                yCoordinate += 25;

                //this.panel1.MaximumSize = new Size(415, 201); Nie wiem czemu ale to nie działa (chciałbym wywalić poziomy scroll).
                this.panel1.Controls.Add(categorySelect.Last());
                this.panel1.Controls.Add(categoryValue.Last().Key);
                this.panel1.Controls.Add(categoryValue.Last().Value);
            }

        }

        private void NextCategory_Click(object sender, EventArgs e)
        {
            int categorySelectCounter = 0;

            foreach (var categoryItem in categoryValue)
            {
                if (!categorySelect[categorySelectCounter].Checked)
                {
                    //injectedProducts.RemoveAt(categorySelectCounter);
                    categorySelectCounter++;
                    continue;
                }

                systemUser.PrefferedProducts.Add(new Product()
                {
                    Carbs = injectedProducts[categorySelectCounter].Carbs,
                    Protein = injectedProducts[categorySelectCounter].Protein,
                    CategoryName = injectedProducts[categorySelectCounter].CategoryName,
                    MacroElement = injectedProducts[categorySelectCounter].MacroElement,
                    Fat = injectedProducts[categorySelectCounter].Fat,
                    Kcal = injectedProducts[categorySelectCounter].Kcal,
                    Name = injectedProducts[categorySelectCounter].Name,
                    Rating = int.Parse(categoryItem.Value.Text)
                });

                categorySelectCounter++;
            }

            MainWindow.QuestionCounter++;
            if (MainWindow.QuestionCounter < questions.Count)
            {
                QuestionWindow nextQuestionWindow = new QuestionWindow(questions, systemUser)
                {
                    StartPosition = FormStartPosition.CenterParent
                };

                this.Hide();
                nextQuestionWindow.ShowDialog();
                this.Close();
            }
            else
            {
                this.Close();
            }
            

        }

    }
}
