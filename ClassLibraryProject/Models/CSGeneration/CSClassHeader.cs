using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProject.Models.CSGeneration
{
    public class CSClassHeader
    {
        public String NameSpace { get; set; }
        public List<String> Usings { get; set; } = new List<String>();
        public String ClassName { get; set; }

        public override string ToString()
        {
            var output = "using System;";

            Usings.ForEach(us =>
            {
                output += "using " + us + ";" + Environment.NewLine;
            });

            output += Environment.NewLine + Environment.NewLine;
            output +="namespce "+ NameSpace+Environment.NewLine+"{"+Environment.NewLine+"\t";
            output += "public class " + ClassName + Environment.NewLine+"\t{";

            return output;
        }
    }
}