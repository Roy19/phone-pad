using System;
using System.Text;

namespace PhoneNumberPad;

public class StateMachine
{
    private Stack<PhoneChar> stack;
    private StringBuilder result;
    private LookupTable lookupTable;

    public StateMachine(LookupTable lookupTable)
    {
        this.lookupTable = lookupTable;
        stack = new Stack<PhoneChar>();
        result = new StringBuilder();
    }

    public void ProcessCharacter(PhoneChar phoneChar)
    {
        PhoneChar lastChar = stack.Count > 0 ? stack.Peek() : phoneChar;
        if (phoneChar.Symbol == lastChar.Symbol)
        {
            stack.Push(phoneChar);
        } else if (phoneChar.IsBackspace()) {
            if (stack.Count > 0) {
                stack.Pop();
            }
        } else {
            string typedString = "";
            while (stack.Count > 0 && !stack.Peek().IsAlphabet())
            {
                typedString = stack.Pop().Symbol + typedString;
            }
            PhoneChar currentChar = lookupTable.Convert(typedString);
            result.Append(currentChar.Symbol);
            if (phoneChar.IsDigit()) {
                stack.Push(phoneChar);
            }
        }
    }

    public string GetTypedString()
    {
        return result.ToString();
    }
}
