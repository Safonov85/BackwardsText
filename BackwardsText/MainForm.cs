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
            
        }

        void SpaceLetters(bool space)
        {
            getText = richTextBox.Text;
            char[] textChar1 = getText.ToCharArray();
            List<char> listFirstText = textChar1.OfType<char>().ToList();

            richTextBox.Text = "";
            bool letterFound = false;

            foreach (char letter in listFirstText)
            {
                if(space == true)
                {
                    richTextBox.Text += letter.ToString() + " ";
                }
                else
                {
                    if(!letter.ToString().Contains(" "))
                    {
                        richTextBox.Text += letter.ToString() + " ";
                    }
                    else
                    {
                        richTextBox.Text += letter.ToString();
                    }
                    
                    //if(letterFound == true)
                    //{
                    //    if(letter.ToString().Contains(" "))
                    //    {
                    //        string removal = letter.ToString();
                    //        string anotherOne = removal.Replace(" ", string.Empty);
                    //        richTextBox.Text += anotherOne;
                    //    }
                    //}
                    //else
                    //{
                    //    richTextBox.Text += letter.ToString();
                    //    letterFound = true;
                    //}
                }
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

        private void SpaceLetterMinusButton_Click(object sender, EventArgs e)
        {
            SpaceLetters(false);
        }

        private void SpaceLetterPlusButton_Click(object sender, EventArgs e)
        {
            SpaceLetters(true);
        }
    }
}
