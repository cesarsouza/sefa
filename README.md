<img align="right" src="https://github.com/cesarsouza/sefa/raw/master/src/Resources/sefa.png" width="55" height="48"><h1><b>S</b>ystem.<b>E</b>nums.<b>F</b>ont<b>A</b>wesome (sefa)</h1>

![Nuget](https://img.shields.io/nuget/v/sefa)

This super small project provides strongly-typed enumerations that can be used to list icons from https://fontawesome.com/. Enumeration members are marked with [DisplayAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.displayattribute?view=netcore-3.1)s to make them suitable for being bound to user controls such as selectlists and comboboxes.

  <pre>PM> Install-Package <b>sefa</b></pre>

The enumerations are defined [here](https://github.com/cesarsouza/sefa/blob/master/src/FontAwesome.Generated.cs) and are separated by style groups (e.g., [brands](https://github.com/cesarsouza/sefa/blob/master/src/FontAwesomeBrands.Generated.cs), [regular](https://github.com/cesarsouza/sefa/blob/master/src/FontAwesomeRegular.Generated.cs), [duotone](https://github.com/cesarsouza/sefa/blob/master/src/FontAwesomeDuotone.Generated.cs)). They have been [automatically generated from Font Awesome's all.css file](https://github.com/cesarsouza/sefa/blob/ff85e9708c338ef0e79462e657690f556974e8d1/gen/Program.cs#L9-L21). You can also use the library to parse other versions of Font-Awesome. The [parser and the generator are included in the library](https://github.com/cesarsouza/sefa/blob/master/src/CodeGeneration/Generator.cs).

The project's source code is available under the <b>MIT</b> license. The project logo is a dubious-taste adaptation of Font-Awesome's <i>couch-solid</i> SVG icon and is therefore also available under the same CC BY 4.0 license as the original.


-----

See also:
 - [System.Enums.GeoNames (segn)](https://github.com/cesarsouza/segn): strongly typed enumerations for the [GeoNames Geographical Database](https://www.geonames.org/).
