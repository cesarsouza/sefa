// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace System.Enums.Parsing
{
    /// <summary>
    ///   Represents information about a single icon from Font-Awesome.
    /// </summary>
    /// 
    public class IconInfo
    {
        /// <summary>
        ///   Constructs a new <see cref="IconInfo"/> instance.
        /// </summary>
        /// 
        public IconInfo(string id, string character)
        {
            this.Id = id;
            this.Character = character;

            this.Title = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(id.Replace("-", " "));
            this.ClassName = $"fa-{id}";

            this.Name = Title.Replace(" ", "");
            if (char.IsDigit(this.Name[0]))
                this.Name = "F" + this.Name;
        }

        /// <summary>
        ///   Gets or sets the ID for a Font-Awesome icon, e.g., "abacus".
        /// </summary>
        /// 
        public string Id { get; set; }

        /// <summary>
        ///   Gets or sets the enumeration member name for a Font-Awesome icon, e.g., "IconAbacus".
        /// </summary>
        /// 
        public string Name { get; set; }

        /// <summary>
        ///   Gets or sets the display name for a Font-Awesome icon, e.g., "Address Card".
        /// </summary>
        /// 
        public string Title { get; set; }

        /// <summary>
        ///   Gets or sets the css class for a Font-Awesome icon, e.g., "fa-address-card".
        /// </summary>
        /// 
        public string ClassName { get; set; }

        /// <summary>
        ///   Gets or sets the unicode character for a Font-Awesome icon, e.g., "\uf2b9".
        /// </summary>
        /// 
        public string Character { get; set; }

        /// <summary>
        ///   Gets all Font-Awesome style groups that contain this icon, e.g., "solid", "regular", "brands".
        /// </summary>
        /// 
        public Dictionary<string, GroupInfo> Groups { get; set; } = new Dictionary<string, GroupInfo>();

        /// <summary>
        ///   Gets a string representation for this instance.
        /// </summary>
        /// 
        public override string ToString() => $"{Title} ({ClassName}) [{Groups.Values.Select(x => x.ClassName)}]";

    }
}
