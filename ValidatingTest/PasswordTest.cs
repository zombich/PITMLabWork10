using LabWork10;

namespace ValidatingTest
{
    public class PasswordTest
    {
        [Theory]
        [InlineData("password1")]
        [InlineData("passw0rd")]
        [InlineData("1234567a")]
        [InlineData("parolcarol1234679890228!")]
        [InlineData("adminka!1703")]
        public void CorrectPassword_ReturnsTrue(string password)
        {
            Assert.True(Password.IsValid(password));
        }

        [Theory]
        [InlineData("pswrd")]
        [InlineData("")]
        [InlineData("@34as")]
        [InlineData("@@@@@@@@@@@@@@@@@3344334")]
        [InlineData("!!!!!asd")]
        public void IncorrectPassword_ReturnsFalse(string password)
        {
            Assert.False(Password.IsValid(password));
        }

        [Fact]
        public void NullPassword_ReturnsThrowsException()
        {
            Assert.Throws<ArgumentNullException>(()=> Password.IsValid(null));
        }
    }
}