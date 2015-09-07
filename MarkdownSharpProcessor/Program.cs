using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MarkdownSharp;

namespace MarkdownSharpProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var mdFile in args)
            {
                // Create new markdown instance
                var mark = new Markdown();

                // Run parser
                var html = mark.Transform(File.ReadAllText(mdFile));

                var htmlFile = Path.ChangeExtension(mdFile, ".html");

                File.WriteAllText(htmlFile, html);
            }
        }
    }
}
