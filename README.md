# course-csharp

## Standard structure of an application:
```csharp
using System;

namespace LogicWithCSharp {
    class Program {
        static void Main(string[] args) {
            Console.Write("Hello World!");
        }
    }
}
```
```csharp
using System;
```
Used for
```csharp
namespace LogicWithCSharp {}
```
Used for
```csharp
class Program {}
```
Used for

```csharp
static void Main(string[] args) {}
```
Used for


## View message on console:
Use **Console.Write()** that belongs to the namespace **using System;**

```csharp
using System;

namespace RememberLogicWithCSharp {
    class Program {
        static void Main(string[] args) {
            Console.Write("Hello World!");
        }
    }
}
```

## How to read keyboard data:
Use Use **Console.ReadLine()**

```csharp
Console.Write("Enter your name: ");
string name = Console.ReadLine();
```
