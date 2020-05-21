// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

using System.Collections.Generic;
using System.Linq;

namespace System.Enums.Parsing
{
    /// <summary>
    ///   Describes information about Font Awesome icons, such as the css 
    ///   class (e.g., "fa-code-branch"), its title (e.g., "Code Branch"),
    ///   its name (e.g., "CodeBranch"), and its UTF-8 character (e.g., f126).
    /// </summary>
    /// 
    public class FontInfo
    {
        /// <summary>
        ///   Constructs a new <see cref="FontInfo"/> instance.
        /// </summary>
        /// 
        public FontInfo(List<IconInfo> icons)
        {
            CssClasses = icons.Select(x => x.ClassName).ToList();
            MemberNames = icons.Select(x => x.Name).ToList();
            Characters = icons.Select(x => x.Character).ToList();
            Titles = icons.Select(x => x.Title).ToList();
            Icons = icons.ToDictionary(x => x.Id, x => x);
            Groups = icons.SelectMany(x => x.Groups.Values).Distinct().ToDictionary(x => x.Id, x => x);
        }

        /// <summary>
        ///   A list containing the CSS classes for all Font-Awesome icons.
        /// </summary>
        /// 
        public List<string> CssClasses { get; set; }

        /// <summary>
        ///   A list containing the UTF-8 character representations for all Font-Awesome icons.
        /// </summary>
        /// 
        public List<string> Characters { get; set; }

        /// <summary>
        ///   A list containing the enumeration names (in PascalCase) for all Font-Awesome icons.
        /// </summary>
        /// 
        public List<string> MemberNames { get; set; }

        /// <summary>
        ///   A list containing the titles (in Title Case) for all Font-Awesome icons.
        /// </summary>
        /// 
        public List<string> Titles { get; set; }

        /// <summary>
        ///   Gets information about all the <see cref="GroupInfo">style groups</see> in Font-Awesome.
        /// </summary>
        /// 
        public Dictionary<string, GroupInfo>? Groups { get; set; }

        /// <summary>
        ///   Gets information about all the <see cref="IconInfo">icons</see> in Font-Awesome.
        /// </summary>
        /// 
        public Dictionary<string, IconInfo> Icons { get; set; }
    }
}
