# System.Enums.FontAwesome

This super small project provides a strongly-typed enumeration that can be used to list icons from https://fontawesome.com/. The enumeration members are marked with [DisplayAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute?view=netcore-3.1)s to make them suitable for being bound to user controls such as selectlists and comboboxes.

The enumeration is defined [here](https://github.com/cesarsouza/sefa/blob/master/src/FontAwesomeIcons.cs). It has been [automatically generated from Font Awesome's all.css file](https://github.com/cesarsouza/sefa/blob/0cc0d9a88d0291618644c554542a8a70f1d6f78c/gen/Program.cs#L9-L17). You can also use the library to parse other versions of Font-Awesome. The [parser and the generator are included in the library](https://github.com/cesarsouza/sefa/blob/master/src/FontAwesomeGenerator.cs).

The license of the project is MIT.
