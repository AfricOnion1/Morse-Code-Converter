using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeConverter
{
    public partial class Form1 : Form
    {
        static Data table = new Data();
        bool encrypt = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            clear(Output);

            string textToConvert = Input.Text;
            
            if(encrypt)
            {
                for (int i = 0; i < textToConvert.Length; i++)
                {
                    char c = Char.ToUpper(textToConvert[i]);
                    if (table.morseCodeTable.ContainsKey(c))
                    {
                        if (table.morseCodeTable[c] == " ") {
                            Output.Text += "/ ";
                        }
                        else Output.Text += table.morseCodeTable[c] + " ";
                    }
                    else if (c.ToString().Equals("\n"))
                    {
                        Output.Text += Environment.NewLine;
                    }
                }
            } else
            {
                string[] morseCodeToConvert = textToConvert.Split('/');
                foreach (string s in morseCodeToConvert)
                {
                    string[] word = s.Trim().Split(' ');
                    foreach (string character in word)
                    {
                        if (table.invertedMorseCodeTable.ContainsKey(character))
                        {
                            Output.Text += table.invertedMorseCodeTable[character];
                        }
                        else Output.Text += '?';
                    }
                    Output.Text += ' ';
                }
            }
        }

        private void clear(TextBox textBox)
        {
            textBox.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            clear(Input);
            clear(Output);
        }

        private void changeMode_Click(object sender, EventArgs e)
        {
            encrypt = !encrypt;

            if(encrypt == true)
            {
                inputLabel.Text = "Upiši tekst za kodiranje:";
                outputLabel.Text = "Morseov kod:";
                convert.Text = "KODIRAJ";
                changeMode.Text = "KODIRANJE";

                Input.Font = new Font(Input.Font.Name, 11.25F, Input.Font.Style, Input.Font.Unit);
                Output.Font = new Font(Input.Font.Name, 15.75F, Input.Font.Style, Input.Font.Unit);
            } else
            {
                inputLabel.Text = "Upiši morseov kod za dekodiranje:";
                outputLabel.Text = "Dekodiran morseov kod:";
                convert.Text = "DEKODIRAJ";
                changeMode.Text = "DEKODIRANJE";

                Input.Font = new Font(Input.Font.Name, 15.75F, Input.Font.Style, Input.Font.Unit);
                Output.Font = new Font(Input.Font.Name, 11.25F, Input.Font.Style, Input.Font.Unit);
            }

            clear(Input);
            clear(Output);
        }

        private void copyInput_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Input.Text);
        }

        private void copyOutput_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Output.Text);
        }
    }
}