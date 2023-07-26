using assembler;

Interpreter interpreter = new Interpreter();
PruebaDeSaltos(interpreter);
int RandomNumber(int valor, int increment, Interpreter interpreter)
{
    string RandomNumber = @"
        MOV AX, " + Convert.ToString(valor, 2)+ @"B;Numero que voy a operar
        MOV CX, "+increment+@"d ; Cantidad de bits a desplazar
        ROR AX, CL 
        MOV BX, 000Fh ; Mascara para conseguir los ultimos 4 bits
        XOR AX, BX ; Aplico la mascara a AX

        MOV AH, 4Ch
        INT 21
    ";
    interpreter.Run(RandomNumber);
    return  Convert.ToUInt16(interpreter.GetRegister("AX")); // le devuelvo AX
}

void PruebaDeSaltos(Interpreter interpreter)
{
    string RandomNumber = @"
        MOV AX, 0001h
        PUSH AX        
        DEC AX
        JZ CX_SWAPPER
 
       CX_SWAPPER:
        MOV CX, 0100h
        RET
    ";
    interpreter.Run(RandomNumber);
    Console.WriteLine(interpreter.GetRegister("AX"));
    Console.WriteLine(interpreter.GetRegister("CX"));
    for (ushort i = 0; i < interpreter.baseRegisters.Stack.Length; i++)
    {
        var stack = interpreter.baseRegisters.Stack;
        if (stack[i] == 0) continue;
        Console.WriteLine(stack[i]);
    }
}
/*
int x;
Console.WriteLine("VUELTAS: ");
x = Convert.ToUInt16(Console.ReadLine());
for (int i = 0; i < x; i++)
{
    Console.WriteLine(RandomNumber(101, i, new Interpreter()));
}
*/




