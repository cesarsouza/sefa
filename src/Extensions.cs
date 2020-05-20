﻿// Copyright (c) 2020 César Roberto de Souza. All rights reserved.
// This work is licensed under the terms of the MIT license. See
// the license at https://opensource.org/licenses/MIT for details.

namespace System.Enums.FontAwesome
{
    public static partial class Extensions
    {
        public static string GetCss(this FontAwesomeIcons icon)
        {
            return values[icon];
        }
    }
}