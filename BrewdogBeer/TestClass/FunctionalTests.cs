namespace BrewdogBeer.TestClass
{
    using BrewdogBeer.Entities;
    using BrewdogBeer.Helpers;
    using BrewdogBeer.Template;
    using System.Net;
    using Xunit.Abstractions;

    /// <summary>
    /// The API functional test class.
    /// </summary>
    public sealed class FunctionalTests(ITestOutputHelper output) : BrewdogBeerTestTemplate(output)
    {

        /// <summary>
        /// The default response result count.
        /// </summary>
        private const int DefaultResultLimit = 25;

        /// <inheritdoc/>
        protected override void Initilize(ITestOutputHelper output)
        {
        }

        /// <summary>
        /// Check if response item count is limited to default value.
        /// </summary>
        [Fact]
        protected void CheckIfResponseItemCountIsAsExpected()
        {
            this.Url = "https://api.punkapi.com/v2/beers";

            this.BeerList = this.GetBeerList(this.Url);

            this.Output.WriteLine($"Default response item count value: {DefaultResultLimit}," +
                $" Actual response item count: {this.BeerList.Count}");

            Assert.True(this.BeerList.Count == DefaultResultLimit);
        }

        /// <summary>
        /// Check if error occured when parameter is passed without value.
        /// </summary>
        [Fact]
        protected void CheckIfErrorWhenParameterIsWithoutValue()
        {
            List<string> wrongResponseParamList = new List<string>();
            foreach (string param in this.PossibleApiParameter)
            {
                this.Url = string.Format("https://api.punkapi.com/v2/beers?{0}=", param);
                this.Output.WriteLine($"Testing {this.Url}");
                try
                {
                    HttpWebResponse httpWebResponse = this.GetUrlResponse(this.Url);
                    wrongResponseParamList.Add(param);
                }
                catch (WebException webEx)
                {
                    this.Output.WriteLine("400 error appeared");
                }
            }

            if (wrongResponseParamList.Count > 0) Assert.Fail(string.Join(" ,", wrongResponseParamList));
        }


        /// <summary>
        /// Check if error is handled when parameter is not recognized.
        /// </summary>
        [Fact]
        protected void CheckIfErrorIsHandledWhenParameterIsNotRecognized()
        {
            this.Url = "https://api.punkapi.com/v2/beers?testparam123=";
            try
            {
                HttpWebResponse httpWebResponse = this.GetUrlResponse(this.Url);
                Assert.Fail("Response for not implemented parameter is not handled");
            }
            catch (WebException webEx)
            {
                this.Output.WriteLine("Bad parameter is handled");
            }
        }

    }
}
