using System.Threading.Tasks;
using Xunit;

namespace Fibonacci.Tests
{

    public class FibonacciUnitTest
    {
        [Fact]
        public async Task Executeshouldreturnanumber()
        {
            var result = await Compute.ExecuteAsync(new[] {"8"});
            Assert.Equal(21, result[0]);

        }
    }
}