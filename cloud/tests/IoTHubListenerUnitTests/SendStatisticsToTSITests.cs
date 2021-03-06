using System;
using Xunit;
using Moq;
using Microsoft.Azure.Devices;
using GWManagementFunctions;
using Microsoft.Azure.WebJobs;
using System.Threading.Tasks;
using System.Threading;
using HeartbeatProto;

namespace IoTHubListenerTests
{
    public class SendStatisticsToTSITests
    {

        
        public Mock<IAsyncCollector<string>> GetEventHubMock() {
            var eventHubMock = new Mock<IAsyncCollector<string>>();
            eventHubMock.Setup(
                foo => foo.AddAsync(It.IsAny<string>(), It.IsAny<CancellationToken>())
            );
            return eventHubMock;
        }

        [Fact]
        public void TestSendStatisticsToTSI()
        {
            var eventHubMock = GetEventHubMock();
            Assert.True(true);
        }
    }

}