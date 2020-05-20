// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

namespace System.Enums.FontAwesome
{
    /// <summary>
    ///   Extension methods for handling <see cref="FontAwesome"/> enumeration members.
    /// </summary>
    /// 
    public static partial class Extensions
    {
        /// <summary>
        ///   Gets the CSS class associated with a <see cref="FontAwesomeIcons"/> icon.
        /// </summary>
        /// 
        public static string GetCss(this FontAwesomeIcons icon)
        {
            return values[icon];
        }

        /// <summary>
        ///   Gets the UTF-8 char associated with a <see cref="FontAwesomeIcons"/> icon.
        /// </summary>
        /// 
        public static char GetChar(this FontAwesomeIcons icon)
        {
            return (char)icon;
        }
    }
}
