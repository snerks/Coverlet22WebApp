using System;
using System.Collections.Generic;
using System.Text;
using Coverlet22WebApp.Controllers;
using Xunit;

namespace Coverlet22WebApp.UnitTest.Controllers
{
    public class ValuesControllerTests
    {
        [Fact]
        public void Get_returns_non_null()
        {
            // Arrange
            var sut = new ValuesController();

            // Act
            var actual = sut.Get();

            // Assert
            Assert.NotNull(actual);
        }
    }
}
