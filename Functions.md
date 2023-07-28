<body>
    <h1>Functions</h1>
    <p>La clase <code>Functions</code> proporciona métodos para realizar operaciones de ensamblador y cálculos
        específicos utilizando el objeto <code>Interpreter</code>.</p>
    <h2>Método <code>SettingValues</code></h2>
    <p>Asigna un valor entero al registro <code>AX</code> del <code>Interpreter</code>.
    </p>
    <pre><code>
        public void SettingValues(int valor)
        {
            interpreter.Run(@$"
                MOV AX, {valor}D
            ");
        }
    </code></pre>
    <p>
        <strong>Parámetros:</strong>
        <ul>
            <li><code>valor</code> (int): Valor entero que se asignará al registro <code>AX</code>.</li>
        </ul>
    </p>
    <h2>Método <code>RotateNumber</code></h2>
    <p>
        <strong>Descripción:</strong> Realiza una operación de rotación hacia la derecha del valor contenido en el
        registro <code>AX</code> del <code>Interpreter</code>. Retorna el resultado como un entero.
    </p>
    <pre><code>
        public int RotateNumber(int increment)
        {
            interpreter.Run(@$"
                MOV CX, {increment}d ; Cantidad de bits a desplazar
                ROR AX, CL ; GIRO DE BITS
                MOV BX, 000Fh ; Máscara para conseguir los últimos 4 bits
                XOR AX, BX ; Aplico la máscara a AX
                CMP AX, 15D ; Compara AX con el valor 15
                JE set_bx ; Si es igual a 15, salta a la etiqueta set_bx
                JNE multiply ; Si no es igual a 15, salta a la etiqueta multiply
            set_bx:
                MOV BX, 1D ; Establece el valor 1 en el registro BX
                MUL BX ; Multiplica el contenido de AX por el valor en BX (resultado en AX)
                JMP end ; Salta al final para evitar la parte de abajo
            multiply:
                MOV BX, 0D ; Puedes elegir otro valor (por ejemplo, 2)
            end:
            ");
            return Convert.ToUInt16(interpreter.GetRegister("BX"));
        }
    </code></pre>
    <p>
        <strong>Parámetros:</strong>
        <ul>
            <li><code>increment</code> (int): Cantidad de bits a desplazar en la operación de rotación.</li>
        </ul>
    </p>
<h2>Método <code>CalculateAttackValue</code></h2>
    <p>
        <strong>Descripción:</strong> Calcula un valor de ataque basado en el nivel del atacante. Retorna el resultado
        como un entero.
    </p>
    <pre><code>
        public int CalculateAttackValue(int attackerLevel)
        {
            interpreter.Run(@$"
                MOV AX, {attackerLevel}D
                SHL AX, 1D
                ADD AX, 10D
                MOV BX, 5D
                MUL BX ; Multiplica el contenido de AX por el valor en BX (resultado en AX)
                SUB AX, 10D 
            ");
            return Convert.ToUInt16(interpreter.GetRegister("AX"));
        }
    </code></pre>
    <p>
        <strong>Parámetros:</strong>
        <ul>
            <li><code>attackerLevel</code> (int): Nivel del atacante utilizado para realizar cálculos.</li>
        </ul>
    </p>
<h2>Método <code>Dispose</code></h2>
    <p>
        <strong>Descripción:</strong> Implementa la interfaz <code>IDisposable</code> y se utiliza para liberar los
        recursos asociados al <code>Interpreter</code> cuando ya no sean necesarios.
    </p>
    <pre><code>
        public void Dispose()
        {
            interpreter?.Dispose();
        }
    </code></pre>
</body>