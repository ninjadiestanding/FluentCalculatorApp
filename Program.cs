using FluentCalculatorApp;

var someBool = new SomeBool(true);
Console.WriteLine(someBool == true && someBool == false); //true

var FluentCalculator = new FluentCalculator();
var result = FluentCalculator.one.plus.two.plus.three.minus.one.minus.two.minus.four; 
Console.WriteLine(result.Value); //-1
Console.ReadLine();