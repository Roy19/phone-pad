namespace PhoneNumberPad;

public class PhoneNumberPad
{
    public static string OldPhonePad(string input) 
    {
        LookupTable lookupTable = new LookupTable();
        StateMachine stateMachine = new StateMachine(lookupTable);
        foreach (char c in input)
        {
            stateMachine.ProcessCharacter(new PhoneChar(c));
        }

        return stateMachine.GetTypedString();
    }
}
