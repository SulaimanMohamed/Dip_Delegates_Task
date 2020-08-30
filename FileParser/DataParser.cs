using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace FileParser {
    public class DataParser {
        

        /// <summary>
        /// Strips any whitespace before and after a data value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripWhiteSpace(List<List<string>> data) {
            foreach (var stripWS in data)
            {
                for (int i = 0; i < stripWS.Count; i++)
                {
                    stripWS[i] = stripWS[i].Replace(" ", "");
                }
            }
            return data; //-- return result here
        }

        /// <summary>
        /// Strips quotes from beginning and end of each data value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripQuotes(List<List<string>> data) {
            foreach ( var stripQuotes in data)
            {
                for (int i = 0; i < stripQuotes.Count; i++)
                {
                    stripQuotes[i] = stripQuotes[i].Replace("\"", "");
                }
            }
            return data; //-- return result here
        }

    }
}