using BenchmarkDotNet.Running;
using SealedClass;

BenchmarkRunner.Run<BenchMarks>();

/* Summary
- Sealed classes perform better than non-sealed classes, however the difference is not significant.
    - Why? 
- From .net7 onwards, the sealed modifier will be default.
- In my opinion the biggest difference is that the sealed modifier marks the user intention to not allow inheritance, which prevents architectural mistakes.
*/

/* What can you learn from this? 
- Set the sealed modifier by default in your project/IDE
    - Rider: Inspection Settings: Class can be made sealed (non-inheritable)
    - Visual Studio Professional: Reshaper: Common Practices and Code Improvements: Class can be made sealed
*/

/* Sources
- Nick Chapsas https://www.youtube.com/watch?v=d76WWAD99Yo&t=4s
- Stephen Toub: https://github.com/dotnet/runtime/issues/49944
- Interesting related discussion https://stackoverflow.com/questions/252257/why-arent-classes-sealed-by-default
*/