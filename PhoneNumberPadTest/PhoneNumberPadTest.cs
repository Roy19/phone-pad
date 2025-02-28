namespace PhoneNumberPadTest;

using System.Runtime.InteropServices;
using PhoneNumberPad;

public class PhoneNumberPadTest
{
    [Theory]
    [InlineData("222 2 22#", "CAB")]
    [InlineData("222 2 222#", "CAC")]
    [InlineData("227*#", "B")]
    [InlineData("4433555 555666#", "HELLO")]
    public void TestBasicCases(string input, string expected)
    {
        Assert.Equal(expected, PhoneNumberPad.OldPhonePad(input));
    }

    [Theory]
    [InlineData("66 66*66#", "NO")]
    [InlineData("1 1102#", "&' A")]
    public void TestAdditionalCases(string input, string expected)
    {
        Assert.Equal(expected, PhoneNumberPad.OldPhonePad(input));
    }

    [Theory]
    [InlineData("8 88777444666*664#", "?????")]
    [InlineData("6666#", "?????")]
    public void TestEdgeCases(string input, string expected)
    {
        Assert.Equal(expected, PhoneNumberPad.OldPhonePad(input));
    }
}
