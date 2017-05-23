using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoccerStats {
    class Program {
        static void Main(string[] args) {
            string currDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currDirectory);
            var fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");
            var fileContents = ReadFile(fileName);
            string[] fileLines = fileContents.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in fileLines) {
                Console.WriteLine(line);
            }
        }
        public static string ReadFile(string fileName) {
            using(var reader = new StreamReader(fileName)) {
                return reader.ReadToEnd();
            }
        }
    }
}
