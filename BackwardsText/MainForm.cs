using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackwardsText
{
    public partial class MainForm : Form
    {
        public string getText;
        public MainForm()
        {
            InitializeComponent();
            UpperLowerCaseCombo.SelectedIndex = 0;
        }

        private void ReversTextButton_Click(object sender, EventArgs e)
        {
            getText = richTextBox.Text;
            char[] textChar1 = getText.ToCharArray();
            List<char> listFirstText = textChar1.OfType<char>().ToList();
            listFirstText.Reverse();

            richTextBox.Text = "";

            foreach(char letter in listFirstText)
            {
                richTextBox.Text += letter.ToString();
            }
        }

        private void SpaceLettersButton_Click(object sender, EventArgs e)
        {
            getText = richTextBox.Text;
            char[] textChar1 = getText.ToCharArray();
            List<char> listFirstText = textChar1.OfType<char>().ToList();
            richTextBox.Text = "";

            foreach (char letter in listFirstText)
            {
                richTextBox.Text += letter.ToString() + " ";
            }
        }

        private void UpperLowerCaseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(UpperLowerCaseCombo.SelectedIndex == 0)
            {
                getText = richTextBox.Text;
                richTextBox.Text = "";
                richTextBox.Text = getText.ToUpper();
            }
            if(UpperLowerCaseCombo.SelectedIndex == 1)
            {
                getText = richTextBox.Text;
                richTextBox.Text = "";
                richTextBox.Text = getText.ToLower();
            }
        }
    }
}
