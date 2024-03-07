namespace BrewdogBeer.Entities
{
    /// <summary>
    /// The ingredients entity.
    /// </summary>
    public class Ingredients
    {
        /// <summary>
        /// The ingredients malt entities.
        /// </summary>
        public List<Malt> malt { get; set; }

        /// <summary>
        /// The ingredients hops entity.
        /// </summary>
        public List<Hop> hops { get; set; }

        /// <summary>
        /// The yeast type.
        /// </summary>
        public string yeast { get; set; }
    }
}
