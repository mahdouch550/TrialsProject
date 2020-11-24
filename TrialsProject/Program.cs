 using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Data.SqlClient;
using Effortless.Net.Encryption;
using CSVFile;
using System.Collections.Generic;
using System.Configuration;
using GoogleTranslateFreeApi;
using System.Threading;

namespace TrialsProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var filePath = Console.ReadLine();
            var files = Directory.GetFiles(filePath).Where(fn => fn.EndsWith(".html")).ToList();
            files.ForEach(file =>
            {
                var fileName = Path.GetFileName(file);
                var words = fileName.Split('-');
                var output = "";
                words.ToList().ForEach(word =>
                {
                    output += char.ToUpper(word[0]) + word.Substring(1);

                });
                File.Move(file, file.Replace(Path.GetFileName(file), output).Replace(".html",".cshtml"));
            });
            Console.ReadLine();
        }
    }
}