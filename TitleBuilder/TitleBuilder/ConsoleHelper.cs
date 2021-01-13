using System;
using System.Collections.Generic;
using System.Text;

namespace TitleBuilder
{
    public class ConsoleHelper
    {
        public string GenerateTitle(string text)
        {
            // TODO - Generate title block arround "text"
            // Example:
            // #########################################
            // # Hello and Welcome to the second grade #
            // # ------------------------------------- #
            // #########################################

            String output = "";

            //////////////////////////////////
            /// Option 1 - No extra method ///
            //////////////////////////////////

            //// First hashtag line
            //for (int i = 0; i < text.Length + 4; i++)
            //{
            //    output += "#";
            //}
            //output += "\n";     // Newline

            //// text
            //output += "# " + text + " #\n";

            //// ------------
            //output += "# ";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    output += "-";
            //}
            //output += " #\n";

            //// Second hashtag line
            //for (int i = 0; i < text.Length + 4; i++)
            //{
            //    output += "#";
            //}

            //////////////////////////////////////////////////
            /// Option 2 - Nice and DRY with custom method ///
            //////////////////////////////////////////////////

            output += CreateCharacterLine('#', text.Length + 4) + "\n";
            output += $"# {text} #\n";
            output += $"# {CreateCharacterLine('-', text.Length)} #\n";
            output += CreateCharacterLine('#', text.Length + 4);

            return output;
        }

        // Cleanest solution was to create extra method
        private string CreateCharacterLine(char symbol, int count)
        {
            string output = "";
            for (int i = 0; i < count; i++)
            {
                output += symbol;
            }
            return output;
        }
    }
}
