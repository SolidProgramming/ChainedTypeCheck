## Usage
Add `IChainable` Interface to the code you want to check which need to a reference type like `class`.

```csharp
﻿global using TypeCheckTest.Interfaces;
global using TypeCheckTest.Models;
using TypeCheckTest.Classes;

A a = new(); //Base

(bool isNull, object? lastObj) = a.IsChainNull();

Console.WriteLine($"{lastObj} is the last object in the chain that is not null");
Console.ReadKey();
```
See [/Models/A.cs](TypeCheckTest/Models/A.cs)
<br/>

### Result for example
```plaintext
TypeCheckTest.Models.C is the last object in the chain that is not null
```
