using FindTheKey;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestKeyValueParser
    {
        KeyValueParser parser = new KeyValueParser();

        [Fact]
        public void TestIsValid()
        {
            Assert.True(parser.IsValid("msg: very good"));
            Assert.False(parser.IsValid("this is not valid"));
            Assert.False(parser.IsValid(""));
        }

        [Fact]
        public void TestValidKeyValue()
        {
            string basic = "key: value";
            Assert.Equal("value", parser.GetValue(basic));

            string keyValue = "id: 12332125";
            Assert.Equal("12332125", parser.GetValue(keyValue));
        }

        [Fact]
        public void TestInvalidKeyValue()
        {
            string invalid = "no colon here";
            Assert.Equal("", parser.GetValue(invalid));
        }

        [Fact]
        public void TestEmptyKeyValue()
        {
            string empty = "";
            Assert.Equal("", parser.GetValue(empty));
        }
    }
}
