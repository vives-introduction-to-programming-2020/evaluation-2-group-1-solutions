using System;
using TitleBuilder;
using Xunit;

namespace Tests
{
    public class ConsoleHelperUnitTest
    {
        ConsoleHelper consoleHelper = new ConsoleHelper();

        [Fact]
        public void TestGenerateTitle()
        {
            string title = "Console Helper is Very Cool.";
            Assert.Equal(
                  "################################\n"
                + "# Console Helper is Very Cool. #\n"
                + "# ---------------------------- #\n"
                + "################################", consoleHelper.GenerateTitle(title));
        }

        [Fact]
        public void TestGenerateSmallerTitle()
        {
            string title = "Urbanus";
            Assert.Equal(
                  "###########\n"
                + "# Urbanus #\n"
                + "# ------- #\n"
                + "###########", consoleHelper.GenerateTitle(title));
        }
    }
}
