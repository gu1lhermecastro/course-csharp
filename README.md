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
 
 ## Comparative operators:

Operator | Example | Result
--------- | --------- | ---------
 ">" | 10 > 15 | false 
 "<" | 10 < 15 | true 
 ">=" | 10 >= 15 | false 
 "<=" | 10 <= 15 | true 
 "==" | 10 == 15 | false 
 "!=" | 10 != 15 | true 
 
 ## Logical operators:

Operator | Example | Result
--------- | --------- | ---------
 && | true && true | true 
 && | true && false | false
 // | true // true | true 
 // | true // false | true
 // | false // false | false
 !| negation 
 
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

## Conditional structure:

Simple:

```csharp
if (condition) {
    //comand
}
```

Composite:

```csharp
if (condition) {
    //comand 1
} else {
    //comand 2
}
```
Interlink:

```csharp
if (condition1) {
    //comand 1
} if (condition2) {
    //comand 2
}else {
    //comand 3
}
```

## Functions:

1. Main advantages: modularization, delegation and reuse.

2. Input and output data:
* Functions may or may not receive input data (parameters or arguments)
* Functions may or may not return an output

3. In OOP, functions in classes are known as "methods".

## Class:
1. It is a model for an object, an object has:
* Attributes (data/fields)
* Methods (functions/operations/methods/actions)

2. They are also characteristics of a class:
* Builders
* Overload
* Encapsulation
* Inheritance
* Polymosphism

Examples of use:
* Entities: Product, Customer and etc.
* services: ProductService, ClienteService, EmailService, StorageService
* Controllers: ProductController, ClienteController
* Utilities: Calculator, Compactor
* Others (views, repositories, managers and etc.)

Suggested orgem for organizing a class

* Private attributes
* Self-implemented properties
* Constructors
* Custom properties
* Other class methods

## Using the this:

* It is a reference to the object itself.

* Common uses:
1. Differentiate attributes from the class of local variables (Java)
2. Reference another constructor in a constructor
3. Pass the object prio as an argument in the call of a method or constructor

```csharp
public Product(string Name) {
    this.Name = Name;
}

public Product(string Name, double Price, int Quantity) : this(Name) {
    this.Price = Price;
    this.Quantity = Quantity;
}
```

## Encapsulation:
//Coming soon

```csharp
private string _name;
private double _price;
private int _quantity;

public string GetName() {
    return this._name;
}

public void SetName(string name) {
    if (name != null && name.Length > 1) {
        this._name = name;
    }
}
```
## Properties:
//Coming soon

```csharp
private string _name;
private double _price;
private int _quantity;

public string Name {
    get { return _name; }
    set {
        if (value != null && value.Length > 1) {
            _name = value;
        }
    }
}
```

## Auto properties:
//Coming soon

```csharp
private string _name;
public double Price { get; private set; }
public int Quantity { get; set; }

public string Name {
    get { return _name; }
    set {
        if (value != null && value.Length > 1) {
            _name = value;
        }
    }
}
```
