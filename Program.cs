using assembler.Assembly.Functions;
using assembler.Assembly;

Interpreter myInterpreter = new Interpreter();
Functions functions = new Functions();
functions.interpreter = myInterpreter;

int x;
//Console.WriteLine(functions.CalculateAttackValue(10, myInterpreter));


Console.WriteLine("VUELTAS: ");
x = Convert.ToUInt16(Console.ReadLine());
functions.SettingValues(20);
for (int i = 1; i < x; i++)
{
    Console.WriteLine(functions.RotateNumber(i));
}




