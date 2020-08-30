using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileParser {
    public class FileHandler {
       
        public FileHandler() { }

        /// <summary>
        /// Reads a file returning each line in a list.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<string> ReadFile(string filePath) {
            List<string> lines = new List<string>();
            StreamReader read = new StreamReader(new FileStream(filePath, FileMode.Open));
            while (read.Peek() >= 0)
            {
                lines.Add(read.ReadLine());
            }
            read.Close();
            return lines; //-- return result here
        }

        
        /// <summary>
        /// Takes a list of a list of data.  Writes to file, using delimeter to seperate data.  Always overwrites.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="delimeter"></param>
        /// <param name="rows"></param>
        public void WriteFile(string filePath, char delimeter, List<List<string>> rows) 
        {
            StreamWriter wr= new StreamWriter(new FileStream(filePath, FileMode.Create));
            var i = 0;
            foreach (var row in rows)
            {
                wr.Write(string.Join(delimeter.ToString(), row));
                if (++i != rows.Count)
                {
                    wr.Write("\n");
                }
            }
            wr.Close();
        }
        
        /// <summary>
        /// Takes a list of strings and seperates based on delimeter.  Returns list of list of strings seperated by delimeter.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public List<List<string>> ParseData(List<string> data, char delimiter) {
            List<List<string>> result = new List<List<string>>();
            
            foreach ( var row in data)
            {
                result.Add(new List<string>(row.Split(delimiter)));
            }
            return result; //-- return result here
        }
        
        /// <summary>
        /// Takes a list of strings and seperates on comma.  Returns list of list of strings seperated by comma.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> ParseCsv(List<string> data) {
            
            return new List<List<string>>(ParseData(data, ','));  //-- return result here
        }
    }
}