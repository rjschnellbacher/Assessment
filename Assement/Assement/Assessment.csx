//// Assessment File for Ron Schnellbacher
//// Part One
//Declare and initialize 5 different types.
//  Int, Boolean, String, Double, Decimal
//2.Write a function that takes two of your variables from #1 
//  and combines two or more of them into a string. For instance:
//    I have been happily married to Esther for 14 years.
//3.Print the string to the console.
//4.Create an array of strings, a simple array of 3-5 names
//  of your closest friends or family will suffice.
//5.Loop over the array and print it to the console
//===================================================

// Part 1: Tasks 1,2,3
using System;

 int     shootings = 35;
 bool    neverTrump = true;
 string  slogan1 = "Cleveland Rocks for Drew Carey";
 string  slogan2 = "Bernie Supporters are each worth";
 double  protestPeople = 456789;
 decimal bworth = 27.39m;

string convNews
    (string slogan, decimal value) {
    var news2 = slogan2 + " " + bworth;
    return news2;
}

var blurb = convNews(slogan2, bworth);
Console.WriteLine(blurb);
