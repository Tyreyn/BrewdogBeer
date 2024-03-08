namespace BrewdogBeer.Template
{
    using BrewdogBeer.Entities;
    using BrewdogBeer.Helpers;
    using Xunit.Abstractions;

    public class VariableValidationTestTemplate(ITestOutputHelper output) : BrewdogBeerTestTemplate(output)
    {

        /// <summary>
        /// Gets or sets the string name of tested variable.
        /// </summary>
        protected string VariableToTest { get; set; }


        /// <summary>
        /// Gets or sets the compared value for tested variable.
        /// </summary>
        protected double ComparedValue { get; set; }

        /// <summary>
        /// Check if beer variable is double.
        /// </summary>
        protected virtual void IsDouble()
        {
            List<string> failingBeersName = new List<string>();
            foreach (Beer beer in this.BeerList)
            {
                var variable = beer.GetType().GetProperty(VariableToTest).GetValue(beer, null);
                this.Output.WriteLine("[{0}]: Beer {1} value {2}. Expected: {3}, Actual: {4}",
                                      beer.name,
                                      this.VariableToTest,
                                      variable,
                                      "double",
                                      variable.GetType());

                if (!ValueOperations.IsDouble(variable))
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
        /// Check if beer variable is not null.
        /// </summary>
        protected virtual void IsNotNull()
        {
            List<string> failingBeersName = new List<string>();

            foreach (Beer beer in this.BeerList)
            {
                var variable = beer.GetType().GetProperty(VariableToTest).GetValue(beer, null);
                this.Output.WriteLine(
                    "[{0}]: Beer {1} value {2}",
                    beer.name,
                    VariableToTest,
                    variable);

                if (ValueOperations.IsNull(variable))
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
        /// Check if beer variable is not empty string.
        /// </summary>
        protected virtual void IsNotEmptyString()
        {
            List<string> failingBeersName = new List<string>();

            foreach (Beer beer in this.BeerList)
            {
                var variable = beer.GetType().GetProperty(this.VariableToTest).GetValue(beer, null);
                this.Output.WriteLine(
                    "[{0}]: Beer {1} value {2}",
                     beer.name,
                    this.VariableToTest,
                    variable);

                if (ValueOperations.IsEmpty(variable.ToString()))
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
        /// Check if beer double variable is over specified value.
        /// </summary>
        protected virtual void IsOverDoubleValue()
        {
            List<string> failingBeersName = new List<string>();

            foreach (Beer beer in this.BeerList)
            {
                var variable = beer.GetType().GetProperty(VariableToTest).GetValue(beer, null);
                this.Output.WriteLine(
                    "[{0}]: ABV value {1}",
                    beer.name,
                    variable);

                if ((double)variable < this.ComparedValue)
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
