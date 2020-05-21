using System.Enums;
using System.Enums.CodeGeneration;
using System.Enums.Parsing;
using System.IO;
using System.Threading.Tasks;

class Program
{
    public static async Task Main()
    {
        FontInfo fontAwesomeInfo = await Parser
            .GetAndParseAsync("https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.css");

        string output = Generator.GenerateCSharpClass(fontAwesomeInfo);
        File.WriteAllText(@"..\..\..\..\src\FontAwesome.Generated.cs", output);

        foreach (GroupInfo group in fontAwesomeInfo.Groups.Values)
        {
            string groupOutput = Generator.GenerateCSharpClass(group);
            File.WriteAllText($@"..\..\..\..\src\FontAwesome{group.Title}.Generated.cs", groupOutput);
        }
    }
}
