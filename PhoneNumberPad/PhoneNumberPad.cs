namespace PhoneNumberPad;

public class PhoneNumberPad
{
    public static string OldPhonePad(string input) 
    {
        LookupTable lookupTable = LookupTable.GetLookupTable();
        CharacterStateController controller = new CharacterStateController(lookupTable);
        foreach (char c in input)
        {
            try
            {
                controller.ProcessCharacter(new PhoneChar(c));
            } 
            catch (InputInvalidException) {
                return "?????";
            }
        }

        return controller.GetTypedString();
    }
}
