namespace BrewdogBeer.TestClass
{
    using BrewdogBeer.Entities;
    using BrewdogBeer.Helpers;
    using BrewdogBeer.Template;
    using Xunit.Abstractions;

    /// <summary>
    /// The Name Brewdog Beer Tests.
    /// </summary>
    public class NameValidationTests(ITestOutputHelper output) : VariableValidationTestTemplate(output)
    {

        /// <inheritdoc/>
        protected override void Initilize(ITestOutputHelper output)
        {
            this.VariableToTest = "name";
            base.Initilize(output);
        }

        /// <inheritdoc/>
        [Fact]
        protected override void IsNotNull()
        {
            base.IsNotNull();
        }

        /// <inheritdoc/>
        [Fact]
        protected override void IsNotEmptyString()
        {
            base.IsNotEmptyString();
        }
    }
}
