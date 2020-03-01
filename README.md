# Language course C# (CSharp)
- [Language conventions](#conventions)
- [Standard structure of an application](#standard-structure)
- [View message on console](#view-message-console)
- [Read keyboard data](#read-keyboard)
- [Functions](#functions)
- [Assignment Operators](#assignment-operators)
- [Nullable](#nullable)
- [Garbage collector](#garbage-collector)
- [Reference types vs value types](#reference-value)
- [Arithmetic operators](#arithmetic-operators)
- [Comparative operators](#comparative-operators)
- [Logical operators](#logical-operators)
- [Conditional structure](#conditional-structure)
- [Placeholders, interpolation and link](#placeholders-interpolation-link)
- [Implicit conversion and casting](#implicit-conversion-casting)
- [How to use Spli](#split)

## <a name="conventions">Conventions:<a/>

1. **Camel Case:** lastName (method parameters, variables within methods)
2. **Pascal Case:** LastNamer (namespace, class, properties and methods)
3. **Standard:** _lastName ("internal" attributes of the class)

## <a name="standard-structure">Standard structure of an application:<a/>

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

## <a name="view-message-console">View message on console:<a/>

Use **Console.Write()** that belongs to the namespace **using System;**. User  or **Console.WriteLine()** to display with line break.

```csharp
using System;

Console.Write("Hello World!");
```
## <a name="read-keyboard">How to read keyboard data:<a/>

Use **Console.ReadLine()** that belongs to the namespace **using System;**

```csharp
using System;

Console.Write("Enter your name: ");
string name = Console.ReadLine();
```

## <a name="split">How to read and store data separately by spaces:<a/>

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
## <a name="assignment-operators">Assignment operators:<a/>

Operator | Example | Result
--------- | --------- | ---------
 = | a = 10 | 10 
 += | a += 5 | 15 
 -= | a -= 5 | 5 
 *= | a *= 5 | 50 
 /= | a /= 5 | 2 
 %= | a %= 5 | 0 

## <a name="arithmetic-operators">Arithmetic operators:<a/>

Operator | Example | Result
--------- | --------- | ---------
 ++ | a++ or ++a | a = a + 1 
 -- | a-- or --a | a = a - 1 
 
## <a name="comparative-operators">Comparative operators:<a/>

Operator | Example | Result
--------- | --------- | ---------
 ">" | 10 > 15 | false 
 "<" | 10 < 15 | true 
 ">=" | 10 >= 15 | false 
 "<=" | 10 <= 15 | true 
 "==" | 10 == 15 | false 
 "!=" | 10 != 15 | true 
 
 ## <a name="logical-operators">Logical operators:<a/>

Operator | Example | Result
--------- | --------- | ---------
 && | true && true | true 
 && | true && false | false
 // | true // true | true 
 // | true // false | true
 // | false // false | false
 !| negation 
 
 ## <a name="implicit-conversion-casting">Implicit conversion and casting:<a/>

 //TODO

 ## <a name="placeholders-interpolation-link">Placeholders, interpolation and link:<a/>

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

## <a name="conditional-structure">Conditional structure:<a/>

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

## <a name="functions">Functions:<a/>

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

## Access modifiers

 empty | própria classe | classes do assembly | subclasses no assembly | classes fora do assembly | subclasses fora do assembly
--------- | --------- | --------- | --------- | --------- | ---------
 public | x | x | x | x | x |
 internal | x | x | x |  | x |
 protected internal | x | x | x |  |  |
 protected | x |  | x |  | x |
 private protected | x |  | x |  |  |
 private | x |  |  |  |  |

## <a name="reference-value">Reference types vs value types:<a/>

 Class | Struct
 --------- | --------- 
 Advantage: Enjoy all OO features | Advantage: it's simple and more performative 
 Objects need to be instantiated using new, or point to an existing object. | You don't have to instantiate using new, but it's possible to 
 Accepts null value | Does not accept null value 
 Heritage Support | It does not support inheritance(but can implement interfaces) 
 Y = X; "Y goes on to point to where X is pointing at that moment" | Y = X; "Y receives a copy of X" 
 Instantiated objects in heap | Instantiated objects in the stack 
 Unused objects are delocated at a time near garbage collector | "Objects" are deallocated immediately when their execution scope is finalized 
 Variables are pointers | Variables are boxes

## <a name="garbage-collector">Garbage collector:<a/>

* It is a process that automates the memory management of a running program.
* Garbage collector monitors objects dynamically allocated by the program (in heap), delocating those that are no longer being used.
* Dynamically allocated objects, when they no longer have reference to them, will be deallocated by garbage collector.
* Local variables are deallocated immediately as soon as their local scope exits execution.

## <a name="nullable">Nullable:<a/>

* It is a C# feature so that value-type data (structs) can receive the null value.
* Common use:
    * Database fields that can valr null (date of birth, some numeric value, etc.).
    * Optional data and parameters.
* Methods:
	* GetValueOrDefault: Takes the value of the variable, but if there is no value, it takes the default value of its type.
	* HasValue : Returns a bolean checking whether or not there is value.
	* Value : Returns the value, but if there is no throws an exception.

```csharp
// The question mark (?) tells the compiler that the variable CAN BE NULL.
double? x = null;
double? y = 10.0;

Console.WriteLine(x.GetValueOrDefault()); // 0
Console.WriteLine(y.GetValueOrDefault()); // 10

Console.WriteLine(x.HasValue); // False
Console.WriteLine(y.HasValue); // True

if (x.HasValue) // If not was verification - Unhandled Expection: Nullable object must have a value.
	Console.WriteLine(x.Value);
else
	Console.WriteLine("X is null");
if (y.HasValue)
	Console.WriteLine(y.Value);
else
	Console.WriteLine("Y is null");
```

### Coalescence operator:

* If the value is null, IT RECEIVES THE VALUE FROM THE RIGHT.
```csharp
double? x = null;
double y = x ?? 10;
```
## Parameter modifier: params

* Suppose you want a calculator to calculate the sum of an amount variable of values. Bad solution would be using overload:

```csharp
public static int Sum(int n1, int n2) {
	return n1 + n2;
}
public static int Sum(int n1, int n2, int n3) {
	return n1 + n2 + n3;
}
public static int Sum(int n1, int n2, int n3, int n4) {
	return n1 + n2 + n3 + n4;
}
```

* Vector solution:
```csharp
public static int Sum(int[] numbers) {
	int sum = 0;
	for (int i=0; i<numbers.Length; i++) {
		sum += numbers[i];
	}
	return sum;
}
```
```csharp
int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });
```

* Solution with modifier params:

```csharp
public static int Sum(params int[] numbers) {
	int sum = 0;
	for (int i=0; i<numbers.Length; i++) {
		sum += numbers[i];
	}
	return sum;
}
```
```csharp
int result = Calculator.Sum(10, 20, 30, 40);
```
## Handling exceptions with Try-Catch scopes:

## Scope try:

* Contains code that represents the normal execution of the code trech that can incur an exception.

## Scope catch:

* Contains the code to run if an exception occurs.
* The type of exception to be handled must be specified (upcasting is allowed)

## Scope finally:

* It is a scope that contains the code to run regardless of whether or not an exception occurred.

	* Examples of use: close a file or connection to the database at the end of processing.

Demo:
```csharp
try
{
	Console.Write("Enter first value: ");
        int value1 = int.Parse(Console.ReadLine());

	Console.Write("Enter second value: ");
        int value2 = int.Parse(Console.ReadLine());

	double result = value1 / value2;
        Console.WriteLine(result);
}
catch(DivideByZeroException e)
{
	Console.WriteLine(e.Message);
}
catch(FormatException e)
{
	Console.WriteLine(e.Message);
}
finally
{
	Console.WriteLine("Execution regardless of exception posting or not.");
}
```
