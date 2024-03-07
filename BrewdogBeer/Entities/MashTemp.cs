using BrewdogBeer.Entities.Elementary;

namespace BrewdogBeer.Entities
{
    /// <summary>
    /// The mash entity
    /// </summary>
    public class MashTemp
    {
        /// <summary>
        /// The mash temperature entity.
        /// </summary>
        public Temp temp { get; set; }

        /// <summary>
        /// The mash duration.
        /// </summary>
        public int? duration { get; set; }
    }
}
