﻿using ClassLibrary;

var p1 = new Person { FirstName = "Alex", LastName = "Stone", Age = 50 };
var p2 = new Person { FirstName = "Sing", LastName = "Edge", Age = 30 };


Console.WriteLine($"Person 1 : {p1.FirstName} {p1.LastName} BEFORE method");
Swap<Person>(ref p1, ref p2);
Console.WriteLine($"Person 1 : {p1.FirstName} {p1.LastName} OUTSIDE method");

int x = 5, y = 7;
Console.WriteLine($"X : {x} y : {y} BEFORE method");
Swap<int>(ref x,ref y);
Console.WriteLine($"X : {x} y : {y} OUTSIDE method");

static void Swap<T>(ref T first, ref T second) // provide T type generics
    {
    T temp = second;
    second = first;
    first = temp;
    Console.WriteLine($"X : {first} y : {second} INSIDE method");
    }