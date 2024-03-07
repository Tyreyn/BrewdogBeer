namespace BrewdogBeer.Template
{
    using System.Data;
    using System.Net;
    using System.Net.Http.Headers;
    using BrewdogBeer.Entities;
    using BrewdogBeer.Helpers;
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
        public List<Beer> BeerList
        {
            get => this.beerList;

            set => this.beerList = value;
        }

        public string Url
        {
            get => url;
            set => url = value;
        }

        /// <summary>
        /// The defualt api url.
        /// </summary>
        private string url = "https://api.punkapi.com/v2/beers?brewed_after=12-2015/1";

        private List<Beer> beerList = new List<Beer>();

        /// <summary>
        /// The test output class.
        /// </summary>
        public readonly ITestOutputHelper Output;


        /// <summary>
        /// Initializes a new instance of the <see cref="BrewdogBeerTestTemplate"/> class.
        /// </summary>
        /// <param name="output">
        /// The test output class.
        /// </param>
        public BrewdogBeerTestTemplate(ITestOutputHelper output)
        {
            this.Output = output;
            this.BeerList = this.GetBeerList(this.Url);
        }

        protected List<Beer> GetBeerList(string url)
        {
            string response;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Stream stream = httpWebResponse.GetResponseStream();
            using (StreamReader reader = new StreamReader(stream))
            {
                response = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<Beer>>(response);
        }
    }
}
