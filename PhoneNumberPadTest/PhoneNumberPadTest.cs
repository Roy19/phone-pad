namespace PhoneNumberPadTest;

using PhoneNumberPad;
using Xunit.Sdk;

public class PhoneNumberPadTest
{
    [Theory]
    [InlineData("222 2 22", "CAB")]
    [InlineData("222 2 222", "CAC")]
    [InlineData("227*", "B")]
    [InlineData("4433555 555666", "HELLO")]
    public void TestBasicCases(string input, string expected)
    {
        Assert.Equal(expected, PhoneNumberPad.OldPhonePad(input));
    }
}
