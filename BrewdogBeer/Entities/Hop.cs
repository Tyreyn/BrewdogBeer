using BrewdogBeer.Entities.Elementary;

namespace BrewdogBeer.Entities
{
    /// <summary>
    /// The hop entity.
    /// </summary>
    public class Hop
    {
        /// <summary>
        /// The hop name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The hop amount entites.
        /// </summary>
        public Amount amount { get; set; }

        /// <summary>
        /// The hop add moment.
        /// </summary>
        public string add { get; set; }

        /// <summary>
        /// The hop attribute.
        /// </summary>
        public string attribute { get; set; }
    }
}
