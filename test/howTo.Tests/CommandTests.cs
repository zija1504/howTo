using System;
using Xunit;
using howTo.Models;

namespace howTo.Tests
{
    public class CommandTests : IDisposable
    {
        Commands? testCommand;
        public CommandTests()
        {
            testCommand = new Commands
            {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }
        public void Dispose()
        {
            testCommand = null;
        }
        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange
            //Act
            testCommand!.HowTo = "Execute Unit Tests";

            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }
    }
}
