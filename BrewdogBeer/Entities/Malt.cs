using BrewdogBeer.Entities.Elementary;

namespace BrewdogBeer.Entities
{
    /// <summary>
    /// The malt entity.
    /// </summary>
    public class Malt
    {
        /// <summary>
        /// The malt name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The malt amount entity.
        /// </summary>
        public Amount amount { get; set; }
    }
}
