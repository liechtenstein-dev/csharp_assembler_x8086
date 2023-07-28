<body>
    <h1>Instruction</h1>
    <p>Este código es parte de un programa que se encarga de ensamblar e interpretar instrucciones de un lenguaje de programación ensamblador.</p>
    <h2>Clase <code> Instruction</code></h2>
    <h3>Constructores y Propiedades</h3>
    <pre><code>public Instruction(InstructionRequirement instruction)</code></pre>
    <p>Constructor de la clase <code>Instruction</code>, que toma un objeto <code>InstructionRequirement</code> como argumento. Esta clase representa una instrucción ensamblador y contiene información sobre los operandos y el nombre de la instrucción.</p>
    <p>Parámetros:</p>
    <ul>
        <li><code>instruction</code>: Objeto de tipo <code>InstructionRequirement</code> que contiene la información sobre la instrucción.</li>
    </ul><hr>
    <h3>Método <code>ParseOperand</code></h3>
    <pre><code>private ushort ParseOperand(string operand)</code></pre>
    <p>Este método se utiliza para analizar y convertir el operando de la instrucción a su valor numérico correspondiente.</p>
    <p>Parámetros:</p>
    <ul>
        <li><code>operand</code>: Cadena que representa el operando de la instrucción a ser analizado y convertido.</li>
    </ul>
    <p>Valor de retorno: Un valor de tipo <code>ushort</code> que representa el valor numérico del operando.</p><br><hr>
    <h3>Métodos <code>TwoOperandInstruction</code> y <code>OneOperandInstruction</code></h3>
    <pre><code>private void TwoOperandInstruction(ushort operand, ushort second_operand, string str_operand)
private void OneOperandInstruction(ushort operand, string str_operand)</code></pre>
    <p>Estos métodos se encargan de ejecutar las instrucciones que requieren dos operandos y un operando respectivamente.</p>
    <p>Parámetros (TwoOperandInstruction):</p>
    <ul>
        <li><code>operand</code>: Valor numérico del primer operando.</li>
        <li><code>second_operand</code>: Valor numérico del segundo operando.</li>
        <li><code>str_operand</code>: Cadena que representa el operando de la instrucción.</li>
    </ul>
    <p>Parámetros (OneOperandInstruction):</p>
    <ul>
        <li><code>operand</code>: Valor numérico del operando.</li>
        <li><code>str_operand</code>: Cadena que representa el operando de la instrucción.</li>
    </ul><br>
    <h3>Método <code>NoOperandInstruction</code></h3>
    <pre><code>private void NoOperandInstruction()</code></pre>
    <p>Este método se encarga de ejecutar instrucciones que no requieren operandos.</p><br><hr>
    <h3>Método <code>GetValuesCompleted</code></h3>
    <pre><code>public InstructionRequirement GetValuesCompleted()</code></pre>
    <p>Este método devuelve el objeto <code>InstructionRequirement</code> que contiene la información completa de la instrucción ensamblador, incluidos los valores de los operandos procesados.</p>
    <p>Valor de retorno: Un objeto de tipo <code>InstructionRequirement</code>.</p>
    <h2>Notas adicionales</h2>
    <ul>
        <li>El código hace uso de diccionarios (<code>Dictionary</code>) y delegados (<code>Action</code>) para manejar las diferentes instrucciones y sus operaciones correspondientes.</li><br>
        <li>Uso de expresiones regulares para identificar diferentes tipos de operandos, como registros, valores binarios, hexadecimales, etiquetas, entre otros.</li><br>
        <li>El código también incluye manejo de excepciones (<code>InvalidOperationException</code>) para manejar situaciones inesperadas o inválidas en las instrucciones.</li><br>
        <li> El uso de <code>jumpable</code> es una variable booleana que se utiliza para controlar si una instrucción de salto
        condicional (como JMP, JZ, JNZ, etc.) ha sido ejecutada y si se debe realizar un salto en el programa. Cuando se ejecuta una
        instrucción de salto condicional, el valor de "jumpable" se establece en true, lo que indica que se debe realizar el salto a la
        dirección de memoria especificada por la instrucción.<br><br>
        Luego, en los métodos <code>TwoOperandInstruction</code> y <code>OneOperandInstruction</code>, se verifica el valor de "jumpable" antes de ejecutar
        cualquier instrucción de salto condicional. Si "jumpable" es true, se realiza el salto y el valor de "jumpable" se restablece
        a false para evitar que se realicen saltos adicionales en instrucciones posteriores.<br>
        El uso de "jumpable" garantiza que las instrucciones de salto condicional se ejecuten correctamente y que no se realicen saltos
        no deseados en el programa.</li><br>
        <li><code>InnerInstructions</code> es una instancia de la clase <code>InstructionRequirement</code> que se almacena como una variable miembro privada
        (<code>innerInstruction</code>) dentro de la clase <code>Instruction</code>. Esta variable se pasa como argumento al constructor de la clase <code>Instruction</code>,
        lo que permite que los métodos de la clase accedan a la información de la instrucción ensamblador que se va a ejecutar.<br>
        </li>
    </ul>
</body>