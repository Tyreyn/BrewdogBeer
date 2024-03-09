namespace BrewdogBeer.TestClass
{
    using System;
    using System.Net;
    using BrewdogBeer.Template;
    using Xunit.Abstractions;


    /// <summary>
    /// The security tests.
    /// </summary>
    /// <param name="output">
    /// The test log output class.
    /// </param>
    public sealed class SecurityTests(ITestOutputHelper output) : BrewdogBeerTestTemplate(output)
    {
        /// <inheritdoc/>
        protected override void Initilize(ITestOutputHelper output)
        {
            this.Url = "https://api.punkapi.com/v2/beers";
        }

        /// <summary>
        /// Send 100 request with set limit delay.
        /// </summary>
        [Fact]
        public void Send100RequestWithLimitedDelay()
        {
            int requests = 100;
            int delayInMilliSeconds = 1000;

            Assert.True(this.SendMultipleRequestInSpecifiedTime(requests, delayInMilliSeconds));
        }

        /// <summary>
        /// Send 100 request faster than limit.
        /// </summary>
        [Fact]
        public void Send100RequestFasterThanLimit()
        {
            int requests = 100;
            int delayInMilliSeconds = 1;

            Assert.True(this.SendMultipleRequestInSpecifiedTime(requests, delayInMilliSeconds));
        }

        /// <summary>
        /// Sending multiple request to API to test throttling handling.
        /// </summary>
        /// <param name="numberOfRequest">
        /// The number of sent requests.
        /// </param>
        /// <param name="delayBetweenRequest">
        /// The delay time in milliseconds between requests.
        /// </param>
        private bool SendMultipleRequestInSpecifiedTime(int numberOfRequest, int delayBetweenRequest)
        {
            for (int request = 0; request < numberOfRequest; request++)
            {
                try
                {
                    var start = DateTime.Now;
                    HttpWebResponse httpWebResponse = this.GetUrlResponse(this.Url);
                    var end = DateTime.Now;
                    this.Output.WriteLine($"[request={request}] request from API took {end - start}");
                }
                catch (WebException webEx)
                {
                    this.Output.WriteLine($"API can't handle {numberOfRequest} with {delayBetweenRequest} delay.");
                    return false;
                }

                Thread.Sleep(delayBetweenRequest);
            }

            return true;
        }
    }
}
