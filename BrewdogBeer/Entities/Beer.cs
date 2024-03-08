using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrewdogBeer.Entities.Elementary;

namespace BrewdogBeer.Entities
{
    /// <summary>
    /// The root beer entities.
    /// </summary>
    public class Beer
    {
        /// <summary>
        /// Gets or sets the beer id.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the beer name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the beer tagline.
        /// </summary>
        public string tagline { get; set; }

        /// <summary>
        /// Gets or sets the beer first brewed.
        /// </summary>
        public string first_brewed { get; set; }

        /// <summary>
        /// Gets or sets the beer description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the beer image url.
        /// </summary>
        public string image_url { get; set; }

        /// <summary>
        /// Gets or sets the beer abv.
        /// </summary>
        public double abv { get; set; }

        /// <summary>
        /// Gets or sets the beer ibu.
        /// </summary>
        public double? ibu { get; set; }

        /// <summary>
        /// Gets or sets the beer target fg.
        /// </summary>
        public double target_fg { get; set; }

        /// <summary>
        /// Gets or sets the beer target og.
        /// </summary>
        public double target_og { get; set; }

        /// <summary>
        /// Gets or sets the beer ebc.
        /// </summary>
        public double? ebc { get; set; }

        /// <summary>
        /// Gets or sets the beer srm.
        /// </summary>
        public double? srm { get; set; }

        /// <summary>
        /// Gets or sets the beer ph.
        /// </summary>
        public double? ph { get; set; }

        /// <summary>
        /// Gets or sets the beer attentuation level.
        /// </summary>
        public double attenuation_level { get; set; }

        /// <summary>
        /// Gets or sets the beer volume.
        /// </summary>
        public Volume volume { get; set; }

        /// <summary>
        /// Gets or sets the beer boil volume.
        /// </summary>
        public BoilVolume boil_volume { get; set; }

        /// <summary>
        /// Gets or sets the beer making methods.
        /// </summary>
        public Method method { get; set; }

        /// <summary>
        /// Gets or sets the beer ingredients.
        /// </summary>
        public Ingredients ingredients { get; set; }

        /// <summary>
        /// Gets or sets the food pairing to beer list.
        /// </summary>
        public List<string> food_pairing { get; set; }

        /// <summary>
        /// Gets or sets the brewers tips.
        /// </summary>
        public string brewers_tips { get; set; }

        /// <summary>
        /// Gets or sets the beer contributor.
        /// </summary>
        public string contributed_by { get; set; }
    }
}
