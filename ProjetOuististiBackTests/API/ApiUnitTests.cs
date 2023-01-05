using Microsoft.Extensions.Logging;
using ProjetOuististiApplication.Controllers;
using ProjetOuististiApplication.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOuististiBackTests.API
{
    [TestClass]
    public class ApiUnitTests
    {
        private CalculatriceController _calcApi = new(new FakeLogger());

        private static string _root = "http://localhost:7140/";
        private static string _calculateRoute = _root + "Calculate";
        private static string _statisticsRoute = _root + "Statistics";

        private static CalculInputDto inputDto = new CalculInputDto{
            input1 = 3, input2 = 4, OperationType = "Addition"
            };

        [TestMethod]
        public void CalculateReplies()
        {
            _calcApi.ReceiveCalculAndReturnResult(inputDto);
        }

        [TestMethod]
        public void StatisticsReplies()
        {
            _calcApi.GetStatistics();
        }

        [TestMethod]
        public void CalculateWorks()
        {
            Assert.AreEqual(_calcApi.ReceiveCalculAndReturnResult(inputDto).output, 7);
        }

        [TestMethod]
        public void StatisticsWorks()
        {
            StatisticsOutputDto outputDto = _calcApi.GetStatistics();
            Assert.IsTrue(
                outputDto.Additions > 0 ||
                outputDto.Divisions > 0 ||
                outputDto.Multiplications > 0 ||
                outputDto.Divisions > 0
                ) ;
        }
    }

    internal class FakeLogger : ILogger<CalculatriceController>
    {
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            //throw new NotImplementedException();
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            //throw new NotImplementedException();
        }
    }
}
