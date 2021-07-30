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
    // ATTENTION!! Need to redo this into an app for Windows or Linux or Mac

    public partial class MainForm : Form
    {
        public string getText;
        private int fontSize = 10;
        List<string> allTexts = new List<string>();
		List<string> undoRedo = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            UpperLowerCaseCombo.SelectedIndex = 0;
        }

        // Reversing Text
        private void ReversTextButton_Click(object sender, EventArgs e)
        {
            getText = richTextBox.Text;
            char[] textChar1 = getText.ToCharArray();
            List<char> listFirstText = textChar1.OfType<char>().ToList();
            listFirstText.Reverse();

            richTextBox.Text = "";

            foreach (char letter in listFirstText)
            {
                richTextBox.Text += letter.ToString();
            }
        }

        private void SpaceLettersButton_Click(object sender, EventArgs e)
        {

        }

        // Adding more spaces between letters, or less.
        void SpaceLetters(bool space)
        {
            getText = richTextBox.Text;
            char[] textChar1 = getText.ToCharArray();
            List<char> listFirstText = textChar1.OfType<char>().ToList();

            if (space == true)
            {
                allTexts.Add(getText);
            }

			if(space == false && !allTexts.Any())
			{
				return;
			}
            
            richTextBox.Text = "";

            foreach (char letter in listFirstText)
            {
                if (space == true)
                {
                    richTextBox.Text += letter.ToString() + " ";
                }
                else
                {
                    if(allTexts.Any())
                    {
                        richTextBox.Text = allTexts[allTexts.Count - 1];
                        allTexts.RemoveAt(allTexts.Count - 1);
                        return;
                    }
                }
            }
        }

        private void UpperLowerCaseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpperLowerCaseCombo.SelectedIndex == 0)
            {
                getText = richTextBox.Text;
                richTextBox.Text = "";
                richTextBox.Text = getText.ToUpper();
            }
            if (UpperLowerCaseCombo.SelectedIndex == 1)
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

        private void ListWordsButton_Click(object sender, EventArgs e)
        {
            ListWords();
        }

		void UndoRedoSave()
		{
			undoRedo.Add(richTextBox.Text);
		}

        // Listing all the words on each line individually
        void ListWords()
        {
            List<string> listText = new List<string>();

            getText = richTextBox.Text;
            string[] wordsText1 = getText.Split(' ');
            foreach (string word in wordsText1)
            {
                listText.Add(word);
            }

            richTextBox.Text = "";

            foreach (string word in listText)
            {
                richTextBox.Text += word + Environment.NewLine;
            }
        }

        // Currently 'Async' not working properly
        void CountAsync()
        {
            if(richTextBox.Text != "")
            {
                WordAmountLabel.Text = "Words Amount: " + CountWords().ToString();
            }
            else
            {
                WordAmountLabel.Text = 0.ToString();
            }
            // This method runs asynchronously.
            //int amount = await Task.Run(() => CountWords());
            //WordAmountLabel.Text = "Word Amount: " + amount.ToString();
        }

        // Counting how many Words in the text
        int CountWords()
        {
            List<string> listText = new List<string>();
            int amount = 0;

            getText = richTextBox.Text;
            string[] wordsText1 = getText.Split(' ');
            foreach (string word in wordsText1)
            {
                amount++;
            }

            return amount;
        }

        void LetterAmount()
        {
            LetterAmountLabel.Text = "Letter Amount: " + CountLetters().ToString();
        }

        // Counting how many letters in the text
        int CountLetters()
        {
            int amount = 0;

            getText = richTextBox.Text;
            amount = getText.Length;

            return amount;
        }

        // Update anything called in this method whenever a key is pressed
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            CountAsync();
            LetterAmount();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void IncreaseVolumeButton_Click(object sender, EventArgs e)
        {
            if(fontSize < 52)
            {
                SizeLetters(true);
            }
        }

        private void DecreaseSizeButton_Click(object sender, EventArgs e)
        {
            if(fontSize > 2)
            {
                SizeLetters(false);
            }
        }

        // Resize the letters either way
        void SizeLetters(bool size)
        {
            richTextBox.SelectAll();

            if (size)
            {
                fontSize++;
            }
            else
            {
                fontSize--;
            }

            richTextBox.SelectionFont = new System.Drawing.Font("Tahoma", fontSize);
        }

		private void richTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			UndoRedoSave();
		}

		private void UndoButton_Click(object sender, EventArgs e)
		{
			Undo();
		}

		void Undo()
		{
			if (undoRedo.Count < 2)
			{
				return;
			}
			undoRedo.RemoveAt(undoRedo.Count - 1);
			richTextBox.Text = undoRedo[undoRedo.Count - 1];
		}
	}
}
