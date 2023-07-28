<body>
    <h1>InstructionRequirement</h1>
    <p>Representa los requisitos de una instrucción en lenguaje ensamblador.</p>
    <h2>Campos:</h2>
    <ul>
        <li>
            <p><strong>NameOfInstruction:</strong> Almacena el nombre de la instrucción.</p>
        </li>
        <li>
            <p><strong>StrOperand:</strong>
            Almacena el primer operando de la instrucción (si existe).</p>
        </li>
        <li>
            <p><strong>SecStrOperand:</strong> Almacena el segundo operando de la instrucción (si existe).</p>
        </li>
        <li>
            <p><strong>BaseRegs:</strong> Almacena una instancia de la estructura BaseRegisters, que contiene los registros y memoria base necesarios para el procesamiento de la instrucción.</p>
        </li>
    </ul>
    <h2>Constructor:</h2>
    <h3><code>InstructionRequirement (string nameOfInstruction, BaseRegisters baseRegs)</code></h3>
    <p>Inicializa una nueva instancia de la estructura <code>InstructionRequirement</code> con el nombre de la instrucción y los registros base proporcionados.</p>
    <p>Parámetros:</p>
    <ul>
        <li><strong>nameOfInstruction:</strong> El nombre de la instrucción.</li>
        <li><strong>baseRegs:</strong> Una instancia de BaseRegisters que contiene los registros y memoria base necesarios para el procesamiento de la instrucción.</li>
    </ul><br>
    <h3><code>InstructionRequirement(string nameOfInstruction, string strOperand, BaseRegisters baseRegs)</code></h3>
    <p>Inicializa una nueva instancia de la estructura <code>InstructionRequirement</code> con el nombre de la instrucción, el primer operando y los registros base proporcionados.</p>
    <p>Parámetros:</p>
    <ul>
        <li><strong>nameOfInstruction:</strong> El nombre de la instrucción.</li>
        <li><strong>strOperand:</strong> El primer operando de la instrucción.</li>
        <li><strong>baseRegs:</strong> Una instancia de BaseRegisters que contiene los registros y memoria base necesarios para el procesamiento de la instrucción.</li>
    </ul>
    <h3>InstructionRequirement(string nameOfInstruction, string strOperand, string secStrOperand, BaseRegisters baseRegs)</h3>
    <p>Inicializa una nueva instancia de la estructura <code>InstructionRequirement</code>con el nombre de la instrucción, el primer y segundo operando, y los registros base proporcionados.</p>
    <p>Parámetros:</p>
    <ul>
        <li><strong>nameOfInstruction:</strong> El nombre de la instrucción.</li>
        <li><strong>strOperand:</strong> El primer operando de la instrucción.</li>
        <li><strong>secStrOperand:</strong> El segundo operando de la instrucción.</li>
        <li><strong>baseRegs:</strong> Una instancia de BaseRegisters que contiene los registros y memoria base necesarios para el procesamiento de la instrucción.</li>
    </ul>
</body>