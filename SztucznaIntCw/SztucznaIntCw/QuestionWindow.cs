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
        public QuestionWindow()
        {
            InitializeComponent();
        }

        public QuestionWindow(Question question)
        {
            this.richTextBox1.Text = question.Content;
            this.label2.Text = question.Number.ToString();

            InitializeComponent();
        }

    }
}
