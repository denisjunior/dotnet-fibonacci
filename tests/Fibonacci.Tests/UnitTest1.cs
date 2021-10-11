using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Fibonacci.Tests
{

    public class FibonacciUnitTest
    {
        [Fact]
        public async Task Executeshouldreturnanumber()
        {
            var builder = new DbContextOptionsBuilder<FibonacciDataContext>(); 
            var dataBaseName = Guid.NewGuid().ToString(); builder.UseInMemoryDatabase(dataBaseName);  
            var options = builder.Options; var fibonacciDataContext = new FibonacciDataContext(options); 
            await fibonacciDataContext.Database.EnsureCreatedAsync();

            var result = await new Fibonacci.Compute(fibonacciDataContext).ExecuteAsync();
            Assert.Equal(1, result.Count);
            Assert.Equal(8, result[0]);


        }
    }
}