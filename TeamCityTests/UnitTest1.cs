using Xunit;

namespace TeamCityTests
{
    public class UnitTest1
    {
        //проверка на неотрицательность
        [Fact]
        public void Test1()
        {
            TeamCity.TeamCity TeamCity = new TeamCity.TeamCity();
            TeamCity.Size = 10;
            var result = IsPrime(TeamCity.Size);
            Assert.True(result, $"{TeamCity.Size} should be prime");
        }

        public bool IsPrime(int candidate)
        {
            if (candidate > 0)
                return true;
            else
                return false;
        }

        //проверка знаменателя на ненулевое значение
        [Fact]
        public void Test2()
        {
            TeamCity.TeamCity TeamCity = new TeamCity.TeamCity();
            TeamCity.Denominator = 10;
            TeamCity.Numerator = 10;
            var result = IsDenominatorNotZero(TeamCity.Denominator);
            Assert.True(result, $"{TeamCity.Denominator} should not be zero");
        }

        public bool IsDenominatorNotZero(int candidate)
        {
            if (candidate == 0)
                return false;
            else
                return true;
        }

        [Fact]
        public void Test3()
        {
            TeamCity.TeamCity TeamCity = new TeamCity.TeamCity();
            TeamCity.Size = 10;
            var result = IsPrime(TeamCity.Size);
            Assert.True(result, $"{TeamCity.Size} should be prime");
        }
    }
}
