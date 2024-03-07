namespace BrewdogBeer
{
    using BrewdogBeer.Entities;
    using BrewdogBeer.Helpers;
    using BrewdogBeer.Template;
    using Xunit.Abstractions;

    /// <summary>
    /// The Name Brewdog Beer Tests.
    /// </summary>
    public class AbvValidationTests(ITestOutputHelper output) : BrewdogBeerTestTemplate(output)
    {
        /// <summary>
        /// Check if beer ABV is double.
        /// </summary>
        [Fact]
        public void IsDouble()
        {
            List<string> failingBeersName = new List<string>();

            foreach (Beer beer in this.BeerList)
            {
                this.Output.WriteLine(
                    "[{0}]: ABV value {1}. Expected: {2}, Actual: {3}",
                    beer.name,
                    beer.abv,
                    "double",
                    beer.abv.GetType());

                if (!ValueOperations.IsDouble(beer.abv))
                {
                    failingBeersName.Add(beer.name);
                }
            }

            if (failingBeersName.Count > 0)
            {
                Assert.Fail(string.Join(" ,", failingBeersName));
            }
        }

        /// <summary>
        /// Check if beer abv is not null.
        /// </summary>
        [Fact]
        public void IsNotNull()
        {
            List<string> failingBeersName = new List<string>();

            foreach (Beer beer in this.BeerList)
            {
                this.Output.WriteLine(
                    "[{0}]: ABV value {1}",
                    beer.name,
                    beer.abv);

                if (ValueOperations.IsNull(beer.abv))
                {
                    failingBeersName.Add(beer.name);
                }
            }

            if (failingBeersName.Count > 0)
            {
                Assert.Fail(string.Join(" ,", failingBeersName));
            }
        }

        /// <summary>
        /// Check if beer abv is not null.
        /// </summary>
        [Fact]
        public void IsNotEmptyString()
        {
            List<string> failingBeersName = new List<string>();

            foreach (Beer beer in this.BeerList)
            {
                this.Output.WriteLine(
                    "[{0}]: ABV value {1}",
                    beer.name,
                    beer.abv);

                if (ValueOperations.IsEmpty(beer.abv.ToString()))
                {
                    failingBeersName.Add(beer.name);
                }
            }

            if (failingBeersName.Count > 0)
            {
                Assert.Fail(string.Join(" ,", failingBeersName));
            }
        }

        /// <summary>
        /// Check if beer abv is over 4.0.
        /// </summary>
        [Fact]
        public void IsOver40()
        {
            List<string> failingBeersName = new List<string>();

            foreach (Beer beer in this.BeerList)
            {
                this.Output.WriteLine(
                    "[{0}]: ABV value {1}",
                    beer.name,
                    beer.abv);

                if (beer.abv < 4.0)
                {
                    failingBeersName.Add(beer.name);
                }
            }

            if (failingBeersName.Count > 0)
            {
                Assert.Fail(string.Join(" ,", failingBeersName));
            }
        }
    }
}
