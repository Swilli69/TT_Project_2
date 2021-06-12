using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearcher
{
    class RabinKarpSearcherSimulator
    {
        protected Label message_label;
        protected RichTextBox pattern_textbox;
        protected RichTextBox text_textbox;
        protected String text;
        protected String pattern;
        //textBoxes that display a mathematical expression for computing hash
        private RichTextBox pattern_hash_expression_textbox;
        private RichTextBox text_hash_expression_textbox;

        //textBoxes that show the validity of the template hess and part of the text
        private TextBox pattern_hash_textbox;
        private TextBox text_hash_textbox;

        const int B = 257, M = 997;

        int text_counter;
        int match_counter;

        private int pattern_hash;
        private int text_hash;

        //a string that stores the mathematical expression as we computed hes
        private string hash_text;
        protected void SetBackColor(RichTextBox textBox, Color color, int start_index, int end_index)
        {
            textBox.Select(start_index, end_index);
            textBox.SelectionBackColor = color;
        }

        protected void SetFrontColor(RichTextBox textBox, Color color, int start_index, int end_index)
        {
            textBox.Select(start_index, end_index);
            textBox.SelectionColor = color;
        }

        protected void SetText(RichTextBox textBox, String text)
        {
            textBox.Text = text;
        }

        public void SetPatternAndText()
        {
            text = text_textbox.Text;
            pattern = pattern_textbox.Text;
        }

        

        public RabinKarpSearcherSimulator(RichTextBox pattern_textbox, 
                                             RichTextBox text_textbox, 
                                             RichTextBox pattern_hash_expression_textbox,
                                             RichTextBox text_hash_expression_textbox, 
                                             TextBox pattern_hash_textbox, 
                                             TextBox text_hash_textbox,
                                             Label message_label)
        {
            this.pattern_textbox = pattern_textbox;
            this.pattern_hash_textbox = pattern_hash_textbox;
            this.pattern_hash_expression_textbox = pattern_hash_expression_textbox;

            this.text_textbox = text_textbox;
            this.text_hash_textbox = text_hash_textbox;
            this.text_hash_expression_textbox = text_hash_expression_textbox;

            this.message_label = message_label;
        }

        /// <summary>
        /// generating a rolling hash for a given string
        /// generating a string that represents the mathematical expression how to generate hes for a given string
        /// </summary>
        private int CalculateHashSimulation(String s)
        {
            int b_to_power_m = 1;
            int hash = s[s.Length - 1];

            hash_text = s[s.Length - 1].ToString() + " * B^0 % M";

            for (int i = 1; i < s.Length; i++)
            {
                b_to_power_m = (b_to_power_m * B) % M;
                int part_of_sum = (s[s.Length - i - 1] * b_to_power_m) % M;
                hash = (hash + part_of_sum) % M;

                hash_text = s[s.Length - i - 1].ToString() + " * B^" + i.ToString() + " % M + " + hash_text;
            }
            return hash;
        }

        /// <summary>
        /// proprema refers to the calculation of hesa stencil and hesa first pattern.Length letters of the text
        /// marking pattern.Length letters of text and templates
        /// </summary>
        public void Prepare()
        {
            pattern_hash = CalculateHashSimulation(pattern);
            pattern_hash_textbox.Text = pattern_hash.ToString();
            SetText(pattern_hash_expression_textbox, hash_text);
            SetBackColor(pattern_textbox, Color.Tan, 0, pattern.Length);

            text_hash = CalculateHashSimulation(text.Substring(0, pattern.Length));
            text_hash_textbox.Text = text_hash.ToString();
            SetText(text_hash_expression_textbox, hash_text);
            SetBackColor(text_textbox, Color.Tan, text_counter, pattern.Length);

            SetMessage();
            
            text_counter = 0;
        }

        public void NextStep()
        {
            //condition for the end of the search
            if (text_counter > text.Length - pattern.Length)
                return;

            
            //removing a colored background from a previous iteration
            SetBackColor(pattern_textbox, Color.White, 0, pattern.Length);
            SetBackColor(text_textbox, Color.White, text_counter, pattern.Length);
            text_counter++;
            if (pattern_hash != text_hash)
            {
                PatternMissmatch(0);
                SetMessage();
            }
            else
            {
                //if the hash template and hash part of the text are the same, we check letter by letter if they are identical
                if (match_counter < pattern.Length)
                {
                    if (pattern[match_counter] == text[text_counter - 1 + match_counter])
                    {
                        //the letter of the template and the parts of the text are identical
                        //we increase the counter of the counted same letters
                        match_counter++;
                        //we mark the part of the template and the part of the text that we have determined to be the same
                        SetBackColor(pattern_textbox, Color.Tan, 0, match_counter);
                        SetBackColor(text_textbox, Color.Tan, text_counter-1, match_counter);
                        message_label.Text = "Буква шаблона и текста совпадает";
                        text_counter--;
                    }
                    else
                    {
                        //the part of the text that has the same hes as the template is not identical to the template
                        match_counter = 0;
                        PatternMissmatch(0);
                        message_label.Text = "Буквы не совпали";
                        AddMessage();
                    }
                }
                else
                {
                    //we have detected the appearance of a template in the text box, and we mark that part of the text with red letters
                    SetFrontColor(text_textbox, Color.Red, text_counter-1, pattern.Length);
                    //we reset the counter and move on to examining the remaining text
                    match_counter = 0;
                    PatternMissmatch(0);
                    message_label.Text = "Найдено совпадение";
                    AddMessage();
                }
            }
           
        }

        private void PatternMissmatch(int shift)
        {

            if (text_counter <= text.Length - pattern.Length)
            {
                text_hash = CalculateHashSimulation(text.Substring(text_counter, pattern.Length));
                //setting the mathematical expression for the newly calculated hes text and its values
                SetText(text_hash_expression_textbox, hash_text);
                text_hash_textbox.Text = text_hash.ToString();

                //marking patterns and parts of the observed text
                SetBackColor(pattern_textbox, Color.Tan, 0, pattern.Length);
                SetBackColor(text_textbox, Color.Tan, text_counter, pattern.Length - shift);
            }
        }

        private void SetMessage()
        {
                if (text_hash != pattern_hash)
                    message_label.Text = "Несовпадение. Тексты шаблона и подстроки разные.";
                else
                    message_label.Text = "Потенциально подходит!";
        }

        private void AddMessage()
        {
            if (text_hash != pattern_hash)
                message_label.Text += "\nНесовпадение. Тексты шаблона и подстроки разные.";
            else
                message_label.Text += "\nПотенциально подходит!";
        }

        public void Reset()
        {
            SetBackColor(pattern_textbox, Color.White, 0, pattern.Length);
            SetBackColor(text_textbox, Color.White, 0, text.Length);
            SetFrontColor(text_textbox, Color.Black, 0, text.Length);
            

            pattern_hash_expression_textbox.Text = "";
            text_hash_expression_textbox.Text = "";
            pattern_hash_textbox.Text = "";
            text_hash_textbox.Text = "";
            text = "";
            pattern = "";
            text_counter = match_counter = 0;
            hash_text = "";
            message_label.Text = "";
        }
    }
}