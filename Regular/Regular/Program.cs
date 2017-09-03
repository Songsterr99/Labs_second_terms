using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "Data.txt",
                   address_ = "Output.txt",
                   pattern = @"((2[0-5]{2}|1[0-9]{2}|[1-9]{0,1}[0-9])\.){3}(2[0-5]{2}|1[0-9]{2}|[1-9]{0,1}[0-9])",
                   data;
            using (StreamReader file = new StreamReader(address))
                data = file.ReadToEnd();

            using (StreamWriter file = new StreamWriter(address_))
            {
                foreach (Match ip in Regex.Matches(data, pattern))
                    file.WriteLine("{0}", ip.Value);
            }
        }
    }
}
