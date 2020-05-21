// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

using System.ComponentModel.DataAnnotations;

namespace System.Enums
{
    /// <summary>
    ///   Extension methods for working with <see cref="FontAwesome"/> enumerations.
    /// </summary>
    /// 
    public static partial class Extensions
    {
        /// <summary>;
        ///   Gets the CSS style definition for a <see cref="FontAwesome">icon</see>
        ///   with a particular <see cref="FontAwesomeStyle">style</see>. Please note
        ///   that not all styles work with every icon.
        /// </summary>
        /// 
        public static string GetCss(this FontAwesome icon, FontAwesomeStyle style)
        {
            return $"{style.GetCss()} {icon.GetCss()}";
        }
    }
}
