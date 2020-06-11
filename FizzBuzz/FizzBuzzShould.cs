using NUnit.Framework;

namespace FizzBuzz
{
    public class FizzBuzzShould
    {
        private const string FIZZ = "FIZZ";
        private const string BUZZ = "BUZZ";
        private const string FIZZ_BUZZ = "FIZZ_BUZZ";

        private FizzBuzz _fizzBuzz;
        
        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void should_convert_to_FIZZ_when_divisible_by_3()
        {
            Assert.That(_fizzBuzz.Convert(6), Is.EqualTo(FIZZ));
        }

        [Test]
        public void should_convert_to_Buzz_when_divisible_by_5()
        {
            Assert.That(_fizzBuzz.Convert(10), Is.EqualTo(BUZZ));
        }

        [Test]
        public void should_return_FIZZ_BUZZ_if_divisible_by_3_and_5()
        {
            Assert.That(_fizzBuzz.Convert(15), Is.EqualTo(FIZZ_BUZZ));
        }

        [Test]
        public void should_return_number_if_not_divisible_by_3_or_by_5_or_by_both()
        {
            Assert.That(_fizzBuzz.Convert(16), Is.EqualTo("16"));
        }
    }
}