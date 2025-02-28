using System;

namespace PhoneNumberPad;

public class InputInvalidException : Exception
{
    public InputInvalidException(string message) : base(message)
    {
    }
}
