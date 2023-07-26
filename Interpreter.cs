using System.Text.RegularExpressions;
using assembler.Assembly;

// Disable ReSharper InconsistencyNaming 
namespace assembler
{
    internal class Interpreter : IDisposable
    {
        public BaseRegisters baseRegisters = new BaseRegisters();

        public ushort[] GetRegisters()
        {
            return baseRegisters.Registers.Values.ToArray();
        }

        public ushort GetRegister(string reg)
        {
            return baseRegisters.Registers[reg];
        }

        public void Run(string program)
        {
            var lineIndex = 0;
            var lines = program.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            lines = lines.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            var labels = baseRegisters.Labels;
            var registers = baseRegisters.Registers;
            
            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                if (!line.EndsWith(":")) continue;
                labels[line.Substring(0, line.Length - 1)] = (ushort)i;
                i++;
                for (var j = i; j < lines.Length; j++)
                {
                    var subLine = lines[j].Trim();
                    i = j;
                    labels[subLine[..subLine.Length]] = (ushort)i;
                    if (subLine.Equals("RET") || subLine.StartsWith("J") || subLine.Equals("LOOP"))
                    {
                        break;
                    }
                }
            }

            while (lineIndex < lines.Length)
            {
                var line = lines[lineIndex].Trim();

                if (!string.IsNullOrEmpty(line) && !line.EndsWith(":") && !labels.ContainsKey(line))
                {
                    
                    var parts = line.Split(' ');
                    var inst = parts[0];
                    var operand1 = parts.Length > 1 ? parts[1] : "";
                    var operand2 = parts.Length > 2 ? parts[2] : "";
                    operand1 = Regex.Replace(operand1, @",.*|;.*", "");
                    operand2 = Regex.Replace(operand2, @",.*|;.*", "").ToUpper();
                    
                    var instructionRequirementToParams = new InstructionRequirement(inst, 
                    operand1, operand2, baseRegisters);
                    var instructionSet = new Instruction(instructionRequirementToParams);
                    instructionRequirementToParams = instructionSet.GetValuesCompleted();
                    baseRegisters = instructionRequirementToParams.BaseRegs;
                    
                }
                registers["IP"]++;
                lineIndex = registers["IP"];
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        ~Interpreter()
        {
            Dispose();
        }
    }
}
