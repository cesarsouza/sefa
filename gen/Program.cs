using System.Enums.FontAwesome;
using System.IO;
using System.Threading.Tasks;

namespace Generator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string source = "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.css";

            var content = await FontAwesomeGenerator.GetAndParseAsync(source);
            string output = FontAwesomeGenerator.GenerateCSharpClass(content);

            File.WriteAllText(@"..\..\..\..\src\FontAwesomeIcons.cs", output);
        }
    }
}