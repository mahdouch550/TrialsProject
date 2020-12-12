using System;
using System.Collections.Generic;

namespace ClassLibraryProject.Models.CSGeneration
{
    public class CSClass
    {
        public CSClassHeader Header { get; set; } = new CSClassHeader();
        public List<CSClassProperty> Properties { get; set; } = new List<CSClassProperty>();
        public String Path { get; set; }

        public override string ToString()
        {
            var output = Header.ToString();
            Properties.ForEach(prop => 
            {
                output += "\t\t\t" + prop.Type + " " + prop.Name + " { get; set; }"+Environment.NewLine+Environment.NewLine;
            });
            output += "\t\t}";
            output += "\t}";
            return output;
        }
    }
}