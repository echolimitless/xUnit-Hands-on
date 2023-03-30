using SharedContext.Tests.Fixtures;
using Xunit;

namespace SharedContext.Tests
{
    public class UnitTest3 : IClassFixture<AsyncHeavyFixture>
    {
        private readonly AsyncHeavyFixture _asyncHeavyFixture;

        public UnitTest3(AsyncHeavyFixture asyncHeavyFixture)
        {
            _asyncHeavyFixture = asyncHeavyFixture;
        }

        [Fact]
        public void Test() => _asyncHeavyFixture.Use();
    }
}