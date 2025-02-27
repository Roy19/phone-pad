using System;

namespace PhoneNumberPad;

public class StateMachine
{
    private Stack<PhoneChar> stack;
    private LookupTable lookupTable;

    public StateMachine(LookupTable lookupTable)
    {
        this.lookupTable = lookupTable;
        stack = new Stack<PhoneChar>();
    }

    public void ProcessCharacter(PhoneChar phoneChar)
    {
        PhoneChar lastChar = stack.Count > 0 ? stack.Peek() : phoneChar;
        if (phoneChar.Symbol == lastChar.Symbol)
        {
            stack.Push(phoneChar);
        } else {
            string typedString = "";
            while (stack.Count > 0 && !stack.Peek().IsAlphabet())
            {
                typedString = stack.Pop().Symbol + typedString;
            }
            PhoneChar currentChar = lookupTable.Convert(typedString);
            stack.Push(currentChar);
        }
    }
}
