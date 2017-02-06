# A repository comparing SharpKit with Bridge.NET (and possibly others)

You can find here some ways how to share code between server (.NET framework) and client (a javascript generated from C#).

## SharpKit (plain)

A standard library with enabled SharpKit and configured to export all code to a single `.js` file.

## SharpKit (UnobtrusiveFeatures)

A SharpKit enabled library containing [UnobtrusiveFeatures](https://github.com/maraf/SharpKit.UnobtrusiveFeatures) plugin for no-reference exporting library to javascript. 

## Bridge.NET (separated csproj)

As Bridge.NET requires reference to `Bridge.dll` through nuget package, there is a need for managing references independently.
