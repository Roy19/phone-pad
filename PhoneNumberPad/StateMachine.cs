using System;

namespace PhoneNumberPad;

public class StateMachine
{
    private Stack<PhoneChar> stack;

    public StateMachine()
    {
        stack = new Stack<PhoneChar>();
    }
}
