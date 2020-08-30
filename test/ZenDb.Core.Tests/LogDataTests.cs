using System;
using System.IO;
using System.Text;
using Xunit;

namespace ZenDb.Core.Tests
{
    public class LogDataTests
    {
        [Fact]
        public void Should_Be_Able_to_Add_data_With_Key()
        {
            LogData data = new LogData(new StreamWriter(new MemoryStream()));
            data.AddData("1", Encoding.UTF8.GetBytes("Hello World"));
        }
    }
}
