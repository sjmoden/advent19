using NUnit.Framework;
using DayFour;

namespace DayFourTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckValidPassword1()
        {
            Assert.That(PasswordValidator.ValidationException(122345), Is.EqualTo(ValidPasswordEnum.Both));
        }

        [Test]
        public void CheckValidPassword2()
        {
            Assert.That(PasswordValidator.ValidationException(111123), Is.EqualTo(ValidPasswordEnum.Original));
        }

        [Test]
        public void CheckValidPassword3()
        {
            Assert.That(PasswordValidator.ValidationException(111111), Is.EqualTo(ValidPasswordEnum.Original));
        }

        [Test]
        public void CheckInvalidPasswordNoDuplicateValue()
        {
            Assert.That(PasswordValidator.ValidationException(123789), Is.EqualTo(ValidPasswordEnum.Neither));
        }

        [Test]
        public void CheckInvalidPasswordNotIncreasing()
        {
            Assert.That(PasswordValidator.ValidationException(223450), Is.EqualTo(ValidPasswordEnum.Neither));
        }

        [Test]
        public void CheckInvalidPasswordTooShort()
        {
            Assert.That(PasswordValidator.ValidationException(22450), Is.EqualTo(ValidPasswordEnum.Neither));
        }

        [Test]
        public void CheckInvalidPasswordTooLong()
        {
            Assert.That(PasswordValidator.ValidationException(2242250), Is.EqualTo(ValidPasswordEnum.Neither));
        }

        [Test]
        public void CheckPasswordNumbers()
        {
            var passwordGenerator = new PasswordGenerator(110000,111132);
            Assert.That(passwordGenerator.NumberOfPasswords, Is.EqualTo(17));
        }

        [Test]
        public void CheckNewPasswordNumbers()
        {
            var passwordGenerator = new PasswordGenerator(110000, 111230);
            Assert.That(passwordGenerator.NumberOfNewPasswords, Is.EqualTo(15));
        }

        [Test]
        public void ChecknewPasswordDuplicatesFail1()
        {
            Assert.That(PasswordValidator.CheckNewDuplicateDigits("123444"), Is.False);
        }

        [Test]
        public void ChecknewPasswordDuplicatesFail2()
        {
            Assert.That(PasswordValidator.CheckNewDuplicateDigits("111122"), Is.True);
        }

        [Test]
        public void ChecknewPasswordDuplicatesPass()
        {
            Assert.That(PasswordValidator.CheckNewDuplicateDigits("112233"), Is.True);
        }
    }
}