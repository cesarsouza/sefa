// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace System.Enums.FontAwesome
{
    public static partial class FontAwesomeGenerator
    {

        /// <summary>
        ///   Parses a Font-Awesome CSS file retrieved from an URL (e.g. "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.css").
        /// </summary>
        /// 
        public static async Task<FontAwesomeContent> GetAndParseAsync(string sourceUrl)
        {
            return ParseString(await new HttpClient().GetStringAsync(sourceUrl));
        }

        /// <summary>
        ///   Parses a Font-Awesome CSS file contained within a string.
        /// </summary>
        /// 
        public static FontAwesomeContent ParseString(string cssFileContents)
        {
            Regex classMatcher = new Regex(@"\.fa-(.*)(?<!px)\:before.*");
            Regex contentMatcher = new Regex(@"\.*content: \""\\(.*)\""");

            TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;

            var cssClass = new List<string>();
            var utfChars = new List<string>();

            var textNames = new List<string>();
            var enumNames = new List<string>();

            string[] lines = cssFileContents.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                var match = classMatcher.Match(lines[i]);
                if (match.Success)
                {
                    string value = match.Groups[1].Value;
                    string titleCase = textInfo.ToTitleCase(value.Replace("-", " "));
                    string pascalCase = titleCase.Replace(" ", "");

                    textNames.Add(titleCase);
                    enumNames.Add(pascalCase);

                    cssClass.Add("fa-" + value);
                    utfChars.Add(contentMatcher.Match(lines[i + 1]).Groups[1].Value);
                }
            }

            return new FontAwesomeContent
            {
                Classes = cssClass,
                Characters = utfChars,
                Titles = textNames,
                Names = enumNames
            };
        }

        /// <summary>
        ///   Generates a C# class defining an enumeration for Font Awesome icons. See
        ///   the generator program at https://github.com/cesarsouza/sefa for an example.
        /// </summary>
        /// 
        public static string GenerateCSharpClass(FontAwesomeContent content,
            string namespaceName = "System.Enums.FontAwesome", string className = "FontAwesomeIcons")
        {
            var classes = content.Classes;
            var chars = content.Characters;

            var titles = content.Titles;
            var names = content.Names;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("// Copyright (c) 2020 César Roberto de Souza. All rights reserved.");
            sb.AppendLine("// This work is licensed under the terms of the MIT license. See");
            sb.AppendLine("// the license at https://opensource.org/licenses/MIT for details.");
            sb.AppendLine();
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.ComponentModel.DataAnnotations;");
            sb.AppendLine();
            sb.AppendLine($"namespace {namespaceName}");
            sb.AppendLine("{");
            sb.AppendLine($"    /// <summary>");
            sb.AppendLine($"    ///     Represents all icon characters in the free Font-Awesome icons library.");
            sb.AppendLine($"    ///     The members of this enumeration are marked with DisplayAttribute to help");
            sb.AppendLine($"    ///     show extra information about them in user forms more easily.");
            sb.AppendLine($"    /// </summary>");
            sb.AppendLine($"    /// ");
            sb.AppendLine($"    public enum {className}");
            sb.AppendLine("    {");
            for (int i = 0; i < classes.Count; i++)
            {
                sb.AppendLine($"        [Display(Name = \"{titles[i]}\", Description = \"{classes[i]}\")]");
                sb.AppendLine($"        {names[i]} = '\\u{chars[i]}',");
                sb.AppendLine($"        ");
            }
            sb.AppendLine("    }");
            sb.AppendLine("    ");
            sb.AppendLine("    public static partial class Extensions");
            sb.AppendLine("    {");

            sb.AppendLine("        static Dictionary<FontAwesomeIcons, string> values = new Dictionary<FontAwesomeIcons, string>");
            sb.AppendLine("        {");
            for (int i = 0; i < classes.Count; i++)
                sb.AppendLine($"            {{ FontAwesomeIcons.{names[i]}, \"{classes[i]}\" }},");
            sb.AppendLine("        };");
            sb.AppendLine("    }");
            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}
