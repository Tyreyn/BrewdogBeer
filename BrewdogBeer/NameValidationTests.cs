namespace BrewdogBeer
{
    using BrewdogBeer.Entities;
    using BrewdogBeer.Helpers;
    using BrewdogBeer.Template;
    using Xunit.Abstractions;

    /// <summary>
    /// The Name Brewdog Beer Tests.
    /// </summary>
    public class NameValidationTests(ITestOutputHelper output) : BrewdogBeerTestTemplate(output)
    {
        /// <summary>
        /// Check if beer name is not null.
        /// </summary>
        [Fact]
        public void IsNotNull()
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

                if (ValueOperations.IsNull(beer.name))
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
        /// Check if beer name is not empty.
        /// </summary>
        [Fact]
        public void IsNotEmpty()
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

                if (ValueOperations.IsEmpty(beer.name))
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
