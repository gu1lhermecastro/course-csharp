# Language course C# (CSharp)

## Conventions:

1. **Camel Case:** lastName (method parameters, variables within methods)
2. **Pascal Case:** LastNamer (namespace, class, properties and methods)
3. **Standard:** _lastName ("internal" attributes of the class)

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
Use **Console.Write()** that belongs to the namespace **using System;**. User  or **Console.WriteLine()** to display with line break.

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

## Assignment operators:

Operator | Example | Result
--------- | --------- | ---------
 = | a = 10 | 10 
 += | a += 5 | 15 
 -= | a -= 5 | 5 
 *= | a *= 5 | 50 
 /= | a /= 5 | 2 
 %= | a %= 5 | 0 

## Arithmetic operators:

Operator | Example | Result
--------- | --------- | ---------
 ++ | a++ or ++a | a = a + 1 
 -- | a-- or --a | a = a - 1 
 
 ## Implicit conversion and casting:
 
 //TODO
 
 ## Placeholders, interpolation and link:
 
 ```csharp
string name = "Guilherme";
int age = 21;
double balance = 1.500;

//Placeholder
Console.WriteLine("{0} is {1} years old and has balance equal to ${2:F2}", name, age, balance);
//Interpolation
Console.WriteLine($"{name} is {age} years old and has balance equal to ${balance:F2}");
//Link/"Concatenacao" in pt-Br
Console.WriteLine(name + " is " + age + " years old and has balance equal to $ " + balance);
```
