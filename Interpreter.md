<body>
    <h1>Interpreter</h1>
    <p>Descripción: Representa un intérprete para el procesamiento de instrucciones en lenguaje ensamblador.</p>
    <h2>Atributos:</h2>
    <ul>
        <li>
            <p><strong>baseRegisters:</strong> Almacena un objeto de la clase BaseRegisters que representa el conjunto de registros base utilizados en el intérprete.</p>
        </li>
    </ul>
    <h2>Métodos:</h2>
    <ul><br>
        <li>
            <p><strong>GetRegisters()</strong> Devuelve un arreglo con los valores de todos los registros almacenados en el objeto BaseRegisters.</p>
        </li>
        <li>
            <strong>GetRegister(string reg)</strong>
            <p>Devuelve el valor del registro especificado.</p>
            <p>Parámetros:</p>
            <ul>
                <li><strong>reg:</strong> (Tipo: string) El nombre del registro del que se desea obtener el valor.</li>
            </ul>
        </li><br><hr>
        <li>
            <p><strong>Run(string program)</strong> Ejecuta el programa de lenguaje ensamblador proporcionado.</p>
            <p>ejecuta el programa proporcionado como parámetro. El programa se debe pasar como una cadena de texto que contiene una serie de instrucciones en lenguaje ensamblador separadas por saltos de línea.</p>
            <p>Antes de comenzar la ejecución del programa, este método busca y registra las etiquetas presentes en el código, asignando a cada etiqueta la línea de inicio de su instrucción correspondiente.</p>
            <p>Una vez que las etiquetas están registradas, el intérprete comienza a ejecutar las instrucciones del programa secuencialmente. Si se encuentra una instrucción de salto, el intérprete actualizará el contador de programa (IP) para saltar a la dirección indicada por la etiqueta.</p>
            <p>Si una instrucción no es una etiqueta y no está relacionada con una instrucción de salto, el intérprete llamará al método `Execute` para procesar la instrucción.</p>
            <p>Finalmente, el método Run se encargará de incrementar el contador de programa (IP) para pasar a la siguiente línea de instrucción y continuar el proceso hasta que se haya ejecutado todo el programa.</p>
        </li><br><hr>
        <li>
            <strong>Execute(string line)</strong>
    <p>Descripción: Ejecuta una instrucción del programa de lenguaje ensamblador proporcionado.</p>
    <h4>Parámetros:</h4>
    <ul>
        <li>
            <p><strong>line:</strong>
            (Tipo: string) La instrucción del programa de lenguaje ensamblador que se va a ejecutar.</p>
            <p>La línea de instrucción debe contener la operación a realizar y, opcionalmente, uno o dos operandos. Estos operandos pueden ser registros, valores inmediatos, etiquetas, o expresiones de memoria.</p>
            <p>La instrucción debe estar bien formada y respetar la sintaxis del lenguaje ensamblador admitida por el intérprete para evitar errores durante la ejecución.</p>
            <p>Ejemplo de instrucción válida: "MOV AX, BX" (mueve el valor del registro BX al registro AX).</p>
        </li>
    </ul>
    <h4>Descripción del Proceso:</h4>
    <p>El método es invocado por el método <code>Run</code> del intérprete para procesar una instrucción individual del programa de lenguaje ensamblador.</p>
    <p>Primero, el método separa la instrucción en sus componentes principales: la operación <code>(`inst`)</code>, el primer operando <code>(`operand1`)</code>, y el segundo operando <code>(`operand2`)</code>. Cualquier comentario presente en la instrucción es eliminado utilizando expresiones regulares.</p>
    <p>A continuación, se crea un objeto de tipo <code>`InstructionRequirement`</code> que contiene la información necesaria para procesar la instrucción. Este objeto se inicializa con los valores de la operación y los operandos, así como el conjunto actual de registros, memoria, etiquetas y la disponibilidad de saltos almacenados en el objeto `BaseRegisters` del intérprete.</p>
    <p>Luego, se crea un objeto de tipo <code>`Instruction`</code> y se le pasa el objeto <code>`InstructionRequirement`</code> para que pueda procesar la instrucción. El objeto <code>`Instruction`</code> se encarga de realizar la operación especificada en la instrucción y actualizar los valores de los registros y memoria según corresponda.</p>
    <p>Finalmente, el método <code>`Execute`</code> actualiza el objeto <code>`BaseRegisters`</code> del intérprete con el estado modificado después de ejecutar la instrucción.</p>
    <h2>Excepciones:</h2>
    <p>El método <code>`Execute`</code> puede lanzar excepciones en caso de encontrar una instrucción no válida o mal formada en el programa de lenguaje ensamblador. En este caso, el intérprete detendrá su ejecución y mostrará el mensaje de error apropiado.</p>
        </li>
    </ul>
</body>