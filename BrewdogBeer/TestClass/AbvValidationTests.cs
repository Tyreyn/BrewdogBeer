namespace BrewdogBeer.TestClass
{
    using BrewdogBeer.Entities;
    using BrewdogBeer.Helpers;
    using BrewdogBeer.Template;
    using Xunit.Abstractions;
    using Xunit.Sdk;

    /// <summary>
    /// The Name Brewdog Beer Tests.
    /// </summary>
    public sealed class AbvValidationTests(ITestOutputHelper output) : VariableValidationTestTemplate(output)
    {

        /// <inheritdoc/>
        protected override void Initilize(ITestOutputHelper output)
        {
            this.VariableToTest = "abv";
            base.Initilize(output);
        }

        /// <inheritdoc/>
        [Fact]
        protected override void IsDouble()
        {
            base.IsDouble();
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

        /// <inheritdoc/>
        [Fact]
        protected override void IsOverDoubleValue()
        {
            this.ComparedValue = 4.0;
            base.IsOverDoubleValue();
        }
    }
}
