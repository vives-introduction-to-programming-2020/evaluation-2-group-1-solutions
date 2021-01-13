using System;
using System.Collections.Generic;
using System.Text;

namespace FindTheKey
{
    public class KeyValueParser
    {
        public string GetValue(string text)
        {
            // Examples of text:
            //          name: Nico De Witte
            //          message: Hello World
            //
            // TODO - Check if "text" is valid. If not return empty string
            // TODO - Get the value ("Nico De Witte" in the example case) from the string

            if (!IsValid(text))
            {
                return "";
            }

            ///////////////////////////////////
            /// Option 1 - Basic constructs ///
            ///////////////////////////////////

            //int iColon = 0;
            //while (text[iColon] != ':')
            //{
            //    iColon++;
            //}

            //iColon += 2;    // For space after colon

            //String value = "";
            //for (int i = iColon; i < text.Length; i++)
            //{
            //    value += text[i];
            //}
            //return value;       // Or value.Trim(); to remove space in front


            ///////////////////////////////////////
            /// Option 2 - Using String methods ///
            ///////////////////////////////////////

            int iColon = text.IndexOf(':');
            return text.Substring(iColon + 2, (text.Length - iColon - 2));
        }

        public bool IsValid(string text)
        {
            // TODO: Check if "text" is a valid key-value string.
            // TODO: Return 'false' if string is empty or does not contain a colon :


            ///////////////////////////////////
            /// Option 1 - Basic constructs ///
            ///////////////////////////////////

            //foreach (var c in text)
            //{
            //    if (c == ':')
            //    {
            //        return true;
            //    }
            //}
            //return false;       // If you get here, there is no colon


            ///////////////////////////////////////
            /// Option 2 - Using String methods ///
            ///////////////////////////////////////
            
            int iColon = text.IndexOf(':');
            return iColon >= 0;
        }
    }
}
