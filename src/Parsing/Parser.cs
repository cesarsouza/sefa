// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace System.Enums.Parsing
{
    /// <summary>
    ///   Static methods for parsing Font-Awesome .CSS files and generating C# source files.
    /// </summary>
    /// 
    public static partial class Parser
    {

        /// <summary>
        ///   Parses a Font-Awesome CSS file retrieved from an URL (e.g. "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.css").
        /// </summary>
        /// 
        /// <param name="cheatshetsUrl">The (optional) URL for FontAwesome's website to be used to obtain information about icon groups.</param>
        /// <param name="sourceUrl">The URL for a particular version of Font-Awesome, e.g., "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.css"</param>
        /// 
        public static async Task<FontInfo> GetAndParseAsync(string sourceUrl, string cheatshetsUrl = "https://fontawesome.com/cheatsheet/")
        {
            List<GroupInfo>? iconGroups = null;

            if (cheatshetsUrl != null)
                iconGroups = await GetCheatSheetsAndParseAsync(cheatshetsUrl);

            return ParseString(await new HttpClient().GetStringAsync(sourceUrl), iconGroups);
        }

        /// <summary>
        ///   Parses a Font-Awesome CSS file contained within a string.
        /// </summary>
        /// 
        /// <param name="cssFileContents">The contents of one of Font-Awesome's CSS files, e.g., contents of "all.css"</param>
        /// <param name="groups">An (optional) list containing extended information about icon groups.</param>
        /// 
        public static FontInfo ParseString(string cssFileContents, List<GroupInfo>? groups = null)
        {
            Regex classMatcher = new Regex(@"\.fa-(.*)\:before.*");
            Regex contentMatcher = new Regex(@"\.*content: \""\\(.*)\""");

            var icons = new List<IconInfo>();

            string[] lines = cssFileContents.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                var match = classMatcher.Match(lines[i]);
                if (match.Success)
                {
                    string id = match.Groups[1].Value;
                    string utf8char = contentMatcher.Match(lines[i + 1]).Groups[1].Value;

                    IconInfo info = new IconInfo(id, utf8char);

                    if (groups != null)
                    {
                        foreach (GroupInfo g in groups.Where(x => x.Icons.ContainsKey(id)))
                            info.Groups.Add(g.Id, g);
                    }

                    icons.Add(info);
                }
            }

            return new FontInfo(icons);
        }

        /// <summary>
        ///   Parses a Font-Awesome cheatsheet (from https://fontawesome.com/cheatsheet/free/) contained within a string.
        /// </summary>
        /// 
        public static async Task<List<GroupInfo>> GetCheatSheetsAndParseAsync(string cheatsheetUrl = "https://fontawesome.com/cheatsheet/")
        {
            string content = await new HttpClient().GetStringAsync(cheatsheetUrl);

            Regex vueMatcher = new Regex(@"window.__inline_data__ =(.*)");
            string inlineData = vueMatcher.Match(content).Groups[1].Value;
            JArray? jArray = JsonConvert.DeserializeObject(inlineData) as JArray;

            if (jArray == null)
                throw new FormatException("Unable to parse Font-Awesome's website: main content not found.");

            JToken? data = jArray[2]["data"];
            if (data == null)
                throw new FormatException("Unable to parse Font-Awesome's website: data element not found.");

            var groups = new Dictionary<string, GroupInfo>();
            var icons = new Dictionary<string, IconInfo>();

            foreach (JToken iconToken in data.Children())
            {
                JToken? attr = iconToken["attributes"];
                if (attr == null)
                    throw new FormatException("Unable to parse Font-Awesome's website: Attributes not found.");

                string? id = attr["id"]?.ToString();
                if (id == null)
                    throw new FormatException("Unable to parse Font-Awesome's website: Icon ID not found.");

                string? character = attr["unicode"]?.ToString();
                if (character == null)
                    throw new FormatException("Unable to parse Font-Awesome's website: Unicode character not found.");

                List<string>? styles = attr["styles"]?.ToObject<List<string>>();
                if (styles == null)
                    throw new FormatException("Unable to parse Font-Awesome's website: Style list not found.");


                if (!icons.TryGetValue(id, out IconInfo icon))
                    icons[id] = icon = new IconInfo(id: id, character: character);

                foreach (string style in styles)
                {
                    if (!groups.TryGetValue(style, out GroupInfo group))
                        groups[style] = group = new GroupInfo(style);

                    if (group.Icons.ContainsKey(id))
                        throw new ApplicationException("Duplicate item found while parsing Font-Awesome website.");

                    group.Icons[id] = icon;
                    icon.Groups[style] = group;
                }
            }

            return groups.Values.ToList();
        }

    }
}
