<body>
    <h1>BaseRegisters</h1>
    <p>Representa un conjunto de registros base para el procesamiento de instrucciones en lenguaje ensamblador.</p>
    <h2>Atributos:</h2>
    <ul>
        <li>
            <p><strong>Registers:</strong> Almacena un diccionario de registros con sus nombres y valores.</p>
        </li>
        <li>
            <p><strong>Memory:</strong> Almacena un diccionario que representa la memoria con direcciones y valores.</p>
        </li>
        <li>
            <p><strong>Labels:</strong> Almacena un diccionario que asocia etiquetas (nombres de posiciones de memoria) con direcciones.</p>
        </li>
        <li>
            <p><strong>JumpAvailable:</strong> Indica si las instrucciones de salto (jump) están disponibles para su uso.</p>
        </li>
        <li>
            <p><strong>Stack:</strong> Almacena un arreglo que representa la pila de memoria.</p>
        </li>
    </ul>
    <h2>Constructores:</h2>
    <h3><code>BaseRegisters(Dictionary&lt;string, ushort&gt; registers, Dictionary&lt;ushort, ushort&gt; memory, Dictionary&lt;string, ushort&gt; labels, ushort[] stack)</code></h3>
    <p>Inicializa una nueva instancia de la clase <code>BaseRegisters</code> con los diccionarios de registros, memoria y etiquetas, junto con el arreglo de la pila proporcionados.</p>
    <p>Parámetros:</p>
    <ul>
        <li><strong>registers:</strong> Un diccionario que contiene los registros con sus nombres y valores.</li>
        <li><strong>memory:</strong> Un diccionario que representa la memoria con direcciones y valores.</li>
        <li><strong>labels:</strong> Un diccionario que asocia etiquetas con direcciones de memoria.</li>
        <li><strong>stack:</strong> Un arreglo que representa la pila de memoria.</li>
    </ul>
    <h3><code>BaseRegisters()</code></h3>
    <p> Inicializa una nueva instancia de la clase BaseRegisters con los registros, memoria, etiquetas y pila vacíos.</p>
</body>