using SharedContext.Tests.Fixtures;
using Xunit;

namespace SharedContext.Tests.Collections
{
    [CollectionDefinition("Heavy collection")]
    public class HeavyCollection : ICollectionFixture<HeavyFixture>
    {

    }
}