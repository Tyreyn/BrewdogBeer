namespace BrewdogBeer.Entities
{
    /// <summary>
    /// The making beer method entity.
    /// </summary>
    public class Method
    {
        /// <summary>
        /// The method mash entities.
        /// </summary>
        public List<MashTemp> mash_temp { get; set; }

        /// <summary>
        /// The method fermentation entity.
        /// </summary>
        public Fermentation fermentation { get; set; }

        /// <summary>
        /// The method twist.
        /// </summary>
        public string twist { get; set; }
    }
}
