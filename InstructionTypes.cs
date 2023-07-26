namespace assembler.Assembly;

public struct InstructionRequirement
{
    public string NameOfInstruction;
    public string StrOperand;
    public string SecStrOperand;
    public BaseRegisters BaseRegs;
    
    #region Constructor
    public InstructionRequirement(string nameOfInstruction, BaseRegisters baseRegs)
    {
        NameOfInstruction = nameOfInstruction;
        StrOperand = string.Empty;
        SecStrOperand = string.Empty;
        BaseRegs = baseRegs;
    }

    public InstructionRequirement(string nameOfInstruction, string strOperand, BaseRegisters baseRegs)
    {
        NameOfInstruction = nameOfInstruction;
        StrOperand = strOperand;
        SecStrOperand = string.Empty;
        BaseRegs = baseRegs;
    }

    public InstructionRequirement(string nameOfInstruction, string strOperand, string secStrOperand, BaseRegisters baseRegs)
    {
        NameOfInstruction = nameOfInstruction;
        StrOperand = strOperand;
        SecStrOperand = secStrOperand;
        BaseRegs = baseRegs;
    }
    #endregion
}

