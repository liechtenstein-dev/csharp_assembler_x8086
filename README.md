# C# Assembler x8086 emulator

Esta clase permite ejecutar un string de codigo Assembly x86 atraves del metodo Run()

## Limitaciones
* No existen los segmentos de codigo, datos, extra, pila.
* No se puede usar las interrupciones y solo funciona la int 21.

<br>
<h2>Estructura del Codigo Assembler</h2>

[Instruction.cs](./instruction.md)

[InstructionTypes.cs](./InstructionTypes.md)

[BaseRegister](./BaseRegisters.md)

[Interpreter.cs](./Interpreter.md)
