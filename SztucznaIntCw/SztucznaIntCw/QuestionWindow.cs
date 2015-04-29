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
        private Person systemUser;
 
        public QuestionWindow()
        {
          
            InitializeComponent();
       
        }

        public QuestionWindow(Question question, Person person)
        {
            InitializeComponent();

            systemUser = person;
            injectedProducts = question.Products;

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

                categoryValue.Values.Last().KeyPress += (sender, e) => e.Handled = (e.KeyChar < 8 || (e.KeyChar > 8 && e.KeyChar < 48) || (e.KeyChar > 57));
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
                //  Mała uwaga dot. przyjętej koncepcji. Ogólnie z obiektu Question przekazuję listę produktów w konstruktorze i przekazuję tą referencję
                //  do zmiennej injectedList. Następnie w obsłudze buttona Next sprawdzam, czy user wybrał dany produkt do definiowania diety.
                //  Jeśli nie to po prostu usuwam dany produkt z wstrzykniętej listy. Jest jeszcze inna opcja bo dodałem typowi Product pole IncludeInDiet,
                //  które obecnie nie jest używane (nie wiem może jednak skorzystamy z niego i przyjmiemy inną koncepcję - trzeba przedyskutować).
                //  Jeśli nie bd z niego korzystali to się zrobi mały refactoring. :D
                
                //injectedProducts[categorySelectCounter].Rating = int.Parse(categoryItem.Value.Text);


                systemUser.PrefferedProducts.Add(new Product()
                {
                    Carbs = injectedProducts[categorySelectCounter].Carbs,
                    Protein = injectedProducts[categorySelectCounter].Protein,
                    CategoryName = injectedProducts[categorySelectCounter].CategoryName,
                    Fat = injectedProducts[categorySelectCounter].Fat,
                    Kcal = injectedProducts[categorySelectCounter].Kcal,
                    Name = injectedProducts[categorySelectCounter].Name,
                    Rating = int.Parse(categoryItem.Value.Text)
                });

                categorySelectCounter++;
            }

        }

    }
}
