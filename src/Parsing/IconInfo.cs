// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace System.Enums.Parsing
{
    public class IconInfo
    {
        public IconInfo(string id, string character)
        {
            this.Id = id;
            this.Character = character;

            this.Title = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(id.Replace("-", " "));
            this.ClassName = $"fa-{id}";

            this.Name = "Icon" + Title.Replace(" ", "");
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ClassName { get; set; }
        public string Character { get; set; }

        public Dictionary<string, GroupInfo> Groups { get; set; } = new Dictionary<string, GroupInfo>();

        public override string ToString() => $"{Title} ({ClassName}) [{Groups.Values.Select(x => x.ClassName)}]";

    }
}
