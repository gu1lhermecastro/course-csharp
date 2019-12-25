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

Console.Write("Hello World!");
```

## How to read keyboard data:
Use **Console.ReadLine()** that belongs to the namespace **using System;**

```csharp
using System;

Console.Write("Enter your name: ");
string name = Console.ReadLine();
```

## How to read and store data separately by spaces:
Use **Split(' ')** to choose the separator string.
```csharp
Console.Write("Enter your last name, age and heigth (same line): ");
string[] array = Console.ReadLine().Split(' ');

string lastName = array[0];
int age = int.Parse(array[1]);
double heigth = double.Parse(array[2]);

Console.WriteLine(lastName);
Console.WriteLine(age);
Console.WriteLine(heigth);
```

