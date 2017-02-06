# A repository comparing SharpKit with Bridge.NET (and possibly others)

You can find here some ways how to share code between server (.NET framework) and client (a javascript generated from C#). All versions always contains three projects.

 - ***Server*** containing a typical server code like web services.
 - ***Client*** containing only client side logic for processing data received through web service and rendering UI.
 - ***Shared*** containing classes shared between Client and Server. All models for communication and possibly a shared logic.

## SharpKit (plain)

A standard library with enabled SharpKit and configured to export all code to a single `.js` file.

## SharpKit (UnobtrusiveFeatures)

A SharpKit enabled library containing [UnobtrusiveFeatures](https://github.com/maraf/SharpKit.UnobtrusiveFeatures) plugin for no-reference exporting library to javascript. 

## Bridge.NET (separated csproj)

As Bridge.NET requires reference to `Bridge.dll` through nuget package, there is a need for managing references independently.
