using System;

namespace PhoneNumberPad;

public class PhoneChar
{
    public char Symbol { get; }

    public PhoneChar(char symbol)
    {
        Symbol = symbol;
    }

    public bool IsAlphabet()
    {
        return char.IsLetter(Symbol);
    }
}
