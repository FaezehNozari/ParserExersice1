using Xunit;
using System;
using FluentAssertions;

namespace ParserTest
{
    public class UnitTest1
    {
        [Fact]
        public void Parse_Should_Throw_Exteption_Message_When_Seprator_Is_Null_Or_Empty()
        {
            var str = "red , green , blue ";
            var seprator = "";

            var result = () => ParserExersice1.Parser.ParseCharacter(str, seprator);

            result.Should().Throw<Exception>();
        }

        [Fact]
        public void Parse_Should_Return_Empty_When_Value_Is_Null_Or_Empty()
        {
            var str = "";
            var sepratore = " , ";

            var result = ParserExersice1.Parser.ParseCharacter(str, sepratore);
            result.Should().BeEmpty();


        }

        [Fact]
        public void Parse_Should_Return_String_Array_When_Input_Valid_Parametr()
        {
            var str = " Red , Blue , Green ";
            var seprator = " , ";

            var result = ParserExersice1.Parser.ParseCharacter(str, seprator);
            bool isString = result is string[];

            Assert.True(isString);
        }
    }
}