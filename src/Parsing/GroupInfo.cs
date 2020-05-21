// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

using System.Collections.Generic;
using System.Globalization;

namespace System.Enums.Parsing
{
    /// <summary>
    ///   Represents information about a style group for Font-Awesome, e.g., "solid", "brands", or "regular".
    /// </summary>
    /// 
    public class GroupInfo
    {
        /// <summary>
        ///   Constructs a new <see cref="GroupInfo"/> instance.
        /// </summary>
        /// 
        public GroupInfo(string id)
        {
            this.Id = id;
            this.Title = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(id.Replace("-", " "));
            this.Name = this.Title.Replace(" ", "");
            this.Postfix = Id[0];
            this.ClassName = "fa" + this.Postfix;
        }

        /// <summary>
        ///   Gets or sets the ID for a Font-Awesome style group, e.g., "brands".
        /// </summary>
        /// 
        public string Id { get; set; }

        /// <summary>
        ///   Gets or sets the display name for a Font-Awesome style group, e.g., "Brands".
        /// </summary>
        /// 
        public string Title { get; set; }

        /// <summary>
        ///   Gets or sets the postfix character for a Font-Awesome style group, e.g., 
        ///   "b" for brands. This is always the last char in <see cref="ClassName"/>.
        /// </summary>
        /// 
        public char Postfix { get; set; }

        /// <summary>
        ///   Gets or sets the enumeration member name for a Font-Awesome style, e.g., "Solid".
        /// </summary>
        /// 
        public string Name { get; set; }

        /// <summary>
        ///   Gets or sets the css class name for a Font-Awesome style group, e.g., "fab".
        /// </summary>
        /// 
        public string ClassName { get; set; }

        /// <summary>
        ///   Gets all <see cref="IconInfo">icons</see> that can be used withing this style group.
        /// </summary>
        /// 
        public Dictionary<string, IconInfo> Icons { get; set; } = new Dictionary<string, IconInfo>();

        /// <summary>
        ///   Gets a string representation for this instance.
        /// </summary>
        /// 
        public override string ToString() => $"{Title} ({Id}): {Icons.Count} icons";
    }
}
