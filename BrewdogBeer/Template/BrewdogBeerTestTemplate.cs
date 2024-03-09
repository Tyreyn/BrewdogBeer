namespace BrewdogBeer.Template
{
    using System;
    using System.Data;
    using System.Net;
    using System.Net.Http.Headers;
    using BrewdogBeer.Entities;
    using BrewdogBeer.Helpers;
    using Microsoft.VisualStudio.TestPlatform.Utilities;
    using Newtonsoft.Json;
    using Xunit.Abstractions;

    /// <summary>
    /// The Brewdog Beer test template.
    /// </summary>
    public class BrewdogBeerTestTemplate
    {
        /// <summary>
        /// Gets or sets the response beer list.
        /// </summary>
        public List<Beer> BeerList { get; set; } = new List<Beer>();

        /// <summary>
        /// Gets or sets API URL.
        /// </summary>
        public string Url { get; set; } = "https://api.punkapi.com/v2/beers?brewed_after=12-2015";

        /// <summary>
        /// The test log output class.
        /// </summary>
        public readonly ITestOutputHelper Output;

        /// <summary>
        /// Possible API parameter array.
        /// </summary>
        public readonly string[] PossibleApiParameter =
        {
            "abv_gt",
            "abv_lt",
            "ibu_gt",
            "ibu_lt",
            "ebc_gt",
            "ebc_lt",
            "beer_name",
            "yeast",
            "brewed_before",
            "brewed_after",
            "hops",
            "malt",
            "food",
            "ids",
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BrewdogBeerTestTemplate"/> class.
        /// </summary>
        /// <param name="output">
        /// The test log output class.
        /// </param>
        public BrewdogBeerTestTemplate(ITestOutputHelper output)
        {
            this.Output = output;
            this.Initilize(output);
        }

        /// <summary>
        /// Perform on class initialization.
        /// </summary>
        /// <param name="output">
        /// The test log output class.
        /// </param>
        protected virtual void Initilize(ITestOutputHelper output)
        {
            this.BeerList = this.GetBeerList(this.Url);
        }

        /// <summary>
        /// Get specified beer list from site.
        /// </summary>
        /// <param name="url">
        /// The string API URL.
        /// </param>
        /// <returns>
        /// Beer list.
        /// </returns>
        protected List<Beer> GetBeerList(string url)
        {
            string response;
            Stream stream = this.GetUrlResponse(url).GetResponseStream();
            using (StreamReader reader = new StreamReader(stream))
            {
                response = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<Beer>>(response);
        }

        /// <summary>
        /// Get stream response from site.
        /// </summary>
        /// <param name="url">
        /// The string API URL.
        /// </param>
        /// <returns>
        /// Stream response
        /// </returns>
        protected HttpWebResponse GetUrlResponse(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            return httpWebResponse;
        }
    }
}
