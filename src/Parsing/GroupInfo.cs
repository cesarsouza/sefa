// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

using System.Collections.Generic;
using System.Globalization;

namespace System.Enums.Parsing
{
    public class GroupInfo
    {
        public GroupInfo(string id)
        {
            this.Id = id;
            this.Title = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(id.Replace("-", " "));
            this.ClassName = "fa" + Id[0];
        }

        public string Id { get; set; }

        public string Title { get; set; }

        public string ClassName { get; set; }

        public Dictionary<string, IconInfo> Icons { get; set; } = new Dictionary<string, IconInfo>();

        public override string ToString() => $"{Title} ({Id}): {Icons.Count} icons";
    }
}
