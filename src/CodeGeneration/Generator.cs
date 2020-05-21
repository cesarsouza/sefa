// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

using System.Collections.Generic;
using System.Enums.Parsing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace System.Enums.CodeGeneration
{
    /// <summary>
    ///   Static methods for parsing Font-Awesome .CSS files and generating C# source files.
    /// </summary>
    /// 
    public static partial class Generator
    {
        /// <summary>
        ///   Generates a C# class defining an enumeration for Font Awesome icons. See
        ///   the generator program at https://github.com/cesarsouza/sefa for an example.
        /// </summary>
        /// 
        public static string GenerateCSharpClass(FontInfo fontInfo,
            string namespaceName = "System.Enums", string enumName = "FontAwesome")
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendHeader(namespaceName);
            sb.AppendLine($"    /// <summary>");
            sb.AppendLine($"    ///     Represents all icon characters in the free Font-Awesome icons library.");
            sb.AppendLine($"    ///     The members of this enumeration are marked with DisplayAttribute to help");
            sb.AppendLine($"    ///     show extra information about them in user forms more easily.");
            sb.AppendLine($"    /// </summary>");
            sb.AppendLine($"    /// ");
            sb.AppendLine($"    public enum {enumName} : uint");
            sb.AppendLine(@"    {");
            foreach (IconInfo icon in fontInfo.Icons.Values.OrderBy(x => x.Id))
            {
                string additionalText = GetGroupNameDisplayAttributeText(icon);
                sb.AppendLine($"        /// <summary>");
                sb.AppendLine($"        ///     {icon.Title} (\"{icon.ClassName}\", \\u{icon.Character}) icon.");
                sb.AppendLine($"        /// </summary>");
                sb.AppendLine($"        /// ");
                sb.AppendLine($"        [Display(Name = \"{icon.Title}\", Description = \"{icon.ClassName}\"{additionalText})]");
                sb.AppendLine($"        {icon.Name} = '\\u{icon.Character}',");
                sb.AppendLine($"        ");
            }
            sb.AppendLine(@"    }");
            sb.AppendLine(@"    ");
            sb.AppendExtensions(fontInfo.Icons.Values, enumName, groupClassName: String.Empty);
            sb.AppendLine(@"}");
            return sb.ToString();
        }

        /// <summary>
        ///   Generates a C# class defining an enumeration for Font Awesome icons. See
        ///   the generator program at https://github.com/cesarsouza/sefa for an example.
        /// </summary>
        /// 
        public static string GenerateCSharpClass(GroupInfo groupInfo,
            string namespaceName = "System.Enums", string? enumName = null)
        {
            if (enumName == null)
                enumName = "FontAwesome" + groupInfo.Title;

            StringBuilder sb = new StringBuilder();
            sb.AppendHeader(namespaceName);
            sb.AppendLine($"    /// <summary>");
            sb.AppendLine($"    ///     Represents free Font-Awesome icons contained in the group {groupInfo.Title}.");
            sb.AppendLine($"    /// </summary>");
            sb.AppendLine($"    /// ");
            sb.AppendLine($"    public enum {enumName} : uint");
            sb.AppendLine("    {");
            foreach (IconInfo icon in groupInfo.Icons.Values.OrderBy(x => x.Id))
            {
                sb.AppendLine($"        /// <summary>");
                sb.AppendLine($"        ///     {icon.Title} (\"{icon.ClassName}\", \\u{icon.Character}) icon.");
                sb.AppendLine($"        /// </summary>");
                sb.AppendLine($"        /// ");
                sb.AppendLine($"        [Display(Name = \"{icon.Title}\", Description = \"{groupInfo.ClassName} {icon.ClassName}\")]");
                sb.AppendLine($"        {icon.Name} = '\\u{icon.Character}',");
                sb.AppendLine($"        ");
            }
            sb.AppendLine("    }");
            sb.AppendLine("    ");
            sb.AppendExtensions(groupInfo.Icons.Values, enumName, groupClassName: groupInfo.ClassName);
            sb.AppendLine("}");

            return sb.ToString();
        }



        private static string GetGroupNameDisplayAttributeText(IconInfo icon)
        {
            if (icon.Groups.Count == 0)
                return String.Empty;

            IEnumerable<string> names = icon.Groups.Keys.OrderBy(x => x);
            return $", GroupName = \"{String.Join(" ", names)}\"";
        }


        private static void AppendHeader(this StringBuilder sb, string namespaceName)
        {
            sb.AppendLine(@"// Copyright (c) 2020 César Roberto de Souza. All rights reserved.");
            sb.AppendLine(@"// This work is licensed under the terms of the MIT license. See");
            sb.AppendLine(@"// the license at https://opensource.org/licenses/MIT for details.");
            sb.AppendLine();
            sb.AppendLine(@"using System.ComponentModel.DataAnnotations;");
            sb.AppendLine();
            sb.AppendLine($"namespace {namespaceName}");
            sb.AppendLine(@"{");
        }

        private static void AppendExtensions(this StringBuilder sb, IEnumerable<IconInfo> icons, string enumName, string groupClassName)
        {
            sb.AppendLine(@"    public static partial class Extensions");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"        /// <summary>");
            sb.AppendLine($"        ///   Gets the CSS class associated with a <see cref=\"{enumName}\"/> icon.");
            sb.AppendLine(@"        /// </summary>");
            sb.AppendLine(@"        /// ");
            sb.AppendLine($"        public static string GetCss(this {enumName} icon) => icon switch");
            sb.AppendLine(@"        {");
            foreach (IconInfo icon in icons.OrderBy(x => x.Id))
            {
                string className = $"{groupClassName} {icon.ClassName}".Trim();
                sb.AppendLine($"            {enumName}.{icon.Name} => \"{className}\",");
            }
            sb.AppendLine($"            _ => throw new ArgumentOutOfRangeException(nameof(icon))");
            sb.AppendLine(@"        };");
            sb.AppendLine("");
            sb.AppendLine(@"        /// <summary>");
            sb.AppendLine($"        ///   Gets the UTF-8 char associated with a <see cref=\"{enumName}\"/> icon.");
            sb.AppendLine(@"        /// </summary>");
            sb.AppendLine(@"        /// ");
            sb.AppendLine($"        public static char GetUnicode(this {enumName} icon) => (char)icon;");
            sb.AppendLine(@"    }");
        }
    }
}
