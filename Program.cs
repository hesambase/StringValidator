// See https://aka.ms/new-console-template for more information
using StringValidator;

Solution _solution = new Solution();
string text = "()";
Console.WriteLine("Input string: " + text);
Console.WriteLine("Validation of string: " + _solution.IsValid(text));
text = "()[]{}";
Console.WriteLine("Input string: " + text);
Console.WriteLine("Validation of string: " + _solution.IsValid(text));
text = "[()[]{}]";
Console.WriteLine("Input string: " + text);
Console.WriteLine("Validation of string: " + _solution.IsValid(text));
text = "[()";
Console.WriteLine("Input string: " + text);
Console.WriteLine("Validation of string: " + _solution.IsValid(text));
text = "[)";
Console.WriteLine("Input string: " + text);
Console.WriteLine("Validation of string: " + _solution.IsValid(text));