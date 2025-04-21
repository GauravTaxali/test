using interfaces.Implementations;
using interfaces.Interfaces;
using interfaces.POCO;

ISayHello sayHello = new SayHelloOne();
sayHello.SayHello("World1");

SaySomething saySomething = new SaySomething();
saySomething.SayAnything("World2");

SaySomething2 saySomething2 = new SaySomething2();
saySomething2.SayAnything("World3");

SaySomething3 saySomething3 = new SaySomething3();
saySomething3.SayAnything("World4");

IMath math = new SayMath();
int result = math.Add(5, 10);
Console.WriteLine($"Addition Result: {result}");

NextLevel fucns = new SayNext();
fucns.PrintMessage("Hello, World!", 3);
var GenerateFibonacci = fucns.GenerateFibonacci(10);
Console.WriteLine("Fibonacci Numbers: " + string.Join(", ", GenerateFibonacci));